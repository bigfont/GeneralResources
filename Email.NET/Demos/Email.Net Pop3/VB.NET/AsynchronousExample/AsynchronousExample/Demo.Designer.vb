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
        Me.label5 = New System.Windows.Forms.Label()
        Me.messageTextBox = New System.Windows.Forms.TextBox()
        Me.portNum = New System.Windows.Forms.NumericUpDown()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.passwordBox = New System.Windows.Forms.TextBox()
        Me.loginBox = New System.Windows.Forms.TextBox()
        Me.hostBox = New System.Windows.Forms.TextBox()
        Me.getAllButton = New System.Windows.Forms.Button()
        Me.closeButton = New System.Windows.Forms.Button()
        Me.getOneButton = New System.Windows.Forms.Button()
        Me.label6 = New System.Windows.Forms.Label()
        Me.messageNumber = New System.Windows.Forms.NumericUpDown()
        Me.target = New Email.Net.Pop3.Pop3Client(Me.components)
        DirectCast(Me.portNum, System.ComponentModel.ISupportInitialize).BeginInit()
        DirectCast(Me.messageNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' label5
        ' 
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(204))
        Me.label5.Location = New System.Drawing.Point(84, 9)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(434, 14)
        Me.label5.TabIndex = 52
        Me.label5.Text = "This example shows how to asynchronously get messages from the mailBox"
        ' 
        ' messageTextBox
        ' 
        Me.messageTextBox.Location = New System.Drawing.Point(283, 42)
        Me.messageTextBox.Multiline = True
        Me.messageTextBox.Name = "messageTextBox"
        Me.messageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.messageTextBox.Size = New System.Drawing.Size(353, 122)
        Me.messageTextBox.TabIndex = 51
        ' 
        ' portNum
        ' 
        Me.portNum.Location = New System.Drawing.Point(116, 79)
        Me.portNum.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.portNum.Name = "portNum"
        Me.portNum.Size = New System.Drawing.Size(150, 20)
        Me.portNum.TabIndex = 43
        Me.portNum.Value = New Decimal(New Integer() {110, 0, 0, 0})
        ' 
        ' label4
        ' 
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(8, 139)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(56, 13)
        Me.label4.TabIndex = 50
        Me.label4.Text = "Password:"
        ' 
        ' label3
        ' 
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(8, 113)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(36, 13)
        Me.label3.TabIndex = 49
        Me.label3.Text = "Login:"
        ' 
        ' label2
        ' 
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(8, 87)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(29, 13)
        Me.label2.TabIndex = 48
        Me.label2.Text = "Port:"
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(8, 60)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(32, 13)
        Me.label1.TabIndex = 47
        Me.label1.Text = "Host:"
        ' 
        ' passwordBox
        ' 
        Me.passwordBox.Location = New System.Drawing.Point(116, 131)
        Me.passwordBox.Name = "passwordBox"
        Me.passwordBox.Size = New System.Drawing.Size(150, 20)
        Me.passwordBox.TabIndex = 45
        Me.passwordBox.Text = ""
        ' 
        ' loginBox
        ' 
        Me.loginBox.Location = New System.Drawing.Point(116, 105)
        Me.loginBox.Name = "loginBox"
        Me.loginBox.Size = New System.Drawing.Size(150, 20)
        Me.loginBox.TabIndex = 44
        Me.loginBox.Text = "mail@someserver.com"
        ' 
        ' hostBox
        ' 
        Me.hostBox.Location = New System.Drawing.Point(116, 53)
        Me.hostBox.Name = "hostBox"
        Me.hostBox.Size = New System.Drawing.Size(150, 20)
        Me.hostBox.TabIndex = 42
        Me.hostBox.Text = "pop.someserver.com"
        ' 
        ' getAllButton
        ' 
        Me.getAllButton.Location = New System.Drawing.Point(396, 170)
        Me.getAllButton.Name = "getAllButton"
        Me.getAllButton.Size = New System.Drawing.Size(75, 23)
        Me.getAllButton.TabIndex = 40
        Me.getAllButton.Text = "Get All"
        Me.getAllButton.UseVisualStyleBackColor = True
        AddHandler Me.getAllButton.Click, New System.EventHandler(AddressOf Me.getAllButton_Click)
        ' 
        ' close
        ' 
        Me.closeButton.Location = New System.Drawing.Point(558, 170)
        Me.closeButton.Name = "close"
        Me.closeButton.Size = New System.Drawing.Size(75, 23)
        Me.closeButton.TabIndex = 41
        Me.closeButton.Text = "Finish"
        Me.closeButton.UseVisualStyleBackColor = True
        AddHandler Me.closeButton.Click, New System.EventHandler(AddressOf Me.closeButton_Click)
        ' 
        ' getOneButton
        ' 
        Me.getOneButton.Location = New System.Drawing.Point(477, 170)
        Me.getOneButton.Name = "getOneButton"
        Me.getOneButton.Size = New System.Drawing.Size(75, 23)
        Me.getOneButton.TabIndex = 53
        Me.getOneButton.Text = "Get one"
        Me.getOneButton.UseVisualStyleBackColor = True
        AddHandler Me.getOneButton.Click, New System.EventHandler(AddressOf Me.getOneButton_Click)
        ' 
        ' label6
        ' 
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(8, 170)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(90, 13)
        Me.label6.TabIndex = 55
        Me.label6.Text = "Message Number"
        ' 
        ' messageNumber
        ' 
        Me.messageNumber.Location = New System.Drawing.Point(116, 163)
        Me.messageNumber.Name = "messageNumber"
        Me.messageNumber.Size = New System.Drawing.Size(150, 20)
        Me.messageNumber.TabIndex = 54
        Me.messageNumber.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' target
        ' 
        Me.target.AttachmentDirectory = "."
        Me.target.AuthenticationType = Email.Net.Common.Configurations.EAuthenticationType.Auto
        Me.target.Host = "localhost"
        Me.target.Password = ""
        Me.target.Port = CUShort(25)
        Me.target.ProxyHost = ""
        Me.target.ProxyPassword = ""
        Me.target.ProxyPort = CUShort(0)
        Me.target.ProxyType = Email.Net.Common.Configurations.EProxyType.No
        Me.target.ProxyUser = ""
        Me.target.ReceiveTimeout = 10000
        Me.target.SendTimeout = 10000
        Me.target.SSLInteractionType = Email.Net.Common.Configurations.EInteractionType.Plain
        Me.target.Username = ""
        ' 
        ' Demo
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 203)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.messageNumber)
        Me.Controls.Add(Me.getOneButton)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.messageTextBox)
        Me.Controls.Add(Me.portNum)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.passwordBox)
        Me.Controls.Add(Me.loginBox)
        Me.Controls.Add(Me.hostBox)
        Me.Controls.Add(Me.getAllButton)
        Me.Controls.Add(Me.closeButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Demo"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Email.NET Asynchronous Demo"
        DirectCast(Me.portNum, System.ComponentModel.ISupportInitialize).EndInit()
        DirectCast(Me.messageNumber, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

	Private label5 As System.Windows.Forms.Label
	Private messageTextBox As System.Windows.Forms.TextBox
	Private portNum As System.Windows.Forms.NumericUpDown
	Private label4 As System.Windows.Forms.Label
	Private label3 As System.Windows.Forms.Label
	Private label2 As System.Windows.Forms.Label
	Private label1 As System.Windows.Forms.Label
	Private passwordBox As System.Windows.Forms.TextBox
	Private loginBox As System.Windows.Forms.TextBox
	Private hostBox As System.Windows.Forms.TextBox
	Private getAllButton As System.Windows.Forms.Button
    Private closeButton As System.Windows.Forms.Button
	Private getOneButton As System.Windows.Forms.Button
	Private label6 As System.Windows.Forms.Label
	Private messageNumber As System.Windows.Forms.NumericUpDown
	Private target As Email.NET.POP3.Pop3Client
End Class

