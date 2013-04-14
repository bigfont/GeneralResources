using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Email.Net.Common;
using Email.Net.Common.Configurations;
using Email.Net.Pop3;

namespace ProxyAuthorithationExample
{
	public partial class Demo : Form
	{
		public Demo()
		{
			InitializeComponent();
			proxyTypeCombo.Items.AddRange(new object[] {
				EProxyType.No,
				EProxyType.SOCKS5,
				EProxyType.SOCKS4 });
			proxyTypeCombo.DropDownStyle = ComboBoxStyle.DropDownList;
			proxyTypeCombo.SelectedIndex = 1;
			proxyTypeCombo.Refresh();
		}

		private void startAuthorization_Click(object sender, EventArgs e)
		{
			//Proxy authorization
			//Initialize provider for proxy usage
			target.ProxyHost = proxyHostBox.Text;
			target.ProxyPort = (ushort)proxyPortNum.Value;
			target.ProxyPassword = proxyPasswordBox.Text;
			target.ProxyUser = proxyLoginBox.Text;
			target.ProxyType = (EProxyType)proxyTypeCombo.SelectedItem; 
			//Create POP3 client with parameters needed
			//URL of host to connect to
			target.Host = hostBox.Text;
			//TCP port for connection
			target.Port = (ushort)portNum.Value;
			//Username to login to the POP3 server
			target.Username = loginBox.Text;
			//Password to login to the POP3 server
			target.Password = passwordBox.Text;
			target.AuthenticationType = EAuthenticationType.Auto;
			Pop3Response response = target.Login();
			if (response.Type == EPop3ResponseType.OK)
			{
				MessageBox.Show("Authorization succeed");
			}
			else
			{
				MessageBox.Show("Authorization failed");
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
