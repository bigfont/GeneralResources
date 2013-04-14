Namespace getSubscribedFolderTreeDemo
	Partial Class Form1
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
            Me.portNum = New System.Windows.Forms.NumericUpDown()
            Me.label5 = New System.Windows.Forms.Label()
            Me.passwordBox = New System.Windows.Forms.TextBox()
            Me.loginBox = New System.Windows.Forms.TextBox()
            Me.hostBox = New System.Windows.Forms.TextBox()
            Me.startAuthorization = New System.Windows.Forms.Button()
            Me.butClose = New System.Windows.Forms.Button()
            Me.label3 = New System.Windows.Forms.Label()
            Me.label2 = New System.Windows.Forms.Label()
            Me.client = New Email.Net.Imap.ImapClient(Me.components)
            Me.label4 = New System.Windows.Forms.Label()
            Me.label1 = New System.Windows.Forms.Label()
            Me.interactionCombo = New System.Windows.Forms.ComboBox()
            DirectCast(Me.portNum, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' portNum
            ' 
            Me.portNum.Location = New System.Drawing.Point(126, 47)
            Me.portNum.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
            Me.portNum.Name = "portNum"
            Me.portNum.Size = New System.Drawing.Size(150, 20)
            Me.portNum.TabIndex = 3
            Me.portNum.Value = New Decimal(New Integer() {993, 0, 0, 0})
            ' 
            ' label5
            ' 
            Me.label5.AutoSize = True
            Me.label5.Location = New System.Drawing.Point(18, 134)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(83, 13)
            Me.label5.TabIndex = 38
            Me.label5.Text = "Interaction type:"
            ' 
            ' passwordBox
            ' 
            Me.passwordBox.Location = New System.Drawing.Point(126, 99)
            Me.passwordBox.Name = "passwordBox"
            Me.passwordBox.Size = New System.Drawing.Size(150, 20)
            Me.passwordBox.TabIndex = 5
            Me.passwordBox.Text = ""
            ' 
            ' loginBox
            ' 
            Me.loginBox.Location = New System.Drawing.Point(126, 73)
            Me.loginBox.Name = "loginBox"
            Me.loginBox.Size = New System.Drawing.Size(150, 20)
            Me.loginBox.TabIndex = 4
            Me.loginBox.Text = "mail@someserver.com"
            ' 
            ' hostBox
            ' 
            Me.hostBox.Location = New System.Drawing.Point(126, 21)
            Me.hostBox.Name = "hostBox"
            Me.hostBox.Size = New System.Drawing.Size(150, 20)
            Me.hostBox.TabIndex = 2
            Me.hostBox.Text = "imap.someserver.com"
            ' 
            ' startAuthorization
            ' 
            Me.startAuthorization.Location = New System.Drawing.Point(69, 182)
            Me.startAuthorization.Name = "startAuthorization"
            Me.startAuthorization.Size = New System.Drawing.Size(75, 23)
            Me.startAuthorization.TabIndex = 0
            Me.startAuthorization.Text = "Start"
            Me.startAuthorization.UseVisualStyleBackColor = True
            AddHandler Me.startAuthorization.Click, New System.EventHandler(AddressOf Me.startAuthorization_Click)
            ' 
            ' close
            ' 
            Me.butClose.Location = New System.Drawing.Point(150, 182)
            Me.butClose.Name = "close"
            Me.butClose.Size = New System.Drawing.Size(75, 23)
            Me.butClose.TabIndex = 1
            Me.butClose.Text = "Finish"
            Me.butClose.UseVisualStyleBackColor = True
            AddHandler Me.butClose.Click, New System.EventHandler(AddressOf Me.close_Click)
            ' 
            ' label3
            ' 
            Me.label3.AutoSize = True
            Me.label3.Location = New System.Drawing.Point(18, 81)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(36, 13)
            Me.label3.TabIndex = 36
            Me.label3.Text = "Login:"
            ' 
            ' label2
            ' 
            Me.label2.AutoSize = True
            Me.label2.Location = New System.Drawing.Point(18, 55)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(29, 13)
            Me.label2.TabIndex = 35
            Me.label2.Text = "Port:"
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
            ' label4
            ' 
            Me.label4.AutoSize = True
            Me.label4.Location = New System.Drawing.Point(18, 107)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(56, 13)
            Me.label4.TabIndex = 37
            Me.label4.Text = "Password:"
            ' 
            ' label1
            ' 
            Me.label1.AutoSize = True
            Me.label1.Location = New System.Drawing.Point(18, 28)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(32, 13)
            Me.label1.TabIndex = 34
            Me.label1.Text = "Host:"
            ' 
            ' interactionCombo
            ' 
            Me.interactionCombo.FormattingEnabled = True
            Me.interactionCombo.Items.AddRange(New Object() {"Plain", "SSLPort", "StartTLs"})
            Me.interactionCombo.Location = New System.Drawing.Point(126, 131)
            Me.interactionCombo.Name = "interactionCombo"
            Me.interactionCombo.Size = New System.Drawing.Size(150, 21)
            Me.interactionCombo.TabIndex = 6
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(295, 226)
            Me.Controls.Add(Me.portNum)
            Me.Controls.Add(Me.label5)
            Me.Controls.Add(Me.passwordBox)
            Me.Controls.Add(Me.loginBox)
            Me.Controls.Add(Me.hostBox)
            Me.Controls.Add(Me.startAuthorization)
            Me.Controls.Add(Me.butClose)
            Me.Controls.Add(Me.label3)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.label4)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.interactionCombo)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "Form1"
            Me.ShowIcon = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Email.NET Get Subscribed Mailbox Tree Demo"
            DirectCast(Me.portNum, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private portNum As System.Windows.Forms.NumericUpDown
        Private label5 As System.Windows.Forms.Label
        Private passwordBox As System.Windows.Forms.TextBox
        Private loginBox As System.Windows.Forms.TextBox
        Private hostBox As System.Windows.Forms.TextBox
        Private startAuthorization As System.Windows.Forms.Button
        Private butClose As System.Windows.Forms.Button
		Private label3 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
        Private client As Email.Net.Imap.ImapClient
		Private label4 As System.Windows.Forms.Label
		Private label1 As System.Windows.Forms.Label
		Private interactionCombo As System.Windows.Forms.ComboBox
	End Class
End Namespace

