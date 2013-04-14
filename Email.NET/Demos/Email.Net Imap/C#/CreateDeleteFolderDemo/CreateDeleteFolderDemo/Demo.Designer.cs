namespace CreateDeleteFolderDemo
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
			this.portNum = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.passwordBox = new System.Windows.Forms.TextBox();
			this.loginBox = new System.Windows.Forms.TextBox();
			this.hostBox = new System.Windows.Forms.TextBox();
			this.startAuthorization = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.interactionCombo = new System.Windows.Forms.ComboBox();
			this.createButton = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.folderName = new System.Windows.Forms.TextBox();
			this.client = new Email.Net.Imap.ImapClient(this.components);
			this.deleteButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.portNum)).BeginInit();
			this.SuspendLayout();
			// 
			// portNum
			// 
			this.portNum.Location = new System.Drawing.Point(120, 49);
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
			this.label5.Location = new System.Drawing.Point(12, 136);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(83, 13);
			this.label5.TabIndex = 38;
			this.label5.Text = "Interaction type:";
			// 
			// passwordBox
			// 
			this.passwordBox.Location = new System.Drawing.Point(120, 101);
			this.passwordBox.Name = "passwordBox";
			this.passwordBox.Size = new System.Drawing.Size(150, 20);
			this.passwordBox.TabIndex = 6;
			this.passwordBox.Text = "";
			// 
			// loginBox
			// 
			this.loginBox.Location = new System.Drawing.Point(120, 75);
			this.loginBox.Name = "loginBox";
			this.loginBox.Size = new System.Drawing.Size(150, 20);
			this.loginBox.TabIndex = 5;
			this.loginBox.Text = "mail@someserver.com";
			// 
			// hostBox
			// 
			this.hostBox.Location = new System.Drawing.Point(120, 23);
			this.hostBox.Name = "hostBox";
			this.hostBox.Size = new System.Drawing.Size(150, 20);
			this.hostBox.TabIndex = 3;
			this.hostBox.Text = "imap.someserver.com";
			// 
			// startAuthorization
			// 
			this.startAuthorization.Location = new System.Drawing.Point(15, 206);
			this.startAuthorization.Name = "startAuthorization";
			this.startAuthorization.Size = new System.Drawing.Size(75, 23);
			this.startAuthorization.TabIndex = 0;
			this.startAuthorization.Text = "Start";
			this.startAuthorization.UseVisualStyleBackColor = true;
			this.startAuthorization.Click += new System.EventHandler(this.startAuthorization_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 78);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(36, 13);
			this.label3.TabIndex = 36;
			this.label3.Text = "Login:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 51);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 13);
			this.label2.TabIndex = 35;
			this.label2.Text = "Port:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 104);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 13);
			this.label4.TabIndex = 37;
			this.label4.Text = "Password:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 13);
			this.label1.TabIndex = 34;
			this.label1.Text = "Host:";
			// 
			// interactionCombo
			// 
			this.interactionCombo.FormattingEnabled = true;
			this.interactionCombo.Location = new System.Drawing.Point(120, 133);
			this.interactionCombo.Name = "interactionCombo";
			this.interactionCombo.Size = new System.Drawing.Size(150, 21);
			this.interactionCombo.TabIndex = 7;
			// 
			// createButton
			// 
			this.createButton.Location = new System.Drawing.Point(105, 206);
			this.createButton.Name = "createButton";
			this.createButton.Size = new System.Drawing.Size(75, 23);
			this.createButton.TabIndex = 1;
			this.createButton.Text = "Create";
			this.createButton.UseVisualStyleBackColor = true;
			this.createButton.Click += new System.EventHandler(this.createButton_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 169);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(68, 13);
			this.label6.TabIndex = 40;
			this.label6.Text = "Folder name:";
			// 
			// folderName
			// 
			this.folderName.Location = new System.Drawing.Point(120, 169);
			this.folderName.Name = "folderName";
			this.folderName.Size = new System.Drawing.Size(150, 20);
			this.folderName.TabIndex = 8;
			this.folderName.Text = "newFolder";
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
			// deleteButton
			// 
			this.deleteButton.Location = new System.Drawing.Point(196, 206);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(75, 23);
			this.deleteButton.TabIndex = 2;
			this.deleteButton.Text = "Delete";
			this.deleteButton.UseVisualStyleBackColor = true;
			this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
			// 
			// Demo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(283, 241);
			this.Controls.Add(this.deleteButton);
			this.Controls.Add(this.folderName);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.createButton);
			this.Controls.Add(this.portNum);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.passwordBox);
			this.Controls.Add(this.loginBox);
			this.Controls.Add(this.hostBox);
			this.Controls.Add(this.startAuthorization);
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
			this.Text = "Email.Net Create and delete folder demo";
			((System.ComponentModel.ISupportInitialize)(this.portNum)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NumericUpDown portNum;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox passwordBox;
		private System.Windows.Forms.TextBox loginBox;
		private System.Windows.Forms.TextBox hostBox;
		private System.Windows.Forms.Button startAuthorization;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox interactionCombo;
		private System.Windows.Forms.Button createButton;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox folderName;
		private Email.Net.Imap.ImapClient client;
		private System.Windows.Forms.Button deleteButton;

	}
}

