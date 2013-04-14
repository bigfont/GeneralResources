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

namespace CreateDeleteFolderDemo
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
			createButton.Enabled = false;
			deleteButton.Enabled = false;
		}

		private void createButton_Click(object sender, EventArgs e)
		{
			//Create new folder on the server with given name
			CompletionResponse response = (CompletionResponse)client.CreateMailbox(folderName.Text);
			if (response.CompletionResult == ECompletionResponseType.OK)
				MessageBox.Show("Created successfully.");
			else MessageBox.Show("Creation failed.");
		}

		private void startAuthorization_Click(object sender, EventArgs e)
		{
			if (startAuthorization.Text == "Start")
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
					createButton.Enabled = true;
					deleteButton.Enabled = true;
					startAuthorization.Text = "Finish";
				}
				else
				{
					MessageBox.Show("Login failed!");
				}

			}
			else 
			{
				client.Logout();
				startAuthorization.Text = "Start";
				createButton.Enabled = false;
				deleteButton.Enabled = false;
			}
		}

		private void deleteButton_Click(object sender, EventArgs e)
		{
			// Delete folder from the server
			//Get folder tree from the server
			Mailbox folders = client.GetMailboxTree();
			//Search for folder needed
			int i = 0;
			foreach (Mailbox x in folders.Children)
			{
				if (x.Name == folderName.Text)
				{
					//If folder found, delete it.
					client.DeleteMailbox(x);
					i++;
				}
			}
			string tmp = "Folders deleted: ";
			tmp += i;
			MessageBox.Show(tmp);
		}
	}
}