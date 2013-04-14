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
        Me.getMessage = New System.Windows.Forms.Button()
        Me.portNum = New System.Windows.Forms.NumericUpDown()
        Me.label5 = New System.Windows.Forms.Label()
        Me.passwordBox = New System.Windows.Forms.TextBox()
        Me.loginBox = New System.Windows.Forms.TextBox()
        Me.hostBox = New System.Windows.Forms.TextBox()
        Me.startButton = New System.Windows.Forms.Button()
        Me.finishButton = New System.Windows.Forms.Button()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.interactionCombo = New System.Windows.Forms.ComboBox()
        Me.client = New Email.Net.Imap.ImapClient(Me.components)
        Me.messageList = New System.Windows.Forms.ListBox()
        Me.messageTextBox = New System.Windows.Forms.TextBox()
        DirectCast(Me.portNum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' getMessage
        ' 
        Me.getMessage.Location = New System.Drawing.Point(105, 159)
        Me.getMessage.Name = "getMessage"
        Me.getMessage.Size = New System.Drawing.Size(75, 23)
        Me.getMessage.TabIndex = 41
        Me.getMessage.Text = "Get"
        Me.getMessage.UseVisualStyleBackColor = True
        AddHandler Me.getMessage.Click, New System.EventHandler(AddressOf Me.getMessage_Click)
        ' 
        ' portNum
        ' 
        Me.portNum.Location = New System.Drawing.Point(120, 38)
        Me.portNum.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.portNum.Name = "portNum"
        Me.portNum.Size = New System.Drawing.Size(150, 20)
        Me.portNum.TabIndex = 43
        Me.portNum.Value = New Decimal(New Integer() {993, 0, 0, 0})
        ' 
        ' label5
        ' 
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(12, 125)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(83, 13)
        Me.label5.TabIndex = 52
        Me.label5.Text = "Interaction type:"
        ' 
        ' passwordBox
        ' 
        Me.passwordBox.Location = New System.Drawing.Point(120, 90)
        Me.passwordBox.Name = "passwordBox"
        Me.passwordBox.Size = New System.Drawing.Size(150, 20)
        Me.passwordBox.TabIndex = 45
        Me.passwordBox.Text = ""
        ' 
        ' loginBox
        ' 
        Me.loginBox.Location = New System.Drawing.Point(120, 64)
        Me.loginBox.Name = "loginBox"
        Me.loginBox.Size = New System.Drawing.Size(150, 20)
        Me.loginBox.TabIndex = 44
        Me.loginBox.Text = "mail@someserver.com"
        ' 
        ' hostBox
        ' 
        Me.hostBox.Location = New System.Drawing.Point(120, 12)
        Me.hostBox.Name = "hostBox"
        Me.hostBox.Size = New System.Drawing.Size(150, 20)
        Me.hostBox.TabIndex = 42
        Me.hostBox.Text = "imap.someserver.com"
        ' 
        ' startButton
        ' 
        Me.startButton.Location = New System.Drawing.Point(13, 159)
        Me.startButton.Name = "startButton"
        Me.startButton.Size = New System.Drawing.Size(75, 23)
        Me.startButton.TabIndex = 39
        Me.startButton.Text = "Start"
        Me.startButton.UseVisualStyleBackColor = True
        AddHandler Me.startButton.Click, New System.EventHandler(AddressOf Me.startButton_Click)
        ' 
        ' finishButton
        ' 
        Me.finishButton.Location = New System.Drawing.Point(195, 159)
        Me.finishButton.Name = "finishButton"
        Me.finishButton.Size = New System.Drawing.Size(75, 23)
        Me.finishButton.TabIndex = 40
        Me.finishButton.Text = "Finish"
        Me.finishButton.UseVisualStyleBackColor = True
        AddHandler Me.finishButton.Click, New System.EventHandler(AddressOf Me.finishButton_Click)
        ' 
        ' label3
        ' 
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(12, 72)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(36, 13)
        Me.label3.TabIndex = 50
        Me.label3.Text = "Login:"
        ' 
        ' label2
        ' 
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(12, 46)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(29, 13)
        Me.label2.TabIndex = 49
        Me.label2.Text = "Port:"
        ' 
        ' label4
        ' 
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(12, 98)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(56, 13)
        Me.label4.TabIndex = 51
        Me.label4.Text = "Password:"
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(12, 19)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(32, 13)
        Me.label1.TabIndex = 48
        Me.label1.Text = "Host:"
        ' 
        ' interactionCombo
        ' 
        Me.interactionCombo.FormattingEnabled = True
        Me.interactionCombo.Location = New System.Drawing.Point(120, 122)
        Me.interactionCombo.Name = "interactionCombo"
        Me.interactionCombo.Size = New System.Drawing.Size(150, 21)
        Me.interactionCombo.TabIndex = 46
        ' 
        ' client
        ' 
        Me.client.Host = "localhost"
        Me.client.Password = "Password"
        Me.client.Port = CUShort(25)
        Me.client.ProxyPort = CUShort(0)
        Me.client.ProxyType = Email.Net.Common.Configurations.EProxyType.No
        Me.client.ReceiveTimeout = 10000
        Me.client.SendTimeout = 10000
        Me.client.SSLInteractionType = Email.Net.Common.Configurations.EInteractionType.Plain
        Me.client.Username = "Login"
        ' 
        ' messageList
        ' 
        Me.messageList.HorizontalScrollbar = True
        Me.messageList.Location = New System.Drawing.Point(276, 9)
        Me.messageList.Name = "messageList"
        Me.messageList.Size = New System.Drawing.Size(212, 173)
        Me.messageList.TabIndex = 53
        ' 
        ' messageTextBox
        ' 
        Me.messageTextBox.Location = New System.Drawing.Point(494, 9)
        Me.messageTextBox.Multiline = True
        Me.messageTextBox.Name = "messageTextBox"
        Me.messageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.messageTextBox.Size = New System.Drawing.Size(187, 168)
        Me.messageTextBox.TabIndex = 54
        ' 
        ' Demo
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(693, 189)
        Me.Controls.Add(Me.messageTextBox)
        Me.Controls.Add(Me.messageList)
        Me.Controls.Add(Me.getMessage)
        Me.Controls.Add(Me.portNum)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.passwordBox)
        Me.Controls.Add(Me.loginBox)
        Me.Controls.Add(Me.hostBox)
        Me.Controls.Add(Me.startButton)
        Me.Controls.Add(Me.finishButton)
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
        Me.Text = "Email.NET Asynchronous Demo"
        DirectCast(Me.portNum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

	Private getMessage As System.Windows.Forms.Button
	Private portNum As System.Windows.Forms.NumericUpDown
	Private label5 As System.Windows.Forms.Label
	Private passwordBox As System.Windows.Forms.TextBox
	Private loginBox As System.Windows.Forms.TextBox
	Private hostBox As System.Windows.Forms.TextBox
	Private startButton As System.Windows.Forms.Button
	Private finishButton As System.Windows.Forms.Button
	Private label3 As System.Windows.Forms.Label
	Private label2 As System.Windows.Forms.Label
	Private label4 As System.Windows.Forms.Label
	Private label1 As System.Windows.Forms.Label
	Private interactionCombo As System.Windows.Forms.ComboBox
    Private client As Email.Net.Imap.ImapClient
	Private messageList As System.Windows.Forms.ListBox
	Private messageTextBox As System.Windows.Forms.TextBox
End Class

