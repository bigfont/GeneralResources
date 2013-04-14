Partial Class RemoteMailBox
	''' <summary>
	''' Required designer variable.
	''' </summary>
	Private components As System.ComponentModel.IContainer = Nothing

	''' <summary>
	''' Clean up any resources being used.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(disposing As Boolean)
		If disposing AndAlso (components IsNot Nothing) Then
			components.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub

	#Region "Windows Form Designer generated code"

	''' <summary>
	''' Required method for Designer support - do not modify
	''' the contents of this method with the code editor.
	''' </summary>
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim groupBox1 As System.Windows.Forms.GroupBox
		Dim label6 As System.Windows.Forms.Label
		Dim label5 As System.Windows.Forms.Label
		Dim label2 As System.Windows.Forms.Label
		Dim label1 As System.Windows.Forms.Label
		Dim label3 As System.Windows.Forms.Label
		Dim label4 As System.Windows.Forms.Label
		Dim groupBox2 As System.Windows.Forms.GroupBox
		Dim ssMain As System.Windows.Forms.StatusStrip
		Me.cbAutentificationType = New System.Windows.Forms.ComboBox()
		Me.cbInteractionType = New System.Windows.Forms.ComboBox()
		Me.nPort = New System.Windows.Forms.NumericUpDown()
		Me.tbHostname = New System.Windows.Forms.TextBox()
		Me.bLogin = New System.Windows.Forms.Button()
		Me.tbLogin = New System.Windows.Forms.TextBox()
		Me.tbPassword = New System.Windows.Forms.TextBox()
		Me.slStatus = New System.Windows.Forms.ToolStripStatusLabel()
		Me.lvMessageBrowser = New System.Windows.Forms.ListView()
		Me.chFrom = DirectCast(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.chSubject = DirectCast(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.chDate = DirectCast(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me._client = New Email.Net.Imap.ImapClient(Me.components)
		groupBox1 = New System.Windows.Forms.GroupBox()
		label6 = New System.Windows.Forms.Label()
		label5 = New System.Windows.Forms.Label()
		label2 = New System.Windows.Forms.Label()
		label1 = New System.Windows.Forms.Label()
		label3 = New System.Windows.Forms.Label()
		label4 = New System.Windows.Forms.Label()
		groupBox2 = New System.Windows.Forms.GroupBox()
		ssMain = New System.Windows.Forms.StatusStrip()
		groupBox1.SuspendLayout()
		DirectCast(Me.nPort, System.ComponentModel.ISupportInitialize).BeginInit()
		groupBox2.SuspendLayout()
		ssMain.SuspendLayout()
		Me.SuspendLayout()
		' 
		' groupBox1
		' 
		groupBox1.Controls.Add(Me.cbAutentificationType)
		groupBox1.Controls.Add(Me.cbInteractionType)
		groupBox1.Controls.Add(label6)
		groupBox1.Controls.Add(label5)
		groupBox1.Controls.Add(Me.nPort)
		groupBox1.Controls.Add(label2)
		groupBox1.Controls.Add(label1)
		groupBox1.Controls.Add(Me.tbHostname)
		groupBox1.Location = New System.Drawing.Point(12, 12)
		groupBox1.Name = "groupBox1"
		groupBox1.Size = New System.Drawing.Size(264, 126)
		groupBox1.TabIndex = 0
		groupBox1.TabStop = False
		groupBox1.Text = "Server"
		' 
		' cbAutentificationType
		' 
		Me.cbAutentificationType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cbAutentificationType.FormattingEnabled = True
		Me.cbAutentificationType.Items.AddRange(New Object() {"No autentification", "Chosen automatically", "Use PLAIN mechanism of authentication", "Use CRAM-MD5 mechanism of authentication", "Use DIGEST-MD5 method of authentication", "Use LOGIN method of authentication"})
		Me.cbAutentificationType.Location = New System.Drawing.Point(124, 96)
		Me.cbAutentificationType.Name = "cbAutentificationType"
		Me.cbAutentificationType.Size = New System.Drawing.Size(131, 21)
		Me.cbAutentificationType.TabIndex = 11
		' 
		' cbInteractionType
		' 
		Me.cbInteractionType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cbInteractionType.FormattingEnabled = True
		Me.cbInteractionType.Items.AddRange(New Object() {"With a plain-text", "Initialize SSL when starting a connection", "Switch to SSL during a connection"})
		Me.cbInteractionType.Location = New System.Drawing.Point(124, 70)
		Me.cbInteractionType.Name = "cbInteractionType"
		Me.cbInteractionType.Size = New System.Drawing.Size(131, 21)
		Me.cbInteractionType.TabIndex = 4
		' 
		' label6
		' 
		label6.AutoSize = True
		label6.Location = New System.Drawing.Point(15, 99)
		label6.Name = "label6"
		label6.Size = New System.Drawing.Size(103, 13)
		label6.TabIndex = 10
		label6.Text = "Authentification type"
		' 
		' label5
		' 
		label5.AutoSize = True
		label5.Location = New System.Drawing.Point(15, 73)
		label5.Name = "label5"
		label5.Size = New System.Drawing.Size(80, 13)
		label5.TabIndex = 9
		label5.Text = "Interaction type"
		' 
		' nPort
		' 
		Me.nPort.Location = New System.Drawing.Point(124, 43)
		Me.nPort.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
		Me.nPort.Name = "nPort"
		Me.nPort.Size = New System.Drawing.Size(91, 20)
		Me.nPort.TabIndex = 8
		Me.nPort.Value = New Decimal(New Integer() {993, 0, 0, 0})
		' 
		' label2
		' 
		label2.AutoSize = True
		label2.Location = New System.Drawing.Point(15, 45)
		label2.Name = "label2"
		label2.Size = New System.Drawing.Size(26, 13)
		label2.TabIndex = 5
		label2.Text = "Port"
		' 
		' label1
		' 
		label1.AutoSize = True
		label1.Location = New System.Drawing.Point(15, 20)
		label1.Name = "label1"
		label1.Size = New System.Drawing.Size(55, 13)
		label1.TabIndex = 4
		label1.Text = "Hostname"
		' 
		' tbHostname
		' 
		Me.tbHostname.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbHostname.Location = New System.Drawing.Point(76, 17)
		Me.tbHostname.Name = "tbHostname"
		Me.tbHostname.Size = New System.Drawing.Size(179, 20)
		Me.tbHostname.TabIndex = 0
        Me.tbHostname.Text = "imap.someserver.com"
		' 
		' label3
		' 
		label3.AutoSize = True
		label3.Location = New System.Drawing.Point(17, 23)
		label3.Name = "label3"
		label3.Size = New System.Drawing.Size(33, 13)
		label3.TabIndex = 6
		label3.Text = "Login"
		' 
		' label4
		' 
		label4.AutoSize = True
		label4.Location = New System.Drawing.Point(17, 50)
		label4.Name = "label4"
		label4.Size = New System.Drawing.Size(53, 13)
		label4.TabIndex = 7
		label4.Text = "Password"
		' 
		' groupBox2
		' 
		groupBox2.Controls.Add(Me.bLogin)
		groupBox2.Controls.Add(Me.tbLogin)
		groupBox2.Controls.Add(label4)
		groupBox2.Controls.Add(Me.tbPassword)
		groupBox2.Controls.Add(label3)
		groupBox2.Location = New System.Drawing.Point(282, 12)
		groupBox2.Name = "groupBox2"
		groupBox2.Size = New System.Drawing.Size(304, 126)
		groupBox2.TabIndex = 2
		groupBox2.TabStop = False
		groupBox2.Text = "User"
		' 
		' bLogin
		' 
		Me.bLogin.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.bLogin.Location = New System.Drawing.Point(122, 87)
		Me.bLogin.Name = "bLogin"
		Me.bLogin.Size = New System.Drawing.Size(61, 25)
		Me.bLogin.TabIndex = 8
		Me.bLogin.Text = "Login"
		Me.bLogin.UseVisualStyleBackColor = True
		AddHandler Me.bLogin.Click, New System.EventHandler(AddressOf Me.bLogin_Click)
		' 
		' tbLogin
		' 
		Me.tbLogin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbLogin.Location = New System.Drawing.Point(76, 20)
		Me.tbLogin.Name = "tbLogin"
		Me.tbLogin.Size = New System.Drawing.Size(222, 20)
		Me.tbLogin.TabIndex = 2
        Me.tbLogin.Text = "mail@somserver.com"
		' 
		' tbPassword
		' 
		Me.tbPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbPassword.Location = New System.Drawing.Point(76, 47)
		Me.tbPassword.Name = "tbPassword"
		Me.tbPassword.Size = New System.Drawing.Size(222, 20)
		Me.tbPassword.TabIndex = 3
        Me.tbPassword.Text = ""
		' 
		' ssMain
		' 
		ssMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.slStatus})
		ssMain.Location = New System.Drawing.Point(0, 395)
		ssMain.Name = "ssMain"
		ssMain.Size = New System.Drawing.Size(598, 22)
		ssMain.TabIndex = 3
		' 
		' slStatus
		' 
		Me.slStatus.Name = "slStatus"
		Me.slStatus.Size = New System.Drawing.Size(79, 17)
		Me.slStatus.Text = "Disconnected"
		' 
		' lvMessageBrowser
		' 
		Me.lvMessageBrowser.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lvMessageBrowser.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chFrom, Me.chSubject, Me.chDate})
		Me.lvMessageBrowser.Location = New System.Drawing.Point(12, 144)
		Me.lvMessageBrowser.Name = "lvMessageBrowser"
		Me.lvMessageBrowser.Size = New System.Drawing.Size(574, 261)
		Me.lvMessageBrowser.TabIndex = 1
		Me.lvMessageBrowser.UseCompatibleStateImageBehavior = False
		Me.lvMessageBrowser.View = System.Windows.Forms.View.Details
		AddHandler Me.lvMessageBrowser.DoubleClick, New System.EventHandler(AddressOf Me.lvMessageBrowser_DoubleClick)
		' 
		' chFrom
		' 
		Me.chFrom.Text = "From"
		Me.chFrom.Width = 150
		' 
		' chSubject
		' 
		Me.chSubject.Text = "Subject"
		Me.chSubject.Width = 190
		' 
		' chDate
		' 
		Me.chDate.Text = "Date"
		Me.chDate.Width = 150
		' 
		' _client
		' 
		Me._client.AuthenticationType = Email.Net.Common.Configurations.EAuthenticationType.Auto
		Me._client.Host = "localhost"
		Me._client.Password = Nothing
		Me._client.Port = CUShort(25)
		Me._client.ProxyPort = CUShort(0)
		Me._client.ProxyType = Email.Net.Common.Configurations.EProxyType.No
		Me._client.ReceiveTimeout = 10000
		Me._client.SendTimeout = 10000
		Me._client.SSLInteractionType = Email.Net.Common.Configurations.EInteractionType.Plain
		Me._client.Username = Nothing
		' 
		' RemoteMailBox
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(598, 417)
		Me.Controls.Add(ssMain)
		Me.Controls.Add(groupBox2)
		Me.Controls.Add(Me.lvMessageBrowser)
		Me.Controls.Add(groupBox1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
		Me.MaximizeBox = False
		Me.Name = "RemoteMailBox"
		Me.Text = "POP3 Mailbox browser"
		groupBox1.ResumeLayout(False)
		groupBox1.PerformLayout()
		DirectCast(Me.nPort, System.ComponentModel.ISupportInitialize).EndInit()
		groupBox2.ResumeLayout(False)
		groupBox2.PerformLayout()
		ssMain.ResumeLayout(False)
		ssMain.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	#End Region

	Private nPort As System.Windows.Forms.NumericUpDown
	Private tbHostname As System.Windows.Forms.TextBox
	Private tbLogin As System.Windows.Forms.TextBox
	Private tbPassword As System.Windows.Forms.TextBox
	Private lvMessageBrowser As System.Windows.Forms.ListView
	Private chFrom As System.Windows.Forms.ColumnHeader
	Private chSubject As System.Windows.Forms.ColumnHeader
	Private chDate As System.Windows.Forms.ColumnHeader
	Private bLogin As System.Windows.Forms.Button
	Private slStatus As System.Windows.Forms.ToolStripStatusLabel
	Private cbAutentificationType As System.Windows.Forms.ComboBox
	Private cbInteractionType As System.Windows.Forms.ComboBox
	Private _client As Email.Net.Imap.ImapClient


End Class

