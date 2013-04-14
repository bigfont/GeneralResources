Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Email.NET.POP3
Imports Email.NET.Common
Imports Email.NET.Common.Configurations

Public Partial Class Demo
	Inherits Form
	Public Sub New()
		InitializeComponent()
		proxyTypeCombo.Items.AddRange(New Object() {EProxyType.No, EProxyType.SOCKS5, EProxyType.SOCKS4})
		proxyTypeCombo.DropDownStyle = ComboBoxStyle.DropDownList
		proxyTypeCombo.SelectedIndex = 1
		proxyTypeCombo.Refresh()
	End Sub

	Private Sub startAuthorization_Click(sender As Object, e As EventArgs)
		'Proxy authorization
		'Create new Configuration provider to connect to proxy server
		'Initialize provider for proxy usage
		target.ProxyHost = proxyHostBox.Text
		target.ProxyPort = CUShort(Math.Truncate(proxyPortNum.Value))
		target.ProxyPassword = proxyPasswordBox.Text
		target.ProxyUser = proxyLoginBox.Text
		target.ProxyType = CType(proxyTypeCombo.SelectedItem, EProxyType)
		'Create POP3 client with parameters needed
		'URL of host to connect to
		target.Host = hostBox.Text
		'TCP port for connection
		target.Port = CUShort(Math.Truncate(portNum.Value))
		'Username to login to the POP3 server
		target.Username = loginBox.Text
		'Password to login to the POP3 server
		target.Password = passwordBox.Text
		target.AuthenticationType = EAuthenticationType.Auto
		Dim response As POP3Response = target.Login()
		If response.Type = EPOP3ResponseType.OK Then
			MessageBox.Show("Authorization succeed")
		Else
			MessageBox.Show("Authorization failed")
		End If
		'Logout from the server
		target.Logout()
	End Sub

	Private Sub close_Click(sender As Object, e As EventArgs)
		Close()
	End Sub
End Class
