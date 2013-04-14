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

namespace searchMessageDemo
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
			search.Enabled = false;
		}

		private void close_Click(object sender, EventArgs e)
		{
			CompletionResponse response = (CompletionResponse)client.Logout();
			if (response.CompletionResult == ECompletionResponseType.OK)
			{
				MessageBox.Show("Logout succeed!");
				close.Enabled = false;
				startAuthorization.Enabled = true;
				search.Enabled = false;
			}
			else
			{
				MessageBox.Show("Logout failed!");
			}
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
				close.Enabled = true;
				startAuthorization.Enabled = false;
				search.Enabled = true;
			}
			else
			{
				MessageBox.Show("Login failed!");
			}
		}

		private void search_Click(object sender, EventArgs e)
		{
			//Create Query to find message
			Query query = Query.Not(Query.Larger((uint)sizeNum.Value));
			//Get folder (inbox) to search in
			Mailbox folder = client.GetMailboxTree();
			Mailbox inbox = Mailbox.Find(folder, "INBOX");
			IEnumerable <uint> result = client.Search(query, inbox);
			//Create user result
			string tmp = "";
			foreach (uint x in result) 
			{
				string subj = client.GetFullMessage(x, inbox).Header.Subject;
				tmp += string.Format(" {0}, message subject - {1}\r\n ",x,subj);
			}
			messageBox.AppendText(String.Format("Messages found: {0}\r\n",tmp));
		}
	}
}
