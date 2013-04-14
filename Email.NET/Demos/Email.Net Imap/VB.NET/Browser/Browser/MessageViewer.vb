Imports System.Windows.Forms
Imports Email.Net.Common
Imports Email.Net.Common.MessageParts
Imports Email.Net.Imap

Public Partial Class MessageViewer
	Inherits Form
	Public Sub New(message As ImapMessage)
		InitializeComponent()
		Fill(message)
	End Sub

	Private Sub Fill(message As ImapMessage)
		'Clearing attachment's list
		lvAttachments.Items.Clear()

		'Get message's subject, from, to and carbon copy
		tbFrom.Text = message.From.ToString()
        If message.[To].Count > 0 Then
            tbTo.Text = message.[To](0).ToString()
        Else
            tbTo.Text = ""
        End If

        If message.CarbonCopies.Count > 0 Then
            tbCc.Text = message.CarbonCopies(0).ToString()
        Else
            tbCc.Text = ""
        End If

        tbSubject.Text = message.Subject

        'if html message
        If message.TextContentType = ETextContentType.Html Then
            'filling bodys
            wbBody.DocumentText = message.Text
            tbBody.Text = message.PlainText
        Else
            'if text message
            'filling bodys
            tbBody.Text = message.Text
        End If

        'filling attachment's list
        For Each attachment As Attachment In message.Attachments
            'Create ListView item
            Dim item As New ListViewItem(attachment.TransferFilename)
            item.SubItems.Add(attachment.ContentType.ToString())
            'Adding item to attachmetn's list
            lvAttachments.Items.Add(item)
        Next
    End Sub
End Class
