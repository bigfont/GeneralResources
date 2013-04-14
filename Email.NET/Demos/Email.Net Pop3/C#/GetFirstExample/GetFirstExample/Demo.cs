using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Email.Net.Common.Collections;
using Email.Net.Common.Configurations;
using Email.Net.Common;
using Email.Net.Pop3;

namespace GetFirstExample
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
			ushort number = (ushort)messageNumber.Value;
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

			//Get message from the server
			Rfc822Message message = target.GetMessage(
				number //Message number at the current session
				);
			//Get message's subject, sender, date and body
			string subject = message.Subject;
			DateTime date = message.Date;
			string body = message.Text;

			//Logout from the server
			target.Logout();
			messageTextBox.AppendText("**** MESSAGE RECEIVED **** \r\n");
			messageTextBox.AppendText("Subject: ");
			messageTextBox.AppendText(subject);
			messageTextBox.AppendText("  \r\n*** Date: ");
			messageTextBox.AppendText(date.ToString());
			messageTextBox.AppendText("\r\n\r\n\r\n");
		}

		private void close_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
