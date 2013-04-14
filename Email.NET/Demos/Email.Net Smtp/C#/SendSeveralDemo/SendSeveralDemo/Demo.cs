using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Email.Net.Common;
using Email.Net.Common.Collections;
using Email.Net.Smtp;

namespace SendSeveralDemo
{
	public partial class Demo : Form
	{
		SmtpMessage message1;
		public Demo()
		{
			InitializeComponent();
			sendMessage.Enabled = false;
			subjectBox.Text = "First message subject";
		}

		private void messageComplete_Click(object sender, EventArgs e)
		{
			EmailAddressCollection addressCollection = new EmailAddressCollection();
			addressCollection.Add(new EmailAddress(toBox.Text));
			//Create 1st message
			message1 = new SmtpMessage(
				new EmailAddress(fromBox.Text),//Source address
				addressCollection,//Address of the recipient
				subjectBox.Text,//Message subject
				messageBox.Text //Message text
				);
			sendMessage.Enabled = true;
			messageComplete.Enabled = false;
			messageBox.Text = "You've finished 1st message creation. Please insert data for 2nd message.";
			subjectBox.Text = "Second message subject";
		}

		private void sendMessage_Click(object sender, EventArgs e)
		{
			//Create and send several (2) messages
			//SMTP client settings
			//URL of host to connect to
			target.Host = hostBox.Text;
			//TCP port for connection
			target.Port = (ushort)portNum.Value;
			//Username to login to the SMTP server
			target.Username = loginBox.Text;
			//Password to login to the SMTP server
			target.Password = passwordBox.Text;
			//Creating address and message 
			EmailAddressCollection addressCollection = new EmailAddressCollection();
			addressCollection.Add(new EmailAddress(toBox.Text));
			//Create 2nd message
			SmtpMessage message2 = new SmtpMessage(
				new EmailAddress(fromBox.Text),//Source address
				addressCollection,//Address of the recipient
				subjectBox.Text,//Message subject
				messageBox.Text //Message text
				);
			//Create bunch of the messages 
			SmtpMessage[] bunch = new SmtpMessage[] { message1, message2 };
			IList <SendResult> result = target.SendSome(bunch);//Send message
			int i = 0;
			foreach (SendResult x in result) 
			{
				if (!x.IsSuccessful) {
					i++;
				}
			}
			if (i > 0)
			{
				MessageBox.Show("Some messages were sent unsuccessfully.");
			}
			else 
			{
				MessageBox.Show("All messages were sent successful.");
			}
			messageBox.Text = "Some random text to create new message";
			subjectBox.Text = "Test message subject";
			messageComplete.Enabled = true;
			sendMessage.Enabled = false;
		}
	}
}
