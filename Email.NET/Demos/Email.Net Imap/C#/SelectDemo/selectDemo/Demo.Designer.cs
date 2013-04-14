namespace selectDemo
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
			this.portNum = new System.Windows.Forms.NumericUpDown();
			this.passwordBox = new System.Windows.Forms.TextBox();
			this.loginBox = new System.Windows.Forms.TextBox();
			this.hostBox = new System.Windows.Forms.TextBox();
			this.loginButton = new System.Windows.Forms.Button();
			this.logoutButton = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.client = new Email.Net.Imap.ImapClient(this.components);
			this.folderBox = new System.Windows.Forms.ListBox();
			this.label5 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.portNum)).BeginInit();
			this.SuspendLayout();
			// 
			// portNum
			// 
			this.portNum.Location = new System.Drawing.Point(120, 64);
			this.portNum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.portNum.Name = "portNum";
			this.portNum.Size = new System.Drawing.Size(150, 20);
			this.portNum.TabIndex = 42;
			this.portNum.Value = new decimal(new int[] {
            143,
            0,
            0,
            0});
			// 
			// passwordBox
			// 
			this.passwordBox.Location = new System.Drawing.Point(120, 116);
			this.passwordBox.Name = "passwordBox";
			this.passwordBox.Size = new System.Drawing.Size(150, 20);
			this.passwordBox.TabIndex = 44;
			this.passwordBox.Text = "";
			// 
			// loginBox
			// 
			this.loginBox.Location = new System.Drawing.Point(120, 90);
			this.loginBox.Name = "loginBox";
			this.loginBox.Size = new System.Drawing.Size(150, 20);
			this.loginBox.TabIndex = 43;
			this.loginBox.Text = "mail@someserver.com";
			// 
			// hostBox
			// 
			this.hostBox.Location = new System.Drawing.Point(120, 38);
			this.hostBox.Name = "hostBox";
			this.hostBox.Size = new System.Drawing.Size(150, 20);
			this.hostBox.TabIndex = 41;
			this.hostBox.Text = "imap.someserver.com";
			// 
			// loginButton
			// 
			this.loginButton.Location = new System.Drawing.Point(93, 146);
			this.loginButton.Name = "loginButton";
			this.loginButton.Size = new System.Drawing.Size(75, 23);
			this.loginButton.TabIndex = 38;
			this.loginButton.Text = "Start";
			this.loginButton.UseVisualStyleBackColor = true;
			this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
			// 
			// logoutButton
			// 
			this.logoutButton.Location = new System.Drawing.Point(193, 146);
			this.logoutButton.Name = "logoutButton";
			this.logoutButton.Size = new System.Drawing.Size(75, 23);
			this.logoutButton.TabIndex = 40;
			this.logoutButton.Text = "Finish";
			this.logoutButton.UseVisualStyleBackColor = true;
			this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 93);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(36, 13);
			this.label3.TabIndex = 48;
			this.label3.Text = "Login:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 66);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 13);
			this.label2.TabIndex = 47;
			this.label2.Text = "Port:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 119);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 13);
			this.label4.TabIndex = 49;
			this.label4.Text = "Password:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 13);
			this.label1.TabIndex = 46;
			this.label1.Text = "Host:";
			// 
			// client
			// 
			this.client.AttachmentDirectory = "";
			this.client.AuthenticationType = Email.Net.Common.Configurations.EAuthenticationType.Auto;
			this.client.Host = "localhost";
			this.client.Password = null;
			this.client.Port = ((ushort)(25));
			this.client.ProxyPort = ((ushort)(0));
			this.client.ProxyType = Email.Net.Common.Configurations.EProxyType.No;
			this.client.ReceiveTimeout = 10000;
			this.client.SendTimeout = 10000;
			this.client.SSLInteractionType = Email.Net.Common.Configurations.EInteractionType.Plain;
			this.client.Username = null;
			// 
			// folderBox
			// 
			this.folderBox.FormattingEnabled = true;
			this.folderBox.Location = new System.Drawing.Point(274, 12);
			this.folderBox.Name = "folderBox";
			this.folderBox.Size = new System.Drawing.Size(262, 160);
			this.folderBox.TabIndex = 50;
			this.folderBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.folderBox_MouseDoubleClick);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(54, 12);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(151, 13);
			this.label5.TabIndex = 51;
			this.label5.Text = "Doubleclick on item to select it";
			// 
			// Demo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(542, 181);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.folderBox);
			this.Controls.Add(this.portNum);
			this.Controls.Add(this.passwordBox);
			this.Controls.Add(this.loginBox);
			this.Controls.Add(this.hostBox);
			this.Controls.Add(this.loginButton);
			this.Controls.Add(this.logoutButton);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Demo";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Email.Net Select a folder demo";
			((System.ComponentModel.ISupportInitialize)(this.portNum)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NumericUpDown portNum;
		private System.Windows.Forms.TextBox passwordBox;
		private System.Windows.Forms.TextBox loginBox;
		private System.Windows.Forms.TextBox hostBox;
		private System.Windows.Forms.Button loginButton;
		private System.Windows.Forms.Button logoutButton;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		private Email.Net.Imap.ImapClient client;
		private System.Windows.Forms.ListBox folderBox;
		private System.Windows.Forms.Label label5;
	}
}

