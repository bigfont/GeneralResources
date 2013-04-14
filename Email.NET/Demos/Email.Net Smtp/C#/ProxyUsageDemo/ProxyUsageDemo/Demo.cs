using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Email.Net.Common;
using Email.Net.Common.Collections;
using Email.Net.Common.Configurations;
using Email.Net.Smtp;

namespace ProxyUsageDemo
{
	public partial class Demo : Form
	{
		public Demo()
		{
			InitializeComponent();
			proxyType.Items.AddRange(new object [] {EProxyType.No, EProxyType.SOCKS5, EProxyType.SOCKS4});
			proxyType.DropDownStyle = ComboBoxStyle.DropDownList;
			proxyType.SelectedIndex = 1;
			proxyType.Refresh();
		}

		private void sendMessage_Click(object sender, EventArgs e)
		{
			//Create and send message using proxy
			//SMTP client settings
			//URL of host to connect to
			target.Host = hostBox.Text;
			//TCP port for connection
			target.Port = (ushort)portNum.Value;
			//Username to login to the SMTP server
			target.Username = loginBox.Text;
			//Password to login to the SMTP server
			target.Password = passwordBox.Text;
			//Configure proxy
			target.ProxyType = (EProxyType)proxyType.SelectedItem;
			target.ProxyHost = proxyHostBox.Text;
			target.ProxyPort =(ushort) proxyPortNum.Value;
			target.ProxyUser = proxyUserBox.Text;
			target.ProxyPassword = proxyPasswordBox.Text;
			//Create address and message 
			EmailAddressCollection addressCollection = new EmailAddressCollection();
			addressCollection.Add(new EmailAddress(toBox.Text));
			//Create message
			SmtpMessage message = new SmtpMessage(
				new EmailAddress(fromBox.Text),//Source address
				addressCollection,//Address of the recipient
				subjectBox.Text,//Message subject
				messageBox.Text //Message text
				);
			SendResult result = target.SendOne(message);//Send message	
			if (result.IsSuccessful)
			{
				MessageBox.Show("Message sent successful!");
			}
			else
			{
				MessageBox.Show("Message sending failed!");
			}

		}
	}
}
