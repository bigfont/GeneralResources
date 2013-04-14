Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Email.NET.Imap.Responses
Imports Email.NET.Imap
Imports Email.NET.Common.Configurations

Public Partial Class Demo
	Inherits Form
	Public Sub New()
		InitializeComponent()
		interactionCombo.Items.AddRange(New Object() {EInteractionType.Plain, EInteractionType.SSLPort, EInteractionType.StartTLS})
		interactionCombo.DropDownStyle = ComboBoxStyle.DropDownList
		interactionCombo.SelectedIndex = 1
		interactionCombo.Refresh()
		finishButton.Enabled = False
	End Sub

	Private Sub startButton_Click(sender As Object, e As EventArgs)
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
			finishButton.Enabled = True
			startButton.Enabled = False
			'Subscribe to events
			AddHandler client.MailboxStatusChanged, New Email.NET.Imap.Events.StateChangedEventHandler(AddressOf client_MailboxStatusChanged)
			AddHandler client.RecentChanged, New Email.NET.Imap.Events.StateChangedEventHandler(AddressOf client_RecentChanged)
			AddHandler client.ExistsChanged, New Email.NET.Imap.Events.StateChangedEventHandler(AddressOf client_ExistsChanged)
			'Select INBOX mailbox, as current
			client.[Select](Mailbox.Find(client.GetMailboxTree(), "INBOX"))
			timer.Start()
		End If

	End Sub

    Private Sub client_ExistsChanged(ByVal sender As ImapClient, ByVal activeMailBox As Mailbox)
        messageTextBox.AppendText("Exist changed" & vbCr & vbLf)
    End Sub

    Private Sub client_RecentChanged(ByVal sender As ImapClient, ByVal activeMailBox As Mailbox)
        messageTextBox.AppendText("Recent changed " & vbCr & vbLf)
    End Sub
    Private Sub client_MailboxStatusChanged(ByVal sender As ImapClient, ByVal activeMailBox As Mailbox)
        messageTextBox.AppendText("Mailbox status changed" & vbCr & vbLf)
    End Sub
	Public Sub sendNoop(sender As Object, e As EventArgs)
		'Send Noop command
		Dim response As CompletionResponse = client.Noop()
		If response.CompletionResult = ECompletionResponseType.OK Then
			messageTextBox.AppendText("Noop was sent" & vbCr & vbLf)
		Else
			messageTextBox.AppendText("Noop wasn't sent" & vbCr & vbLf)
		End If
	End Sub

	Private Sub finishButton_Click(sender As Object, e As EventArgs)
		'Logout from the server
		Dim response As CompletionResponse = DirectCast(client.Logout(), CompletionResponse)
		If response.CompletionResult = ECompletionResponseType.OK Then
			timer.[Stop]()
			MessageBox.Show("Logout succeed!")
			finishButton.Enabled = False
			startButton.Enabled = True

			messageTextBox.Clear()
		Else
			MessageBox.Show("Logout failed!")
		End If
	End Sub
End Class
