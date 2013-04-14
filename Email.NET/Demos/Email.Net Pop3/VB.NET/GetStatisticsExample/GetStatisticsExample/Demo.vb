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
		Dim response As POP3Response = target.Login()
        If response.Type = EPOP3ResponseType.OK Then
            'Create new statistics item, and get statistics from the server
            Dim statistics As POP3MessageStatistics = target.GetStatistic()
            'Get number of messages 
            Dim messagecounter As UInteger = statistics.CountMessages
            Dim messagesize As UInteger = statistics.SizeMessages
            messageTextBox.AppendText(vbCr & vbLf & " ***Statistics*** " & vbCr & vbLf & " Number of messages: ")
            messageTextBox.AppendText(messagecounter.ToString())
            messageTextBox.AppendText("  Size of messages: ")
            messageTextBox.AppendText(messagesize.ToString())
        Else
            MessageBox.Show("Login failed.")
        End If
        'Logout from the server
        target.Logout()
	End Sub

	Private Sub close_Click(sender As Object, e As EventArgs)
		Close()
	End Sub
End Class
