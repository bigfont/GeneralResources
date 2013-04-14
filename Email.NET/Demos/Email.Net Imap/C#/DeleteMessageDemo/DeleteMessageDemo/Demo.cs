using System;
using System.Windows.Forms;
using Email.Net.Imap;
using Email.Net.Common.Configurations;
using Email.Net.Imap.Responses;
using Email.Net.Imap.Collections;
using Email.Net.Imap.Sequences;

namespace deleteMessageDemo
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
			delete.Enabled = false;
		}

		private void showMessages()
		{
			Mailbox folders = client.GetMailboxTree();
			//Get inbox folder
			Mailbox inbox = Mailbox.Find(folders, "INBOX");
			MessageCollection tmp = client.GetAllMessageHeaders(inbox);
			for (int i = 0; i < tmp.Count; i++)
			{
				string a = decodeCollection(tmp[i].Flags);
				messageList.Items.Add(String.Format("{0}. {1}  *** flags: {2}", tmp[i].UID, tmp[i].Header.Subject, a));
			}
			if(messageList.Items.Count > 0)messageList.SetSelected(0, true);
		}

		private string decodeCollection(MessageFlagCollection a)
		{
			string b = "";
			for (int i = 0; i < a.Count; i++)
			{
				b += a[i].ToString();
				b += "; ";
			}
			return b;
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
				messageList.Items.Clear();
				showMessages();
				close.Enabled = true;
				startAuthorization.Enabled = false;
				delete.Enabled = true;
			}
			else
			{
				MessageBox.Show("Login failed!");
			}

		}

		private void close_Click(object sender, EventArgs e)
		{
			CompletionResponse response = (CompletionResponse)client.Logout();
			if (response.CompletionResult == ECompletionResponseType.OK)
			{
				MessageBox.Show("Logout succeed!");
				close.Enabled = false;
				startAuthorization.Enabled = true;
				delete.Enabled = false;
			}
			else
			{
				MessageBox.Show("Logout failed!");
			}
		}

		private void messageList_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void delete_Click(object sender, EventArgs e)
		{
			if (messageList.Items.Count > 0)
			{
				string selected = (string)messageList.SelectedItem;
				int cnt = selected.IndexOf('.');
				uint id = Convert.ToUInt32(selected.Remove(cnt));
				//Mark message to delete
				//Get folder to delete from
				Mailbox folders = client.GetMailboxTree();
				//Get inbox folder
				Mailbox inbox = Mailbox.Find(folders, "INBOX");
				//Create parameters for message setting
				ISequence sequence = new SequenceNumber(id);
				//Set message flags
				CompletionResponse response = client.MarkAsDeleted(sequence, inbox);
				//Delete marked messages
				response = client.DeleteMarkedMessages(inbox);
				messageList.Items.Clear();
				showMessages();
			}
			else
			{
				MessageBox.Show("Empty mailbox! Can not mark message!");
				delete.Enabled = false;
			}
		}

	}
}
