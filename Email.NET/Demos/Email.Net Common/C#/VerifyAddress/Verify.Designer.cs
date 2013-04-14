namespace VerifyAddress
{
	partial class Verify
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
			this.components = new System.ComponentModel.Container();
			this.tbEmail = new System.Windows.Forms.TextBox();
			this.epAddressChecker = new System.Windows.Forms.ErrorProvider(this.components);
			this.bCheck = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.epAddressChecker)).BeginInit();
			this.SuspendLayout();
			// 
			// tbEmail
			// 
			this.tbEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tbEmail.Location = new System.Drawing.Point(12, 12);
			this.tbEmail.Name = "tbEmail";
			this.tbEmail.Size = new System.Drawing.Size(238, 20);
			this.tbEmail.TabIndex = 0;
			// 
			// epAddressChecker
			// 
			this.epAddressChecker.ContainerControl = this;
			// 
			// bCheck
			// 
			this.bCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.bCheck.Location = new System.Drawing.Point(273, 12);
			this.bCheck.Name = "bCheck";
			this.bCheck.Size = new System.Drawing.Size(56, 23);
			this.bCheck.TabIndex = 1;
			this.bCheck.Text = "Check";
			this.bCheck.UseVisualStyleBackColor = true;
			this.bCheck.Click += new System.EventHandler(this.bCheck_Click);
			// 
			// Verify
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(341, 41);
			this.Controls.Add(this.bCheck);
			this.Controls.Add(this.tbEmail);
			this.MaximizeBox = false;
			this.Name = "Verify";
			this.ShowIcon = false;
			this.Text = "Verify address";
			((System.ComponentModel.ISupportInitialize)(this.epAddressChecker)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbEmail;
		private System.Windows.Forms.ErrorProvider epAddressChecker;
		private System.Windows.Forms.Button bCheck;
	}
}

