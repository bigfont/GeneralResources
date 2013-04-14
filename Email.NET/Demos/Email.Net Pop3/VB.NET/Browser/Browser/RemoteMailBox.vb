Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Email.Net.Common
Imports Email.Net.Common.Collections
Imports Email.Net.Common.Configurations
Imports Email.Net.Pop3

Public Partial Class RemoteMailBox
	Inherits Form
	Public Sub New()
		InitializeComponent()
		cbAutentificationType.SelectedIndex = 1
		cbInteractionType.SelectedIndex = 0
		_client.AttachmentDirectory = "."
	End Sub

	Private Sub bLogin_Click(sender As Object, e As EventArgs)
		'Create POP3 client with parameters needed
		'URL of host to connect to
		_client.Host = tbHostname.Text
		'TCP port for connection
		_client.Port = CUShort(Math.Truncate(nPort.Value))
		'Username to login to the POP3 server
		_client.Username = tbLogin.Text
		'Password to login to the POP3 server
		_client.Password = tbPassword.Text
		'Interaction type for connection
		_client.SSLInteractionType = CType(cbInteractionType.SelectedIndex, EInteractionType)
		'Authentification type for authentification
		_client.AuthenticationType = CType(cbAutentificationType.SelectedIndex, EAuthenticationType)

		Try
			'Login to the server
			Dim response As Pop3Response = _client.Login()
			If response.Type = EPop3ResponseType.OK Then
				slStatus.Text = "Connected"
			Else
				MessageBox.Show("Error", [String].Format("Connection error:" & vbLf & " {0}", response.Message), MessageBoxButtons.OK, MessageBoxIcon.[Error])
				slStatus.Text = "Connection error"
			End If
			'Get messages for the server
			Dim messages As Rfc822MessageCollection = _client.GetAllMessages()

			FillMessageSList(messages)
		Catch ex As Exception
			slStatus.Text = "Error: " & ex.Message
		End Try

		Try
			'Logout from the server
			_client.Logout()
		Catch
		End Try
	End Sub

	Private Sub FillMessageSList(messages As Rfc822MessageCollection)
		'Clear messages list
		lvMessageBrowser.Items.Clear()

		'Adding messages to list
		For Each message As Rfc822Message In messages
			'Get message's subject and date
            Dim subject As String
            If (message.Subject IsNot Nothing) Then
                subject = message.Subject
            Else
                subject = "n/a"
            End If

            Dim [date] As String = message.[Date].ToString("yyyy-MM-dd HH:mm:ss")
            'Creating new ListView item
            Dim item As New ListViewItem(message.From.ToString())
            'Filling item
            item.Tag = message
            item.SubItems.Add(subject)
            item.SubItems.Add([date])
            'Adding item
            lvMessageBrowser.Items.Add(item)
        Next
	End Sub

	Private Sub lvMessageBrowser_DoubleClick(sender As Object, e As EventArgs)
		If lvMessageBrowser.SelectedItems.Count > 0 Then
			'Showing received message
			Dim viewer As New MessageViewer(DirectCast(lvMessageBrowser.SelectedItems(0).Tag, Rfc822Message))
			viewer.ShowDialog()
		End If
	End Sub
End Class
