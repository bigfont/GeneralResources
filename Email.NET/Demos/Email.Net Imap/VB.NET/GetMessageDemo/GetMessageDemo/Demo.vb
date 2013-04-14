Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Email.Net.Common
Imports Email.Net.Imap
Imports Email.Net.Common.Configurations
Imports Email.Net.Imap.Responses
Imports Email.Net.Imap.Collections

Partial Public Class Demo
    Inherits Form
    Public Sub New()
        InitializeComponent()
        interactionCombo.DropDownStyle = ComboBoxStyle.DropDownList
        interactionCombo.SelectedIndex = 1
        interactionCombo.Refresh()
        close.Enabled = False
        getMessage.Enabled = False
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
            Windows.Forms.MessageBox.Show("Login succeed!")
            close.Enabled = True
            startAuthorization.Enabled = False
            getMessage.Enabled = True
        Else
            Windows.Forms.MessageBox.Show("Login failed!")
        End If

    End Sub

    Private Sub getMessage_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Get all messages to know the uid
        Dim folders As Mailbox = client.GetMailboxTree()
        'Get inbox folder
        Dim inbox As Mailbox = Mailbox.Find(folders, "INBOX")
        Dim tmp As MessageCollection = client.GetAllMessageHeaders(inbox)
        messageBox.AppendText(vbCr & vbLf & "***Received messages: ")
        messageBox.AppendText(tmp.Count.ToString())
        Dim uid As UInteger = Convert.ToUInt32(tmp(0).UID)
        'Get message from the server
        Dim message As ImapMessage = client.GetFullMessage(uid, inbox)
        messageBox.AppendText(vbCr & vbLf & "Sender (from): ")
        messageBox.AppendText(message.Header.From.ToString())
        messageBox.AppendText(vbCr & vbLf & "Subject: ")
        messageBox.AppendText(message.Header.Subject)
    End Sub

    Private Sub close_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim response As CompletionResponse = DirectCast(client.Logout(), CompletionResponse)
        If response.CompletionResult = ECompletionResponseType.OK Then
            Windows.Forms.MessageBox.Show("Logout succeed!")
            close.Enabled = False
            startAuthorization.Enabled = True
            getMessage.Enabled = False
        Else
            Windows.Forms.MessageBox.Show("Logout failed!")
        End If
    End Sub
End Class
