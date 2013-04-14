Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Email.NET.POP3
Imports Email.NET.Common.Collections
Imports Email.NET.Common.Configurations
Imports Email.NET.Common

Public Partial Class Demo
	Inherits Form
	Public Sub New()
		InitializeComponent()
	End Sub

	Private Sub startAuthorization_Click(sender As Object, e As EventArgs)

		'Create POP3 client with parameters needed
		Dim number As UShort = CUShort(Math.Truncate(messageNumber.Value))
		'URL of host to connect to
		target.Host = hostBox.Text
		'TCP port for connection
		target.Port = CUShort(Math.Truncate(portNum.Value))
		'Username to login to the POP3 server
		target.Username = loginBox.Text
		'Password to login to the POP3 server
		target.Password = passwordBox.Text
		'Login to the server
		Dim response As Pop3Response = target.Login()

		'Get message from the server
			'Message number at the current session
		Dim message As Rfc822Message = target.GetMessage(number)
		'Get message's subject, sender, date and body
		Dim subject As String = message.Subject
		Dim [date] As DateTime = message.[Date]
		Dim body As String = message.Text

		'Logout from the server
		target.Logout()
		messageTextBox.AppendText("**** MESSAGE RECEIVED **** " & vbCr & vbLf)
		messageTextBox.AppendText("Subject: ")
		messageTextBox.AppendText(subject)
		messageTextBox.AppendText("  " & vbCr & vbLf & "*** Date: ")
		messageTextBox.AppendText([date].ToString())
		messageTextBox.AppendText(vbCr & vbLf & vbCr & vbLf & vbCr & vbLf)
	End Sub

	Private Sub close_Click(sender As Object, e As EventArgs)
		Close()
	End Sub
End Class
