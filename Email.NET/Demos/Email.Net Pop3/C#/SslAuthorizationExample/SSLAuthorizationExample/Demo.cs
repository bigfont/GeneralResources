using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//using Email.Net.POP3.Command;
using Email.Net.Common;
using Email.Net.Common.Configurations;
using Email.Net.Pop3;

namespace SSLAuthorizationExample
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
			authentificationCombo.DropDownStyle = ComboBoxStyle.DropDownList;
			authentificationCombo.Items.AddRange(new object[] {
				EAuthenticationType.None,
				EAuthenticationType.Auto,
				EAuthenticationType.Plain,
				EAuthenticationType.CramMD5,
				EAuthenticationType.DigestMD5,
				EAuthenticationType.Login});
			interactionCombo.SelectedIndex = 1;
			interactionCombo.Refresh();
			authentificationCombo.SelectedIndex = 2;
			interactionCombo.Refresh();
		}

		private void close_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void startAuthorization_Click(object sender, EventArgs e)
		{
			//Create POP3 client, with parameters needed
			//URL of host to connect to
			target.Host = hostBox.Text;
			//TCP port for connection
			target.Port = (ushort)portNum.Value;
			//Username to login to the POP3 server
			target.Username = loginBox.Text;
			//Password to login to the POP3 server
			target.Password = passwordBox.Text;
			target.SSLInteractionType = (EInteractionType)interactionCombo.SelectedItem;
			target.AuthenticationType = (EAuthenticationType)authentificationCombo.SelectedItem;
			//Login to the server
			Pop3Response response = target.Login();
			if (response.Type == EPop3ResponseType.OK)
			{ MessageBox.Show("Authorization succeed.", "All finished", MessageBoxButtons.OK); }
			else { MessageBox.Show("Authorization failed", "All finished", MessageBoxButtons.OK); }
			//Logout from the server
			target.Logout();
		}
	}
}
