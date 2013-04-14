using System;
using System.Windows.Forms;
using Email.Net.Imap;
using Email.Net.Common.Configurations;
using Email.Net.Imap.Responses;
using Email.Net.Imap.Collections;

namespace asynchronousDemo
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
			finishButton.Enabled = false;
			getMessage.Enabled = false;
		}
		private void showMessages()
		{
			messageList.Items.Clear();
			messageList.Refresh();
			Mailbox folders = client.GetMailboxTree();
			//Get inbox folder
			Mailbox inbox = Mailbox.Find(folders, "INBOX");
			client.BeginGetAllMessageHeaders(inbox, callback);
		}

		void callback(IAsyncResult ar)
		{
			//This is method, which will be called after receiving
			MessageCollection tmp = client.EndGetAllMessageHeaders(ar);
			for (int i = 0; i < tmp.Count; i++)
			{
				string a = decodeCollection(tmp[i].Flags);
				MethodInvoker invoker = delegate
				{
					messageList.Items.Add(String.Format("{0}.{1} *** flags: {2}", tmp[i].UID, tmp[i].Header.Subject, a));
					messageList.Refresh();
					getMessage.Enabled = true;
				};
				Invoke(invoker);
			}

		}

		private string decodeCollection(MessageFlagCollection a)
		{
			string b = "";
			for (int i = 0; i < a.Count; i++)
			{
				b += a[i].ToString();
				b += "; ";
			}
			return b;
		}
		private void startButton_Click(object sender, EventArgs e)
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
			CompletionResponse response = client.Login();
			if (response.CompletionResult == ECompletionResponseType.OK)
			{
				MessageBox.Show("Login succeed!");
				messageList.Items.Clear();
				showMessages();
				finishButton.Enabled = true;
				startButton.Enabled = false;
			}
			else
			{
				MessageBox.Show("Login failed!");
			}

		}

		private void finishButton_Click(object sender, EventArgs e)
		{
			CompletionResponse response = (CompletionResponse)client.Logout();
			if (response.CompletionResult == ECompletionResponseType.OK)
			{
				MessageBox.Show("Logout succeed!");
				finishButton.Enabled = false;
				startButton.Enabled = true;
				getMessage.Enabled = false;
				messageList.Items.Clear();
				messageList.Refresh();
				messageTextBox.Clear();
			}
			else
			{
				MessageBox.Show("Logout failed!");
			}
		}

		private void getMessage_Click(object sender, EventArgs e)
		{
			//Get all messages to know the uid
			Mailbox folders = client.GetMailboxTree();
			//Get inbox folder
			Mailbox inbox = Mailbox.Find(folders, "INBOX");
			string selected = (string)messageList.SelectedItem;
			if (selected == null) selected = (string)messageList.Items[0];
			int cnt = selected.IndexOf('.');
			uint uid = Convert.ToUInt32(selected.Remove(cnt));
			//Get message from the server
			client.BeginGetMessageText(uid, inbox, callbackOne);
		}

		void callbackOne(IAsyncResult ar)
		{
			//This is method, which will be called after receiving
			ImapMessage tmp = client.EndGetMessageText(ar);
			MethodInvoker invoker = delegate 
			{
				messageTextBox.Text = string.Format("Message subject: {0}\r\nMessage text: \r\n{1}\r\n", tmp.Header.Subject, tmp.PlainText);
			};
			Invoke(invoker);
		}

	}
}
