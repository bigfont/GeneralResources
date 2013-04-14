using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Email.Net.Common.Configurations;
using Email.Net.Common;
using Email.Net.Common.Collections;
using Email.Net.Pop3;

namespace GetAllMessagesExample
{
	public partial class Demo : Form
	{
		public Demo()
		{
			InitializeComponent();
		}

		private void startAuthorization_Click(object sender, EventArgs e)
		{
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
			Pop3Response response = target.Login();
			if (response.Type == EPop3ResponseType.OK)
			{
				//Get all messages from the server
				Rfc822MessageCollection messages = target.GetAllMessages();
				//Make some actions, for example
				//Count number of messages received
				string cnt = Convert.ToString(messages.Count);
				cnt += " messages was got";
				MessageBox.Show(cnt, "All messages from the server were received!", MessageBoxButtons.OK);
			}
			//Logout from the server
			target.Logout();

		}

		private void close_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
