Imports Email.Net.Smtp

Public Class SendMessageForm
	Public Sub New()
		InitializeComponent()
	End Sub

	Private Sub btnChangeConfig_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnChangeConfig.Click
		smtpClient.Host = txtSmtpServer.Text
		smtpClient.Port = UShort.Parse(txtSmtpPort.Text)
		smtpClient.Username = txtSmtpLogin.Text
		smtpClient.Password = txtSmtpPassword.Text
		MessageBox.Show("Settings changed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
	End Sub

	Private Sub btnSendMessage_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSendMessage.Click
		Dim result As SendResult = smtpClient.SendOne(txtSenderAddress.Text, txtRecipientAddress.Text, txtSubject.Text, txtMessageText.Text)

		If result.IsSuccessful = True Then
			MessageBox.Show("Message sent successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
		Else
			MessageBox.Show("Some errors has happen during sending", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
		End If
	End Sub
End Class
