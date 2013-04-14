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
using System.Threading;

namespace NoopDemo
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
			close.Enabled = false;
		}
		private void InitNoopTimer()
				 {
			const int noopTimeout = 1800; 
			//Create a timer which will send noop commands
			System.Threading.Timer timer = new System.Threading.Timer(callback, client, Timeout.Infinite, noopTimeout);
			//Run timer
			timer.Change(0, noopTimeout);
				 }

		private void callback(object state)
		{
			//Method which will send noop command on timer event
			client = (ImapClient)state;
			//Actualy sends noop command
			CompletionResponse response =  client.Noop();
			if (response.CompletionResult == ECompletionResponseType.OK)
			{
				AppendLogMessage("NoOp sent to server. \r\n");
			}
			else 
			{
				messageBox.AppendText("NoOp failed \r\n");
			}
		}

		private delegate void AppendLogMessageDelegate(string text);

		private void AppendLogMessage(string text)
		{
			if (InvokeRequired)
			{
				Invoke(new AppendLogMessageDelegate(AppendLogMessage), new object[]{text});
			}
			else
			{
				messageBox.AppendText(text); 
			}
		}

		private void startAuthorization_Click(object sender, EventArgs e)
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
				InitNoopTimer();
				close.Enabled = true;
				startAuthorization.Enabled = false;
			}
			else
			{
				MessageBox.Show("Login failed!");
			}

		}

		private void close_Click(object sender, EventArgs e)
		{
			CompletionResponse response = (CompletionResponse)client.Logout();
			if (response.CompletionResult == ECompletionResponseType.OK)
			{
				MessageBox.Show("Logout succeed!");
				close.Enabled = false;
				startAuthorization.Enabled = true;
			}
			else
			{
				MessageBox.Show("Logout failed!");
			}
		}
	}
}
