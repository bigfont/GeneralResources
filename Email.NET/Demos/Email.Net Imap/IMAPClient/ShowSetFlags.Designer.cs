namespace ImapClientExample
{
	partial class ShowSetFlags
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
			this.lbFlags1 = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnDel = new System.Windows.Forms.Button();
			this.lbFlags2 = new System.Windows.Forms.ListBox();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.btnAddAll = new System.Windows.Forms.Button();
			this.btnDelAll = new System.Windows.Forms.Button();
			this.btnSet = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbFlags1
			// 
			this.lbFlags1.FormattingEnabled = true;
			this.lbFlags1.Location = new System.Drawing.Point(8, 50);
			this.lbFlags1.Name = "lbFlags1";
			this.lbFlags1.Size = new System.Drawing.Size(120, 186);
			this.lbFlags1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "label1";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Mode: ";
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(134, 88);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(28, 23);
			this.btnAdd.TabIndex = 3;
			this.btnAdd.Text = "<";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnDel
			// 
			this.btnDel.Location = new System.Drawing.Point(134, 159);
			this.btnDel.Name = "btnDel";
			this.btnDel.Size = new System.Drawing.Size(28, 23);
			this.btnDel.TabIndex = 4;
			this.btnDel.Text = ">";
			this.btnDel.UseVisualStyleBackColor = true;
			this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
			// 
			// lbFlags2
			// 
			this.lbFlags2.FormattingEnabled = true;
			this.lbFlags2.Location = new System.Drawing.Point(168, 50);
			this.lbFlags2.Name = "lbFlags2";
			this.lbFlags2.Size = new System.Drawing.Size(120, 186);
			this.lbFlags2.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(168, 33);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "label3";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Add Flags",
            "Delete Flags",
            "Set Flags"});
			this.comboBox1.Location = new System.Drawing.Point(58, 6);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(108, 21);
			this.comboBox1.TabIndex = 7;
			// 
			// btnAddAll
			// 
			this.btnAddAll.Location = new System.Drawing.Point(134, 117);
			this.btnAddAll.Name = "btnAddAll";
			this.btnAddAll.Size = new System.Drawing.Size(28, 23);
			this.btnAddAll.TabIndex = 8;
			this.btnAddAll.Text = "<<";
			this.btnAddAll.UseVisualStyleBackColor = true;
			this.btnAddAll.Click += new System.EventHandler(this.btnAddAll_Click);
			// 
			// btnDelAll
			// 
			this.btnDelAll.Location = new System.Drawing.Point(134, 188);
			this.btnDelAll.Name = "btnDelAll";
			this.btnDelAll.Size = new System.Drawing.Size(28, 23);
			this.btnDelAll.TabIndex = 9;
			this.btnDelAll.Text = ">>";
			this.btnDelAll.UseVisualStyleBackColor = true;
			this.btnDelAll.Click += new System.EventHandler(this.btnDelAll_Click);
			// 
			// btnSet
			// 
			this.btnSet.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnSet.Location = new System.Drawing.Point(8, 242);
			this.btnSet.Name = "btnSet";
			this.btnSet.Size = new System.Drawing.Size(120, 23);
			this.btnSet.TabIndex = 10;
			this.btnSet.Text = "Set flags";
			this.btnSet.UseVisualStyleBackColor = true;
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(168, 242);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(120, 23);
			this.btnCancel.TabIndex = 11;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// ShowSetFlags
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(297, 273);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSet);
			this.Controls.Add(this.btnDelAll);
			this.Controls.Add(this.btnAddAll);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lbFlags2);
			this.Controls.Add(this.btnDel);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lbFlags1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "ShowSetFlags";
			this.Text = "ShowSetFlags";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox lbFlags1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnDel;
		private System.Windows.Forms.ListBox lbFlags2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button btnAddAll;
		private System.Windows.Forms.Button btnDelAll;
		private System.Windows.Forms.Button btnSet;
		private System.Windows.Forms.Button btnCancel;
	}
}