using System;
using System.Windows.Forms;
using Email.Net.Pop3;

namespace NoopExample
{
	public partial class Demo : Form
	{
		private TimeSpan t = TimeSpan.Zero;

		public Demo()
		{
			InitializeComponent();
		}

		private void startAuthorization_Click(object sender, EventArgs e)
		{
			//Noop function demo
			//URL of host to connect to
			target.Host = hostBox.Text;
			//TCP port for connection
			target.Port = (ushort)portNum.Value;
			//Username to login to the POP3 server
			target.Username = loginBox.Text;
			//Password to login to the POP3 server
			target.Password = passwordBox.Text;
			
			//Login to the server
			target.Login();

			//Start the noopTimer
			noopTimer.Enabled = true;
		}

		private void noopTimer_Tick(object sender, EventArgs e)
		{
			//Add elapsed time between two timer ticks
			t = t.Add(TimeSpan.FromMilliseconds(noopTimer.Interval));

			//Hold an open connection for 5 minutes
			if (t > TimeSpan.FromMinutes(1))
			{
				//Stop the noopTimer
				noopTimer.Enabled = false;

				//Logout from the server
				target.Logout();
				messageTextBox.AppendText("Client have just logged out from the server\r\n");
				return;
			}

			//Check if another operation on target is executing right now
			lock (target)
			{
				if (target.State != EPop3ClientState.Busy)
				{
					target.Noop();
					messageTextBox.AppendText("Noop command sent to the server \r\n");
				}
			}
		}
	}
}
