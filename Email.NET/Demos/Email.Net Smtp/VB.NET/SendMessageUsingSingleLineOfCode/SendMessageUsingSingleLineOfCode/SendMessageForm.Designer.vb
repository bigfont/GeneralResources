<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SendMessageForm
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

#Region "Windows Form Designer generated code"

	''' <summary>
	''' Required method for Designer support - do not modify
	''' the contents of this method with the code editor.
	''' </summary>
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.smtpClient = New Email.Net.Smtp.SmtpClient(Me.components)
		Me.label1 = New System.Windows.Forms.Label()
		Me.label2 = New System.Windows.Forms.Label()
		Me.txtRecipientAddress = New System.Windows.Forms.TextBox()
		Me.txtSenderAddress = New System.Windows.Forms.TextBox()
		Me.groupBox1 = New System.Windows.Forms.GroupBox()
		Me.txtSmtpPassword = New System.Windows.Forms.TextBox()
		Me.txtSmtpServer = New System.Windows.Forms.TextBox()
		Me.txtSmtpLogin = New System.Windows.Forms.TextBox()
		Me.label4 = New System.Windows.Forms.Label()
		Me.label5 = New System.Windows.Forms.Label()
		Me.label3 = New System.Windows.Forms.Label()
		Me.label6 = New System.Windows.Forms.Label()
		Me.txtSmtpPort = New System.Windows.Forms.TextBox()
		Me.txtSubject = New System.Windows.Forms.TextBox()
		Me.label7 = New System.Windows.Forms.Label()
		Me.txtMessageText = New System.Windows.Forms.TextBox()
		Me.label8 = New System.Windows.Forms.Label()
		Me.btnSendMessage = New System.Windows.Forms.Button()
		Me.btnChangeConfig = New System.Windows.Forms.Button()
		Me.groupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'smtpClient
		'
		Me.smtpClient.AuthenticationType = Email.Net.Common.Configurations.EAuthenticationType.[Auto]
		Me.smtpClient.Host = "smtp.domain.com"
		Me.smtpClient.Password = "mypassword"
		Me.smtpClient.Port = CType(25US, UShort)
		Me.smtpClient.ProxyHost = ""
		Me.smtpClient.ProxyPassword = ""
		Me.smtpClient.ProxyPort = CType(0US, UShort)
		Me.smtpClient.ProxyType = Email.Net.Common.Configurations.EProxyType.No
		Me.smtpClient.ProxyUser = ""
		Me.smtpClient.ReceiveTimeOut = 10000
		Me.smtpClient.SendTimeOut = 10000
		Me.smtpClient.SSLInteractionType = Email.Net.Common.Configurations.EInteractionType.Plain
		Me.smtpClient.Username = "myusername"
		'
		'label1
		'
		Me.label1.AutoSize = True
		Me.label1.Location = New System.Drawing.Point(12, 56)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(95, 13)
		Me.label1.TabIndex = 0
		Me.label1.Text = "Recipient address:"
		'
		'label2
		'
		Me.label2.AutoSize = True
		Me.label2.Location = New System.Drawing.Point(23, 82)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(84, 13)
		Me.label2.TabIndex = 1
		Me.label2.Text = "Sender address:"
		'
		'txtRecipientAddress
		'
		Me.txtRecipientAddress.Location = New System.Drawing.Point(113, 53)
		Me.txtRecipientAddress.Name = "txtRecipientAddress"
		Me.txtRecipientAddress.Size = New System.Drawing.Size(230, 20)
		Me.txtRecipientAddress.TabIndex = 2
		Me.txtRecipientAddress.Text = "myfriend@domain.com"
		'
		'txtSenderAddress
		'
		Me.txtSenderAddress.Location = New System.Drawing.Point(113, 79)
		Me.txtSenderAddress.Name = "txtSenderAddress"
		Me.txtSenderAddress.Size = New System.Drawing.Size(230, 20)
		Me.txtSenderAddress.TabIndex = 3
		Me.txtSenderAddress.Text = "me@domain.com"
		'
		'groupBox1
		'
		Me.groupBox1.Controls.Add(Me.btnChangeConfig)
		Me.groupBox1.Controls.Add(Me.txtSmtpPassword)
		Me.groupBox1.Controls.Add(Me.txtSmtpServer)
		Me.groupBox1.Controls.Add(Me.txtSmtpLogin)
		Me.groupBox1.Controls.Add(Me.label4)
		Me.groupBox1.Controls.Add(Me.label5)
		Me.groupBox1.Controls.Add(Me.label3)
		Me.groupBox1.Controls.Add(Me.label6)
		Me.groupBox1.Controls.Add(Me.txtSmtpPort)
		Me.groupBox1.Location = New System.Drawing.Point(454, 12)
		Me.groupBox1.Name = "groupBox1"
		Me.groupBox1.Size = New System.Drawing.Size(270, 159)
		Me.groupBox1.TabIndex = 12
		Me.groupBox1.TabStop = False
		Me.groupBox1.Text = "Server parameters"
		'
		'txtSmtpPassword
		'
		Me.txtSmtpPassword.Location = New System.Drawing.Point(137, 97)
		Me.txtSmtpPassword.Name = "txtSmtpPassword"
		Me.txtSmtpPassword.Size = New System.Drawing.Size(127, 20)
		Me.txtSmtpPassword.TabIndex = 20
		Me.txtSmtpPassword.Text = "mypassword"
		'
		'txtSmtpServer
		'
		Me.txtSmtpServer.Location = New System.Drawing.Point(137, 19)
		Me.txtSmtpServer.Name = "txtSmtpServer"
		Me.txtSmtpServer.Size = New System.Drawing.Size(127, 20)
		Me.txtSmtpServer.TabIndex = 15
		Me.txtSmtpServer.Text = "smtp.domain.com"
		'
		'txtSmtpLogin
		'
		Me.txtSmtpLogin.Location = New System.Drawing.Point(137, 71)
		Me.txtSmtpLogin.Name = "txtSmtpLogin"
		Me.txtSmtpLogin.Size = New System.Drawing.Size(127, 20)
		Me.txtSmtpLogin.TabIndex = 19
		Me.txtSmtpLogin.Text = "mylogin"
		'
		'label4
		'
		Me.label4.AutoSize = True
		Me.label4.Location = New System.Drawing.Point(19, 22)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(112, 13)
		Me.label4.TabIndex = 13
		Me.label4.Text = "SMTP server address:"
		'
		'label5
		'
		Me.label5.AutoSize = True
		Me.label5.Location = New System.Drawing.Point(75, 100)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(56, 13)
		Me.label5.TabIndex = 18
		Me.label5.Text = "Password:"
		'
		'label3
		'
		Me.label3.AutoSize = True
		Me.label3.Location = New System.Drawing.Point(38, 48)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(93, 13)
		Me.label3.TabIndex = 14
		Me.label3.Text = "SMTP server port:"
		'
		'label6
		'
		Me.label6.AutoSize = True
		Me.label6.Location = New System.Drawing.Point(95, 74)
		Me.label6.Name = "label6"
		Me.label6.Size = New System.Drawing.Size(36, 13)
		Me.label6.TabIndex = 17
		Me.label6.Text = "Login:"
		'
		'txtSmtpPort
		'
		Me.txtSmtpPort.Location = New System.Drawing.Point(137, 45)
		Me.txtSmtpPort.Name = "txtSmtpPort"
		Me.txtSmtpPort.Size = New System.Drawing.Size(127, 20)
		Me.txtSmtpPort.TabIndex = 16
		Me.txtSmtpPort.Text = "25"
		'
		'txtSubject
		'
		Me.txtSubject.Location = New System.Drawing.Point(113, 105)
		Me.txtSubject.Name = "txtSubject"
		Me.txtSubject.Size = New System.Drawing.Size(335, 20)
		Me.txtSubject.TabIndex = 14
		Me.txtSubject.Text = "Subject of the message"
		'
		'label7
		'
		Me.label7.AutoSize = True
		Me.label7.Location = New System.Drawing.Point(61, 108)
		Me.label7.Name = "label7"
		Me.label7.Size = New System.Drawing.Size(46, 13)
		Me.label7.TabIndex = 13
		Me.label7.Text = "Subject:"
		'
		'txtMessageText
		'
		Me.txtMessageText.Location = New System.Drawing.Point(12, 177)
		Me.txtMessageText.Multiline = True
		Me.txtMessageText.Name = "txtMessageText"
		Me.txtMessageText.Size = New System.Drawing.Size(711, 222)
		Me.txtMessageText.TabIndex = 15
		Me.txtMessageText.Text = "Text of the message"
		'
		'label8
		'
		Me.label8.AutoSize = True
		Me.label8.Location = New System.Drawing.Point(12, 139)
		Me.label8.Name = "label8"
		Me.label8.Size = New System.Drawing.Size(70, 13)
		Me.label8.TabIndex = 16
        Me.label8.Text = "Message text"
		'
		'btnSendMessage
		'
		Me.btnSendMessage.Location = New System.Drawing.Point(307, 405)
		Me.btnSendMessage.Name = "btnSendMessage"
		Me.btnSendMessage.Size = New System.Drawing.Size(123, 23)
		Me.btnSendMessage.TabIndex = 17
		Me.btnSendMessage.Text = "SendMessage"
		Me.btnSendMessage.UseVisualStyleBackColor = True
		'
		'btnChangeConfig
		'
		Me.btnChangeConfig.Location = New System.Drawing.Point(71, 130)
		Me.btnChangeConfig.Name = "btnChangeConfig"
		Me.btnChangeConfig.Size = New System.Drawing.Size(129, 23)
		Me.btnChangeConfig.TabIndex = 21
		Me.btnChangeConfig.Text = "Change config"
		Me.btnChangeConfig.UseVisualStyleBackColor = True
		'
		'SendMessageForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(736, 440)
		Me.Controls.Add(Me.btnSendMessage)
		Me.Controls.Add(Me.label8)
		Me.Controls.Add(Me.txtMessageText)
		Me.Controls.Add(Me.txtSubject)
		Me.Controls.Add(Me.label7)
		Me.Controls.Add(Me.groupBox1)
		Me.Controls.Add(Me.txtSenderAddress)
		Me.Controls.Add(Me.txtRecipientAddress)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.label1)
		Me.Name = "SendMessageForm"
		Me.Text = "Send a message"
		Me.groupBox1.ResumeLayout(False)
		Me.groupBox1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

#End Region

	Private smtpClient As Email.Net.Smtp.SmtpClient
	Private label1 As System.Windows.Forms.Label
	Private label2 As System.Windows.Forms.Label
	Private txtRecipientAddress As System.Windows.Forms.TextBox
	Private txtSenderAddress As System.Windows.Forms.TextBox
	Private groupBox1 As System.Windows.Forms.GroupBox
	Private txtSmtpPassword As System.Windows.Forms.TextBox
	Private txtSmtpServer As System.Windows.Forms.TextBox
	Private txtSmtpLogin As System.Windows.Forms.TextBox
	Private label4 As System.Windows.Forms.Label
	Private label5 As System.Windows.Forms.Label
	Private label3 As System.Windows.Forms.Label
	Private label6 As System.Windows.Forms.Label
	Private txtSmtpPort As System.Windows.Forms.TextBox
	Private txtSubject As System.Windows.Forms.TextBox
	Private label7 As System.Windows.Forms.Label
	Private txtMessageText As System.Windows.Forms.TextBox
	Private label8 As System.Windows.Forms.Label
	Private WithEvents btnChangeConfig As System.Windows.Forms.Button
	Private WithEvents btnSendMessage As System.Windows.Forms.Button

End Class
