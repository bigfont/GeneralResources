using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Email.Net.Imap.Responses;
using Email.Net.Common;
using Email.Net.Imap.Collections;
using Email.Net.Imap;

namespace selectDemo
{
	public partial class Demo : Form
	{
		public Demo()
		{
			InitializeComponent();
		}
		private void showFolders()
		{
			//Receive folders (mailboxes) names 
			Mailbox folders = client.GetMailboxTree();
			foreach(Mailbox x in folders.Children){
				folderBox.Items.Add(x.DisplayName);
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
			//Login to the server
			CompletionResponse response = (CompletionResponse)client.Login();
			if (response.CompletionResult == ECompletionResponseType.OK)
			{
				MessageBox.Show("Login succeed!");
				folderBox.Items.Clear();
				showFolders();
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
			CompletionResponse response = (CompletionResponse)client.Logout();
			if (response.CompletionResult == ECompletionResponseType.OK)
			{
				MessageBox.Show("Logout succeed!");
				logoutButton.Enabled = false;
				loginButton.Enabled = true;
			}
			else
			{
				MessageBox.Show("Logout failed!");
			}

		}

		private void folderBox_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (folderBox.Items.Count > 0)
			{
				string name = folderBox.SelectedItem.ToString();
				//Set selected item, as current mailbox
				Mailbox current = Mailbox.Find(client.GetMailboxTree(), name);
				client.Select(current);
			}
			MessageBox.Show("Selected item now current");
		}

	}
}
