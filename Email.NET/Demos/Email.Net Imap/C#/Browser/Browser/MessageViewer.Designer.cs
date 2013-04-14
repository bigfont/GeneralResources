namespace Browser
{
	partial class MessageViewer
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.SplitContainer splitContainer1;
			this.tcMessage = new System.Windows.Forms.TabControl();
			this.tpMailMessage = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.label1 = new System.Windows.Forms.Label();
			this.tbFrom = new System.Windows.Forms.TextBox();
			this.tbTo = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbCc = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tbSubject = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.wbBody = new System.Windows.Forms.WebBrowser();
			this.lvAttachments = new System.Windows.Forms.ListView();
			this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.tbBody = new System.Windows.Forms.RichTextBox();
			this.chType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.tcMessage.SuspendLayout();
			this.tpMailMessage.SuspendLayout();
			this.tabPage2.SuspendLayout();
			splitContainer1.Panel1.SuspendLayout();
			splitContainer1.Panel2.SuspendLayout();
			splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tcMessage
			// 
			this.tcMessage.Controls.Add(this.tpMailMessage);
			this.tcMessage.Controls.Add(this.tabPage2);
			this.tcMessage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tcMessage.Location = new System.Drawing.Point(0, 0);
			this.tcMessage.Name = "tcMessage";
			this.tcMessage.SelectedIndex = 0;
			this.tcMessage.Size = new System.Drawing.Size(627, 374);
			this.tcMessage.TabIndex = 0;
			// 
			// tpMailMessage
			// 
			this.tpMailMessage.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.tpMailMessage.Controls.Add(splitContainer1);
			this.tpMailMessage.Controls.Add(this.tbSubject);
			this.tpMailMessage.Controls.Add(this.label4);
			this.tpMailMessage.Controls.Add(this.tbCc);
			this.tpMailMessage.Controls.Add(this.label3);
			this.tpMailMessage.Controls.Add(this.tbTo);
			this.tpMailMessage.Controls.Add(this.label2);
			this.tpMailMessage.Controls.Add(this.tbFrom);
			this.tpMailMessage.Controls.Add(this.label1);
			this.tpMailMessage.Location = new System.Drawing.Point(4, 22);
			this.tpMailMessage.Name = "tpMailMessage";
			this.tpMailMessage.Padding = new System.Windows.Forms.Padding(3);
			this.tpMailMessage.Size = new System.Drawing.Size(321, 348);
			this.tpMailMessage.TabIndex = 0;
			this.tpMailMessage.Text = "MailMessage";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.lvAttachments);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(619, 348);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Attachments";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(33, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "From:";
			// 
			// tbFrom
			// 
			this.tbFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tbFrom.Location = new System.Drawing.Point(50, 6);
			this.tbFrom.Name = "tbFrom";
			this.tbFrom.Size = new System.Drawing.Size(265, 20);
			this.tbFrom.TabIndex = 1;
			// 
			// tbTo
			// 
			this.tbTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tbTo.Location = new System.Drawing.Point(50, 32);
			this.tbTo.Name = "tbTo";
			this.tbTo.Size = new System.Drawing.Size(265, 20);
			this.tbTo.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(23, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "To:";
			// 
			// tbCc
			// 
			this.tbCc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tbCc.Location = new System.Drawing.Point(50, 58);
			this.tbCc.Name = "tbCc";
			this.tbCc.Size = new System.Drawing.Size(265, 20);
			this.tbCc.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 61);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(23, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Cc:";
			// 
			// tbSubject
			// 
			this.tbSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tbSubject.Location = new System.Drawing.Point(50, 84);
			this.tbSubject.Name = "tbSubject";
			this.tbSubject.Size = new System.Drawing.Size(265, 20);
			this.tbSubject.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 87);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(46, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Subject:";
			// 
			// wbBody
			// 
			this.wbBody.Dock = System.Windows.Forms.DockStyle.Fill;
			this.wbBody.Location = new System.Drawing.Point(0, 0);
			this.wbBody.MinimumSize = new System.Drawing.Size(20, 20);
			this.wbBody.Name = "wbBody";
			this.wbBody.Size = new System.Drawing.Size(310, 106);
			this.wbBody.TabIndex = 9;
			// 
			// lvAttachments
			// 
			this.lvAttachments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chType});
			this.lvAttachments.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvAttachments.Location = new System.Drawing.Point(3, 3);
			this.lvAttachments.Name = "lvAttachments";
			this.lvAttachments.Size = new System.Drawing.Size(613, 342);
			this.lvAttachments.TabIndex = 0;
			this.lvAttachments.UseCompatibleStateImageBehavior = false;
			this.lvAttachments.View = System.Windows.Forms.View.Details;
			// 
			// chName
			// 
			this.chName.Text = "Name";
			this.chName.Width = 150;
			// 
			// splitContainer1
			// 
			splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			splitContainer1.Location = new System.Drawing.Point(3, 110);
			splitContainer1.Name = "splitContainer1";
			splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			splitContainer1.Panel1.Controls.Add(this.wbBody);
			// 
			// splitContainer1.Panel2
			// 
			splitContainer1.Panel2.Controls.Add(this.tbBody);
			splitContainer1.Size = new System.Drawing.Size(310, 232);
			splitContainer1.SplitterDistance = 106;
			splitContainer1.TabIndex = 10;
			// 
			// tbBody
			// 
			this.tbBody.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbBody.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbBody.Location = new System.Drawing.Point(0, 0);
			this.tbBody.Name = "tbBody";
			this.tbBody.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
			this.tbBody.Size = new System.Drawing.Size(310, 122);
			this.tbBody.TabIndex = 0;
			this.tbBody.Text = "";
			// 
			// chType
			// 
			this.chType.Text = "Type";
			this.chType.Width = 150;
			// 
			// MessageViewer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(627, 374);
			this.Controls.Add(this.tcMessage);
			this.Name = "MessageViewer";
			this.Text = "Message viewer";
			this.tcMessage.ResumeLayout(false);
			this.tpMailMessage.ResumeLayout(false);
			this.tpMailMessage.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			splitContainer1.Panel1.ResumeLayout(false);
			splitContainer1.Panel2.ResumeLayout(false);
			splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tcMessage;
		private System.Windows.Forms.TabPage tpMailMessage;
		private System.Windows.Forms.WebBrowser wbBody;
		private System.Windows.Forms.TextBox tbSubject;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbCc;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbTo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbFrom;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.ListView lvAttachments;
		private System.Windows.Forms.ColumnHeader chName;
		private System.Windows.Forms.RichTextBox tbBody;
		private System.Windows.Forms.ColumnHeader chType;
	}
}