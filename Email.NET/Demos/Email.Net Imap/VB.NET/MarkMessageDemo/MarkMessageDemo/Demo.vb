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
Imports Email.NET.Imap.Sequences
Imports Email.NET.Imap.MessagePart

Partial Public Class Demo
    Inherits Form
    Public Sub New()
        InitializeComponent()
        interactionCombo.DropDownStyle = ComboBoxStyle.DropDownList
        interactionCombo.SelectedIndex = 1
        interactionCombo.Refresh()
        close.Enabled = False
        markAll.Enabled = False
    End Sub
    Private Sub showMessages()
        Dim folders As Mailbox = client.GetMailboxTree()
        'Get inbox folder
        Dim inbox As Mailbox = Mailbox.Find(folders, "INBOX")
        Dim tmp As MessageCollection = client.GetAllMessageHeaders(inbox)
        For i As Integer = 0 To tmp.Count - 1
            Dim a As String = decodeCollection(tmp(i).Flags)
            messageList.Items.Add([String].Format("{0}. {1}  *** flags: {2}", tmp(i).UID, tmp(i).Header.Subject, a))
        Next
    End Sub
    Private Function decodeCollection(ByVal a As MessageFlagCollection) As String
        Dim b As String = ""
        For i As Integer = 0 To a.Count - 1
            b += a(i).ToString()
            b += "; "
        Next
        Return b
    End Function
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
            messageList.Items.Clear()
            showMessages()
            close.Enabled = True
            startAuthorization.Enabled = False
            markAll.Enabled = True
        Else
            MessageBox.Show("Login failed!")
        End If
    End Sub

    Private Sub close_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim response As CompletionResponse = DirectCast(client.Logout(), CompletionResponse)
        If response.CompletionResult = ECompletionResponseType.OK Then
            MessageBox.Show("Logout succeed!")
            close.Enabled = False
            startAuthorization.Enabled = True
        Else
            MessageBox.Show("Logout failed!")
        End If
    End Sub

    Private Sub markAll_Click(ByVal sender As Object, ByVal e As EventArgs)
        If messageList.Items.Count > 0 Then
            Dim selected As String = DirectCast(messageList.SelectedItem, String)
            If String.IsNullOrEmpty(selected) Then
                selected = DirectCast(messageList.Items(0), String)
            End If
            Dim cnt As Integer = selected.IndexOf("."c)
            Dim id As UInteger = Convert.ToUInt32(selected.Remove(cnt))
            Dim folders As Mailbox = client.GetMailboxTree()
            'Get inbox folder
            Dim inbox As Mailbox = Mailbox.Find(folders, "INBOX")
            Dim sequence As ISequence = New SequenceNumber(id)
            Dim flags As New MessageFlagCollection()
            flags.Add(New MessageFlag(EFlag.Seen))
            'Set message flags
            ' message id collection
            ' mailbox folder
            ' message collection flags
            ' flag update mode
            Dim response As CompletionResponse = DirectCast(client.SetMessageFlags(sequence, inbox, flags, EFlagMode.Add), CompletionResponse)
            messageList.Items.Clear()
            showMessages()
        Else
            MessageBox.Show("Empty mailbox! Can not mark message!")
            markAll.Enabled = False
        End If
    End Sub

End Class
