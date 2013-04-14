namespace SendMessageUsingSingleLineOfCode
{
	partial class SendMessageForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.smtpClient = new Email.Net.Smtp.SmtpClient(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtRecipientAddress = new System.Windows.Forms.TextBox();
			this.txtSenderAddress = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtSmtpPassword = new System.Windows.Forms.TextBox();
			this.txtSmtpServer = new System.Windows.Forms.TextBox();
			this.txtSmtpLogin = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtSmtpPort = new System.Windows.Forms.TextBox();
			this.txtSubject = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtMessageText = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.btnSendMessage = new System.Windows.Forms.Button();
			this.btnChangeConfig = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// smtpClient
			// 
			this.smtpClient.AuthenticationType = Email.Net.Common.Configurations.EAuthenticationType.Auto;
			this.smtpClient.Host = "smtp.domain.com";
			this.smtpClient.Password = "mypassword";
			this.smtpClient.Port = ((ushort)(25));
			this.smtpClient.ProxyHost = "";
			this.smtpClient.ProxyPassword = "";
			this.smtpClient.ProxyPort = ((ushort)(0));
			this.smtpClient.ProxyType = Email.Net.Common.Configurations.EProxyType.No;
			this.smtpClient.ProxyUser = "";
			this.smtpClient.ReceiveTimeOut = 10000;
			this.smtpClient.SendTimeOut = 10000;
			this.smtpClient.SSLInteractionType = Email.Net.Common.Configurations.EInteractionType.Plain;
			this.smtpClient.Username = "myusername";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(95, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Recipient address:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(23, 82);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(84, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Sender address:";
			// 
			// txtRecipientAddress
			// 
			this.txtRecipientAddress.Location = new System.Drawing.Point(113, 53);
			this.txtRecipientAddress.Name = "txtRecipientAddress";
			this.txtRecipientAddress.Size = new System.Drawing.Size(230, 20);
			this.txtRecipientAddress.TabIndex = 2;
			this.txtRecipientAddress.Text = "myfriend@domain.com";
			// 
			// txtSenderAddress
			// 
			this.txtSenderAddress.Location = new System.Drawing.Point(113, 79);
			this.txtSenderAddress.Name = "txtSenderAddress";
			this.txtSenderAddress.Size = new System.Drawing.Size(230, 20);
			this.txtSenderAddress.TabIndex = 3;
			this.txtSenderAddress.Text = "me@domain.com";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnChangeConfig);
			this.groupBox1.Controls.Add(this.txtSmtpPassword);
			this.groupBox1.Controls.Add(this.txtSmtpServer);
			this.groupBox1.Controls.Add(this.txtSmtpLogin);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.txtSmtpPort);
			this.groupBox1.Location = new System.Drawing.Point(454, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(270, 159);
			this.groupBox1.TabIndex = 12;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Server parameters";
			// 
			// txtSmtpPassword
			// 
			this.txtSmtpPassword.Location = new System.Drawing.Point(137, 97);
			this.txtSmtpPassword.Name = "txtSmtpPassword";
			this.txtSmtpPassword.Size = new System.Drawing.Size(127, 20);
			this.txtSmtpPassword.TabIndex = 20;
			this.txtSmtpPassword.Text = "mypassword";
			// 
			// txtSmtpServer
			// 
			this.txtSmtpServer.Location = new System.Drawing.Point(137, 19);
			this.txtSmtpServer.Name = "txtSmtpServer";
			this.txtSmtpServer.Size = new System.Drawing.Size(127, 20);
			this.txtSmtpServer.TabIndex = 15;
			this.txtSmtpServer.Text = "smtp.domain.com";
			// 
			// txtSmtpLogin
			// 
			this.txtSmtpLogin.Location = new System.Drawing.Point(137, 71);
			this.txtSmtpLogin.Name = "txtSmtpLogin";
			this.txtSmtpLogin.Size = new System.Drawing.Size(127, 20);
			this.txtSmtpLogin.TabIndex = 19;
			this.txtSmtpLogin.Text = "mylogin";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(19, 22);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(112, 13);
			this.label4.TabIndex = 13;
			this.label4.Text = "SMTP server address:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(75, 100);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(56, 13);
			this.label5.TabIndex = 18;
			this.label5.Text = "Password:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(38, 48);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(93, 13);
			this.label3.TabIndex = 14;
			this.label3.Text = "SMTP server port:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(95, 74);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(36, 13);
			this.label6.TabIndex = 17;
			this.label6.Text = "Login:";
			// 
			// txtSmtpPort
			// 
			this.txtSmtpPort.Location = new System.Drawing.Point(137, 45);
			this.txtSmtpPort.Name = "txtSmtpPort";
			this.txtSmtpPort.Size = new System.Drawing.Size(127, 20);
			this.txtSmtpPort.TabIndex = 16;
			this.txtSmtpPort.Text = "25";
			// 
			// txtSubject
			// 
			this.txtSubject.Location = new System.Drawing.Point(113, 105);
			this.txtSubject.Name = "txtSubject";
			this.txtSubject.Size = new System.Drawing.Size(335, 20);
			this.txtSubject.TabIndex = 14;
			this.txtSubject.Text = "Subject of the message";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(61, 108);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(46, 13);
			this.label7.TabIndex = 13;
			this.label7.Text = "Subject:";
			// 
			// txtMessageText
			// 
			this.txtMessageText.Location = new System.Drawing.Point(12, 177);
			this.txtMessageText.Multiline = true;
			this.txtMessageText.Name = "txtMessageText";
			this.txtMessageText.Size = new System.Drawing.Size(711, 222);
			this.txtMessageText.TabIndex = 15;
			this.txtMessageText.Text = "Text of the message";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(12, 139);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(70, 13);
			this.label8.TabIndex = 16;
			this.label8.Text = "Message text";
			// 
			// btnSendMessage
			// 
			this.btnSendMessage.Location = new System.Drawing.Point(307, 405);
			this.btnSendMessage.Name = "btnSendMessage";
			this.btnSendMessage.Size = new System.Drawing.Size(123, 23);
			this.btnSendMessage.TabIndex = 17;
			this.btnSendMessage.Text = "SendMessage";
			this.btnSendMessage.UseVisualStyleBackColor = true;
			this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
			// 
			// btnChangeConfig
			// 
			this.btnChangeConfig.Location = new System.Drawing.Point(79, 123);
			this.btnChangeConfig.Name = "btnChangeConfig";
			this.btnChangeConfig.Size = new System.Drawing.Size(112, 23);
			this.btnChangeConfig.TabIndex = 21;
			this.btnChangeConfig.Text = "Change config";
			this.btnChangeConfig.UseVisualStyleBackColor = true;
			this.btnChangeConfig.Click += new System.EventHandler(this.btnChangeConfig_Click);
			// 
			// SendMessageForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(736, 440);
			this.Controls.Add(this.btnSendMessage);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtMessageText);
			this.Controls.Add(this.txtSubject);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.txtSenderAddress);
			this.Controls.Add(this.txtRecipientAddress);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "SendMessageForm";
			this.Text = "Send a message";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Email.Net.Smtp.SmtpClient smtpClient;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtRecipientAddress;
		private System.Windows.Forms.TextBox txtSenderAddress;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtSmtpPassword;
		private System.Windows.Forms.TextBox txtSmtpServer;
		private System.Windows.Forms.TextBox txtSmtpLogin;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtSmtpPort;
		private System.Windows.Forms.TextBox txtSubject;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtMessageText;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btnSendMessage;
		private System.Windows.Forms.Button btnChangeConfig;
	}
}

