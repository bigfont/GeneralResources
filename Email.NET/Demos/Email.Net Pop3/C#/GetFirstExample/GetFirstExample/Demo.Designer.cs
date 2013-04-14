namespace GetFirstExample
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
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.passwordBox = new System.Windows.Forms.TextBox();
			this.loginBox = new System.Windows.Forms.TextBox();
			this.hostBox = new System.Windows.Forms.TextBox();
			this.startAuthorization = new System.Windows.Forms.Button();
			this.close = new System.Windows.Forms.Button();
			this.messageTextBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.messageNumber = new System.Windows.Forms.NumericUpDown();
			this.label6 = new System.Windows.Forms.Label();
			this.target = new Email.Net.Pop3.Pop3Client(this.components);
			((System.ComponentModel.ISupportInitialize)(this.portNum)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.messageNumber)).BeginInit();
			this.SuspendLayout();
			// 
			// portNum
			// 
			this.portNum.Location = new System.Drawing.Point(114, 72);
			this.portNum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.portNum.Name = "portNum";
			this.portNum.Size = new System.Drawing.Size(150, 20);
			this.portNum.TabIndex = 3;
			this.portNum.Value = new decimal(new int[] {
            110,
            0,
            0,
            0});
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 127);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 13);
			this.label4.TabIndex = 35;
			this.label4.Text = "Password:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 101);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(36, 13);
			this.label3.TabIndex = 34;
			this.label3.Text = "Login:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 74);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 13);
			this.label2.TabIndex = 33;
			this.label2.Text = "Port:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 49);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 13);
			this.label1.TabIndex = 32;
			this.label1.Text = "Host:";
			// 
			// passwordBox
			// 
			this.passwordBox.Location = new System.Drawing.Point(114, 124);
			this.passwordBox.Name = "passwordBox";
			this.passwordBox.Size = new System.Drawing.Size(150, 20);
			this.passwordBox.TabIndex = 5;
			this.passwordBox.Text = "";
			// 
			// loginBox
			// 
			this.loginBox.Location = new System.Drawing.Point(114, 98);
			this.loginBox.Name = "loginBox";
			this.loginBox.Size = new System.Drawing.Size(150, 20);
			this.loginBox.TabIndex = 4;
			this.loginBox.Text = "mail@someserver.com";
			// 
			// hostBox
			// 
			this.hostBox.Location = new System.Drawing.Point(114, 46);
			this.hostBox.Name = "hostBox";
			this.hostBox.Size = new System.Drawing.Size(150, 20);
			this.hostBox.TabIndex = 2;
			this.hostBox.Text = "pop.someserver.com";
			// 
			// startAuthorization
			// 
			this.startAuthorization.Location = new System.Drawing.Point(49, 193);
			this.startAuthorization.Name = "startAuthorization";
			this.startAuthorization.Size = new System.Drawing.Size(75, 23);
			this.startAuthorization.TabIndex = 0;
			this.startAuthorization.Text = "Start";
			this.startAuthorization.UseVisualStyleBackColor = true;
			this.startAuthorization.Click += new System.EventHandler(this.startAuthorization_Click);
			// 
			// close
			// 
			this.close.Location = new System.Drawing.Point(130, 193);
			this.close.Name = "close";
			this.close.Size = new System.Drawing.Size(75, 23);
			this.close.TabIndex = 1;
			this.close.Text = "Finish";
			this.close.UseVisualStyleBackColor = true;
			this.close.Click += new System.EventHandler(this.close_Click);
			// 
			// messageTextBox
			// 
			this.messageTextBox.Location = new System.Drawing.Point(281, 35);
			this.messageTextBox.Multiline = true;
			this.messageTextBox.Name = "messageTextBox";
			this.messageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.messageTextBox.Size = new System.Drawing.Size(353, 181);
			this.messageTextBox.TabIndex = 36;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(153, 9);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(345, 14);
			this.label5.TabIndex = 37;
			this.label5.Text = "This example shows how to get a message from the mailBox";
			this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// messageNumber
			// 
			this.messageNumber.Location = new System.Drawing.Point(114, 156);
			this.messageNumber.Name = "messageNumber";
			this.messageNumber.Size = new System.Drawing.Size(150, 20);
			this.messageNumber.TabIndex = 6;
			this.messageNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 158);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(91, 13);
			this.label6.TabIndex = 39;
			this.label6.Text = "Message number:";
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
			this.target.ReceiveTimeout = 10000;
			this.target.SendTimeout = 10000;
			this.target.SSLInteractionType = Email.Net.Common.Configurations.EInteractionType.Plain;
			this.target.Username = "";
			// 
			// Demo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(646, 228);
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
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Demo";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Email.Net Get a message demo";
			((System.ComponentModel.ISupportInitialize)(this.portNum)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.messageNumber)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

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
		private System.Windows.Forms.TextBox messageTextBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.NumericUpDown messageNumber;
		private System.Windows.Forms.Label label6;
		private Email.Net.Pop3.Pop3Client target;
	}
}

