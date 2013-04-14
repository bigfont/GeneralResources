Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Email.NET.POP3.Command
Imports Email.NET.POP3
Imports Email.NET.Common
Imports Email.NET.Common.Configurations

Public Partial Class Demo
	Inherits Form
	Public Sub New()
		InitializeComponent()
		interactionCombo.Items.AddRange(New Object() {EInteractionType.Plain, EInteractionType.SSLPort, EInteractionType.StartTLS})
		interactionCombo.DropDownStyle = ComboBoxStyle.DropDownList
		authentificationCombo.DropDownStyle = ComboBoxStyle.DropDownList
		authentificationCombo.Items.AddRange(New Object() {EAuthenticationType.None, EAuthenticationType.Auto, EAuthenticationType.Plain, EAuthenticationType.CramMD5, EAuthenticationType.DigestMD5, EAuthenticationType.Login})
		interactionCombo.SelectedIndex = 1
		interactionCombo.Refresh()
		authentificationCombo.SelectedIndex = 2
		interactionCombo.Refresh()
	End Sub

	Private Sub close_Click(sender As Object, e As EventArgs)
		Close()
	End Sub

	Private Sub startAuthorization_Click(sender As Object, e As EventArgs)
		'Create POP3 client, with parameters needed
		'URL of host to connect to
		target.Host = hostBox.Text
		'TCP port for connection
		target.Port = CUShort(Math.Truncate(portNum.Value))
		'Username to login to the POP3 server
		target.Username = loginBox.Text
		'Password to login to the POP3 server
		target.Password = passwordBox.Text
		target.SSLInteractionType = CType(interactionCombo.SelectedItem, EInteractionType)
		target.AuthenticationType = CType(authentificationCombo.SelectedItem, EAuthenticationType)
		'Login to the server
		Dim response As POP3Response = target.Login()
		If response.Type = EPOP3ResponseType.OK Then
			MessageBox.Show("Authorization succeed.", "All finished", MessageBoxButtons.OK)
		Else
			MessageBox.Show("Authorization failed", "All finished", MessageBoxButtons.OK)
		End If
		'Logout from the server
		target.Logout()
	End Sub
End Class
