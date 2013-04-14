Partial Class Demo
	Private components As System.ComponentModel.IContainer = Nothing

	Protected Overrides Sub Dispose(disposing As Boolean)
		If disposing AndAlso (components IsNot Nothing) Then
			components.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub

#Region ""
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.toBox = New System.Windows.Forms.TextBox()
        Me.portNum = New System.Windows.Forms.NumericUpDown()
        Me.label1 = New System.Windows.Forms.Label()
        Me.subjectBox = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.hostBox = New System.Windows.Forms.TextBox()
        Me.fromBox = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.messageBox = New System.Windows.Forms.TextBox()
        Me.loginBox = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.sendMessage = New System.Windows.Forms.Button()
        Me.label6 = New System.Windows.Forms.Label()
        Me.passwordBox = New System.Windows.Forms.TextBox()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.label12 = New System.Windows.Forms.Label()
        Me.proxyType = New System.Windows.Forms.ComboBox()
        Me.proxyPortNum = New System.Windows.Forms.NumericUpDown()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label9 = New System.Windows.Forms.Label()
        Me.proxyHostBox = New System.Windows.Forms.TextBox()
        Me.label10 = New System.Windows.Forms.Label()
        Me.proxyUserBox = New System.Windows.Forms.TextBox()
        Me.label11 = New System.Windows.Forms.Label()
        Me.proxyPasswordBox = New System.Windows.Forms.TextBox()
        Me.target = New Email.Net.Smtp.SmtpClient(Me.components)
        DirectCast(Me.portNum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox2.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.groupBox3.SuspendLayout()
        DirectCast(Me.proxyPortNum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' toBox
        ' 
        Me.toBox.Location = New System.Drawing.Point(96, 50)
        Me.toBox.Name = "toBox"
        Me.toBox.Size = New System.Drawing.Size(152, 20)
        Me.toBox.TabIndex = 1
        Me.toBox.Text = "mailnet.tester@gmail.com"
        ' 
        ' portNum
        ' 
        Me.portNum.Location = New System.Drawing.Point(68, 45)
        Me.portNum.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.portNum.Name = "portNum"
        Me.portNum.Size = New System.Drawing.Size(73, 20)
        Me.portNum.TabIndex = 1
        Me.portNum.Value = New Decimal(New Integer() {25, 0, 0, 0})
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(3, 22)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(32, 13)
        Me.label1.TabIndex = 30
        Me.label1.Text = "Host:"
        ' 
        ' subjectBox
        ' 
        Me.subjectBox.Location = New System.Drawing.Point(64, 79)
        Me.subjectBox.Name = "subjectBox"
        Me.subjectBox.Size = New System.Drawing.Size(184, 20)
        Me.subjectBox.TabIndex = 2
        Me.subjectBox.Text = "Test message Subject"
        ' 
        ' label4
        ' 
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(6, 101)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(56, 13)
        Me.label4.TabIndex = 33
        Me.label4.Text = "Password:"
        ' 
        ' hostBox
        ' 
        Me.hostBox.Location = New System.Drawing.Point(68, 19)
        Me.hostBox.Name = "hostBox"
        Me.hostBox.Size = New System.Drawing.Size(73, 20)
        Me.hostBox.TabIndex = 0
        Me.hostBox.Text = "smtp.someserver.com"
        ' 
        ' fromBox
        ' 
        Me.fromBox.Location = New System.Drawing.Point(96, 19)
        Me.fromBox.Name = "fromBox"
        Me.fromBox.Size = New System.Drawing.Size(152, 20)
        Me.fromBox.TabIndex = 0
        Me.fromBox.Text = "mail@someserver.com"
        ' 
        ' label3
        ' 
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(6, 75)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(36, 13)
        Me.label3.TabIndex = 32
        Me.label3.Text = "Login:"
        ' 
        ' messageBox
        ' 
        Me.messageBox.Location = New System.Drawing.Point(6, 108)
        Me.messageBox.Multiline = True
        Me.messageBox.Name = "messageBox"
        Me.messageBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.messageBox.Size = New System.Drawing.Size(242, 141)
        Me.messageBox.TabIndex = 3
        Me.messageBox.Text = "This demo shows how to send message using proxy server." & vbCr & vbLf & "Insert your message text" & " here."
        ' 
        ' loginBox
        ' 
        Me.loginBox.Location = New System.Drawing.Point(68, 72)
        Me.loginBox.Name = "loginBox"
        Me.loginBox.Size = New System.Drawing.Size(73, 20)
        Me.loginBox.TabIndex = 2
        Me.loginBox.Text = "test_mailnet"
        ' 
        ' label5
        ' 
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(9, 26)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(33, 13)
        Me.label5.TabIndex = 4
        Me.label5.Text = "From:"
        ' 
        ' label2
        ' 
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(6, 47)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(29, 13)
        Me.label2.TabIndex = 31
        Me.label2.Text = "Port:"
        ' 
        ' sendMessage
        ' 
        Me.sendMessage.Location = New System.Drawing.Point(352, 282)
        Me.sendMessage.Name = "sendMessage"
        Me.sendMessage.Size = New System.Drawing.Size(75, 23)
        Me.sendMessage.TabIndex = 3
        Me.sendMessage.Text = "Send"
        Me.sendMessage.UseVisualStyleBackColor = True
        AddHandler Me.sendMessage.Click, New System.EventHandler(AddressOf Me.sendMessage_Click)
        ' 
        ' label6
        ' 
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(9, 53)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(23, 13)
        Me.label6.TabIndex = 5
        Me.label6.Text = "To:"
        ' 
        ' passwordBox
        ' 
        Me.passwordBox.Location = New System.Drawing.Point(68, 98)
        Me.passwordBox.Name = "passwordBox"
        Me.passwordBox.Size = New System.Drawing.Size(73, 20)
        Me.passwordBox.TabIndex = 3
        Me.passwordBox.Text = ""
        ' 
        ' groupBox2
        ' 
        Me.groupBox2.Controls.Add(Me.label7)
        Me.groupBox2.Controls.Add(Me.label6)
        Me.groupBox2.Controls.Add(Me.label5)
        Me.groupBox2.Controls.Add(Me.subjectBox)
        Me.groupBox2.Controls.Add(Me.toBox)
        Me.groupBox2.Controls.Add(Me.fromBox)
        Me.groupBox2.Controls.Add(Me.messageBox)
        Me.groupBox2.Location = New System.Drawing.Point(179, 12)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(254, 253)
        Me.groupBox2.TabIndex = 5
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Message"
        ' 
        ' label7
        ' 
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(9, 79)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(46, 13)
        Me.label7.TabIndex = 6
        Me.label7.Text = "Subject:"
        ' 
        ' groupBox1
        ' 
        Me.groupBox1.Controls.Add(Me.portNum)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.hostBox)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.loginBox)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.passwordBox)
        Me.groupBox1.Location = New System.Drawing.Point(12, 12)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(147, 129)
        Me.groupBox1.TabIndex = 4
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Connection Settings"
        ' 
        ' groupBox3
        ' 
        Me.groupBox3.Controls.Add(Me.label12)
        Me.groupBox3.Controls.Add(Me.proxyType)
        Me.groupBox3.Controls.Add(Me.proxyPortNum)
        Me.groupBox3.Controls.Add(Me.label8)
        Me.groupBox3.Controls.Add(Me.label9)
        Me.groupBox3.Controls.Add(Me.proxyHostBox)
        Me.groupBox3.Controls.Add(Me.label10)
        Me.groupBox3.Controls.Add(Me.proxyUserBox)
        Me.groupBox3.Controls.Add(Me.label11)
        Me.groupBox3.Controls.Add(Me.proxyPasswordBox)
        Me.groupBox3.Location = New System.Drawing.Point(12, 147)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(147, 158)
        Me.groupBox3.TabIndex = 6
        Me.groupBox3.TabStop = False
        Me.groupBox3.Text = "Proxy Settings"
        ' 
        ' label12
        ' 
        Me.label12.AutoSize = True
        Me.label12.Location = New System.Drawing.Point(6, 127)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(34, 13)
        Me.label12.TabIndex = 35
        Me.label12.Text = "Type:"
        ' 
        ' proxyType
        ' 
        Me.proxyType.FormattingEnabled = True
        Me.proxyType.Location = New System.Drawing.Point(68, 124)
        Me.proxyType.Name = "proxyType"
        Me.proxyType.Size = New System.Drawing.Size(73, 21)
        Me.proxyType.TabIndex = 34
        ' 
        ' proxyPortNum
        ' 
        Me.proxyPortNum.Location = New System.Drawing.Point(68, 45)
        Me.proxyPortNum.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.proxyPortNum.Name = "proxyPortNum"
        Me.proxyPortNum.Size = New System.Drawing.Size(73, 20)
        Me.proxyPortNum.TabIndex = 1
        Me.proxyPortNum.Value = New Decimal(New Integer() {25, 0, 0, 0})
        ' 
        ' label8
        ' 
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(6, 22)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(32, 13)
        Me.label8.TabIndex = 30
        Me.label8.Text = "Host:"
        ' 
        ' label9
        ' 
        Me.label9.AutoSize = True
        Me.label9.Location = New System.Drawing.Point(6, 101)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(56, 13)
        Me.label9.TabIndex = 33
        Me.label9.Text = "Password:"
        ' 
        ' proxyHostBox
        ' 
        Me.proxyHostBox.Location = New System.Drawing.Point(68, 19)
        Me.proxyHostBox.Name = "proxyHostBox"
        Me.proxyHostBox.Size = New System.Drawing.Size(73, 20)
        Me.proxyHostBox.TabIndex = 0
        Me.proxyHostBox.Text = "smtp.someserver.com"
        ' 
        ' label10
        ' 
        Me.label10.AutoSize = True
        Me.label10.Location = New System.Drawing.Point(6, 75)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(36, 13)
        Me.label10.TabIndex = 32
        Me.label10.Text = "Login:"
        ' 
        ' proxyUserBox
        ' 
        Me.proxyUserBox.Location = New System.Drawing.Point(68, 72)
        Me.proxyUserBox.Name = "proxyUserBox"
        Me.proxyUserBox.Size = New System.Drawing.Size(73, 20)
        Me.proxyUserBox.TabIndex = 2
        Me.proxyUserBox.Text = "test_mailnet"
        ' 
        ' label11
        ' 
        Me.label11.AutoSize = True
        Me.label11.Location = New System.Drawing.Point(6, 47)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(29, 13)
        Me.label11.TabIndex = 31
        Me.label11.Text = "Port:"
        ' 
        ' proxyPasswordBox
        ' 
        Me.proxyPasswordBox.Location = New System.Drawing.Point(68, 98)
        Me.proxyPasswordBox.Name = "proxyPasswordBox"
        Me.proxyPasswordBox.Size = New System.Drawing.Size(73, 20)
        Me.proxyPasswordBox.TabIndex = 3
        Me.proxyPasswordBox.Text = ""
        ' 
        ' target
        ' 
        Me.target.AuthenticationType = Email.Net.Common.Configurations.EAuthenticationType.Auto
        Me.target.Host = "localhost"
        Me.target.Password = ""
        Me.target.Port = CUShort(25)
        Me.target.ProxyHost = ""
        Me.target.ProxyPassword = ""
        Me.target.ProxyPort = CUShort(0)
        Me.target.ProxyType = Email.Net.Common.Configurations.EProxyType.No
        Me.target.ProxyUser = ""
        Me.target.ReceiveTimeOut = 10000
        Me.target.SendTimeOut = 10000
        Me.target.SSLInteractionType = Email.Net.Common.Configurations.EInteractionType.Plain
        Me.target.Username = ""
        ' 
        ' Form1
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 310)
        Me.Controls.Add(Me.groupBox3)
        Me.Controls.Add(Me.sendMessage)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.groupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Email.NET Send with Proxy Demo"
        DirectCast(Me.portNum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.groupBox3.ResumeLayout(False)
        Me.groupBox3.PerformLayout()
        DirectCast(Me.proxyPortNum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

	Private toBox As System.Windows.Forms.TextBox
	Private portNum As System.Windows.Forms.NumericUpDown
	Private label1 As System.Windows.Forms.Label
	Private subjectBox As System.Windows.Forms.TextBox
	Private label4 As System.Windows.Forms.Label
	Private hostBox As System.Windows.Forms.TextBox
	Private fromBox As System.Windows.Forms.TextBox
	Private label3 As System.Windows.Forms.Label
	Private messageBox As System.Windows.Forms.TextBox
	Private loginBox As System.Windows.Forms.TextBox
	Private label5 As System.Windows.Forms.Label
	Private label2 As System.Windows.Forms.Label
	Private sendMessage As System.Windows.Forms.Button
	Private label6 As System.Windows.Forms.Label
	Private passwordBox As System.Windows.Forms.TextBox
	Private groupBox2 As System.Windows.Forms.GroupBox
	Private label7 As System.Windows.Forms.Label
	Private groupBox1 As System.Windows.Forms.GroupBox
	Private groupBox3 As System.Windows.Forms.GroupBox
	Private label12 As System.Windows.Forms.Label
	Private proxyType As System.Windows.Forms.ComboBox
	Private proxyPortNum As System.Windows.Forms.NumericUpDown
	Private label8 As System.Windows.Forms.Label
	Private label9 As System.Windows.Forms.Label
	Private proxyHostBox As System.Windows.Forms.TextBox
	Private label10 As System.Windows.Forms.Label
	Private proxyUserBox As System.Windows.Forms.TextBox
	Private label11 As System.Windows.Forms.Label
	Private proxyPasswordBox As System.Windows.Forms.TextBox
	Private target As Email.NET.Smtp.SmtpClient
End Class

