using System;
using System.Windows.Forms;
using Email.Net.Common;
using Email.Net.Common.Collections;
using Email.Net.Common.Configurations;
using Email.Net.Imap;
using Email.Net.Imap.Collections;
using Email.Net.Imap.Responses;
using Email.Net.Pop3;

namespace Browser
{
	public partial class RemoteMailBox : Form
	{
		public RemoteMailBox()
		{
			InitializeComponent();
			cbAutentificationType.SelectedIndex = 1;
			cbInteractionType.SelectedIndex = 0;
			_client.AttachmentDirectory = ".";
		}

		private void bLogin_Click(object sender, EventArgs e)
		{
			//Create POP3 client with parameters needed
			//URL of host to connect to
			_client.Host = tbHostname.Text;
			//TCP port for connection
			_client.Port = (ushort) nPort.Value;
			//Username to login to the POP3 server
			_client.Username = tbLogin.Text;
			//Password to login to the POP3 server
			_client.Password = tbPassword.Text;
			//Interaction type for connection
			_client.SSLInteractionType = (EInteractionType) cbInteractionType.SelectedIndex;
			//Authentification type for authentification
			_client.AuthenticationType = (EAuthenticationType) cbAutentificationType.SelectedIndex;

			try
			{
				//Login to the server
				CompletionResponse response = _client.Login();
				if (response.CompletionResult == ECompletionResponseType.OK)
				{
					slStatus.Text = "Connected";
				}
				else
				{
					MessageBox.Show("Error", String.Format("Connection error:\n {0}", response.Message), MessageBoxButtons.OK, MessageBoxIcon.Error);
					slStatus.Text = "Connection error";
				}

				//Get all messages to know the uid
				Mailbox folders = _client.GetMailboxTree();

				//Get inbox folder
				Mailbox inbox = Mailbox.Find(folders, "INBOX");

				//Get messages for the server
				MessageCollection messages = _client.GetAllMessageHeaders(inbox);

				FillMessageSList(messages, inbox);
			}
			catch (Exception ex)
			{
				slStatus.Text = "Error: " + ex.Message;
			}

			try
			{
				//Logout from the server
				_client.Logout();
			}
			catch
			{
			}
		}

		private void FillMessageSList(MessageCollection messages, Mailbox inbox)
		{
			//Clear messages list
			lvMessageBrowser.Items.Clear();

			//Adding messages to list
			foreach (ImapMessage messageHeader in messages)
			{
				//Get message from the server
				uint uid = Convert.ToUInt32(messageHeader.UID);
				ImapMessage message = _client.GetFullMessage(uid, inbox);

				//Get message's subject and date
				string subject = (message.Subject != null) ? message.Subject : "n/a";
				string date = (message.Date != null) ? message.Date.ToString("yyyy-MM-dd HH:mm:ss") : "n/a";
				//Creating new ListView item
				ListViewItem item = new ListViewItem(message.From.ToString());
				//Filling item
				item.Tag = message;
				item.SubItems.Add(subject);
				item.SubItems.Add(date);
				//Adding item
				lvMessageBrowser.Items.Add(item);
			}
		}

		private void lvMessageBrowser_DoubleClick(object sender, EventArgs e)
		{
			if (lvMessageBrowser.SelectedItems.Count > 0)
			{
				//Showing received message
				MessageViewer viewer = new MessageViewer((ImapMessage)lvMessageBrowser.SelectedItems[0].Tag);
				viewer.ShowDialog();
			}
		}
	}
}
