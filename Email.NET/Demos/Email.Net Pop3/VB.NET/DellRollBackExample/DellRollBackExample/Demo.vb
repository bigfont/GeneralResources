Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Email.NET.POP3
Imports Email.NET.Common

Public Partial Class Demo
	Inherits Form
	Private response As POP3Response

	Public Sub New()
		InitializeComponent()
		deleteButton.Enabled = False

		rollbackButton.Enabled = False
	End Sub

	Private Sub deleteButton_Click(sender As Object, e As EventArgs)
		'Delete message
		response = target.DeleteMessage(CUInt(Math.Truncate(messageNumber.Value)))
		If response.Type = EPOP3ResponseType.OK Then
			messageTextBox.AppendText(vbCr & vbLf & " Message deleted. " & vbCr & vbLf)
		End If
		rollbackButton.Enabled = True
	End Sub

	Private Sub rollbackButton_Click(sender As Object, e As EventArgs)
		'Rollback last transaction
		response = target.Reset()
		If response.Type = EPOP3ResponseType.OK Then
			messageTextBox.AppendText(vbCr & vbLf & " Transaction rolled back " & vbCr & vbLf)
		End If
		rollbackButton.Enabled = False
	End Sub

	Private Sub close_Click(sender As Object, e As EventArgs)
		If rollbackButton.Enabled <> False Then
			'Logout from the server
			target.Logout()
			messageTextBox.AppendText(vbCr & vbLf & " *** Messages were deleted *** " & vbCr & vbLf)
			rollbackButton.Enabled = False
			deleteButton.Enabled = False
		Else
			Close()
		End If

	End Sub

	Private Sub startAuthorization_Click(sender As Object, e As EventArgs)

		'Create POP3 client with parameters needed
		Dim port As UShort
		port = CUShort(Math.Truncate(portNum.Value))
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
		response = target.Login()
		If response.Type = EPOP3ResponseType.OK Then
			deleteButton.Enabled = True
		End If
	End Sub

End Class
