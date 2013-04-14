using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Email.Net.Common;
using Email.Net.Imap;
using Email.Net.Common.Configurations;
using Email.Net.Imap.Responses;
using Email.Net.Imap.Collections;
using Email.Net.Imap.Sequences;

namespace markMessageDemo
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
			markMessage.Enabled = false;
		}
		private void showMessages() 
		{
			Mailbox folders = client.GetMailboxTree();
			//Get inbox folder
			Mailbox inbox = Mailbox.Find(folders, "INBOX");
			MessageCollection tmp = client.GetAllMessageHeaders(inbox);
			for (int i = 0; i < tmp.Count; i++) {
				string a = decodeCollection(tmp[i].Flags);
				messageList.Items.Add(String.Format("{0}. {1}  *** flags: {2}",tmp[i].UID,tmp[i].Header.Subject,a));
			}			
		}
		private string decodeCollection(MessageFlagCollection a)
		{
			string b= "";
			for(int i=0;i<a.Count;i++)
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
			CompletionResponse response = (CompletionResponse)client.Login();
			if (response.CompletionResult == ECompletionResponseType.OK)
			{
				MessageBox.Show("Login succeed!");
				messageList.Items.Clear();
				showMessages();
				close.Enabled = true;
				startAuthorization.Enabled = false;
				markMessage.Enabled = true;
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
				markMessage.Enabled = false;
			}
			else
			{
				MessageBox.Show("Logout failed!");
			}
		}

		private void markMessage_Click(object sender, EventArgs e)
		{
			if (messageList.Items.Count > 0)
			{
				string selected = (string)messageList.SelectedItem;
				if (selected == null) selected = (string)messageList.Items[0];
				int cnt = selected.IndexOf('.');
				uint id = Convert.ToUInt32(selected.Remove(cnt));
				Mailbox folders = client.GetMailboxTree();
				//Get inbox folder
				Mailbox inbox = Mailbox.Find(folders, "INBOX");
				ISequence sequence = new SequenceNumber(id);
				MessageFlagCollection flags = new MessageFlagCollection();
				flags.Add(new MessageFlag(EFlag.Seen));
				//Set message flags
				CompletionResponse response = (CompletionResponse)client.SetMessageFlags(
					sequence, // message id collection
					inbox, // mailbox folder
					flags, // message collection flags
					EFlagMode.Add // flag update mode
				);
				messageList.Items.Clear();
				showMessages();
			}
			else 
			{
				MessageBox.Show("Empty mailbox! Can not mark message!");
				markMessage.Enabled = false;
			}
		}

	}
}
