namespace ProxyAuthorithationExample
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label9 = new System.Windows.Forms.Label();
			this.proxyTypeCombo = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.proxyPortNum = new System.Windows.Forms.NumericUpDown();
			this.proxyHostBox = new System.Windows.Forms.TextBox();
			this.proxyLoginBox = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.proxyPasswordBox = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.target = new Email.Net.Pop3.Pop3Client(this.components);
			((System.ComponentModel.ISupportInitialize)(this.portNum)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.proxyPortNum)).BeginInit();
			this.SuspendLayout();
			// 
			// portNum
			// 
			this.portNum.Location = new System.Drawing.Point(77, 45);
			this.portNum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.portNum.Name = "portNum";
			this.portNum.Size = new System.Drawing.Size(150, 20);
			this.portNum.TabIndex = 17;
			this.portNum.Value = new decimal(new int[] {
            110,
            0,
            0,
            0});
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(13, 100);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 13);
			this.label4.TabIndex = 25;
			this.label4.Text = "Password:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 73);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(36, 13);
			this.label3.TabIndex = 24;
			this.label3.Text = "Login:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 47);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 13);
			this.label2.TabIndex = 23;
			this.label2.Text = "Port:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 13);
			this.label1.TabIndex = 22;
			this.label1.Text = "Host:";
			// 
			// passwordBox
			// 
			this.passwordBox.Location = new System.Drawing.Point(77, 97);
			this.passwordBox.Name = "passwordBox";
			this.passwordBox.Size = new System.Drawing.Size(150, 20);
			this.passwordBox.TabIndex = 19;
			this.passwordBox.Text = "1123be11";
			// 
			// loginBox
			// 
			this.loginBox.Location = new System.Drawing.Point(77, 71);
			this.loginBox.Name = "loginBox";
			this.loginBox.Size = new System.Drawing.Size(150, 20);
			this.loginBox.TabIndex = 18;
			this.loginBox.Text = "mailnet.tester@gmail.com";
			// 
			// hostBox
			// 
			this.hostBox.Location = new System.Drawing.Point(77, 19);
			this.hostBox.Name = "hostBox";
			this.hostBox.Size = new System.Drawing.Size(150, 20);
			this.hostBox.TabIndex = 16;
			this.hostBox.Text = "pop.gmail.com";
			// 
			// startAuthorization
			// 
			this.startAuthorization.Location = new System.Drawing.Point(41, 147);
			this.startAuthorization.Name = "startAuthorization";
			this.startAuthorization.Size = new System.Drawing.Size(75, 23);
			this.startAuthorization.TabIndex = 14;
			this.startAuthorization.Text = "Start";
			this.startAuthorization.UseVisualStyleBackColor = true;
			this.startAuthorization.Click += new System.EventHandler(this.startAuthorization_Click);
			// 
			// close
			// 
			this.close.Location = new System.Drawing.Point(122, 147);
			this.close.Name = "close";
			this.close.Size = new System.Drawing.Size(75, 23);
			this.close.TabIndex = 15;
			this.close.Text = "Finish";
			this.close.UseVisualStyleBackColor = true;
			this.close.Click += new System.EventHandler(this.close_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.portNum);
			this.groupBox1.Controls.Add(this.hostBox);
			this.groupBox1.Controls.Add(this.loginBox);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.passwordBox);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(242, 128);
			this.groupBox1.TabIndex = 26;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Server settings";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.proxyTypeCombo);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.proxyPortNum);
			this.groupBox2.Controls.Add(this.proxyHostBox);
			this.groupBox2.Controls.Add(this.proxyLoginBox);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.proxyPasswordBox);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Location = new System.Drawing.Point(275, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(239, 158);
			this.groupBox2.TabIndex = 27;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Proxy settings";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(7, 125);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(59, 13);
			this.label9.TabIndex = 35;
			this.label9.Text = "Proxy type:";
			// 
			// proxyTypeCombo
			// 
			this.proxyTypeCombo.FormattingEnabled = true;
			this.proxyTypeCombo.Location = new System.Drawing.Point(81, 122);
			this.proxyTypeCombo.Name = "proxyTypeCombo";
			this.proxyTypeCombo.Size = new System.Drawing.Size(152, 21);
			this.proxyTypeCombo.TabIndex = 34;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 99);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(56, 13);
			this.label5.TabIndex = 33;
			this.label5.Text = "Password:";
			// 
			// proxyPortNum
			// 
			this.proxyPortNum.Location = new System.Drawing.Point(81, 44);
			this.proxyPortNum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.proxyPortNum.Name = "proxyPortNum";
			this.proxyPortNum.Size = new System.Drawing.Size(152, 20);
			this.proxyPortNum.TabIndex = 27;
			this.proxyPortNum.Value = new decimal(new int[] {
            1080,
            0,
            0,
            0});
			// 
			// proxyHostBox
			// 
			this.proxyHostBox.Location = new System.Drawing.Point(81, 18);
			this.proxyHostBox.Name = "proxyHostBox";
			this.proxyHostBox.Size = new System.Drawing.Size(152, 20);
			this.proxyHostBox.TabIndex = 26;
			this.proxyHostBox.Text = "Virtual-XP";
			// 
			// proxyLoginBox
			// 
			this.proxyLoginBox.Location = new System.Drawing.Point(81, 70);
			this.proxyLoginBox.Name = "proxyLoginBox";
			this.proxyLoginBox.Size = new System.Drawing.Size(152, 20);
			this.proxyLoginBox.TabIndex = 28;
			this.proxyLoginBox.Text = "User";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(7, 73);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(32, 13);
			this.label6.TabIndex = 32;
			this.label6.Text = "User:";
			// 
			// proxyPasswordBox
			// 
			this.proxyPasswordBox.Location = new System.Drawing.Point(81, 96);
			this.proxyPasswordBox.Name = "proxyPasswordBox";
			this.proxyPasswordBox.Size = new System.Drawing.Size(152, 20);
			this.proxyPasswordBox.TabIndex = 29;
			this.proxyPasswordBox.Text = "Password";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(7, 46);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(29, 13);
			this.label7.TabIndex = 31;
			this.label7.Text = "Port:";
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
			this.ClientSize = new System.Drawing.Size(527, 181);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.startAuthorization);
			this.Controls.Add(this.close);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Demo";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Email.Net Proxy authorization demo";
			((System.ComponentModel.ISupportInitialize)(this.portNum)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.proxyPortNum)).EndInit();
			this.ResumeLayout(false);

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
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ComboBox proxyTypeCombo;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.NumericUpDown proxyPortNum;
		private System.Windows.Forms.TextBox proxyHostBox;
		private System.Windows.Forms.TextBox proxyLoginBox;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox proxyPasswordBox;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private Email.Net.Pop3.Pop3Client target;
	}
}

