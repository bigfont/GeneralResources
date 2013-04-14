using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Email.Net.Common;
using Email.Net.Pop3;

namespace GetStatisticsExample
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
				//Create new statistics item, and get statistics from the server
				Pop3MessageStatistics statistics = target.GetStatistic();
				//Get number of messages 
				uint messagecounter = statistics.CountMessages;
				uint messagesize = statistics.SizeMessages;
				messageTextBox.AppendText("\r\n ***Statistics*** \r\n Number of messages: ");
				messageTextBox.AppendText(messagecounter.ToString());
				messageTextBox.AppendText("  Size of messages: ");
				messageTextBox.AppendText(messagesize.ToString());
			}
			else 
			{ 
				MessageBox.Show("Login failed.");
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
