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
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.label9 = New System.Windows.Forms.Label()
        Me.proxyTypeCombo = New System.Windows.Forms.ComboBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.proxyPortNum = New System.Windows.Forms.NumericUpDown()
        Me.proxyHostBox = New System.Windows.Forms.TextBox()
        Me.proxyLoginBox = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.proxyPasswordBox = New System.Windows.Forms.TextBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.target = New Email.Net.Pop3.Pop3Client(Me.components)
        DirectCast(Me.portNum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox1.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        DirectCast(Me.proxyPortNum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' portNum
        ' 
        Me.portNum.Location = New System.Drawing.Point(77, 45)
        Me.portNum.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.portNum.Name = "portNum"
        Me.portNum.Size = New System.Drawing.Size(150, 20)
        Me.portNum.TabIndex = 17
        Me.portNum.Value = New Decimal(New Integer() {110, 0, 0, 0})
        ' 
        ' label4
        ' 
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(6, 103)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(56, 13)
        Me.label4.TabIndex = 25
        Me.label4.Text = "Password:"
        ' 
        ' label3
        ' 
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(6, 77)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(36, 13)
        Me.label3.TabIndex = 24
        Me.label3.Text = "Login:"
        ' 
        ' label2
        ' 
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(6, 51)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(29, 13)
        Me.label2.TabIndex = 23
        Me.label2.Text = "Port:"
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(6, 24)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(32, 13)
        Me.label1.TabIndex = 22
        Me.label1.Text = "Host:"
        ' 
        ' passwordBox
        ' 
        Me.passwordBox.Location = New System.Drawing.Point(77, 97)
        Me.passwordBox.Name = "passwordBox"
        Me.passwordBox.Size = New System.Drawing.Size(150, 20)
        Me.passwordBox.TabIndex = 19
        Me.passwordBox.Text = "1123be11"
        ' 
        ' loginBox
        ' 
        Me.loginBox.Location = New System.Drawing.Point(77, 71)
        Me.loginBox.Name = "loginBox"
        Me.loginBox.Size = New System.Drawing.Size(150, 20)
        Me.loginBox.TabIndex = 18
        Me.loginBox.Text = "mailnet.tester@gmail.com"
        ' 
        ' hostBox
        ' 
        Me.hostBox.Location = New System.Drawing.Point(77, 19)
        Me.hostBox.Name = "hostBox"
        Me.hostBox.Size = New System.Drawing.Size(150, 20)
        Me.hostBox.TabIndex = 16
        Me.hostBox.Text = "pop.gmail.com"
        ' 
        ' startAuthorization
        ' 
        Me.startAuthorization.Location = New System.Drawing.Point(41, 147)
        Me.startAuthorization.Name = "startAuthorization"
        Me.startAuthorization.Size = New System.Drawing.Size(75, 23)
        Me.startAuthorization.TabIndex = 14
        Me.startAuthorization.Text = "Start"
        Me.startAuthorization.UseVisualStyleBackColor = True
        AddHandler Me.startAuthorization.Click, New System.EventHandler(AddressOf Me.startAuthorization_Click)
        ' 
        ' closeButton
        ' 
        Me.closeButton.Location = New System.Drawing.Point(122, 147)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Size = New System.Drawing.Size(75, 23)
        Me.closeButton.TabIndex = 15
        Me.closeButton.Text = "Finish"
        Me.closeButton.UseVisualStyleBackColor = True
        AddHandler Me.closeButton.Click, New System.EventHandler(AddressOf Me.close_Click)
        ' 
        ' groupBox1
        ' 
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.portNum)
        Me.groupBox1.Controls.Add(Me.hostBox)
        Me.groupBox1.Controls.Add(Me.loginBox)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.passwordBox)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Location = New System.Drawing.Point(12, 12)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(242, 128)
        Me.groupBox1.TabIndex = 26
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Server settings"
        ' 
        ' groupBox2
        ' 
        Me.groupBox2.Controls.Add(Me.label9)
        Me.groupBox2.Controls.Add(Me.proxyTypeCombo)
        Me.groupBox2.Controls.Add(Me.label5)
        Me.groupBox2.Controls.Add(Me.proxyPortNum)
        Me.groupBox2.Controls.Add(Me.proxyHostBox)
        Me.groupBox2.Controls.Add(Me.proxyLoginBox)
        Me.groupBox2.Controls.Add(Me.label6)
        Me.groupBox2.Controls.Add(Me.proxyPasswordBox)
        Me.groupBox2.Controls.Add(Me.label7)
        Me.groupBox2.Controls.Add(Me.label8)
        Me.groupBox2.Location = New System.Drawing.Point(275, 12)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(239, 158)
        Me.groupBox2.TabIndex = 27
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Proxy settings"
        ' 
        ' label9
        ' 
        Me.label9.AutoSize = True
        Me.label9.Location = New System.Drawing.Point(6, 130)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(60, 13)
        Me.label9.TabIndex = 35
        Me.label9.Text = "Proxy Type"
        ' 
        ' proxyTypeCombo
        ' 
        Me.proxyTypeCombo.FormattingEnabled = True
        Me.proxyTypeCombo.Location = New System.Drawing.Point(81, 122)
        Me.proxyTypeCombo.Name = "proxyTypeCombo"
        Me.proxyTypeCombo.Size = New System.Drawing.Size(152, 21)
        Me.proxyTypeCombo.TabIndex = 34
        ' 
        ' label5
        ' 
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(4, 104)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(56, 13)
        Me.label5.TabIndex = 33
        Me.label5.Text = "Password:"
        ' 
        ' proxyPortNum
        ' 
        Me.proxyPortNum.Location = New System.Drawing.Point(81, 44)
        Me.proxyPortNum.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.proxyPortNum.Name = "proxyPortNum"
        Me.proxyPortNum.Size = New System.Drawing.Size(152, 20)
        Me.proxyPortNum.TabIndex = 27
        Me.proxyPortNum.Value = New Decimal(New Integer() {1080, 0, 0, 0})
        ' 
        ' proxyHostBox
        ' 
        Me.proxyHostBox.Location = New System.Drawing.Point(81, 18)
        Me.proxyHostBox.Name = "proxyHostBox"
        Me.proxyHostBox.Size = New System.Drawing.Size(152, 20)
        Me.proxyHostBox.TabIndex = 26
        Me.proxyHostBox.Text = "Virtual-XP"
        ' 
        ' proxyLoginBox
        ' 
        Me.proxyLoginBox.Location = New System.Drawing.Point(81, 70)
        Me.proxyLoginBox.Name = "proxyLoginBox"
        Me.proxyLoginBox.Size = New System.Drawing.Size(152, 20)
        Me.proxyLoginBox.TabIndex = 28
        Me.proxyLoginBox.Text = "User"
        ' 
        ' label6
        ' 
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(4, 78)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(32, 13)
        Me.label6.TabIndex = 32
        Me.label6.Text = "User:"
        ' 
        ' proxyPasswordBox
        ' 
        Me.proxyPasswordBox.Location = New System.Drawing.Point(81, 96)
        Me.proxyPasswordBox.Name = "proxyPasswordBox"
        Me.proxyPasswordBox.Size = New System.Drawing.Size(152, 20)
        Me.proxyPasswordBox.TabIndex = 29
        Me.proxyPasswordBox.Text = "Password"
        ' 
        ' label7
        ' 
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(4, 52)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(29, 13)
        Me.label7.TabIndex = 31
        Me.label7.Text = "Port:"
        ' 
        ' label8
        ' 
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(4, 25)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(32, 13)
        Me.label8.TabIndex = 30
        Me.label8.Text = "Host:"
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
        Me.ClientSize = New System.Drawing.Size(527, 181)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.startAuthorization)
        Me.Controls.Add(Me.closeButton)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Demo"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Email.NET Proxy authorization Demo"
        DirectCast(Me.portNum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        DirectCast(Me.proxyPortNum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

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
	Private groupBox1 As System.Windows.Forms.GroupBox
	Private groupBox2 As System.Windows.Forms.GroupBox
	Private label9 As System.Windows.Forms.Label
	Private proxyTypeCombo As System.Windows.Forms.ComboBox
	Private label5 As System.Windows.Forms.Label
	Private proxyPortNum As System.Windows.Forms.NumericUpDown
	Private proxyHostBox As System.Windows.Forms.TextBox
	Private proxyLoginBox As System.Windows.Forms.TextBox
	Private label6 As System.Windows.Forms.Label
	Private proxyPasswordBox As System.Windows.Forms.TextBox
	Private label7 As System.Windows.Forms.Label
	Private label8 As System.Windows.Forms.Label
    Private target As Email.NET.POP3.Pop3Client
End Class

