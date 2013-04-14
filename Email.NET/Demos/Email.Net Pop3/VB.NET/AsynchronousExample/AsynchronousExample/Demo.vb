Imports System.Windows.Forms
Imports Email.NET.POP3
Imports Email.NET.Common


Public Partial Class Demo
	Inherits Form
	Private AsyncMessageCount As Integer = 0

	Public Sub New()
		InitializeComponent()
		AddHandler target.MessageReceived, New Pop3MessageEventHandler(AddressOf target_MessageReceived)
	End Sub

	Private Sub getAllButton_Click(sender As Object, e As EventArgs)
		getOneButton.Enabled = False
		getAllButton.Enabled = False
		'Create POP3 client with parameters needed
		'URL of host to connect to
		target.Host = hostBox.Text
		'TCP port for connection
		target.Port = CUShort(Math.Truncate(portNum.Value))
		'Username to login to the POP3 server
		target.Username = loginBox.Text
		'Password to login to the POP3 server
		target.Password = passwordBox.Text
		AsyncMessageCount = 0
		'Login to the server
		Dim response As Pop3Response = target.Login()
		'Get message from the server (asynchronously)
			'delegate will be called when receiving finished
		Dim result As IAsyncResult = target.BeginRecv(AddressOf callBack)
	End Sub

	Private Sub target_MessageReceived(sender As Pop3Client, message As Rfc822Message)
		SyncLock Me
			AsyncMessageCount += 1
		End SyncLock
	End Sub

	Private Sub callBack(ar As IAsyncResult)
		'This is method, which will be called after receiving
		'Finish receiving
		target.EndRecv(ar)
		'Get number of messages, to check how much was got 
		'Logout from the server
		target.Logout()
        Dim invoker As MethodInvoker = AddressOf MySub
		Me.Invoke(invoker)
    End Sub

    Sub MySub()
        messageTextBox.AppendText([String].Format("Number of messages: {0} " & vbCr & vbLf, AsyncMessageCount))
        getOneButton.Enabled = True
        getAllButton.Enabled = True
    End Sub

    Private Sub closeButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        Close()
    End Sub

    Private Sub getOneButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        getAllButton.Enabled = False
        getOneButton.Enabled = False
        'Create POP3 client with parameters needed
        'URL of host to connect to
        target.Host = hostBox.Text
        'TCP port for connection
        target.Port = CUShort(Math.Truncate(portNum.Value))
        'Username to login to the POP3 server
        target.Username = loginBox.Text
        'Password to login to the POP3 server
        target.Password = passwordBox.Text
        'Login to the server
        Dim response As Pop3Response = target.Login()
        'Get message from the server (asynchronously)
        'messages numbers to receive
        'delegate will be called when receiving finished
        Dim result As IAsyncResult = target.BeginRecv(New UInteger() {CUInt(Math.Truncate(messageNumber.Value))}, AddressOf callBack)
    End Sub
End Class
