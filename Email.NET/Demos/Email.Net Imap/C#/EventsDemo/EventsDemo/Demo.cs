using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Email.Net.Imap.Responses;
using Email.Net.Imap;
using Email.Net.Common.Configurations;
using Email.Net.Imap.Events;

namespace eventsDemo
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
			finishButton.Enabled = false;
		}

		private void startButton_Click(object sender, EventArgs e)
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
			if (response.CompletionResult == ECompletionResponseType.OK) {
				finishButton.Enabled = true;
				startButton.Enabled = false;
				//Subscribe to events
				client.MailboxStatusChanged += new Email.Net.Imap.Events.StateChangedEventHandler(client_MailboxStatusChanged);
                client.RecentChanged += new Email.Net.Imap.Events.StateChangedEventHandler(client_RecentChanged);
                client.ExistsChanged += new Email.Net.Imap.Events.StateChangedEventHandler(client_ExistsChanged);
				//Select INBOX mailbox, as current
				client.Select(Mailbox.Find(client.GetMailboxTree(), "INBOX"));
				timer.Start();
			}

		}

		void client_ExistsChanged(ImapClient sender, Mailbox activeMailBox)
		{
			messageTextBox.AppendText("Exist changed\r\n");
		}

		void client_RecentChanged(ImapClient sender, Mailbox activeMailBox)
		{
			messageTextBox.AppendText("Recent changed \r\n");
		}
		void client_MailboxStatusChanged(ImapClient sender, Mailbox activeMailBox)
		{
				messageTextBox.AppendText("Mailbox status changed\r\n");
		}
		public void sendNoop(object sender, EventArgs e)
		{
			//Send Noop command
			CompletionResponse response =  client.Noop();
			if (response.CompletionResult == ECompletionResponseType.OK)
			{
				messageTextBox.AppendText("Noop was sent\r\n");
			}
			else 
			{
				messageTextBox.AppendText("Noop wasn't sent\r\n");
			}
		}

		private void finishButton_Click(object sender, EventArgs e)
		{
			//Logout from the server
			CompletionResponse response = (CompletionResponse)client.Logout();
			if (response.CompletionResult == ECompletionResponseType.OK)
			{
				timer.Stop();
				MessageBox.Show("Logout succeed!");
				finishButton.Enabled = false;
				startButton.Enabled = true;
				messageTextBox.Clear();
				
			}
			else
			{
				MessageBox.Show("Logout failed!");
			}
		}
	}
}
