Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Email.NET.Common
Imports Email.NET.Imap
Imports Email.NET.Common.Configurations
Imports Email.NET.Imap.Responses
Imports Email.NET.Imap.Collections

Public Partial Class Demo
	Inherits Form
	Public Sub New()
		InitializeComponent()
		interactionCombo.DropDownStyle = ComboBoxStyle.DropDownList
		interactionCombo.SelectedIndex = 1
		interactionCombo.Refresh()
		close.Enabled = False
		search.Enabled = False
	End Sub

	Private Sub close_Click(sender As Object, e As EventArgs)
        Dim response As CompletionResponse = DirectCast(client.Logout(), CompletionResponse)
        If response.CompletionResult = ECompletionResponseType.OK Then
            Windows.Forms.MessageBox.Show("Logout succeed!")
            close.Enabled = False
            startAuthorization.Enabled = True
            search.Enabled = False
        Else
            Windows.Forms.MessageBox.Show("Logout failed!")
        End If
	End Sub

	Private Sub startAuthorization_Click(sender As Object, e As EventArgs)
		'Create IMAP4 client with parameters needed
		'URL of host to connect to
		client.Host = hostBox.Text
		'TCP port for connection
		client.Port = CUShort(Math.Truncate(portNum.Value))
		'Username to login to the IMAP server
		client.Username = loginBox.Text
		'Password to login to the IMAP server
		client.Password = passwordBox.Text
		'Interaction type
		client.SSLInteractionType = CType(Convert.ToInt32(interactionCombo.SelectedIndex), EInteractionType)
		'Login to the server
        Dim response As CompletionResponse = DirectCast(client.Login(), CompletionResponse)
        If response.CompletionResult = ECompletionResponseType.OK Then
            Windows.Forms.MessageBox.Show("Login succeed!")
            close.Enabled = True
            startAuthorization.Enabled = False
            search.Enabled = True
        Else
            Windows.Forms.MessageBox.Show("Login failed!")
        End If
	End Sub

	Private Sub search_Click(sender As Object, e As EventArgs)
		'Create query to find message
		Dim query__1 As Query = Query.[Not](Query.Larger(CUInt(Math.Truncate(sizeNum.Value))))
		'Get folder (inbox) to search in
        Dim folder As Mailbox = client.GetMailboxTree()
        Dim inbox As Mailbox = Mailbox.Find(folder, "INBOX")
		Dim result As IEnumerable(Of UInteger) = client.Search(query__1, inbox)
		'Create user result
		Dim tmp As String = ""
        'MessageCollection messages = client.GetAllMessages(inbox);
		For Each x As UInteger In result
            Dim subj As String = client.GetFullMessage(x, inbox).Header.Subject
			tmp += String.Format(" {0}, message subject - {1}" & vbCr & vbLf & " ", x, subj)
		Next
		messageBox.AppendText([String].Format("Messages found: {0}" & vbCr & vbLf, tmp))
	End Sub
End Class
