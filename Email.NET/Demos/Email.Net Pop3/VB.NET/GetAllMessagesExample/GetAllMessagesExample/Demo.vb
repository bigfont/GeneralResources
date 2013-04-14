Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Email.NET.Common.Configurations
Imports Email.NET.POP3
Imports Email.NET.Common
Imports Email.NET.Common.Collections

Public Partial Class Demo
	Inherits Form
	Public Sub New()
		InitializeComponent()
	End Sub

	Private Sub startAuthorization_Click(sender As Object, e As EventArgs)
		'Create POP3 client with parameters needed
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
		If response.Type = EPop3ResponseType.OK Then
			'Get all messages from the server
			Dim messages As Rfc822MessageCollection = target.GetAllMessages()
			'Make some actions, for example
			'Count number of messages received
			Dim cnt As String = Convert.ToString(messages.Count)
			cnt += " messages was got"
			MessageBox.Show(cnt, "All messages from the server were received!", MessageBoxButtons.OK)
		End If
		'Logout from the server
		target.Logout()

	End Sub

	Private Sub close_Click(sender As Object, e As EventArgs)
		Close()
	End Sub
End Class
