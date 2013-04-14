Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Email.Net.Imap
Imports Email.Net.Common.Collections
Imports Email.Net.Common.Configurations
Imports Email.Net.Imap.Responses
Imports Email.Net.Imap.Collections

Public Partial Class Demo
    Inherits Form
    Dim b As String
    Dim tmp1 As ImapMessage
	Public Sub New()
		InitializeComponent()
		interactionCombo.Items.AddRange(New Object() {EInteractionType.Plain, EInteractionType.SSLPort, EInteractionType.StartTLS})
		interactionCombo.DropDownStyle = ComboBoxStyle.DropDownList
		interactionCombo.SelectedIndex = 1
		interactionCombo.Refresh()
		finishButton.Enabled = False
		getMessage.Enabled = False
	End Sub
	Private Sub showMessages()
		messageList.Items.Clear()
		messageList.Refresh()
        Dim folders As Mailbox = client.GetMailboxTree()
		'Get inbox folder
        Dim inbox As Mailbox = Mailbox.Find(folders, "INBOX")
        Dim ar As IAsyncResult = client.BeginGetAllMessageHeaders(inbox, AddressOf callback)

	End Sub
	Private Sub callback(ar As IAsyncResult)
		'This is method, which will be called after receiving
        Dim tmp As MessageCollection = client.EndGetAllMessageHeaders(ar)
		For i As Integer = 0 To tmp.Count - 1
            b = decodeCollection(tmp(i).Flags)
            tmp1 = tmp(i)
            Dim invoker As MethodInvoker = AddressOf MySub
            Me.Invoke(invoker)
        Next

    End Sub

    Sub MySub()
        messageList.Items.Add([String].Format("{0}.{1} *** flags: {2}", tmp1.UID, tmp1.Header.Subject, b))
        messageList.Refresh()
        getMessage.Enabled = True
    End Sub

    Private Function decodeCollection(ByVal a As MessageFlagCollection) As String
        Dim b As String = ""
        For i As Integer = 0 To a.Count - 1
            b += a(i).ToString()
            b += "; "
        Next
        Return b
    End Function
    Private Sub startButton_Click(ByVal sender As Object, ByVal e As EventArgs)
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
        client.SSLInteractionType = CType(interactionCombo.SelectedItem, EInteractionType)
        'Login to the server
        Dim response As CompletionResponse = DirectCast(client.Login(), CompletionResponse)
        If response.CompletionResult = ECompletionResponseType.OK Then
            MessageBox.Show("Login succeed!")
            messageList.Items.Clear()
            showMessages()
            finishButton.Enabled = True
            startButton.Enabled = False
        Else
            MessageBox.Show("Login failed!")
        End If

    End Sub

    Private Sub finishButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim response As CompletionResponse = DirectCast(client.Logout(), CompletionResponse)
        If response.CompletionResult = ECompletionResponseType.OK Then
            MessageBox.Show("Logout succeed!")
            finishButton.Enabled = False
            startButton.Enabled = True
            getMessage.Enabled = False
            messageList.Items.Clear()
            messageList.Refresh()
            messageTextBox.Clear()
        Else
            MessageBox.Show("Logout failed!")
        End If
    End Sub

    Private Sub getMessage_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Get all messages to know the uid
        Dim folders As Mailbox = client.GetMailboxTree()
        'Get inbox folder
        Dim inbox As Mailbox = Mailbox.Find(folders, "INBOX")
        Dim selected As String = DirectCast(messageList.SelectedItem, String)
        If selected Is Nothing Then
            selected = DirectCast(messageList.Items(0), String)
        End If
        Dim cnt As Integer = selected.IndexOf("."c)
        Dim uid As UInteger = Convert.ToUInt32(selected.Remove(cnt))
        'Get message from the server
        Dim ar As IAsyncResult = client.BeginGetMessageText(uid, inbox, AddressOf callbackOne)
    End Sub
    Private Sub callbackOne(ByVal ar As IAsyncResult)
        'This is method, which will be called after receiving
        tmp1 = client.EndGetMessageText(ar)
        Dim invoker As MethodInvoker = AddressOf MySub1
        Me.Invoke(invoker)
    End Sub
    Sub MySub1()
        messageTextBox.Text = String.Format("Message subject: {0}" & vbCr & vbLf & "Message text: " & vbCr & vbLf & "{1}" & vbCr & vbLf, tmp1.Header.Subject, tmp1.PlainText)
    End Sub
End Class
