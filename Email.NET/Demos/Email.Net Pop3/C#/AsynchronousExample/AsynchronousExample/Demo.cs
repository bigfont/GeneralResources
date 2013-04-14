using System;
using System.Windows.Forms;
using Email.Net.Common;
using Email.Net.Pop3;


namespace AsynchronousExample
{
	public partial class Demo : Form
	{
		int AsyncMessageCount = 0;
		
		public Demo()
		{
			InitializeComponent();
			target.MessageReceived += new Pop3MessageEventHandler(target_MessageReceived);
		}
		
		private void getAllButton_Click(object sender, EventArgs e)
		{
			getOneButton.Enabled = false;
			getAllButton.Enabled = false;
			//Create POP3 client with parameters needed
			//URL of host to connect to
			target.Host =  hostBox.Text;
			//TCP port for connection
			target.Port = (ushort)portNum.Value;
			//Username to login to the POP3 server
			target.Username = loginBox.Text;
			//Password to login to the POP3 server
			target.Password = passwordBox.Text;
			AsyncMessageCount = 0;
			//Login to the server
			Pop3Response response = target.Login();
			//Get message from the server (asynchronously)
			IAsyncResult result = target.BeginRecv(
				callBack //delegate will be called when receiving finished
				);
		}
		
		void target_MessageReceived(Pop3Client sender, Rfc822Message message)
		{
			lock (this)
			{
				AsyncMessageCount++;
			}
		}

		void callBack(IAsyncResult ar)
		{
			//This is method, which will be called after receiving
			//Finish receiving
			target.EndRecv(ar);
			//Get number of messages, to check how much was got 
			//Logout from the server
			target.Logout();
			MethodInvoker invoker = delegate() { 
				messageTextBox.AppendText(String.Format("Number of messages: {0} \r\n", AsyncMessageCount));
				getOneButton.Enabled = true;
				getAllButton.Enabled = true;
			};
			this.Invoke(invoker);

			AsyncMessageCount = 0;
		}

		private void close_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void getOneButton_Click(object sender, EventArgs e)
		{
			getAllButton.Enabled = false;
			getOneButton.Enabled = false;
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
			//Get message from the server (asynchronously)
			IAsyncResult result = target.BeginRecv(
				new uint[] {(uint)messageNumber.Value},//messages numbers to receive
				callBack //delegate will be called when receiving finished
				);
		}
	}
}
