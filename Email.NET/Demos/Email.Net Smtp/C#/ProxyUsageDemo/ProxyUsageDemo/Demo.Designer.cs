namespace ProxyUsageDemo
{
	partial class Demo
	{
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region 
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.toBox = new System.Windows.Forms.TextBox();
			this.portNum = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.subjectBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.hostBox = new System.Windows.Forms.TextBox();
			this.fromBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.messageBox = new System.Windows.Forms.TextBox();
			this.loginBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.sendMessage = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.passwordBox = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label7 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label12 = new System.Windows.Forms.Label();
			this.proxyType = new System.Windows.Forms.ComboBox();
			this.proxyPortNum = new System.Windows.Forms.NumericUpDown();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.proxyHostBox = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.proxyUserBox = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.proxyPasswordBox = new System.Windows.Forms.TextBox();
			this.target = new Email.Net.Smtp.SmtpClient(this.components);
			((System.ComponentModel.ISupportInitialize)(this.portNum)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.proxyPortNum)).BeginInit();
			this.SuspendLayout();
			// 
			// toBox
			// 
			this.toBox.Location = new System.Drawing.Point(96, 50);
			this.toBox.Name = "toBox";
			this.toBox.Size = new System.Drawing.Size(152, 20);
			this.toBox.TabIndex = 1;
			this.toBox.Text = "test@someserver.com";
			// 
			// portNum
			// 
			this.portNum.Location = new System.Drawing.Point(68, 45);
			this.portNum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.portNum.Name = "portNum";
			this.portNum.Size = new System.Drawing.Size(73, 20);
			this.portNum.TabIndex = 1;
			this.portNum.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 13);
			this.label1.TabIndex = 30;
			this.label1.Text = "Host:";
			// 
			// subjectBox
			// 
			this.subjectBox.Location = new System.Drawing.Point(64, 79);
			this.subjectBox.Name = "subjectBox";
			this.subjectBox.Size = new System.Drawing.Size(184, 20);
			this.subjectBox.TabIndex = 2;
			this.subjectBox.Text = "Test message Subject";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 101);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 13);
			this.label4.TabIndex = 33;
			this.label4.Text = "Password:";
			// 
			// hostBox
			// 
			this.hostBox.Location = new System.Drawing.Point(68, 19);
			this.hostBox.Name = "hostBox";
			this.hostBox.Size = new System.Drawing.Size(73, 20);
			this.hostBox.TabIndex = 0;
			this.hostBox.Text = "smtp.someserver.com";
			// 
			// fromBox
			// 
			this.fromBox.Location = new System.Drawing.Point(96, 19);
			this.fromBox.Name = "fromBox";
			this.fromBox.Size = new System.Drawing.Size(152, 20);
			this.fromBox.TabIndex = 0;
			this.fromBox.Text = "mail@someserver.com";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 75);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(36, 13);
			this.label3.TabIndex = 32;
			this.label3.Text = "Login:";
			// 
			// messageBox
			// 
			this.messageBox.Location = new System.Drawing.Point(6, 108);
			this.messageBox.Multiline = true;
			this.messageBox.Name = "messageBox";
			this.messageBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.messageBox.Size = new System.Drawing.Size(242, 141);
			this.messageBox.TabIndex = 3;
			this.messageBox.Text = "This demo shows how to send message using proxy server.\r\nInsert your message text" +
				" here.";
			// 
			// loginBox
			// 
			this.loginBox.Location = new System.Drawing.Point(68, 72);
			this.loginBox.Name = "loginBox";
			this.loginBox.Size = new System.Drawing.Size(73, 20);
			this.loginBox.TabIndex = 2;
			this.loginBox.Text = "mail@someserver.com";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(9, 26);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(33, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "From:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 47);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 13);
			this.label2.TabIndex = 31;
			this.label2.Text = "Port:";
			// 
			// sendMessage
			// 
			this.sendMessage.Location = new System.Drawing.Point(352, 282);
			this.sendMessage.Name = "sendMessage";
			this.sendMessage.Size = new System.Drawing.Size(75, 23);
			this.sendMessage.TabIndex = 3;
			this.sendMessage.Text = "Send";
			this.sendMessage.UseVisualStyleBackColor = true;
			this.sendMessage.Click += new System.EventHandler(this.sendMessage_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(9, 53);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(23, 13);
			this.label6.TabIndex = 5;
			this.label6.Text = "To:";
			// 
			// passwordBox
			// 
			this.passwordBox.Location = new System.Drawing.Point(68, 98);
			this.passwordBox.Name = "passwordBox";
			this.passwordBox.Size = new System.Drawing.Size(73, 20);
			this.passwordBox.TabIndex = 3;
			this.passwordBox.Text = "";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.subjectBox);
			this.groupBox2.Controls.Add(this.toBox);
			this.groupBox2.Controls.Add(this.fromBox);
			this.groupBox2.Controls.Add(this.messageBox);
			this.groupBox2.Location = new System.Drawing.Point(179, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(254, 253);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Message";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(9, 79);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(46, 13);
			this.label7.TabIndex = 6;
			this.label7.Text = "Subject:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.portNum);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.hostBox);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.loginBox);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.passwordBox);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(147, 129);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Connection Settings";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.label12);
			this.groupBox3.Controls.Add(this.proxyType);
			this.groupBox3.Controls.Add(this.proxyPortNum);
			this.groupBox3.Controls.Add(this.label8);
			this.groupBox3.Controls.Add(this.label9);
			this.groupBox3.Controls.Add(this.proxyHostBox);
			this.groupBox3.Controls.Add(this.label10);
			this.groupBox3.Controls.Add(this.proxyUserBox);
			this.groupBox3.Controls.Add(this.label11);
			this.groupBox3.Controls.Add(this.proxyPasswordBox);
			this.groupBox3.Location = new System.Drawing.Point(12, 147);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(147, 158);
			this.groupBox3.TabIndex = 6;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Proxy Settings";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(6, 127);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(34, 13);
			this.label12.TabIndex = 35;
			this.label12.Text = "Type:";
			// 
			// proxyType
			// 
			this.proxyType.FormattingEnabled = true;
			this.proxyType.Location = new System.Drawing.Point(68, 124);
			this.proxyType.Name = "proxyType";
			this.proxyType.Size = new System.Drawing.Size(73, 21);
			this.proxyType.TabIndex = 34;
			// 
			// proxyPortNum
			// 
			this.proxyPortNum.Location = new System.Drawing.Point(68, 45);
			this.proxyPortNum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.proxyPortNum.Name = "proxyPortNum";
			this.proxyPortNum.Size = new System.Drawing.Size(73, 20);
			this.proxyPortNum.TabIndex = 1;
			this.proxyPortNum.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(6, 22);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(32, 13);
			this.label8.TabIndex = 30;
			this.label8.Text = "Host:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(6, 101);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(56, 13);
			this.label9.TabIndex = 33;
			this.label9.Text = "Password:";
			// 
			// proxyHostBox
			// 
			this.proxyHostBox.Location = new System.Drawing.Point(68, 19);
			this.proxyHostBox.Name = "proxyHostBox";
			this.proxyHostBox.Size = new System.Drawing.Size(73, 20);
			this.proxyHostBox.TabIndex = 0;
			this.proxyHostBox.Text = "proxy.someserver.com";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(6, 75);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(36, 13);
			this.label10.TabIndex = 32;
			this.label10.Text = "Login:";
			// 
			// proxyUserBox
			// 
			this.proxyUserBox.Location = new System.Drawing.Point(68, 72);
			this.proxyUserBox.Name = "proxyUserBox";
			this.proxyUserBox.Size = new System.Drawing.Size(73, 20);
			this.proxyUserBox.TabIndex = 2;
			this.proxyUserBox.Text = "proxyUser";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(6, 47);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(29, 13);
			this.label11.TabIndex = 31;
			this.label11.Text = "Port:";
			// 
			// proxyPasswordBox
			// 
			this.proxyPasswordBox.Location = new System.Drawing.Point(68, 98);
			this.proxyPasswordBox.Name = "proxyPasswordBox";
			this.proxyPasswordBox.Size = new System.Drawing.Size(73, 20);
			this.proxyPasswordBox.TabIndex = 3;
			this.proxyPasswordBox.Text = "";
			// 
			// target
			// 
			this.target.AuthenticationType = Email.Net.Common.Configurations.EAuthenticationType.Auto;
			this.target.Host = "localhost";
			this.target.Password = "";
			this.target.Port = ((ushort)(25));
			this.target.ProxyHost = "";
			this.target.ProxyPassword = "";
			this.target.ProxyPort = ((ushort)(0));
			this.target.ProxyType = Email.Net.Common.Configurations.EProxyType.No;
			this.target.ProxyUser = "";
			this.target.ReceiveTimeOut = 10000;
			this.target.SendTimeOut = 10000;
			this.target.SSLInteractionType = Email.Net.Common.Configurations.EInteractionType.Plain;
			this.target.Username = "";
			// 
			// Demo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(444, 310);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.sendMessage);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Demo";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Email.Net Send with proxy demo";
			((System.ComponentModel.ISupportInitialize)(this.portNum)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.proxyPortNum)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox toBox;
		private System.Windows.Forms.NumericUpDown portNum;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox subjectBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox hostBox;
		private System.Windows.Forms.TextBox fromBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox messageBox;
		private System.Windows.Forms.TextBox loginBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button sendMessage;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox passwordBox;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.ComboBox proxyType;
		private System.Windows.Forms.NumericUpDown proxyPortNum;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox proxyHostBox;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox proxyUserBox;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox proxyPasswordBox;
		private Email.Net.Smtp.SmtpClient target;
	}
}

