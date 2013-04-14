Partial Class MessageViewer
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
		Dim splitContainer1 As System.Windows.Forms.SplitContainer
		Me.tcMessage = New System.Windows.Forms.TabControl()
		Me.tpMailMessage = New System.Windows.Forms.TabPage()
		Me.tabPage2 = New System.Windows.Forms.TabPage()
		Me.label1 = New System.Windows.Forms.Label()
		Me.tbFrom = New System.Windows.Forms.TextBox()
		Me.tbTo = New System.Windows.Forms.TextBox()
		Me.label2 = New System.Windows.Forms.Label()
		Me.tbCc = New System.Windows.Forms.TextBox()
		Me.label3 = New System.Windows.Forms.Label()
		Me.tbSubject = New System.Windows.Forms.TextBox()
		Me.label4 = New System.Windows.Forms.Label()
		Me.wbBody = New System.Windows.Forms.WebBrowser()
		Me.lvAttachments = New System.Windows.Forms.ListView()
		Me.chName = DirectCast(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.tbBody = New System.Windows.Forms.RichTextBox()
		Me.chType = DirectCast(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		splitContainer1 = New System.Windows.Forms.SplitContainer()
		Me.tcMessage.SuspendLayout()
		Me.tpMailMessage.SuspendLayout()
		Me.tabPage2.SuspendLayout()
		splitContainer1.Panel1.SuspendLayout()
		splitContainer1.Panel2.SuspendLayout()
		splitContainer1.SuspendLayout()
		Me.SuspendLayout()
		' 
		' tcMessage
		' 
		Me.tcMessage.Controls.Add(Me.tpMailMessage)
		Me.tcMessage.Controls.Add(Me.tabPage2)
		Me.tcMessage.Dock = System.Windows.Forms.DockStyle.Fill
		Me.tcMessage.Location = New System.Drawing.Point(0, 0)
		Me.tcMessage.Name = "tcMessage"
		Me.tcMessage.SelectedIndex = 0
		Me.tcMessage.Size = New System.Drawing.Size(627, 374)
		Me.tcMessage.TabIndex = 0
		' 
		' tpMailMessage
		' 
		Me.tpMailMessage.BackColor = System.Drawing.SystemColors.ButtonFace
		Me.tpMailMessage.Controls.Add(splitContainer1)
		Me.tpMailMessage.Controls.Add(Me.tbSubject)
		Me.tpMailMessage.Controls.Add(Me.label4)
		Me.tpMailMessage.Controls.Add(Me.tbCc)
		Me.tpMailMessage.Controls.Add(Me.label3)
		Me.tpMailMessage.Controls.Add(Me.tbTo)
		Me.tpMailMessage.Controls.Add(Me.label2)
		Me.tpMailMessage.Controls.Add(Me.tbFrom)
		Me.tpMailMessage.Controls.Add(Me.label1)
		Me.tpMailMessage.Location = New System.Drawing.Point(4, 22)
		Me.tpMailMessage.Name = "tpMailMessage"
		Me.tpMailMessage.Padding = New System.Windows.Forms.Padding(3)
		Me.tpMailMessage.Size = New System.Drawing.Size(321, 348)
		Me.tpMailMessage.TabIndex = 0
		Me.tpMailMessage.Text = "MailMessage"
		' 
		' tabPage2
		' 
		Me.tabPage2.Controls.Add(Me.lvAttachments)
		Me.tabPage2.Location = New System.Drawing.Point(4, 22)
		Me.tabPage2.Name = "tabPage2"
		Me.tabPage2.Padding = New System.Windows.Forms.Padding(3)
		Me.tabPage2.Size = New System.Drawing.Size(619, 348)
		Me.tabPage2.TabIndex = 1
		Me.tabPage2.Text = "Attachments"
		Me.tabPage2.UseVisualStyleBackColor = True
		' 
		' label1
		' 
		Me.label1.AutoSize = True
		Me.label1.Location = New System.Drawing.Point(6, 9)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(33, 13)
		Me.label1.TabIndex = 0
		Me.label1.Text = "From:"
		' 
		' tbFrom
		' 
		Me.tbFrom.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbFrom.Location = New System.Drawing.Point(50, 6)
		Me.tbFrom.Name = "tbFrom"
		Me.tbFrom.Size = New System.Drawing.Size(265, 20)
		Me.tbFrom.TabIndex = 1
		' 
		' tbTo
		' 
		Me.tbTo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbTo.Location = New System.Drawing.Point(50, 32)
		Me.tbTo.Name = "tbTo"
		Me.tbTo.Size = New System.Drawing.Size(265, 20)
		Me.tbTo.TabIndex = 3
		' 
		' label2
		' 
		Me.label2.AutoSize = True
		Me.label2.Location = New System.Drawing.Point(6, 35)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(23, 13)
		Me.label2.TabIndex = 2
		Me.label2.Text = "To:"
		' 
		' tbCc
		' 
		Me.tbCc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbCc.Location = New System.Drawing.Point(50, 58)
		Me.tbCc.Name = "tbCc"
		Me.tbCc.Size = New System.Drawing.Size(265, 20)
		Me.tbCc.TabIndex = 5
		' 
		' label3
		' 
		Me.label3.AutoSize = True
		Me.label3.Location = New System.Drawing.Point(6, 61)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(23, 13)
		Me.label3.TabIndex = 4
		Me.label3.Text = "Cc:"
		' 
		' tbSubject
		' 
		Me.tbSubject.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbSubject.Location = New System.Drawing.Point(50, 84)
		Me.tbSubject.Name = "tbSubject"
		Me.tbSubject.Size = New System.Drawing.Size(265, 20)
		Me.tbSubject.TabIndex = 7
		' 
		' label4
		' 
		Me.label4.AutoSize = True
		Me.label4.Location = New System.Drawing.Point(6, 87)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(46, 13)
		Me.label4.TabIndex = 6
		Me.label4.Text = "Subject:"
		' 
		' wbBody
		' 
		Me.wbBody.Dock = System.Windows.Forms.DockStyle.Fill
		Me.wbBody.Location = New System.Drawing.Point(0, 0)
		Me.wbBody.MinimumSize = New System.Drawing.Size(20, 20)
		Me.wbBody.Name = "wbBody"
		Me.wbBody.Size = New System.Drawing.Size(310, 106)
		Me.wbBody.TabIndex = 9
		' 
		' lvAttachments
		' 
		Me.lvAttachments.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chName, Me.chType})
		Me.lvAttachments.Dock = System.Windows.Forms.DockStyle.Fill
		Me.lvAttachments.Location = New System.Drawing.Point(3, 3)
		Me.lvAttachments.Name = "lvAttachments"
		Me.lvAttachments.Size = New System.Drawing.Size(613, 342)
		Me.lvAttachments.TabIndex = 0
		Me.lvAttachments.UseCompatibleStateImageBehavior = False
		Me.lvAttachments.View = System.Windows.Forms.View.Details
		' 
		' chName
		' 
		Me.chName.Text = "Name"
		Me.chName.Width = 150
		' 
		' splitContainer1
		' 
		splitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		splitContainer1.Location = New System.Drawing.Point(3, 110)
		splitContainer1.Name = "splitContainer1"
		splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
		' 
		' splitContainer1.Panel1
		' 
		splitContainer1.Panel1.Controls.Add(Me.wbBody)
		' 
		' splitContainer1.Panel2
		' 
		splitContainer1.Panel2.Controls.Add(Me.tbBody)
		splitContainer1.Size = New System.Drawing.Size(310, 232)
		splitContainer1.SplitterDistance = 106
		splitContainer1.TabIndex = 10
		' 
		' tbBody
		' 
		Me.tbBody.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.tbBody.Dock = System.Windows.Forms.DockStyle.Fill
		Me.tbBody.Location = New System.Drawing.Point(0, 0)
		Me.tbBody.Name = "tbBody"
		Me.tbBody.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
		Me.tbBody.Size = New System.Drawing.Size(310, 122)
		Me.tbBody.TabIndex = 0
		Me.tbBody.Text = ""
		' 
		' chType
		' 
		Me.chType.Text = "Type"
		Me.chType.Width = 150
		' 
		' MessageViewer
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(627, 374)
		Me.Controls.Add(Me.tcMessage)
		Me.Name = "MessageViewer"
		Me.Text = "Message viewer"
		Me.tcMessage.ResumeLayout(False)
		Me.tpMailMessage.ResumeLayout(False)
		Me.tpMailMessage.PerformLayout()
		Me.tabPage2.ResumeLayout(False)
		splitContainer1.Panel1.ResumeLayout(False)
		splitContainer1.Panel2.ResumeLayout(False)
		splitContainer1.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub

	#End Region

	Private tcMessage As System.Windows.Forms.TabControl
	Private tpMailMessage As System.Windows.Forms.TabPage
	Private wbBody As System.Windows.Forms.WebBrowser
	Private tbSubject As System.Windows.Forms.TextBox
	Private label4 As System.Windows.Forms.Label
	Private tbCc As System.Windows.Forms.TextBox
	Private label3 As System.Windows.Forms.Label
	Private tbTo As System.Windows.Forms.TextBox
	Private label2 As System.Windows.Forms.Label
	Private tbFrom As System.Windows.Forms.TextBox
	Private label1 As System.Windows.Forms.Label
	Private tabPage2 As System.Windows.Forms.TabPage
	Private lvAttachments As System.Windows.Forms.ListView
	Private chName As System.Windows.Forms.ColumnHeader
	Private tbBody As System.Windows.Forms.RichTextBox
	Private chType As System.Windows.Forms.ColumnHeader
End Class
