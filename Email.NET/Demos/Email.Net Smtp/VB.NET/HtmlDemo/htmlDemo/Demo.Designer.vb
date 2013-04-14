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
        Me.label7 = New System.Windows.Forms.Label()
        Me.sendMessage = New System.Windows.Forms.Button()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.subjectBox = New System.Windows.Forms.TextBox()
        Me.toBox = New System.Windows.Forms.TextBox()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.fromBox = New System.Windows.Forms.TextBox()
        Me.messageBox = New System.Windows.Forms.TextBox()
        Me.portNum = New System.Windows.Forms.NumericUpDown()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.hostBox = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.loginBox = New System.Windows.Forms.TextBox()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.passwordBox = New System.Windows.Forms.TextBox()
        Me.target = New Email.Net.Smtp.SmtpClient(Me.components)
        Me.plainBox = New System.Windows.Forms.TextBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.groupBox2.SuspendLayout()
        DirectCast(Me.portNum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        ' sendMessage
        ' 
        Me.sendMessage.Location = New System.Drawing.Point(41, 231)
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
        ' label5
        ' 
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(9, 26)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(33, 13)
        Me.label5.TabIndex = 4
        Me.label5.Text = "From:"
        ' 
        ' subjectBox
        ' 
        Me.subjectBox.Location = New System.Drawing.Point(64, 79)
        Me.subjectBox.Name = "subjectBox"
        Me.subjectBox.Size = New System.Drawing.Size(184, 20)
        Me.subjectBox.TabIndex = 2
        Me.subjectBox.Text = "Test message Subject"
        ' 
        ' toBox
        ' 
        Me.toBox.Location = New System.Drawing.Point(96, 50)
        Me.toBox.Name = "toBox"
        Me.toBox.Size = New System.Drawing.Size(152, 20)
        Me.toBox.TabIndex = 1
        Me.toBox.Text = "mailnet.tester@gmail.com"
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
        Me.groupBox2.Size = New System.Drawing.Size(254, 242)
        Me.groupBox2.TabIndex = 5
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Message"
        ' 
        ' fromBox
        ' 
        Me.fromBox.Location = New System.Drawing.Point(96, 19)
        Me.fromBox.Name = "fromBox"
        Me.fromBox.Size = New System.Drawing.Size(152, 20)
        Me.fromBox.TabIndex = 0
        Me.fromBox.Text = "mail@someserver.com"
        ' 
        ' messageBox
        ' 
        Me.messageBox.Location = New System.Drawing.Point(6, 108)
        Me.messageBox.Multiline = True
        Me.messageBox.Name = "messageBox"
        Me.messageBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.messageBox.Size = New System.Drawing.Size(242, 128)
        Me.messageBox.TabIndex = 3
        Me.messageBox.Text = "This demo is shows how to create and send message." & vbCr & vbLf & "Insert your message text here" & "."
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
        Me.label1.Location = New System.Drawing.Point(6, 26)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(32, 13)
        Me.label1.TabIndex = 30
        Me.label1.Text = "Host:"
        ' 
        ' label4
        ' 
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(6, 105)
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
        ' label3
        ' 
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(6, 79)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(36, 13)
        Me.label3.TabIndex = 32
        Me.label3.Text = "Login:"
        ' 
        ' loginBox
        ' 
        Me.loginBox.Location = New System.Drawing.Point(68, 72)
        Me.loginBox.Name = "loginBox"
        Me.loginBox.Size = New System.Drawing.Size(73, 20)
        Me.loginBox.TabIndex = 2
        Me.loginBox.Text = "test_mailnet"
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
        ' label2
        ' 
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(6, 53)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(29, 13)
        Me.label2.TabIndex = 31
        Me.label2.Text = "Port:"
        ' 
        ' passwordBox
        ' 
        Me.passwordBox.Location = New System.Drawing.Point(68, 98)
        Me.passwordBox.Name = "passwordBox"
        Me.passwordBox.Size = New System.Drawing.Size(73, 20)
        Me.passwordBox.TabIndex = 3
        Me.passwordBox.Text = ""
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
        ' plainBox
        ' 
        Me.plainBox.Location = New System.Drawing.Point(21, 164)
        Me.plainBox.Multiline = True
        Me.plainBox.Name = "plainBox"
        Me.plainBox.Size = New System.Drawing.Size(132, 62)
        Me.plainBox.TabIndex = 6
        Me.plainBox.Text = "Insert message plain text here."
        ' 
        ' label8
        ' 
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(12, 148)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(100, 13)
        Me.label8.TabIndex = 7
        Me.label8.Text = "Message PlainText:"
        ' 
        ' Demo
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 259)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.plainBox)
        Me.Controls.Add(Me.sendMessage)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.groupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Demo"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Email.NET HTML message Demo"
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        DirectCast(Me.portNum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

	Private label7 As System.Windows.Forms.Label
	Private sendMessage As System.Windows.Forms.Button
	Private label6 As System.Windows.Forms.Label
	Private label5 As System.Windows.Forms.Label
	Private subjectBox As System.Windows.Forms.TextBox
	Private toBox As System.Windows.Forms.TextBox
	Private groupBox2 As System.Windows.Forms.GroupBox
	Private fromBox As System.Windows.Forms.TextBox
	Private messageBox As System.Windows.Forms.TextBox
	Private portNum As System.Windows.Forms.NumericUpDown
	Private label1 As System.Windows.Forms.Label
	Private label4 As System.Windows.Forms.Label
	Private hostBox As System.Windows.Forms.TextBox
	Private label3 As System.Windows.Forms.Label
	Private loginBox As System.Windows.Forms.TextBox
	Private groupBox1 As System.Windows.Forms.GroupBox
	Private label2 As System.Windows.Forms.Label
	Private passwordBox As System.Windows.Forms.TextBox
	Private target As Email.NET.Smtp.SmtpClient
	Private plainBox As System.Windows.Forms.TextBox
	Private label8 As System.Windows.Forms.Label
End Class

