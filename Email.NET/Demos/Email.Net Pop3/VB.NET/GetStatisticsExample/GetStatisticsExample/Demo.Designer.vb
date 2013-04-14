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
		Me.startAuthorization = New System.Windows.Forms.Button()
        Me.closeButton = New System.Windows.Forms.Button()
        Me.target = New Email.NET.POP3.Pop3Client(Me.components)
		DirectCast(Me.portNum, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		' 
		' label5
		' 
		Me.label5.AutoSize = True
		Me.label5.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(204))
		Me.label5.Location = New System.Drawing.Point(103, 9)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(332, 14)
		Me.label5.TabIndex = 52
		Me.label5.Text = "This example shows how to get statistics from the server."
		Me.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
		' 
		' messageTextBox
		' 
		Me.messageTextBox.Location = New System.Drawing.Point(283, 31)
		Me.messageTextBox.Multiline = True
		Me.messageTextBox.Name = "messageTextBox"
		Me.messageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.messageTextBox.Size = New System.Drawing.Size(236, 138)
		Me.messageTextBox.TabIndex = 51
		' 
		' portNum
		' 
		Me.portNum.Location = New System.Drawing.Point(116, 68)
		Me.portNum.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
		Me.portNum.Name = "portNum"
		Me.portNum.Size = New System.Drawing.Size(150, 20)
		Me.portNum.TabIndex = 43
		Me.portNum.Value = New Decimal(New Integer() {110, 0, 0, 0})
		' 
		' label4
		' 
		Me.label4.AutoSize = True
		Me.label4.Location = New System.Drawing.Point(8, 128)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(56, 13)
		Me.label4.TabIndex = 50
		Me.label4.Text = "Password:"
		' 
		' label3
		' 
		Me.label3.AutoSize = True
		Me.label3.Location = New System.Drawing.Point(8, 102)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(36, 13)
		Me.label3.TabIndex = 49
		Me.label3.Text = "Login:"
		' 
		' label2
		' 
		Me.label2.AutoSize = True
		Me.label2.Location = New System.Drawing.Point(8, 76)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(29, 13)
		Me.label2.TabIndex = 48
		Me.label2.Text = "Port:"
		' 
		' label1
		' 
		Me.label1.AutoSize = True
		Me.label1.Location = New System.Drawing.Point(8, 49)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(32, 13)
		Me.label1.TabIndex = 47
		Me.label1.Text = "Host:"
		' 
		' passwordBox
		' 
		Me.passwordBox.Location = New System.Drawing.Point(116, 120)
		Me.passwordBox.Name = "passwordBox"
		Me.passwordBox.Size = New System.Drawing.Size(150, 20)
		Me.passwordBox.TabIndex = 45
        Me.passwordBox.Text = ""
		' 
		' loginBox
		' 
		Me.loginBox.Location = New System.Drawing.Point(116, 94)
		Me.loginBox.Name = "loginBox"
		Me.loginBox.Size = New System.Drawing.Size(150, 20)
		Me.loginBox.TabIndex = 44
        Me.loginBox.Text = "mail@someserver.com"
		' 
		' hostBox
		' 
		Me.hostBox.Location = New System.Drawing.Point(116, 42)
		Me.hostBox.Name = "hostBox"
		Me.hostBox.Size = New System.Drawing.Size(150, 20)
		Me.hostBox.TabIndex = 42
        Me.hostBox.Text = "pop.someserver.com"
		' 
		' startAuthorization
		' 
		Me.startAuthorization.Location = New System.Drawing.Point(55, 146)
		Me.startAuthorization.Name = "startAuthorization"
		Me.startAuthorization.Size = New System.Drawing.Size(75, 23)
		Me.startAuthorization.TabIndex = 40
		Me.startAuthorization.Text = "Start"
		Me.startAuthorization.UseVisualStyleBackColor = True
		AddHandler Me.startAuthorization.Click, New System.EventHandler(AddressOf Me.startAuthorization_Click)
		' 
        ' closeButton
		' 
        Me.closeButton.Location = New System.Drawing.Point(136, 146)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Size = New System.Drawing.Size(75, 23)
        Me.closeButton.TabIndex = 41
        Me.closeButton.Text = "Finish"
        Me.closeButton.UseVisualStyleBackColor = True
        AddHandler Me.closeButton.Click, New System.EventHandler(AddressOf Me.close_Click)
		' 
		' target
		' 
		Me.target.AuthenticationType = Email.NET.Common.Configurations.EAuthenticationType.Auto
		Me.target.Host = "localhost"
		Me.target.Password = ""
		Me.target.Port = CUShort(25)
		Me.target.ProxyHost = ""
		Me.target.ProxyPassword = ""
		Me.target.ProxyPort = CUShort(0)
		Me.target.ProxyType = Email.NET.Common.Configurations.EProxyType.No
		Me.target.ProxyUser = ""
		Me.target.ReceiveTimeOut = 10000
		Me.target.SendTimeOut = 10000
		Me.target.SSLInteractionType = Email.NET.Common.Configurations.EInteractionType.Plain
		Me.target.Username = ""
		' 
		' Demo
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(525, 177)
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
		Me.Controls.Add(Me.startAuthorization)
        Me.Controls.Add(Me.closeButton)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "Demo"
		Me.ShowIcon = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Email.NET Get Statistics Demo"
		DirectCast(Me.portNum, System.ComponentModel.ISupportInitialize).EndInit()
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
	Private startAuthorization As System.Windows.Forms.Button
    Private closeButton As System.Windows.Forms.Button
    Private target As Email.NET.POP3.Pop3Client
End Class

