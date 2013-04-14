Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports Email.Net.Common

Public Partial Class Verify
	Inherits Form
	Public Sub New()
		InitializeComponent()
	End Sub

	Private Sub bCheck_Click(sender As Object, e As EventArgs)
		Try
			'Create new email address
			Dim address As New EmailAddress(tbEmail.Text, "")
			'Delete error message
			epAddressChecker.SetError(tbEmail, "")
		Catch generatedExceptionName As Exception
			'Set error message
			epAddressChecker.SetError(tbEmail, "nonvalid email")
		End Try
	End Sub
End Class
