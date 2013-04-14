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
        Me.client = New Email.Net.Imap.ImapClient(Me.components)
        Me.portNum = New System.Windows.Forms.NumericUpDown()
        Me.label5 = New System.Windows.Forms.Label()
        Me.passwordBox = New System.Windows.Forms.TextBox()
        Me.loginBox = New System.Windows.Forms.TextBox()
        Me.hostBox = New System.Windows.Forms.TextBox()
        Me.loginButton = New System.Windows.Forms.Button()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.interactionCombo = New System.Windows.Forms.ComboBox()
        Me.messageList = New System.Windows.Forms.ListBox()
        Me.logoutButton = New System.Windows.Forms.Button()
        Me.messageTextBox = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.attachmentBox = New System.Windows.Forms.ComboBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.receiveAttachment = New System.Windows.Forms.Button()
        DirectCast(Me.portNum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' client
        ' 
        Me.client.Host = "localhost"
        Me.client.Password = Nothing
        Me.client.Port = CUShort(25)
        Me.client.ProxyPort = CUShort(0)
        Me.client.ProxyType = Email.Net.Common.Configurations.EProxyType.No
        Me.client.ReceiveTimeout = 10000
        Me.client.SendTimeout = 10000
        Me.client.SSLInteractionType = Email.Net.Common.Configurations.EInteractionType.Plain
        Me.client.Username = Nothing
        ' 
        ' portNum
        ' 
        Me.portNum.Location = New System.Drawing.Point(120, 40)
        Me.portNum.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.portNum.Name = "portNum"
        Me.portNum.Size = New System.Drawing.Size(150, 20)
        Me.portNum.TabIndex = 3
        Me.portNum.Value = New Decimal(New Integer() {993, 0, 0, 0})
        ' 
        ' label5
        ' 
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(12, 127)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(83, 13)
        Me.label5.TabIndex = 54
        Me.label5.Text = "Interaction type:"
        ' 
        ' passwordBox
        ' 
        Me.passwordBox.Location = New System.Drawing.Point(120, 92)
        Me.passwordBox.Name = "passwordBox"
        Me.passwordBox.Size = New System.Drawing.Size(150, 20)
        Me.passwordBox.TabIndex = 5
        Me.passwordBox.Text = ""
        ' 
        ' loginBox
        ' 
        Me.loginBox.Location = New System.Drawing.Point(120, 66)
        Me.loginBox.Name = "loginBox"
        Me.loginBox.Size = New System.Drawing.Size(150, 20)
        Me.loginBox.TabIndex = 4
        Me.loginBox.Text = "mail@someserver.com"
        ' 
        ' hostBox
        ' 
        Me.hostBox.Location = New System.Drawing.Point(120, 14)
        Me.hostBox.Name = "hostBox"
        Me.hostBox.Size = New System.Drawing.Size(150, 20)
        Me.hostBox.TabIndex = 2
        Me.hostBox.Text = "imap.someserver.com"
        ' 
        ' loginButton
        ' 
        Me.loginButton.Location = New System.Drawing.Point(281, 221)
        Me.loginButton.Name = "loginButton"
        Me.loginButton.Size = New System.Drawing.Size(75, 23)
        Me.loginButton.TabIndex = 0
        Me.loginButton.Text = "Start"
        Me.loginButton.UseVisualStyleBackColor = True
        AddHandler Me.loginButton.Click, New System.EventHandler(AddressOf Me.loginButton_Click)
        ' 
        ' label3
        ' 
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(12, 74)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(36, 13)
        Me.label3.TabIndex = 52
        Me.label3.Text = "Login:"
        ' 
        ' label2
        ' 
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(12, 48)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(29, 13)
        Me.label2.TabIndex = 51
        Me.label2.Text = "Port:"
        ' 
        ' label4
        ' 
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(12, 100)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(56, 13)
        Me.label4.TabIndex = 53
        Me.label4.Text = "Password:"
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(12, 21)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(32, 13)
        Me.label1.TabIndex = 50
        Me.label1.Text = "Host:"
        ' 
        ' interactionCombo
        ' 
        Me.interactionCombo.FormattingEnabled = True
        Me.interactionCombo.Location = New System.Drawing.Point(120, 124)
        Me.interactionCombo.Name = "interactionCombo"
        Me.interactionCombo.Size = New System.Drawing.Size(150, 21)
        Me.interactionCombo.TabIndex = 6
        ' 
        ' messageList
        ' 
        Me.messageList.HorizontalScrollbar = True
        Me.messageList.Location = New System.Drawing.Point(15, 175)
        Me.messageList.Name = "messageList"
        Me.messageList.Size = New System.Drawing.Size(255, 69)
        Me.messageList.TabIndex = 7
        AddHandler Me.messageList.SelectedIndexChanged, New System.EventHandler(AddressOf Me.messageList_SelectedIndexChanged)
        ' 
        ' logoutButton
        ' 
        Me.logoutButton.Location = New System.Drawing.Point(443, 221)
        Me.logoutButton.Name = "logoutButton"
        Me.logoutButton.Size = New System.Drawing.Size(75, 23)
        Me.logoutButton.TabIndex = 1
        Me.logoutButton.Text = "Finish"
        Me.logoutButton.UseVisualStyleBackColor = True
        AddHandler Me.logoutButton.Click, New System.EventHandler(AddressOf Me.logoutButton_Click)
        ' 
        ' messageTextBox
        ' 
        Me.messageTextBox.Location = New System.Drawing.Point(286, 39)
        Me.messageTextBox.Multiline = True
        Me.messageTextBox.Name = "messageTextBox"
        Me.messageTextBox.Size = New System.Drawing.Size(233, 128)
        Me.messageTextBox.TabIndex = 8
        ' 
        ' label6
        ' 
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(283, 17)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(73, 13)
        Me.label6.TabIndex = 58
        Me.label6.Text = "Message text:"
        ' 
        ' label7
        ' 
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(13, 154)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(58, 13)
        Me.label7.TabIndex = 59
        Me.label7.Text = "Messages:"
        ' 
        ' attachmentBox
        ' 
        Me.attachmentBox.FormattingEnabled = True
        Me.attachmentBox.Location = New System.Drawing.Point(362, 175)
        Me.attachmentBox.Name = "attachmentBox"
        Me.attachmentBox.Size = New System.Drawing.Size(156, 21)
        Me.attachmentBox.TabIndex = 8
        ' 
        ' label8
        ' 
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(283, 178)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(69, 13)
        Me.label8.TabIndex = 61
        Me.label8.Text = "Attachments:"
        ' 
        ' receiveAttachment
        ' 
        Me.receiveAttachment.Location = New System.Drawing.Point(362, 221)
        Me.receiveAttachment.Name = "receiveAttachment"
        Me.receiveAttachment.Size = New System.Drawing.Size(75, 23)
        Me.receiveAttachment.TabIndex = 62
        Me.receiveAttachment.Text = "Receive"
        Me.receiveAttachment.UseVisualStyleBackColor = True
        AddHandler Me.receiveAttachment.Click, New System.EventHandler(AddressOf Me.receiveAttachment_Click)
        ' 
        ' Demo
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 253)
        Me.Controls.Add(Me.receiveAttachment)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.attachmentBox)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.messageTextBox)
        Me.Controls.Add(Me.logoutButton)
        Me.Controls.Add(Me.messageList)
        Me.Controls.Add(Me.portNum)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.passwordBox)
        Me.Controls.Add(Me.loginBox)
        Me.Controls.Add(Me.hostBox)
        Me.Controls.Add(Me.loginButton)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.interactionCombo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Demo"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Email.NET Get Attachment and Message Text Demo"
        DirectCast(Me.portNum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private client As Email.Net.Imap.ImapClient
	Private portNum As System.Windows.Forms.NumericUpDown
	Private label5 As System.Windows.Forms.Label
	Private passwordBox As System.Windows.Forms.TextBox
	Private loginBox As System.Windows.Forms.TextBox
	Private hostBox As System.Windows.Forms.TextBox
	Private loginButton As System.Windows.Forms.Button
	Private label3 As System.Windows.Forms.Label
	Private label2 As System.Windows.Forms.Label
	Private label4 As System.Windows.Forms.Label
	Private label1 As System.Windows.Forms.Label
	Private interactionCombo As System.Windows.Forms.ComboBox
	Private messageList As System.Windows.Forms.ListBox
	Private logoutButton As System.Windows.Forms.Button
	Private messageTextBox As System.Windows.Forms.TextBox
	Private label6 As System.Windows.Forms.Label
	Private label7 As System.Windows.Forms.Label
	Private attachmentBox As System.Windows.Forms.ComboBox
	Private label8 As System.Windows.Forms.Label
	Private receiveAttachment As System.Windows.Forms.Button
End Class

