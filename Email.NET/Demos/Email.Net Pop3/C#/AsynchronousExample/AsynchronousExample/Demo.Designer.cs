namespace AsynchronousExample
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
			this.getAllButton = new System.Windows.Forms.Button();
			this.close = new System.Windows.Forms.Button();
			this.getOneButton = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.messageNumber = new System.Windows.Forms.NumericUpDown();
			this.target = new Email.Net.Pop3.Pop3Client(this.components);
			((System.ComponentModel.ISupportInitialize)(this.portNum)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.messageNumber)).BeginInit();
			this.SuspendLayout();
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(84, 9);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(434, 14);
			this.label5.TabIndex = 52;
			this.label5.Text = "This example shows how to asynchronously get messages from the mailBox";
			// 
			// messageTextBox
			// 
			this.messageTextBox.Location = new System.Drawing.Point(283, 42);
			this.messageTextBox.Multiline = true;
			this.messageTextBox.Name = "messageTextBox";
			this.messageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.messageTextBox.Size = new System.Drawing.Size(353, 122);
			this.messageTextBox.TabIndex = 51;
			// 
			// portNum
			// 
			this.portNum.Location = new System.Drawing.Point(116, 79);
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
			this.label4.Location = new System.Drawing.Point(12, 134);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 13);
			this.label4.TabIndex = 50;
			this.label4.Text = "Password:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 108);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(36, 13);
			this.label3.TabIndex = 49;
			this.label3.Text = "Login:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 81);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 13);
			this.label2.TabIndex = 48;
			this.label2.Text = "Port:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 13);
			this.label1.TabIndex = 47;
			this.label1.Text = "Host:";
			// 
			// passwordBox
			// 
			this.passwordBox.Location = new System.Drawing.Point(116, 131);
			this.passwordBox.Name = "passwordBox";
			this.passwordBox.Size = new System.Drawing.Size(150, 20);
			this.passwordBox.TabIndex = 45;
			this.passwordBox.Text = "";
			// 
			// loginBox
			// 
			this.loginBox.Location = new System.Drawing.Point(116, 105);
			this.loginBox.Name = "loginBox";
			this.loginBox.Size = new System.Drawing.Size(150, 20);
			this.loginBox.TabIndex = 44;
			this.loginBox.Text = "mail@someserver.com";
			// 
			// hostBox
			// 
			this.hostBox.Location = new System.Drawing.Point(116, 53);
			this.hostBox.Name = "hostBox";
			this.hostBox.Size = new System.Drawing.Size(150, 20);
			this.hostBox.TabIndex = 42;
			this.hostBox.Text = "pop.someserver.com";
			// 
			// getAllButton
			// 
			this.getAllButton.Location = new System.Drawing.Point(396, 170);
			this.getAllButton.Name = "getAllButton";
			this.getAllButton.Size = new System.Drawing.Size(75, 23);
			this.getAllButton.TabIndex = 40;
			this.getAllButton.Text = "Get All";
			this.getAllButton.UseVisualStyleBackColor = true;
			this.getAllButton.Click += new System.EventHandler(this.getAllButton_Click);
			// 
			// close
			// 
			this.close.Location = new System.Drawing.Point(558, 170);
			this.close.Name = "close";
			this.close.Size = new System.Drawing.Size(75, 23);
			this.close.TabIndex = 41;
			this.close.Text = "Finish";
			this.close.UseVisualStyleBackColor = true;
			this.close.Click += new System.EventHandler(this.close_Click);
			// 
			// getOneButton
			// 
			this.getOneButton.Location = new System.Drawing.Point(477, 170);
			this.getOneButton.Name = "getOneButton";
			this.getOneButton.Size = new System.Drawing.Size(75, 23);
			this.getOneButton.TabIndex = 53;
			this.getOneButton.Text = "Get one";
			this.getOneButton.UseVisualStyleBackColor = true;
			this.getOneButton.Click += new System.EventHandler(this.getOneButton_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 165);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(91, 13);
			this.label6.TabIndex = 55;
			this.label6.Text = "Message number:";
			// 
			// messageNumber
			// 
			this.messageNumber.Location = new System.Drawing.Point(116, 163);
			this.messageNumber.Name = "messageNumber";
			this.messageNumber.Size = new System.Drawing.Size(150, 20);
			this.messageNumber.TabIndex = 54;
			this.messageNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
			this.ClientSize = new System.Drawing.Size(645, 203);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.messageNumber);
			this.Controls.Add(this.getOneButton);
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
			this.Controls.Add(this.getAllButton);
			this.Controls.Add(this.close);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Demo";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Email.Net Asynchronous demo";
			((System.ComponentModel.ISupportInitialize)(this.portNum)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.messageNumber)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

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
		private System.Windows.Forms.Button getAllButton;
		private System.Windows.Forms.Button close;
		private System.Windows.Forms.Button getOneButton;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.NumericUpDown messageNumber;
		private Email.Net.Pop3.Pop3Client target;
	}
}

