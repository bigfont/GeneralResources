namespace asynchronousDemo
{
	partial class Demo
	{
		/// <summary>
		/// 
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="disposing"></param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region 

		/// <summary>
		/// 
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.getMessage = new System.Windows.Forms.Button();
			this.portNum = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.passwordBox = new System.Windows.Forms.TextBox();
			this.loginBox = new System.Windows.Forms.TextBox();
			this.hostBox = new System.Windows.Forms.TextBox();
			this.startButton = new System.Windows.Forms.Button();
			this.finishButton = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.interactionCombo = new System.Windows.Forms.ComboBox();
			this.client = new Email.Net.Imap.ImapClient(this.components);
			this.messageList = new System.Windows.Forms.ListBox();
			this.messageTextBox = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.portNum)).BeginInit();
			this.SuspendLayout();
			// 
			// getMessage
			// 
			this.getMessage.Location = new System.Drawing.Point(105, 159);
			this.getMessage.Name = "getMessage";
			this.getMessage.Size = new System.Drawing.Size(75, 23);
			this.getMessage.TabIndex = 41;
			this.getMessage.Text = "Get";
			this.getMessage.UseVisualStyleBackColor = true;
			this.getMessage.Click += new System.EventHandler(this.getMessage_Click);
			// 
			// portNum
			// 
			this.portNum.Location = new System.Drawing.Point(120, 38);
			this.portNum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.portNum.Name = "portNum";
			this.portNum.Size = new System.Drawing.Size(150, 20);
			this.portNum.TabIndex = 43;
			this.portNum.Value = new decimal(new int[] {
            993,
            0,
            0,
            0});
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 125);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(83, 13);
			this.label5.TabIndex = 52;
			this.label5.Text = "Interaction type:";
			// 
			// passwordBox
			// 
			this.passwordBox.Location = new System.Drawing.Point(120, 90);
			this.passwordBox.Name = "passwordBox";
			this.passwordBox.Size = new System.Drawing.Size(150, 20);
			this.passwordBox.TabIndex = 45;
			this.passwordBox.Text = "";
			// 
			// loginBox
			// 
			this.loginBox.Location = new System.Drawing.Point(120, 64);
			this.loginBox.Name = "loginBox";
			this.loginBox.Size = new System.Drawing.Size(150, 20);
			this.loginBox.TabIndex = 44;
			this.loginBox.Text = "mail@someserver.com";
			// 
			// hostBox
			// 
			this.hostBox.Location = new System.Drawing.Point(120, 12);
			this.hostBox.Name = "hostBox";
			this.hostBox.Size = new System.Drawing.Size(150, 20);
			this.hostBox.TabIndex = 42;
			this.hostBox.Text = "imap.someserver.com";
			// 
			// startButton
			// 
			this.startButton.Location = new System.Drawing.Point(13, 159);
			this.startButton.Name = "startButton";
			this.startButton.Size = new System.Drawing.Size(75, 23);
			this.startButton.TabIndex = 39;
			this.startButton.Text = "Start";
			this.startButton.UseVisualStyleBackColor = true;
			this.startButton.Click += new System.EventHandler(this.startButton_Click);
			// 
			// finishButton
			// 
			this.finishButton.Location = new System.Drawing.Point(195, 159);
			this.finishButton.Name = "finishButton";
			this.finishButton.Size = new System.Drawing.Size(75, 23);
			this.finishButton.TabIndex = 40;
			this.finishButton.Text = "Finish";
			this.finishButton.UseVisualStyleBackColor = true;
			this.finishButton.Click += new System.EventHandler(this.finishButton_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 72);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(36, 13);
			this.label3.TabIndex = 50;
			this.label3.Text = "Login:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 46);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 13);
			this.label2.TabIndex = 49;
			this.label2.Text = "Port:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 98);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 13);
			this.label4.TabIndex = 51;
			this.label4.Text = "Password:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 13);
			this.label1.TabIndex = 48;
			this.label1.Text = "Host:";
			// 
			// interactionCombo
			// 
			this.interactionCombo.FormattingEnabled = true;
			this.interactionCombo.Location = new System.Drawing.Point(120, 122);
			this.interactionCombo.Name = "interactionCombo";
			this.interactionCombo.Size = new System.Drawing.Size(150, 21);
			this.interactionCombo.TabIndex = 46;
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
			this.client.ReceiveTimeout = 10000;
			this.client.SendTimeout = 10000;
			this.client.SSLInteractionType = Email.Net.Common.Configurations.EInteractionType.Plain;
			this.client.Username = "Login";
			// 
			// messageList
			// 
			this.messageList.HorizontalScrollbar = true;
			this.messageList.Location = new System.Drawing.Point(276, 9);
			this.messageList.Name = "messageList";
			this.messageList.Size = new System.Drawing.Size(212, 173);
			this.messageList.TabIndex = 53;
			// 
			// messageTextBox
			// 
			this.messageTextBox.Location = new System.Drawing.Point(494, 9);
			this.messageTextBox.Multiline = true;
			this.messageTextBox.Name = "messageTextBox";
			this.messageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.messageTextBox.Size = new System.Drawing.Size(187, 168);
			this.messageTextBox.TabIndex = 54;
			// 
			// Demo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(693, 189);
			this.Controls.Add(this.messageTextBox);
			this.Controls.Add(this.messageList);
			this.Controls.Add(this.getMessage);
			this.Controls.Add(this.portNum);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.passwordBox);
			this.Controls.Add(this.loginBox);
			this.Controls.Add(this.hostBox);
			this.Controls.Add(this.startButton);
			this.Controls.Add(this.finishButton);
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
			this.Text = "Email.Net Asynchronous demo";
			((System.ComponentModel.ISupportInitialize)(this.portNum)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button getMessage;
		private System.Windows.Forms.NumericUpDown portNum;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox passwordBox;
		private System.Windows.Forms.TextBox loginBox;
		private System.Windows.Forms.TextBox hostBox;
		private System.Windows.Forms.Button startButton;
		private System.Windows.Forms.Button finishButton;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox interactionCombo;
		private Email.Net.Imap.ImapClient client;
		private System.Windows.Forms.ListBox messageList;
		private System.Windows.Forms.TextBox messageTextBox;
	}
}

