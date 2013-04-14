Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Email.NET.Smtp
Imports Email.NET.Common
Imports Email.NET.Common.Collections
Imports Email.NET.Common.Configurations

Public Partial Class Demo
	Inherits Form
	Public Sub New()
		InitializeComponent()
		proxyType.Items.AddRange(New Object() {EProxyType.No, EProxyType.SOCKS5, EProxyType.SOCKS4})
		proxyType.DropDownStyle = ComboBoxStyle.DropDownList
		proxyType.SelectedIndex = 1
		proxyType.Refresh()
	End Sub

	Private Sub sendMessage_Click(sender As Object, e As EventArgs)
		'Create and send message using proxy
		'SMTP client settings
		'URL of host to connect to
		target.Host = hostBox.Text
		'TCP port for connection
		target.Port = CUShort(Math.Truncate(portNum.Value))
		'Username to login to the SMTP server
		target.Username = loginBox.Text
		'Password to login to the SMTP server
		target.Password = passwordBox.Text
		'Configure proxy
		target.ProxyType = CType(proxyType.SelectedItem, EProxyType)
		target.ProxyHost = proxyHostBox.Text
		target.ProxyPort = CUShort(Math.Truncate(proxyPortNum.Value))
		target.ProxyUser = proxyUserBox.Text
		target.ProxyPassword = proxyPasswordBox.Text
		'Create address and message 
		Dim addressCollection As New EmailAddressCollection()
		addressCollection.Add(New EmailAddress(toBox.Text))
		'Create message
		'Source address
		'Address of the recipient
		'Message subject
			'Message text
		Dim message As New SmtpMessage(New EmailAddress(fromBox.Text), addressCollection, subjectBox.Text, messageBox.Text)
		Dim result As SendResult = target.SendOne(message)
		'Send message	
		If result.IsSuccessful Then
            Windows.Forms.MessageBox.Show("Message sent successful!")
		Else
            Windows.Forms.MessageBox.Show("Message sending failed!")
		End If

	End Sub
End Class
