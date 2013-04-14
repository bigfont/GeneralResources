using System;
using System.Windows.Forms;
using Email.Net.Smtp;

namespace SendMessageUsingSingleLineOfCode
{
	public partial class SendMessageForm : Form
	{
		public SendMessageForm()
		{
			InitializeComponent();
		}

		private void btnChangeConfig_Click(object sender, EventArgs e)
		{
			smtpClient.Host = txtSmtpServer.Text;
			smtpClient.Port = ushort.Parse(txtSmtpPort.Text);
			smtpClient.Username = txtSmtpLogin.Text;
			smtpClient.Password = txtSmtpPassword.Text;
			MessageBox.Show("Settings changed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information,MessageBoxDefaultButton.Button1);
		}

		private void btnSendMessage_Click(object sender, EventArgs e)
		{
			SendResult result=smtpClient.SendOne(txtSenderAddress.Text, txtRecipientAddress.Text, txtSubject.Text, txtMessageText.Text);

			if (result.IsSuccessful == true) MessageBox.Show("Message sent successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
			else MessageBox.Show("Some errors has happen during sending", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
		}
	}
}
