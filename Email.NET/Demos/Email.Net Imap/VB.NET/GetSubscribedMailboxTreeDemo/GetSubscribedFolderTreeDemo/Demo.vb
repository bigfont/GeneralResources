Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Email.NET.Imap
Imports Email.NET.Common
Imports Email.NET.Common.Configurations
Imports Email.NET.Imap.Responses

Namespace getSubscribedFolderTreeDemo
	Public Partial Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
			interactionCombo.DropDownStyle = ComboBoxStyle.DropDownList
			interactionCombo.SelectedIndex = 1
			interactionCombo.Refresh()
            butClose.Enabled = False
        End Sub

        Private Sub startAuthorization_Click(ByVal sender As Object, ByVal e As EventArgs)
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
                MessageBox.Show("Login succeed!")
                'Get subscribed folder tree
                Dim folders As Mailbox = client.GetSubscribedMailboxTree()
                Dim tmp As String = "There are "
                'Count number of subscribed folders
                tmp += folders.Children.Count.ToString()
                tmp += " subscribed folders"
                MessageBox.Show(tmp)
                butClose.Enabled = True
                startAuthorization.Enabled = False
            Else
                MessageBox.Show("Login failed!")
            End If
        End Sub

        Private Sub close_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim response As CompletionResponse = DirectCast(client.Logout(), CompletionResponse)
            If response.CompletionResult = ECompletionResponseType.OK Then
                MessageBox.Show("Logout succeed!")
                butClose.Enabled = False
                startAuthorization.Enabled = True
            Else
                MessageBox.Show("Logout failed!")
            End If
        End Sub
	End Class
End Namespace
