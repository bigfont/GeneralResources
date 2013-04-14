using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Email.Net.Pop3;
using Email.Net.Common;

namespace DellRollBackExample
{
	public partial class Demo : Form
	{
		Pop3Response response;

		public Demo()
		{
			InitializeComponent();
			deleteButton.Enabled = false;
			rollbackButton.Enabled = false;

		}

		private void deleteButton_Click(object sender, EventArgs e)
		{
			//Delete message
			response = target.DeleteMessage((uint)messageNumber.Value);
			if(response.Type == EPop3ResponseType.OK)
			messageTextBox.AppendText("\r\n Message deleted. \r\n");
			rollbackButton.Enabled = true;
		}

		private void rollbackButton_Click(object sender, EventArgs e)
		{
			//Rollback last transaction
			response = target.Reset();
			if(response.Type == EPop3ResponseType.OK)
			messageTextBox.AppendText("\r\n Transaction rolled back \r\n");
			rollbackButton.Enabled = false;
		}

		private void close_Click(object sender, EventArgs e)
		{
			if (rollbackButton.Enabled != false)
			{
				//Logout from the server
				target.Logout();
				messageTextBox.AppendText("\r\n *** Messages were deleted *** \r\n");
				rollbackButton.Enabled = false;
				deleteButton.Enabled = false;
			}
			else 
			{
				Close();
			}

		}

		private void startAuthorization_Click(object sender, EventArgs e)
		{

			//Create POP3 client with parameters needed
			ushort port;
			port = (ushort)portNum.Value;
			//Create POP3 client with parameters needed
			//URL of host to connect to
			target.Host = hostBox.Text;
			//TCP port for connection
			target.Port = (ushort)portNum.Value;
			//Username to login to the POP3 server
			target.Username = loginBox.Text;
			//Password to login to the POP3 server
			target.Password = passwordBox.Text;
			//Login to the server
			response = target.Login();
			if (response.Type == EPop3ResponseType.OK )
			{
				deleteButton.Enabled = true;
			}
		}

	}
}
