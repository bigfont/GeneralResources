using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Email.Net.Common;
using Email.Net.Common.Collections;
using Email.Net.Common.Configurations;
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
				Pop3Response response = _client.Login();
				if (response.Type == EPop3ResponseType.OK)
				{
					slStatus.Text = "Connected";
				}
				else
				{
					MessageBox.Show("Error", String.Format("Connection error:\n {0}", response.Message), MessageBoxButtons.OK, MessageBoxIcon.Error);
					slStatus.Text = "Connection error";
				}
				//Get messages for the server
				Rfc822MessageCollection messages = _client.GetAllMessages();

				FillMessageSList(messages);
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

		private void FillMessageSList(Rfc822MessageCollection messages)
		{
			//Clear messages list
			lvMessageBrowser.Items.Clear();

			//Adding messages to list
			foreach (Rfc822Message message in messages)
			{
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
				MessageViewer viewer = new MessageViewer((Rfc822Message)lvMessageBrowser.SelectedItems[0].Tag);
				viewer.ShowDialog();
			}
		}
	}
}
