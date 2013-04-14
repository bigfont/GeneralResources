Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Email.NET.Imap.Responses
Imports Email.NET.Common
Imports Email.NET.Imap.Collections
Imports Email.NET.Imap

Public Partial Class Demo
	Inherits Form
	Public Sub New()
		InitializeComponent()
	End Sub
	Private Sub showFolders()
		'Receive folders (mailboxes) names 
        Dim folders As Mailbox = client.GetMailboxTree()
        For Each x As Mailbox In folders.Children
            folderBox.Items.Add(x.DisplayName)
        Next
	End Sub
	Private Sub loginButton_Click(sender As Object, e As EventArgs)
        'Create  client with parameters needed
		'URL of host to connect to
		client.Host = hostBox.Text
		'TCP port for connection
		client.Port = CUShort(Math.Truncate(portNum.Value))
		'Username to login to the IMAP server
		client.Username = loginBox.Text
		'Password to login to the IMAP server
		client.Password = passwordBox.Text
		'Login to the server
        Dim response As CompletionResponse = DirectCast(client.Login(), CompletionResponse)
        If response.CompletionResult = ECompletionResponseType.OK Then
            MessageBox.Show("Login succeed!")
            folderBox.Items.Clear()
            showFolders()
            logoutButton.Enabled = True
            loginButton.Enabled = False
        Else
            MessageBox.Show("Login failed!")
        End If
	End Sub

	Private Sub logoutButton_Click(sender As Object, e As EventArgs)
		'Logout from the server
        Dim response As CompletionResponse = DirectCast(client.Logout(), CompletionResponse)
        If response.CompletionResult = ECompletionResponseType.OK Then
            MessageBox.Show("Logout succeed!")
            logoutButton.Enabled = False
            loginButton.Enabled = True
        Else
            MessageBox.Show("Logout failed!")
        End If

	End Sub

	Private Sub folderBox_MouseDoubleClick(sender As Object, e As MouseEventArgs)
		If folderBox.Items.Count > 0 Then
			Dim name As String = folderBox.SelectedItem.ToString()
			'Set selected item, as current mailbox
            Dim current As Mailbox = Mailbox.Find(client.GetMailboxTree(), name)
			client.[Select](current)
		End If
		MessageBox.Show("Selected item now current")
	End Sub

End Class
