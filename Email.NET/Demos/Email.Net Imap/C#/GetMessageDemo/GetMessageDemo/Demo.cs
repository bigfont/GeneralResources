using System;
using System.Windows.Forms;
using Email.Net.Imap;
using Email.Net.Common.Configurations;
using Email.Net.Imap.Responses;
using Email.Net.Imap.Collections;

namespace getMessageDemo
{
	public partial class Demo : Form
	{
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
			close.Enabled = false;
			getMessage.Enabled = false;
		}

		private void startAuthorization_Click(object sender, EventArgs e)
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
				close.Enabled = true;
				startAuthorization.Enabled = false;
				getMessage.Enabled = true;
			}
			else
			{
				MessageBox.Show("Login failed!");
			}

		}

		private void getMessage_Click(object sender, EventArgs e)
		{
			//Get all messages to know the uid
			Mailbox folders = client.GetMailboxTree();
			
			//Get inbox folder
			Mailbox inbox = Mailbox.Find(folders,"INBOX");
			MessageCollection tmp = client.GetAllMessageHeaders(inbox);
			messageBox.AppendText("\r\n***Received messages: ");
			messageBox.AppendText(tmp.Count.ToString());
			uint uid = Convert.ToUInt32(tmp[0].UID);
			
			//Get message from the server
			ImapMessage message = client.GetFullMessage(uid,inbox);
			messageBox.AppendText("\r\nSender (from): ");
			messageBox.AppendText(message.Header.From.ToString());
			messageBox.AppendText("\r\nSubject: ");
			messageBox.AppendText(message.Header.Subject);
		}

		private void close_Click(object sender, EventArgs e)
		{
			CompletionResponse response = client.Logout();
			if (response.CompletionResult == ECompletionResponseType.OK)
			{
				MessageBox.Show("Logout succeed!");
				close.Enabled = false;
				startAuthorization.Enabled = true;
				getMessage.Enabled = false;				
			}
			else
			{
				MessageBox.Show("Logout failed!");
			}
		}
	}
}
