Imports System.Windows.Forms
Imports Email.NET.POP3

Public Partial Class Demo
	Inherits Form
	Private t As TimeSpan = TimeSpan.Zero

	Public Sub New()
		InitializeComponent()
	End Sub

	Private Sub startAuthorization_Click(sender As Object, e As EventArgs)
		'Noop function demo
		'URL of host to connect to
		target.Host = hostBox.Text
		'TCP port for connection
		target.Port = CUShort(Math.Truncate(portNum.Value))
		'Username to login to the POP3 server
		target.Username = loginBox.Text
		'Password to login to the POP3 server
		target.Password = passwordBox.Text

		'Login to the server
		target.Login()

		'Start the noopTimer
		noopTimer.Enabled = True
	End Sub

	Private Sub noopTimer_Tick(sender As Object, e As EventArgs)
		'Add elapsed time between two timer ticks
		t = t.Add(TimeSpan.FromMilliseconds(noopTimer.Interval))

		'Hold an open connection for 5 minutes
		If t > TimeSpan.FromMinutes(1) Then
			'Stop the noopTimer
			noopTimer.Enabled = False

			'Logout from the server
			target.Logout()
			messageTextBox.AppendText("Client have just logged out from the server" & vbCr & vbLf)
			Return
		End If

		'Check if another operation on target is executing right now
		SyncLock target
			If target.State <> EPop3ClientState.Busy Then
				target.Noop()
				messageTextBox.AppendText("Noop command sent to the server " & vbCr & vbLf)
			End If
		End SyncLock
	End Sub
End Class
