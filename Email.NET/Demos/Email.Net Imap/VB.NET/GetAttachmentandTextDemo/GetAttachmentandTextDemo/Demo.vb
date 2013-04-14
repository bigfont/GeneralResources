Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Email.Net.Common.Configurations
Imports Email.Net.Imap.Responses
Imports Email.Net.Imap.Collections
Imports Email.Net.Imap
Imports Email.Net.Imap.MessagePart

Public Partial Class Demo
	Inherits Form
    Private inbox As Mailbox
    Private msg As Email.Net.Imap.ImapMessage

	Public Sub New()
		InitializeComponent()
		interactionCombo.Items.AddRange(New Object() {EInteractionType.Plain, EInteractionType.SSLPort, EInteractionType.StartTLS})
		interactionCombo.DropDownStyle = ComboBoxStyle.DropDownList
		interactionCombo.SelectedIndex = 1
		interactionCombo.Refresh()
		logoutButton.Enabled = False
		receiveAttachment.Enabled = False
	End Sub
	Private Sub showMessages()
		'Show all messages into inbox mailbox
        Dim folders As Mailbox = client.GetMailboxTree()
		'Get inbox folder
        inbox = Mailbox.Find(folders, "INBOX")
        Dim tmp As MessageCollection = client.GetAllMessageHeaders(inbox)
        For Each x As ImapMessage In tmp
            messageList.Items.Add([String].Format("{0}. {1}", x.UID, x.Header.Subject))
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
		'Interaction type
		client.SSLInteractionType = CType(interactionCombo.SelectedItem, EInteractionType)
		'Login to the server
        Dim response As CompletionResponse = DirectCast(client.Login(), CompletionResponse)
        If response.CompletionResult = ECompletionResponseType.OK Then
            MessageBox.Show("Login succeed!")
            messageList.Items.Clear()
            showMessages()
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
            messageList.Items.Clear()
            messageTextBox.Clear()
            attachmentBox.Items.Clear()
            attachmentBox.Refresh()
            receiveAttachment.Enabled = False
        Else
            MessageBox.Show("Logout failed!")
        End If
	End Sub

	Private Sub messageList_SelectedIndexChanged(sender As Object, e As EventArgs)
		'Show message text and attachment list
		receiveAttachment.Enabled = False
		attachmentBox.Items.Clear()
		messageTextBox.Clear()
		Dim selected As String = DirectCast(messageList.SelectedItem, String)
		Dim cnt As Integer = selected.IndexOf("."C)
		Dim id As UInteger = Convert.ToUInt32(selected.Remove(cnt))
		'Receive and show message text
		msg = client.GetMessageText(id, inbox)
		messageTextBox.Text = msg.PlainText
		'If there are any attachments, show list of them
		If msg.Attachments.Count > 0 Then
			For i As Integer = 0 To msg.Attachments.Count - 1
                attachmentBox.Items.Add([String].Format("{0}.{1}", msg.GetPartIndex(msg.GetPartByAttachment(msg.Attachments(i))), msg.Attachments(i).TransferFilename))
			Next
			attachmentBox.DropDownStyle = ComboBoxStyle.DropDownList
			attachmentBox.SelectedIndex = 0
			attachmentBox.Refresh()
			receiveAttachment.Enabled = True
		End If
	End Sub

	Private Sub receiveAttachment_Click(sender As Object, e As EventArgs)
		'Save attachment to disk
		Dim selected As String = DirectCast(attachmentBox.SelectedItem, String)
		Dim partID As String = selected.Remove(selected.IndexOf("."))
        Dim attach As Email.Net.Common.MessageParts.Attachment = Nothing
		For i As Integer = 0 To msg.Attachments.Count - 1
            If msg.GetPartIndex(msg.GetPartByAttachment(msg.Attachments(i))) = partID Then
                attach = msg.Attachments(i)
            End If
		Next
		If attach IsNot Nothing Then
			'Get attachment needed 
            Dim tmp As Email.Net.Common.MessageParts.Attachment = client.GetAttachment(inbox, msg, attach)
			'Show attachment name
            MessageBox.Show(String.Format("Attachment saved at: {0}", tmp.DiskFilename))
		End If
	End Sub
End Class
