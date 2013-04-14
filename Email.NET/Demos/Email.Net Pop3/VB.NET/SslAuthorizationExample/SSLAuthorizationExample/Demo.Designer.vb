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
        Me.closeButton = New System.Windows.Forms.Button()
        Me.startAuthorization = New System.Windows.Forms.Button()
        Me.hostBox = New System.Windows.Forms.TextBox()
        Me.loginBox = New System.Windows.Forms.TextBox()
        Me.passwordBox = New System.Windows.Forms.TextBox()
        Me.interactionCombo = New System.Windows.Forms.ComboBox()
        Me.authentificationCombo = New System.Windows.Forms.ComboBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.portNum = New System.Windows.Forms.NumericUpDown()
        Me.target = New Email.Net.Pop3.Pop3Client(Me.components)
        DirectCast(Me.portNum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' closeButton
        ' 
        Me.closeButton.Location = New System.Drawing.Point(145, 200)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Size = New System.Drawing.Size(75, 23)
        Me.closeButton.TabIndex = 1
        Me.closeButton.Text = "Finish"
        Me.closeButton.UseVisualStyleBackColor = True
        AddHandler Me.closeButton.Click, New System.EventHandler(AddressOf Me.close_Click)
        ' 
        ' startAuthorization
        ' 
        Me.startAuthorization.Location = New System.Drawing.Point(64, 200)
        Me.startAuthorization.Name = "startAuthorization"
        Me.startAuthorization.Size = New System.Drawing.Size(75, 23)
        Me.startAuthorization.TabIndex = 0
        Me.startAuthorization.Text = "Start"
        Me.startAuthorization.UseVisualStyleBackColor = True
        AddHandler Me.startAuthorization.Click, New System.EventHandler(AddressOf Me.startAuthorization_Click)
        ' 
        ' hostBox
        ' 
        Me.hostBox.Location = New System.Drawing.Point(120, 23)
        Me.hostBox.Name = "hostBox"
        Me.hostBox.Size = New System.Drawing.Size(150, 20)
        Me.hostBox.TabIndex = 2
        Me.hostBox.Text = "pop.gmail.com"
        ' 
        ' loginBox
        ' 
        Me.loginBox.Location = New System.Drawing.Point(120, 75)
        Me.loginBox.Name = "loginBox"
        Me.loginBox.Size = New System.Drawing.Size(150, 20)
        Me.loginBox.TabIndex = 4
        Me.loginBox.Text = "mailnet.tester@gmail.com"
        ' 
        ' passwordBox
        ' 
        Me.passwordBox.Location = New System.Drawing.Point(120, 101)
        Me.passwordBox.Name = "passwordBox"
        Me.passwordBox.Size = New System.Drawing.Size(150, 20)
        Me.passwordBox.TabIndex = 5
        Me.passwordBox.Text = "1123be11"
        ' 
        ' interactionCombo
        ' 
        Me.interactionCombo.FormattingEnabled = True
        Me.interactionCombo.Location = New System.Drawing.Point(120, 127)
        Me.interactionCombo.Name = "interactionCombo"
        Me.interactionCombo.Size = New System.Drawing.Size(150, 21)
        Me.interactionCombo.TabIndex = 6
        ' 
        ' authentificationCombo
        ' 
        Me.authentificationCombo.FormattingEnabled = True
        Me.authentificationCombo.Location = New System.Drawing.Point(120, 154)
        Me.authentificationCombo.Name = "authentificationCombo"
        Me.authentificationCombo.Size = New System.Drawing.Size(150, 21)
        Me.authentificationCombo.TabIndex = 7
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(12, 30)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(32, 13)
        Me.label1.TabIndex = 8
        Me.label1.Text = "Host:"
        ' 
        ' label2
        ' 
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(12, 57)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(29, 13)
        Me.label2.TabIndex = 9
        Me.label2.Text = "Port:"
        ' 
        ' label3
        ' 
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(12, 83)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(36, 13)
        Me.label3.TabIndex = 10
        Me.label3.Text = "Login:"
        ' 
        ' label4
        ' 
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(12, 109)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(56, 13)
        Me.label4.TabIndex = 11
        Me.label4.Text = "Password:"
        ' 
        ' label5
        ' 
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(12, 136)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(83, 13)
        Me.label5.TabIndex = 12
        Me.label5.Text = "Interaction type:"
        ' 
        ' label6
        ' 
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(12, 158)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(78, 13)
        Me.label6.TabIndex = 13
        Me.label6.Text = "Authentication:"
        ' 
        ' portNum
        ' 
        Me.portNum.Location = New System.Drawing.Point(120, 49)
        Me.portNum.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.portNum.Name = "portNum"
        Me.portNum.Size = New System.Drawing.Size(150, 20)
        Me.portNum.TabIndex = 3
        Me.portNum.Value = New Decimal(New Integer() {995, 0, 0, 0})
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
        Me.target.ReceiveTimeout = 10000
        Me.target.SendTimeout = 10000
        Me.target.SSLInteractionType = Email.Net.Common.Configurations.EInteractionType.Plain
        Me.target.Username = ""
        ' 
        ' Demo
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 237)
        Me.Controls.Add(Me.portNum)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.authentificationCombo)
        Me.Controls.Add(Me.interactionCombo)
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
        Me.Text = "Email.NET Authorization Demo"
        DirectCast(Me.portNum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private closeButton As System.Windows.Forms.Button
	Private startAuthorization As System.Windows.Forms.Button
	Private hostBox As System.Windows.Forms.TextBox
	Private loginBox As System.Windows.Forms.TextBox
	Private passwordBox As System.Windows.Forms.TextBox
	Private interactionCombo As System.Windows.Forms.ComboBox
	Private authentificationCombo As System.Windows.Forms.ComboBox
	Private label1 As System.Windows.Forms.Label
	Private label2 As System.Windows.Forms.Label
	Private label3 As System.Windows.Forms.Label
	Private label4 As System.Windows.Forms.Label
	Private label5 As System.Windows.Forms.Label
	Private label6 As System.Windows.Forms.Label
	Private portNum As System.Windows.Forms.NumericUpDown
    Private target As Email.NET.POP3.Pop3Client
End Class

