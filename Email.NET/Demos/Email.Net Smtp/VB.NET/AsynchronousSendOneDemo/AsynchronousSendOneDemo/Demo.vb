Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Email.NET.Smtp
Imports Email.NET.Common
Imports Email.NET.Common.Collections

Public Partial Class Demo
	Inherits Form
	Public Sub New()
		InitializeComponent()
	End Sub
    Private Sub callBack(ByVal ar As IAsyncResult)
        Dim result As SendResult = target.EndSendOne(ar)
        If result.IsSuccessful Then
            Windows.Forms.MessageBox.Show("Message sent successful!")
        Else
            Windows.Forms.MessageBox.Show("Message sending failed!")
        End If
        Dim invoker As MethodInvoker = AddressOf MySub
        Me.Invoke(invoker)
    End Sub
    Sub MySub()
        statusLabel.Text = "Status: message was sent. Ready."
    End Sub
	Private Sub sendMessage_Click(sender As Object, e As EventArgs)
		'Create and send message
		'SMTP client settings
		'URL of host to connect to
		target.Host = hostBox.Text
		'TCP port for connection
		target.Port = CUShort(Math.Truncate(portNum.Value))
		'Username to login to the SMTP server
		target.Username = loginBox.Text
		'Password to login to the SMTP server
		target.Password = passwordBox.Text
		'Create address and message 
		Dim addressCollection As New EmailAddressCollection()
		addressCollection.Add(New EmailAddress(toBox.Text))
		'Create message
		'Source address
		'Address of the recipient
		'Message subject
			'Message text
		Dim message As New SmtpMessage(New EmailAddress(fromBox.Text), addressCollection, subjectBox.Text, messageBox.Text)
		Dim ar As IAsyncResult = target.BeginSendOne(message, AddressOf callback)
		statusLabel.Text = "Status: message sending..."
	End Sub
End Class
