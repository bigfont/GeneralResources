namespace searchMessageDemo
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
			this.messageBox = new System.Windows.Forms.TextBox();
			this.portNum = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.passwordBox = new System.Windows.Forms.TextBox();
			this.loginBox = new System.Windows.Forms.TextBox();
			this.hostBox = new System.Windows.Forms.TextBox();
			this.startAuthorization = new System.Windows.Forms.Button();
			this.close = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.interactionCombo = new System.Windows.Forms.ComboBox();
			this.client = new Email.Net.Imap.ImapClient(this.components);
			this.sizeNum = new System.Windows.Forms.NumericUpDown();
			this.label6 = new System.Windows.Forms.Label();
			this.search = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.portNum)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sizeNum)).BeginInit();
			this.SuspendLayout();
			// 
			// messageBox
			// 
			this.messageBox.Location = new System.Drawing.Point(284, 23);
			this.messageBox.Multiline = true;
			this.messageBox.Name = "messageBox";
			this.messageBox.Size = new System.Drawing.Size(217, 199);
			this.messageBox.TabIndex = 9;
			// 
			// portNum
			// 
			this.portNum.Location = new System.Drawing.Point(119, 49);
			this.portNum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.portNum.Name = "portNum";
			this.portNum.Size = new System.Drawing.Size(150, 20);
			this.portNum.TabIndex = 4;
			this.portNum.Value = new decimal(new int[] {
            993,
            0,
            0,
            0});
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(30, 136);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(83, 13);
			this.label5.TabIndex = 52;
			this.label5.Text = "Interaction type:";
			// 
			// passwordBox
			// 
			this.passwordBox.Location = new System.Drawing.Point(119, 101);
			this.passwordBox.Name = "passwordBox";
			this.passwordBox.Size = new System.Drawing.Size(150, 20);
			this.passwordBox.TabIndex = 6;
			this.passwordBox.Text = "";
			// 
			// loginBox
			// 
			this.loginBox.Location = new System.Drawing.Point(119, 75);
			this.loginBox.Name = "loginBox";
			this.loginBox.Size = new System.Drawing.Size(150, 20);
			this.loginBox.TabIndex = 5;
			this.loginBox.Text = "mail@someserver.com";
			// 
			// hostBox
			// 
			this.hostBox.Location = new System.Drawing.Point(119, 23);
			this.hostBox.Name = "hostBox";
			this.hostBox.Size = new System.Drawing.Size(150, 20);
			this.hostBox.TabIndex = 3;
			this.hostBox.Text = "imap.someserver.com";
			// 
			// startAuthorization
			// 
			this.startAuthorization.Location = new System.Drawing.Point(12, 199);
			this.startAuthorization.Name = "startAuthorization";
			this.startAuthorization.Size = new System.Drawing.Size(75, 23);
			this.startAuthorization.TabIndex = 0;
			this.startAuthorization.Text = "Start";
			this.startAuthorization.UseVisualStyleBackColor = true;
			this.startAuthorization.Click += new System.EventHandler(this.startAuthorization_Click);
			// 
			// close
			// 
			this.close.Location = new System.Drawing.Point(194, 199);
			this.close.Name = "close";
			this.close.Size = new System.Drawing.Size(75, 23);
			this.close.TabIndex = 2;
			this.close.Text = "Finish";
			this.close.UseVisualStyleBackColor = true;
			this.close.Click += new System.EventHandler(this.close_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(77, 78);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(36, 13);
			this.label3.TabIndex = 50;
			this.label3.Text = "Login:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(84, 51);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 13);
			this.label2.TabIndex = 49;
			this.label2.Text = "Port:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(57, 104);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 13);
			this.label4.TabIndex = 51;
			this.label4.Text = "Password:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(81, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 13);
			this.label1.TabIndex = 48;
			this.label1.Text = "Host:";
			// 
			// interactionCombo
			// 
			this.interactionCombo.FormattingEnabled = true;
			this.interactionCombo.Location = new System.Drawing.Point(119, 133);
			this.interactionCombo.Name = "interactionCombo";
			this.interactionCombo.Size = new System.Drawing.Size(150, 21);
			this.interactionCombo.TabIndex = 7;
			// 
			// client
			// 
			this.client.AttachmentDirectory = "";
			this.client.AuthenticationType = Email.Net.Common.Configurations.EAuthenticationType.Auto;
			this.client.Host = "localhost";
			this.client.Password = "Password";
			this.client.Port = ((ushort)(25));
			this.client.ProxyPort = ((ushort)(0));
			this.client.ProxyType = Email.Net.Common.Configurations.EProxyType.No;
			this.client.ReceiveTimeout = 100000;
			this.client.SendTimeout = 100000;
			this.client.SSLInteractionType = Email.Net.Common.Configurations.EInteractionType.Plain;
			this.client.Username = "Login";
			// 
			// sizeNum
			// 
			this.sizeNum.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.sizeNum.Location = new System.Drawing.Point(119, 161);
			this.sizeNum.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
			this.sizeNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.sizeNum.Name = "sizeNum";
			this.sizeNum.Size = new System.Drawing.Size(97, 20);
			this.sizeNum.TabIndex = 8;
			this.sizeNum.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(30, 155);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(77, 26);
			this.label6.TabIndex = 54;
			this.label6.Text = "Message size :\r\n(not large)";
			// 
			// search
			// 
			this.search.Location = new System.Drawing.Point(104, 199);
			this.search.Name = "search";
			this.search.Size = new System.Drawing.Size(75, 23);
			this.search.TabIndex = 1;
			this.search.Text = "Search";
			this.search.UseVisualStyleBackColor = true;
			this.search.Click += new System.EventHandler(this.search_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(222, 163);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(33, 13);
			this.label7.TabIndex = 56;
			this.label7.Text = "Bytes";
			// 
			// Demo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(508, 234);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.search);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.sizeNum);
			this.Controls.Add(this.messageBox);
			this.Controls.Add(this.portNum);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.passwordBox);
			this.Controls.Add(this.loginBox);
			this.Controls.Add(this.hostBox);
			this.Controls.Add(this.startAuthorization);
			this.Controls.Add(this.close);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.interactionCombo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Demo";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Email.Net Search messages demo";
			((System.ComponentModel.ISupportInitialize)(this.portNum)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sizeNum)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox messageBox;
		private System.Windows.Forms.NumericUpDown portNum;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox passwordBox;
		private System.Windows.Forms.TextBox loginBox;
		private System.Windows.Forms.TextBox hostBox;
		private System.Windows.Forms.Button startAuthorization;
		private System.Windows.Forms.Button close;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox interactionCombo;
		private Email.Net.Imap.ImapClient client;
		private System.Windows.Forms.NumericUpDown sizeNum;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button search;
		private System.Windows.Forms.Label label7;
	}
}

