Partial Class Verify
	''' <summary>
	''' Required designer variable.
	''' </summary>
	Private components As System.ComponentModel.IContainer = Nothing

	''' <summary>
	''' Clean up any resources being used.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(disposing As Boolean)
		If disposing AndAlso (components IsNot Nothing) Then
			components.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub

	#Region "Windows Form Designer generated code"

	''' <summary>
	''' Required method for Designer support - do not modify
	''' the contents of this method with the code editor.
	''' </summary>
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.tbEmail = New System.Windows.Forms.TextBox()
		Me.epAddressChecker = New System.Windows.Forms.ErrorProvider(Me.components)
		Me.bCheck = New System.Windows.Forms.Button()
		DirectCast(Me.epAddressChecker, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		' 
		' tbEmail
		' 
		Me.tbEmail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbEmail.Location = New System.Drawing.Point(12, 12)
		Me.tbEmail.Name = "tbEmail"
		Me.tbEmail.Size = New System.Drawing.Size(238, 20)
		Me.tbEmail.TabIndex = 0
		' 
		' epAddressChecker
		' 
		Me.epAddressChecker.ContainerControl = Me
		' 
		' bCheck
		' 
		Me.bCheck.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.bCheck.Location = New System.Drawing.Point(273, 12)
		Me.bCheck.Name = "bCheck"
		Me.bCheck.Size = New System.Drawing.Size(56, 23)
		Me.bCheck.TabIndex = 1
		Me.bCheck.Text = "Check"
		Me.bCheck.UseVisualStyleBackColor = True
		AddHandler Me.bCheck.Click, New System.EventHandler(AddressOf Me.bCheck_Click)
		' 
		' Verify
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(341, 41)
		Me.Controls.Add(Me.bCheck)
		Me.Controls.Add(Me.tbEmail)
		Me.MaximizeBox = False
		Me.Name = "Verify"
		Me.ShowIcon = False
		Me.Text = "Verify address"
		DirectCast(Me.epAddressChecker, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	#End Region

	Private tbEmail As System.Windows.Forms.TextBox
	Private epAddressChecker As System.Windows.Forms.ErrorProvider
	Private bCheck As System.Windows.Forms.Button
End Class

