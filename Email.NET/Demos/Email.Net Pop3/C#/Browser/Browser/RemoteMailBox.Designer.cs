namespace Browser
{
	partial class RemoteMailBox
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
			System.Windows.Forms.GroupBox groupBox1;
			System.Windows.Forms.Label label2;
			System.Windows.Forms.Label label1;
			System.Windows.Forms.Label label3;
			System.Windows.Forms.Label label4;
			System.Windows.Forms.GroupBox groupBox2;
			System.Windows.Forms.StatusStrip ssMain;
			System.Windows.Forms.Label label5;
			System.Windows.Forms.Label label6;
			this.nPort = new System.Windows.Forms.NumericUpDown();
			this.tbHostname = new System.Windows.Forms.TextBox();
			this.bLogin = new System.Windows.Forms.Button();
			this.tbLogin = new System.Windows.Forms.TextBox();
			this.tbPassword = new System.Windows.Forms.TextBox();
			this.slStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.lvMessageBrowser = new System.Windows.Forms.ListView();
			this.chFrom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chSubject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this._client = new Email.Net.Pop3.Pop3Client(this.components);
			this.cbInteractionType = new System.Windows.Forms.ComboBox();
			this.cbAutentificationType = new System.Windows.Forms.ComboBox();
			groupBox1 = new System.Windows.Forms.GroupBox();
			label2 = new System.Windows.Forms.Label();
			label1 = new System.Windows.Forms.Label();
			label3 = new System.Windows.Forms.Label();
			label4 = new System.Windows.Forms.Label();
			groupBox2 = new System.Windows.Forms.GroupBox();
			ssMain = new System.Windows.Forms.StatusStrip();
			label5 = new System.Windows.Forms.Label();
			label6 = new System.Windows.Forms.Label();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nPort)).BeginInit();
			groupBox2.SuspendLayout();
			ssMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(this.cbAutentificationType);
			groupBox1.Controls.Add(this.cbInteractionType);
			groupBox1.Controls.Add(label6);
			groupBox1.Controls.Add(label5);
			groupBox1.Controls.Add(this.nPort);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(label1);
			groupBox1.Controls.Add(this.tbHostname);
			groupBox1.Location = new System.Drawing.Point(12, 12);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new System.Drawing.Size(264, 126);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			groupBox1.Text = "Server";
			// 
			// nPort
			// 
			this.nPort.Location = new System.Drawing.Point(124, 43);
			this.nPort.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.nPort.Name = "nPort";
			this.nPort.Size = new System.Drawing.Size(91, 20);
			this.nPort.TabIndex = 8;
			this.nPort.Value = new decimal(new int[] {
            110,
            0,
            0,
            0});
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(15, 45);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(26, 13);
			label2.TabIndex = 5;
			label2.Text = "Port";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(15, 20);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(55, 13);
			label1.TabIndex = 4;
			label1.Text = "Hostname";
			// 
			// tbHostname
			// 
			this.tbHostname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tbHostname.Location = new System.Drawing.Point(76, 17);
			this.tbHostname.Name = "tbHostname";
			this.tbHostname.Size = new System.Drawing.Size(179, 20);
			this.tbHostname.TabIndex = 0;
			this.tbHostname.Text = "pop.someserver.com";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new System.Drawing.Point(17, 23);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(33, 13);
			label3.TabIndex = 6;
			label3.Text = "Login";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new System.Drawing.Point(17, 50);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(53, 13);
			label4.TabIndex = 7;
			label4.Text = "Password";
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(this.bLogin);
			groupBox2.Controls.Add(this.tbLogin);
			groupBox2.Controls.Add(label4);
			groupBox2.Controls.Add(this.tbPassword);
			groupBox2.Controls.Add(label3);
			groupBox2.Location = new System.Drawing.Point(282, 12);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new System.Drawing.Size(304, 126);
			groupBox2.TabIndex = 2;
			groupBox2.TabStop = false;
			groupBox2.Text = "User";
			// 
			// bLogin
			// 
			this.bLogin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.bLogin.Location = new System.Drawing.Point(122, 87);
			this.bLogin.Name = "bLogin";
			this.bLogin.Size = new System.Drawing.Size(61, 25);
			this.bLogin.TabIndex = 8;
			this.bLogin.Text = "Login";
			this.bLogin.UseVisualStyleBackColor = true;
			this.bLogin.Click += new System.EventHandler(this.bLogin_Click);
			// 
			// tbLogin
			// 
			this.tbLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tbLogin.Location = new System.Drawing.Point(76, 20);
			this.tbLogin.Name = "tbLogin";
			this.tbLogin.Size = new System.Drawing.Size(222, 20);
			this.tbLogin.TabIndex = 2;
			this.tbLogin.Text = "mail@someserver.com";
			// 
			// tbPassword
			// 
			this.tbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tbPassword.Location = new System.Drawing.Point(76, 47);
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.Size = new System.Drawing.Size(222, 20);
			this.tbPassword.TabIndex = 3;
			this.tbPassword.Text = "";
			// 
			// ssMain
			// 
			ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slStatus});
			ssMain.Location = new System.Drawing.Point(0, 395);
			ssMain.Name = "ssMain";
			ssMain.Size = new System.Drawing.Size(598, 22);
			ssMain.TabIndex = 3;
			// 
			// slStatus
			// 
			this.slStatus.Name = "slStatus";
			this.slStatus.Size = new System.Drawing.Size(79, 17);
			this.slStatus.Text = "Disconnected";
			// 
			// lvMessageBrowser
			// 
			this.lvMessageBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.lvMessageBrowser.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chFrom,
            this.chSubject,
            this.chDate});
			this.lvMessageBrowser.Location = new System.Drawing.Point(12, 144);
			this.lvMessageBrowser.Name = "lvMessageBrowser";
			this.lvMessageBrowser.Size = new System.Drawing.Size(574, 261);
			this.lvMessageBrowser.TabIndex = 1;
			this.lvMessageBrowser.UseCompatibleStateImageBehavior = false;
			this.lvMessageBrowser.View = System.Windows.Forms.View.Details;
			this.lvMessageBrowser.DoubleClick += new System.EventHandler(this.lvMessageBrowser_DoubleClick);
			// 
			// chFrom
			// 
			this.chFrom.Text = "From";
			this.chFrom.Width = 150;
			// 
			// chSubject
			// 
			this.chSubject.Text = "Subject";
			this.chSubject.Width = 190;
			// 
			// chDate
			// 
			this.chDate.Text = "Date";
			this.chDate.Width = 150;
			// 
			// _client
			// 
			this._client.AttachmentDirectory = "";
			this._client.AuthenticationType = Email.Net.Common.Configurations.EAuthenticationType.Auto;
			this._client.Host = "localhost";
			this._client.Password = "";
			this._client.Port = ((ushort)(25));
			this._client.ProxyHost = "";
			this._client.ProxyPassword = "";
			this._client.ProxyPort = ((ushort)(0));
			this._client.ProxyType = Email.Net.Common.Configurations.EProxyType.No;
			this._client.ProxyUser = "";
			this._client.ReceiveTimeout = 10000;
			this._client.SendTimeout = 10000;
			this._client.SSLInteractionType = Email.Net.Common.Configurations.EInteractionType.Plain;
			this._client.Username = "";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new System.Drawing.Point(15, 73);
			label5.Name = "label5";
			label5.Size = new System.Drawing.Size(80, 13);
			label5.TabIndex = 9;
			label5.Text = "Interaction type";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new System.Drawing.Point(15, 99);
			label6.Name = "label6";
			label6.Size = new System.Drawing.Size(103, 13);
			label6.TabIndex = 10;
			label6.Text = "Authentification type";
			// 
			// cbInteractionType
			// 
			this.cbInteractionType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.cbInteractionType.FormattingEnabled = true;
			this.cbInteractionType.Items.AddRange(new object[] {
            "With a plain-text",
            "Initialize SSL when starting a connection",
            "Switch to SSL during a connection"});
			this.cbInteractionType.Location = new System.Drawing.Point(124, 70);
			this.cbInteractionType.Name = "cbInteractionType";
			this.cbInteractionType.Size = new System.Drawing.Size(131, 21);
			this.cbInteractionType.TabIndex = 4;
			// 
			// cbAutentificationType
			// 
			this.cbAutentificationType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.cbAutentificationType.FormattingEnabled = true;
			this.cbAutentificationType.Items.AddRange(new object[] {
            "No autentification",
            "Chosen automatically",
            "Use PLAIN mechanism of authentication",
            "Use CRAM-MD5 mechanism of authentication",
            "Use DIGEST-MD5 method of authentication",
            "Use LOGIN method of authentication"});
			this.cbAutentificationType.Location = new System.Drawing.Point(124, 96);
			this.cbAutentificationType.Name = "cbAutentificationType";
			this.cbAutentificationType.Size = new System.Drawing.Size(131, 21);
			this.cbAutentificationType.TabIndex = 11;
			// 
			// RemoteMailBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(598, 417);
			this.Controls.Add(ssMain);
			this.Controls.Add(groupBox2);
			this.Controls.Add(this.lvMessageBrowser);
			this.Controls.Add(groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.Name = "RemoteMailBox";
			this.Text = "POP3 Mailbox browser";
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nPort)).EndInit();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			ssMain.ResumeLayout(false);
			ssMain.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NumericUpDown nPort;
		private System.Windows.Forms.TextBox tbHostname;
		private System.Windows.Forms.TextBox tbLogin;
		private System.Windows.Forms.TextBox tbPassword;
		private System.Windows.Forms.ListView lvMessageBrowser;
		private System.Windows.Forms.ColumnHeader chFrom;
		private System.Windows.Forms.ColumnHeader chSubject;
		private System.Windows.Forms.ColumnHeader chDate;
		private System.Windows.Forms.Button bLogin;
		private System.Windows.Forms.ToolStripStatusLabel slStatus;
		private Email.Net.Pop3.Pop3Client _client;
		private System.Windows.Forms.ComboBox cbAutentificationType;
		private System.Windows.Forms.ComboBox cbInteractionType;


	}
}

