Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Email.NET.Common
Imports Email.NET.Common.Collections
Imports Email.NET.Smtp

Public Partial Class Demo
	Inherits Form
	Private message1 As MailMessage
	Public Sub New()
		InitializeComponent()
		sendMessage.Enabled = False
		subjectBox.Text = "First message subject"
	End Sub

	Private Sub messageComplete_Click(sender As Object, e As EventArgs)
		Dim addressCollection As New EmailAddressCollection()
		addressCollection.Add(New EmailAddress(toBox.Text))
		'Create 1st message
		'Source address
		'Address of the recipient
		'Message subject
			'Message text
		message1 = New SmtpMessage(New EmailAddress(fromBox.Text), addressCollection, subjectBox.Text, messageBox.Text)
		sendMessage.Enabled = True
		messageComplete.Enabled = False
		messageBox.Text = "You've finished 1st message creation. Please insert data for 2nd message."
		subjectBox.Text = "Second message subject"
	End Sub

	Private Sub sendMessage_Click(sender As Object, e As EventArgs)
		'Create and send several (2) messages
		'SMTP client settings
		'URL of host to connect to
		target.Host = hostBox.Text
		'TCP port for connection
		target.Port = CUShort(Math.Truncate(portNum.Value))
		'Username to login to the SMTP server
		target.Username = loginBox.Text
		'Password to login to the SMTP server
		target.Password = passwordBox.Text
		'Creating address and message 
		Dim addressCollection As New EmailAddressCollection()
		addressCollection.Add(New EmailAddress(toBox.Text))
		'Create 2nd message
		'Source address
		'Address of the recipient
		'Message subject
			'Message text
		Dim message2 As New SmtpMessage(New EmailAddress(fromBox.Text), addressCollection, subjectBox.Text, messageBox.Text)
		'Create bunch of the messages 
		Dim bunch As MailMessage() = New MailMessage() {message1, message2}
		Dim result As IList(Of SendResult) = target.SendSome(bunch)
		'Send message
		Dim i As Integer = 0
		For Each x As SendResult In result
			If Not x.IsSuccessful Then
				i += 1
			End If
		Next
		If i > 0 Then
            Windows.Forms.MessageBox.Show("One of messages sent unsuccessfully.")
		Else
            Windows.Forms.MessageBox.Show("All messages sent successful.")
		End If
		messageBox.Text = "Some random text to create new message"
		subjectBox.Text = "Test message subject"
		messageComplete.Enabled = True
		sendMessage.Enabled = False
	End Sub
End Class
