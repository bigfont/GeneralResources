using System;
using System.Windows.Forms;
using Email.Net.Common.Configurations;
using Email.Net.Common.MessageParts;
using Email.Net.Imap.Responses;
using Email.Net.Imap.Collections;
using Email.Net.Imap;

namespace getAttachmentandTextDemo
{
	public partial class Demo : Form
	{
		Mailbox inbox;
		ImapMessage msg;
		public Demo()
		{
			InitializeComponent();
			interactionCombo.Items.AddRange(new object[] {
			EInteractionType.Plain,
			EInteractionType.SSLPort,
			EInteractionType.StartTLS});
			interactionCombo.DropDownStyle = ComboBoxStyle.DropDownList;
			interactionCombo.SelectedIndex = 1;
			interactionCombo.Refresh();
			logoutButton.Enabled = false;
			receiveAttachment.Enabled = false;
		}
		private void showMessages()
		{
			//Show all messages into inbox mailbox
			Mailbox folders = client.GetMailboxTree();
			//Get inbox folder
			inbox = Mailbox.Find(folders, "INBOX");
			MessageCollection tmp = client.GetAllMessageHeaders(inbox);
			foreach (ImapMessage x in tmp)
			{
				messageList.Items.Add(String.Format("{0}. {1}", x.UID, x.Header.Subject));
			}
		}

		private void loginButton_Click(object sender, EventArgs e)
		{
			//Create IMAP4 client with parameters needed
			//URL of host to connect to
			client.Host = hostBox.Text;
			//TCP port for connection
			client.Port = (ushort)portNum.Value;
			//Username to login to the IMAP server
			client.Username = loginBox.Text;
			//Password to login to the IMAP server
			client.Password = passwordBox.Text;
			//Interaction type
			client.SSLInteractionType = (EInteractionType)interactionCombo.SelectedItem;
			
			//Login to the server
			CompletionResponse response = client.Login();
			if (response.CompletionResult == ECompletionResponseType.OK)
			{
				MessageBox.Show("Login succeed!");
				messageList.Items.Clear();
				showMessages();
				logoutButton.Enabled = true;
				loginButton.Enabled = false;
			}
			else
			{
				MessageBox.Show("Login failed!");
			}
		}

		private void logoutButton_Click(object sender, EventArgs e)
		{
			//Logout from the server
			CompletionResponse response = client.Logout();
			if (response.CompletionResult == ECompletionResponseType.OK)
			{
				MessageBox.Show("Logout succeed!");
				logoutButton.Enabled = false;
				loginButton.Enabled = true;
				messageList.Items.Clear();
				messageTextBox.Clear();
				attachmentBox.Items.Clear();
				attachmentBox.Refresh();
				receiveAttachment.Enabled = false;
			}
			else
			{
				MessageBox.Show("Logout failed!");
			}
		}

		private void messageList_SelectedIndexChanged(object sender, EventArgs e)
		{
			//Show message text and attachment list
			receiveAttachment.Enabled = false;
			attachmentBox.Items.Clear();
			messageTextBox.Clear();
			string selected = (string) messageList.SelectedItem;
			int cnt = selected.IndexOf('.');
			uint id = Convert.ToUInt32(selected.Remove(cnt));
			
			//Receive and show message text
			msg = client.GetMessageText(id, inbox);
			messageTextBox.Text = msg.PlainText;
			
			//If there are any attachments, show list of them
			if (msg.Attachments.Count > 0)
			{
				for (int i = 0; i < msg.Attachments.Count; i++)
				{
					attachmentBox.Items.Add(String.Format("{0}.{1}",(i + 1),msg.Attachments[i].TransferFilename));
				}
				attachmentBox.DropDownStyle = ComboBoxStyle.DropDownList;
				attachmentBox.SelectedIndex = 0;
				attachmentBox.Refresh();
				receiveAttachment.Enabled = true;
			}
		}

		private void receiveAttachment_Click(object sender, EventArgs e)
		{
			//Save attachment to disk
			string selected = (string)attachmentBox.SelectedItem;
			string partID = selected.Remove(selected.IndexOf("."));
			Attachment attach = msg.Attachments[int.Parse(partID)];

			if (attach != null)
			{
				//Get attachment needed 
				Attachment tmp = client.GetAttachment(inbox, msg, attach);
				//Show attachment name
				MessageBox.Show(string.Format("Attachment saved at: {0}",tmp.FullFilename));
			}
		}
	}
}
