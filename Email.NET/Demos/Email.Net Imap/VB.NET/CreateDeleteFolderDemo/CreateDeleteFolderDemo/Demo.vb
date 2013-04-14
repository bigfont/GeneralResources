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

Partial Public Class Demo
    Inherits Form
    Public Sub New()
        InitializeComponent()
        interactionCombo.DropDownStyle = ComboBoxStyle.DropDownList
        interactionCombo.SelectedIndex = 1
        interactionCombo.Refresh()
        createButton.Enabled = False
        deleteButton.Enabled = False
    End Sub

    Private Sub createButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Create new folder on the server with given name
        Dim response As CompletionResponse = DirectCast(client.CreateMailbox(folderName.Text), CompletionResponse)
        If response.CompletionResult = ECompletionResponseType.OK Then
            MessageBox.Show("Created successfully.")
        Else
            MessageBox.Show("Creation failed.")
        End If
    End Sub

    Private Sub startAuthorization_Click_1(ByVal sender As Object, ByVal e As EventArgs)
        If startAuthorization.Text = "Start" Then
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
                createButton.Enabled = True
                deleteButton.Enabled = True
                startAuthorization.Text = "Finish"
            Else
                MessageBox.Show("Login failed!")

            End If
        Else
            client.Logout()
            startAuthorization.Text = "Start"
        End If
    End Sub

    Private Sub deleteButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Delete folder from the server
        'Get folder tree from the server
        Dim folders As Mailbox = client.GetMailboxTree()
        'Search for folder needed
        Dim i As Integer = 0
        For Each x As Mailbox In folders.Children
            If x.Name = folderName.Text Then
                'If folder found, delete it.
                client.DeleteMailbox(x)
                i += 1
            End If
        Next
        Dim tmp As String = "Folders deleted: "
        tmp += i.ToString()
        MessageBox.Show(tmp)
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs)
    End Sub
End Class
