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
Imports System.Threading

Public Partial Class Demo
	Inherits Form
	Public Sub New()
		InitializeComponent()
		interactionCombo.DropDownStyle = ComboBoxStyle.DropDownList
		interactionCombo.SelectedIndex = 1
		interactionCombo.Refresh()
		close.Enabled = False
	End Sub
	Private Sub InitNoopTimer()
		Const  noopTimeout As Integer = 180
		'Create a timer which will send noop commands
		Dim timer As New System.Threading.Timer(AddressOf callback, client, Timeout.Infinite, noopTimeout)
		'Run timer
		timer.Change(0, noopTimeout)
	End Sub

	Private Sub callback(state As Object)
		'Method which will send noop command on timer event
        client = DirectCast(state, ImapClient)
		'Actualy sends noop command
        Dim response As CompletionResponse = client.Noop()
        If response.CompletionResult = ECompletionResponseType.OK Then
            AppendLogMessage("NoOp sent to server. " & vbCr & vbLf)
        Else
            messageBox.AppendText("NoOp failed " & vbCr & vbLf)
        End If
	End Sub

	Private Delegate Sub AppendLogMessageDelegate(text As String)

	Private Sub AppendLogMessage(text As String)
		If InvokeRequired Then
			Invoke(New AppendLogMessageDelegate(AddressOf AppendLogMessage), New Object() {text})
		Else
			messageBox.AppendText(text)
		End If
	End Sub

	Private Sub startAuthorization_Click(sender As Object, e As EventArgs)
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
            InitNoopTimer()
            close.Enabled = True
            startAuthorization.Enabled = False
        Else
            Windows.Forms.MessageBox.Show("Login failed!")
        End If

	End Sub

	Private Sub close_Click(sender As Object, e As EventArgs)
        Dim response As CompletionResponse = DirectCast(client.Logout(), CompletionResponse)
        If response.CompletionResult = ECompletionResponseType.OK Then
            Windows.Forms.MessageBox.Show("Logout succeed!")
            close.Enabled = False
            startAuthorization.Enabled = True
        Else
            Windows.Forms.MessageBox.Show("Logout failed!")
        End If
	End Sub
End Class
