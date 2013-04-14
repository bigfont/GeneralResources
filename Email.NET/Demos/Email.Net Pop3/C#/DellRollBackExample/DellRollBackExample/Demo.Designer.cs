namespace DellRollBackExample
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
			this.label6 = new System.Windows.Forms.Label();
			this.messageNumber = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.messageTextBox = new System.Windows.Forms.TextBox();
			this.portNum = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.passwordBox = new System.Windows.Forms.TextBox();
			this.loginBox = new System.Windows.Forms.TextBox();
			this.hostBox = new System.Windows.Forms.TextBox();
			this.startAuthorization = new System.Windows.Forms.Button();
			this.close = new System.Windows.Forms.Button();
			this.deleteButton = new System.Windows.Forms.Button();
			this.rollbackButton = new System.Windows.Forms.Button();
			this.target = new Email.Net.Pop3.Pop3Client(this.components);
			((System.ComponentModel.ISupportInitialize)(this.messageNumber)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.portNum)).BeginInit();
			this.SuspendLayout();
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 162);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(91, 13);
			this.label6.TabIndex = 53;
			this.label6.Text = "Message number:";
			// 
			// messageNumber
			// 
			this.messageNumber.Location = new System.Drawing.Point(116, 160);
			this.messageNumber.Name = "messageNumber";
			this.messageNumber.Size = new System.Drawing.Size(150, 20);
			this.messageNumber.TabIndex = 46;
			this.messageNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(42, 6);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(453, 28);
			this.label5.TabIndex = 52;
			this.label5.Text = "This example shows how to delete a message and rollback transaction.\r\nOnly messag" +
				"es deteted between last rollback and session finish will be deleted.";
			// 
			// messageTextBox
			// 
			this.messageTextBox.Location = new System.Drawing.Point(283, 39);
			this.messageTextBox.Multiline = true;
			this.messageTextBox.Name = "messageTextBox";
			this.messageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.messageTextBox.Size = new System.Drawing.Size(236, 141);
			this.messageTextBox.TabIndex = 51;
			// 
			// portNum
			// 
			this.portNum.Location = new System.Drawing.Point(116, 76);
			this.portNum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.portNum.Name = "portNum";
			this.portNum.Size = new System.Drawing.Size(150, 20);
			this.portNum.TabIndex = 43;
			this.portNum.Value = new decimal(new int[] {
            110,
            0,
            0,
            0});
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 131);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 13);
			this.label4.TabIndex = 50;
			this.label4.Text = "Password:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 105);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(36, 13);
			this.label3.TabIndex = 49;
			this.label3.Text = "Login:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 78);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 13);
			this.label2.TabIndex = 48;
			this.label2.Text = "Port:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 53);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 13);
			this.label1.TabIndex = 47;
			this.label1.Text = "Host:";
			// 
			// passwordBox
			// 
			this.passwordBox.Location = new System.Drawing.Point(116, 128);
			this.passwordBox.Name = "passwordBox";
			this.passwordBox.Size = new System.Drawing.Size(150, 20);
			this.passwordBox.TabIndex = 45;
			this.passwordBox.Text = "";
			// 
			// loginBox
			// 
			this.loginBox.Location = new System.Drawing.Point(116, 102);
			this.loginBox.Name = "loginBox";
			this.loginBox.Size = new System.Drawing.Size(150, 20);
			this.loginBox.TabIndex = 44;
			this.loginBox.Text = "mail@someserver.com";
			// 
			// hostBox
			// 
			this.hostBox.Location = new System.Drawing.Point(116, 50);
			this.hostBox.Name = "hostBox";
			this.hostBox.Size = new System.Drawing.Size(150, 20);
			this.hostBox.TabIndex = 42;
			this.hostBox.Text = "pop.someserver.com";
			// 
			// startAuthorization
			// 
			this.startAuthorization.Location = new System.Drawing.Point(85, 204);
			this.startAuthorization.Name = "startAuthorization";
			this.startAuthorization.Size = new System.Drawing.Size(75, 23);
			this.startAuthorization.TabIndex = 40;
			this.startAuthorization.Text = "Start";
			this.startAuthorization.UseVisualStyleBackColor = true;
			this.startAuthorization.Click += new System.EventHandler(this.startAuthorization_Click);
			// 
			// close
			// 
			this.close.Location = new System.Drawing.Point(399, 204);
			this.close.Name = "close";
			this.close.Size = new System.Drawing.Size(75, 23);
			this.close.TabIndex = 41;
			this.close.Text = "Finish";
			this.close.UseVisualStyleBackColor = true;
			this.close.Click += new System.EventHandler(this.close_Click);
			// 
			// deleteButton
			// 
			this.deleteButton.Location = new System.Drawing.Point(183, 204);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(75, 23);
			this.deleteButton.TabIndex = 54;
			this.deleteButton.Text = "Delete";
			this.deleteButton.UseVisualStyleBackColor = true;
			this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
			// 
			// rollbackButton
			// 
			this.rollbackButton.Location = new System.Drawing.Point(287, 204);
			this.rollbackButton.Name = "rollbackButton";
			this.rollbackButton.Size = new System.Drawing.Size(75, 23);
			this.rollbackButton.TabIndex = 55;
			this.rollbackButton.Text = "RollBack";
			this.rollbackButton.UseVisualStyleBackColor = true;
			this.rollbackButton.Click += new System.EventHandler(this.rollbackButton_Click);
			// 
			// target
			// 
			this.target.AttachmentDirectory = "";
			this.target.AuthenticationType = Email.Net.Common.Configurations.EAuthenticationType.Auto;
			this.target.Host = "localhost";
			this.target.Password = "";
			this.target.Port = ((ushort)(25));
			this.target.ProxyHost = "";
			this.target.ProxyPassword = "";
			this.target.ProxyPort = ((ushort)(0));
			this.target.ProxyType = Email.Net.Common.Configurations.EProxyType.No;
			this.target.ProxyUser = "";
			this.target.ReceiveTimeout = 10000;
			this.target.SendTimeout = 10000;
			this.target.SSLInteractionType = Email.Net.Common.Configurations.EInteractionType.Plain;
			this.target.Username = "";
			// 
			// Demo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(527, 239);
			this.Controls.Add(this.rollbackButton);
			this.Controls.Add(this.deleteButton);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.messageNumber);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.messageTextBox);
			this.Controls.Add(this.portNum);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.passwordBox);
			this.Controls.Add(this.loginBox);
			this.Controls.Add(this.hostBox);
			this.Controls.Add(this.startAuthorization);
			this.Controls.Add(this.close);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "Demo";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Email.Net Delete and rollback demo";
			((System.ComponentModel.ISupportInitialize)(this.messageNumber)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.portNum)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.NumericUpDown messageNumber;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox messageTextBox;
		private System.Windows.Forms.NumericUpDown portNum;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox passwordBox;
		private System.Windows.Forms.TextBox loginBox;
		private System.Windows.Forms.TextBox hostBox;
		private System.Windows.Forms.Button startAuthorization;
		private System.Windows.Forms.Button close;
		private System.Windows.Forms.Button deleteButton;
		private System.Windows.Forms.Button rollbackButton;
		private Email.Net.Pop3.Pop3Client target;

	}
}

