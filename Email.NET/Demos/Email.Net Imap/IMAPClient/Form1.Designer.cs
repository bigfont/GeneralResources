namespace ImapClientExample
{
	partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Tabs = new System.Windows.Forms.TabControl();
            this.MainTab = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.trFolders = new System.Windows.Forms.TreeView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnSelFolder = new System.Windows.Forms.Button();
            this.btnRenameFolder = new System.Windows.Forms.Button();
            this.ConnBtn = new System.Windows.Forms.Button();
            this.btnDeleteFolder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNewFolder = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.DisconnBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvMessages = new System.Windows.Forms.DataGridView();
            this.attachmentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seen = new System.Windows.Forms.DataGridViewImageColumn();
            this.Del = new System.Windows.Forms.DataGridViewImageColumn();
            this.Sel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Flag = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dsMess = new System.Data.DataSet();
            this.Messages = new System.Data.DataTable();
            this.AttachmentsCol = new System.Data.DataColumn();
            this.SubjectCol = new System.Data.DataColumn();
            this.FromCol = new System.Data.DataColumn();
            this.DateCol = new System.Data.DataColumn();
            this.UIDCol = new System.Data.DataColumn();
            this.SeenCol = new System.Data.DataColumn();
            this.dataColumn1 = new System.Data.DataColumn();
            this.Flags = new System.Data.DataColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnDelMess = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btnUpdateMess = new System.Windows.Forms.Button();
            this.AccountsTab = new System.Windows.Forms.TabPage();
            this.DelAccBtn = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SelAccbtn = new System.Windows.Forms.Button();
            this.cbSecType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NewBtn = new System.Windows.Forms.Button();
            this.SetBtn = new System.Windows.Forms.Button();
            this.txtPassw = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInServ = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAccName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbAcc = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SubscriptionsTab = new System.Windows.Forms.TabPage();
            this.btnDelSubs = new System.Windows.Forms.Button();
            this.btnAddSubs = new System.Windows.Forms.Button();
            this.trFolders2 = new System.Windows.Forms.TreeView();
            this.label12 = new System.Windows.Forms.Label();
            this.trSubs = new System.Windows.Forms.TreeView();
            this.label11 = new System.Windows.Forms.Label();
            this.btnGetSubs = new System.Windows.Forms.Button();
            this.tabSearch = new System.Windows.Forms.TabPage();
            this.dgvSearchMessages = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchFlag = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dsSearchMess = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataColumn7 = new System.Data.DataColumn();
            this.dataColumn8 = new System.Data.DataColumn();
            this.dataColumn9 = new System.Data.DataColumn();
            this.panel27 = new System.Windows.Forms.Panel();
            this.btnSSelFolder = new System.Windows.Forms.Button();
            this.txtSFolder = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.panel26 = new System.Windows.Forms.Panel();
            this.label34 = new System.Windows.Forms.Label();
            this.mtxtSSendSince = new System.Windows.Forms.MaskedTextBox();
            this.cbOrSendSince = new System.Windows.Forms.CheckBox();
            this.panel25 = new System.Windows.Forms.Panel();
            this.label33 = new System.Windows.Forms.Label();
            this.mtxtSSendOn = new System.Windows.Forms.MaskedTextBox();
            this.cbOrSendOn = new System.Windows.Forms.CheckBox();
            this.panel24 = new System.Windows.Forms.Panel();
            this.label32 = new System.Windows.Forms.Label();
            this.mtxtSSentBefore = new System.Windows.Forms.MaskedTextBox();
            this.cbOrSendBefore = new System.Windows.Forms.CheckBox();
            this.panel23 = new System.Windows.Forms.Panel();
            this.label31 = new System.Windows.Forms.Label();
            this.mtxtSSince = new System.Windows.Forms.MaskedTextBox();
            this.cbOrSince = new System.Windows.Forms.CheckBox();
            this.panel22 = new System.Windows.Forms.Panel();
            this.label30 = new System.Windows.Forms.Label();
            this.mtxtsOn = new System.Windows.Forms.MaskedTextBox();
            this.cbOrOn = new System.Windows.Forms.CheckBox();
            this.panel21 = new System.Windows.Forms.Panel();
            this.label29 = new System.Windows.Forms.Label();
            this.mtxtSBefore = new System.Windows.Forms.MaskedTextBox();
            this.cbOrBefore = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbRecent = new System.Windows.Forms.RadioButton();
            this.rbOld = new System.Windows.Forms.RadioButton();
            this.cbOrOldRecent = new System.Windows.Forms.CheckBox();
            this.panel20 = new System.Windows.Forms.Panel();
            this.txtSUID = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.cbOrUID = new System.Windows.Forms.CheckBox();
            this.panel19 = new System.Windows.Forms.Panel();
            this.txtSSmaller = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.cbOrSmaller = new System.Windows.Forms.CheckBox();
            this.panel18 = new System.Windows.Forms.Panel();
            this.txtSLarger = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.cbOrLarger = new System.Windows.Forms.CheckBox();
            this.panel17 = new System.Windows.Forms.Panel();
            this.txtSValue = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtSField = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.cbOrHeader = new System.Windows.Forms.CheckBox();
            this.panel16 = new System.Windows.Forms.Panel();
            this.txtSBody = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.cbOrBody = new System.Windows.Forms.CheckBox();
            this.panel15 = new System.Windows.Forms.Panel();
            this.txtSFrom = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.cbOrFrom = new System.Windows.Forms.CheckBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.txtSBlCopy = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.cbOrBlCopy = new System.Windows.Forms.CheckBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.txtSCopy = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cbOrCopy = new System.Windows.Forms.CheckBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.txtSTo = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cbOrTo = new System.Windows.Forms.CheckBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.txtSText = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cbOrText = new System.Windows.Forms.CheckBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txtSSubj = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cbOrSubj = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rbUnDraft = new System.Windows.Forms.RadioButton();
            this.rbDraft = new System.Windows.Forms.RadioButton();
            this.cbOrDraft = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbUnAns = new System.Windows.Forms.RadioButton();
            this.rbAnswered = new System.Windows.Forms.RadioButton();
            this.cbOrAns = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbUnDel = new System.Windows.Forms.RadioButton();
            this.rbDeleted = new System.Windows.Forms.RadioButton();
            this.cbOrDeleted = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rbUnFlagged = new System.Windows.Forms.RadioButton();
            this.rbFlagged = new System.Windows.Forms.RadioButton();
            this.cbOrFlagged = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbUnSeen = new System.Windows.Forms.RadioButton();
            this.rbSeen = new System.Windows.Forms.RadioButton();
            this.cbOrSeen = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.NoopLogTab = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lbNoopLog = new System.Windows.Forms.ListBox();
            this.lbLog = new System.Windows.Forms.ListBox();
            this.tabEvents = new System.Windows.Forms.TabPage();
            this.cbServerRespRec = new System.Windows.Forms.CheckBox();
            this.cbMessReceived = new System.Windows.Forms.CheckBox();
            this.cbAllMessReceived = new System.Windows.Forms.CheckBox();
            this.label36 = new System.Windows.Forms.Label();
            this.cbAuth = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblMess = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.NoopTimer = new System.Windows.Forms.Timer(this.components);
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel8 = new System.Windows.Forms.Panel();
            this.iClient = new Email.Net.Imap.ImapClient(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label37 = new System.Windows.Forms.Label();
            this.Tabs.SuspendLayout();
            this.MainTab.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Messages)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.AccountsTab.SuspendLayout();
            this.SubscriptionsTab.SuspendLayout();
            this.tabSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchMessages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSearchMess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            this.panel27.SuspendLayout();
            this.panel26.SuspendLayout();
            this.panel25.SuspendLayout();
            this.panel24.SuspendLayout();
            this.panel23.SuspendLayout();
            this.panel22.SuspendLayout();
            this.panel21.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel20.SuspendLayout();
            this.panel19.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.NoopLogTab.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabEvents.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.MainTab);
            this.Tabs.Controls.Add(this.AccountsTab);
            this.Tabs.Controls.Add(this.SubscriptionsTab);
            this.Tabs.Controls.Add(this.tabSearch);
            this.Tabs.Controls.Add(this.NoopLogTab);
            this.Tabs.Controls.Add(this.tabEvents);
            this.Tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tabs.Location = new System.Drawing.Point(0, 0);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(919, 380);
            this.Tabs.TabIndex = 4;
            // 
            // MainTab
            // 
            this.MainTab.Controls.Add(this.splitContainer1);
            this.MainTab.Location = new System.Drawing.Point(4, 22);
            this.MainTab.Name = "MainTab";
            this.MainTab.Padding = new System.Windows.Forms.Padding(3);
            this.MainTab.Size = new System.Drawing.Size(911, 354);
            this.MainTab.TabIndex = 0;
            this.MainTab.Text = "Main";
            this.MainTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.trFolders);
            this.splitContainer1.Panel1.Controls.Add(this.panel7);
            this.splitContainer1.Panel1.Controls.Add(this.panel6);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(905, 348);
            this.splitContainer1.SplitterDistance = 234;
            this.splitContainer1.TabIndex = 16;
            // 
            // trFolders
            // 
            this.trFolders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trFolders.HideSelection = false;
            this.trFolders.Location = new System.Drawing.Point(0, 63);
            this.trFolders.Name = "trFolders";
            this.trFolders.Size = new System.Drawing.Size(234, 255);
            this.trFolders.TabIndex = 2;
            this.trFolders.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trFolders_AfterSelect);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnSelFolder);
            this.panel7.Controls.Add(this.btnRenameFolder);
            this.panel7.Controls.Add(this.ConnBtn);
            this.panel7.Controls.Add(this.btnDeleteFolder);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.btnNewFolder);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(234, 63);
            this.panel7.TabIndex = 1;
            // 
            // btnSelFolder
            // 
            this.btnSelFolder.Location = new System.Drawing.Point(80, 35);
            this.btnSelFolder.Name = "btnSelFolder";
            this.btnSelFolder.Size = new System.Drawing.Size(35, 23);
            this.btnSelFolder.TabIndex = 15;
            this.btnSelFolder.Text = "Sel";
            this.btnSelFolder.UseVisualStyleBackColor = true;
            this.btnSelFolder.Click += new System.EventHandler(this.SelBtn_Click);
            // 
            // btnRenameFolder
            // 
            this.btnRenameFolder.Location = new System.Drawing.Point(158, 35);
            this.btnRenameFolder.Name = "btnRenameFolder";
            this.btnRenameFolder.Size = new System.Drawing.Size(39, 23);
            this.btnRenameFolder.TabIndex = 10;
            this.btnRenameFolder.Text = "Ren";
            this.btnRenameFolder.UseVisualStyleBackColor = true;
            this.btnRenameFolder.Click += new System.EventHandler(this.btnRenameFolder_Click);
            // 
            // ConnBtn
            // 
            this.ConnBtn.Location = new System.Drawing.Point(4, 3);
            this.ConnBtn.Name = "ConnBtn";
            this.ConnBtn.Size = new System.Drawing.Size(75, 23);
            this.ConnBtn.TabIndex = 0;
            this.ConnBtn.Text = "Connect";
            this.ConnBtn.UseVisualStyleBackColor = true;
            this.ConnBtn.Click += new System.EventHandler(this.ConnBtn_Click);
            // 
            // btnDeleteFolder
            // 
            this.btnDeleteFolder.Location = new System.Drawing.Point(200, 35);
            this.btnDeleteFolder.Name = "btnDeleteFolder";
            this.btnDeleteFolder.Size = new System.Drawing.Size(31, 23);
            this.btnDeleteFolder.TabIndex = 9;
            this.btnDeleteFolder.Text = "Del";
            this.btnDeleteFolder.UseVisualStyleBackColor = true;
            this.btnDeleteFolder.Click += new System.EventHandler(this.btnDeleteFolder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "All Folders:";
            // 
            // btnNewFolder
            // 
            this.btnNewFolder.Location = new System.Drawing.Point(117, 35);
            this.btnNewFolder.Name = "btnNewFolder";
            this.btnNewFolder.Size = new System.Drawing.Size(38, 23);
            this.btnNewFolder.TabIndex = 8;
            this.btnNewFolder.Text = "New";
            this.btnNewFolder.UseVisualStyleBackColor = true;
            this.btnNewFolder.Click += new System.EventHandler(this.btnNewFolder_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.DisconnBtn);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 318);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(234, 30);
            this.panel6.TabIndex = 0;
            // 
            // DisconnBtn
            // 
            this.DisconnBtn.Enabled = false;
            this.DisconnBtn.Location = new System.Drawing.Point(3, 3);
            this.DisconnBtn.Name = "DisconnBtn";
            this.DisconnBtn.Size = new System.Drawing.Size(75, 23);
            this.DisconnBtn.TabIndex = 1;
            this.DisconnBtn.Text = "Disconnect";
            this.DisconnBtn.UseVisualStyleBackColor = true;
            this.DisconnBtn.Click += new System.EventHandler(this.DisconnBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvMessages);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(667, 307);
            this.panel3.TabIndex = 1;
            // 
            // dgvMessages
            // 
            this.dgvMessages.AllowUserToAddRows = false;
            this.dgvMessages.AllowUserToDeleteRows = false;
            this.dgvMessages.AutoGenerateColumns = false;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMessages.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle31;
            this.dgvMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMessages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.attachmentsDataGridViewTextBoxColumn,
            this.subjectDataGridViewTextBoxColumn,
            this.fromDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.Seen,
            this.Del,
            this.Sel,
            this.Flag});
            this.dgvMessages.DataMember = "Messages";
            this.dgvMessages.DataSource = this.dsMess;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMessages.DefaultCellStyle = dataGridViewCellStyle32;
            this.dgvMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMessages.Location = new System.Drawing.Point(0, 0);
            this.dgvMessages.Name = "dgvMessages";
            this.dgvMessages.ReadOnly = true;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMessages.RowHeadersDefaultCellStyle = dataGridViewCellStyle33;
            this.dgvMessages.RowHeadersVisible = false;
            this.dgvMessages.RowTemplate.Height = 18;
            this.dgvMessages.Size = new System.Drawing.Size(667, 307);
            this.dgvMessages.TabIndex = 7;
            this.dgvMessages.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMessages_CellDoubleClick);
            this.dgvMessages.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvMessages_RowsAdded);
            this.dgvMessages.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMessages_CellClick);
            // 
            // attachmentsDataGridViewTextBoxColumn
            // 
            this.attachmentsDataGridViewTextBoxColumn.DataPropertyName = "Attachments";
            this.attachmentsDataGridViewTextBoxColumn.HeaderText = "Attachments";
            this.attachmentsDataGridViewTextBoxColumn.Name = "attachmentsDataGridViewTextBoxColumn";
            this.attachmentsDataGridViewTextBoxColumn.ReadOnly = true;
            this.attachmentsDataGridViewTextBoxColumn.Width = 15;
            // 
            // subjectDataGridViewTextBoxColumn
            // 
            this.subjectDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.subjectDataGridViewTextBoxColumn.DataPropertyName = "Subject";
            this.subjectDataGridViewTextBoxColumn.HeaderText = "Subject";
            this.subjectDataGridViewTextBoxColumn.Name = "subjectDataGridViewTextBoxColumn";
            this.subjectDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fromDataGridViewTextBoxColumn
            // 
            this.fromDataGridViewTextBoxColumn.DataPropertyName = "From";
            this.fromDataGridViewTextBoxColumn.HeaderText = "From";
            this.fromDataGridViewTextBoxColumn.Name = "fromDataGridViewTextBoxColumn";
            this.fromDataGridViewTextBoxColumn.ReadOnly = true;
            this.fromDataGridViewTextBoxColumn.Width = 150;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Seen
            // 
            this.Seen.HeaderText = "Seen";
            this.Seen.Image = global::ImapClientExample.Properties.Resources.seen1;
            this.Seen.Name = "Seen";
            this.Seen.ReadOnly = true;
            this.Seen.Width = 35;
            // 
            // Del
            // 
            this.Del.HeaderText = "Del";
            this.Del.Image = global::ImapClientExample.Properties.Resources.kor2;
            this.Del.Name = "Del";
            this.Del.ReadOnly = true;
            this.Del.Width = 35;
            // 
            // Sel
            // 
            this.Sel.HeaderText = "Sel";
            this.Sel.Name = "Sel";
            this.Sel.ReadOnly = true;
            this.Sel.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Sel.ToolTipText = "Sel";
            this.Sel.Width = 30;
            // 
            // Flag
            // 
            this.Flag.HeaderText = "Flag";
            this.Flag.Name = "Flag";
            this.Flag.ReadOnly = true;
            this.Flag.Text = "Flag";
            this.Flag.ToolTipText = "Look flags";
            this.Flag.UseColumnTextForButtonValue = true;
            this.Flag.Width = 30;
            // 
            // dsMess
            // 
            this.dsMess.DataSetName = "NewDataSet";
            this.dsMess.Tables.AddRange(new System.Data.DataTable[] {
            this.Messages});
            // 
            // Messages
            // 
            this.Messages.Columns.AddRange(new System.Data.DataColumn[] {
            this.AttachmentsCol,
            this.SubjectCol,
            this.FromCol,
            this.DateCol,
            this.UIDCol,
            this.SeenCol,
            this.dataColumn1,
            this.Flags});
            this.Messages.TableName = "Messages";
            // 
            // AttachmentsCol
            // 
            this.AttachmentsCol.ColumnName = "Attachments";
            // 
            // SubjectCol
            // 
            this.SubjectCol.ColumnName = "Subject";
            // 
            // FromCol
            // 
            this.FromCol.ColumnName = "From";
            // 
            // DateCol
            // 
            this.DateCol.ColumnName = "Date";
            // 
            // UIDCol
            // 
            this.UIDCol.ColumnName = "UID";
            this.UIDCol.DataType = typeof(uint);
            // 
            // SeenCol
            // 
            this.SeenCol.ColumnName = "Seen";
            this.SeenCol.DataType = typeof(int);
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "Del";
            this.dataColumn1.DataType = typeof(bool);
            this.dataColumn1.DefaultValue = false;
            // 
            // Flags
            // 
            this.Flags.Caption = "Flags";
            this.Flags.ColumnName = "Flags";
            this.Flags.DataType = typeof(object);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(667, 41);
            this.panel2.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnDelMess);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.comboBox1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(306, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(361, 41);
            this.panel5.TabIndex = 1;
            // 
            // btnDelMess
            // 
            this.btnDelMess.Location = new System.Drawing.Point(286, 12);
            this.btnDelMess.Name = "btnDelMess";
            this.btnDelMess.Size = new System.Drawing.Size(72, 23);
            this.btnDelMess.TabIndex = 11;
            this.btnDelMess.Text = "Del Marked";
            this.btnDelMess.UseVisualStyleBackColor = true;
            this.btnDelMess.Click += new System.EventHandler(this.btnDelMess_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(66, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Do with checked:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "None",
            "Copy To",
            "Mark Seen",
            "Mark UnSeen",
            "Mark To Delete",
            "Mark UnDelete",
            "SetFlags"});
            this.comboBox1.Location = new System.Drawing.Point(157, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.btnUpdateMess);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(175, 41);
            this.panel4.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Messages:";
            // 
            // btnUpdateMess
            // 
            this.btnUpdateMess.Location = new System.Drawing.Point(82, 9);
            this.btnUpdateMess.Name = "btnUpdateMess";
            this.btnUpdateMess.Size = new System.Drawing.Size(52, 23);
            this.btnUpdateMess.TabIndex = 14;
            this.btnUpdateMess.Text = "Update";
            this.btnUpdateMess.UseVisualStyleBackColor = true;
            this.btnUpdateMess.Click += new System.EventHandler(this.btnUpdateMess_Click);
            // 
            // AccountsTab
            // 
            this.AccountsTab.Controls.Add(this.DelAccBtn);
            this.AccountsTab.Controls.Add(this.label14);
            this.AccountsTab.Controls.Add(this.label13);
            this.AccountsTab.Controls.Add(this.SelAccbtn);
            this.AccountsTab.Controls.Add(this.cbSecType);
            this.AccountsTab.Controls.Add(this.label2);
            this.AccountsTab.Controls.Add(this.NewBtn);
            this.AccountsTab.Controls.Add(this.SetBtn);
            this.AccountsTab.Controls.Add(this.txtPassw);
            this.AccountsTab.Controls.Add(this.label7);
            this.AccountsTab.Controls.Add(this.txtLogin);
            this.AccountsTab.Controls.Add(this.label6);
            this.AccountsTab.Controls.Add(this.txtPort);
            this.AccountsTab.Controls.Add(this.label5);
            this.AccountsTab.Controls.Add(this.txtInServ);
            this.AccountsTab.Controls.Add(this.label4);
            this.AccountsTab.Controls.Add(this.txtAccName);
            this.AccountsTab.Controls.Add(this.label3);
            this.AccountsTab.Controls.Add(this.lbAcc);
            this.AccountsTab.Controls.Add(this.label8);
            this.AccountsTab.Location = new System.Drawing.Point(4, 22);
            this.AccountsTab.Name = "AccountsTab";
            this.AccountsTab.Padding = new System.Windows.Forms.Padding(3);
            this.AccountsTab.Size = new System.Drawing.Size(911, 354);
            this.AccountsTab.TabIndex = 1;
            this.AccountsTab.Text = "Accounts";
            this.AccountsTab.UseVisualStyleBackColor = true;
            // 
            // DelAccBtn
            // 
            this.DelAccBtn.Location = new System.Drawing.Point(8, 276);
            this.DelAccBtn.Name = "DelAccBtn";
            this.DelAccBtn.Size = new System.Drawing.Size(196, 23);
            this.DelAccBtn.TabIndex = 43;
            this.DelAccBtn.Text = "Remove Selected Account";
            this.DelAccBtn.UseVisualStyleBackColor = true;
            this.DelAccBtn.Click += new System.EventHandler(this.DelAccBtn_Click_1);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(296, 239);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 13);
            this.label14.TabIndex = 42;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(210, 239);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 13);
            this.label13.TabIndex = 41;
            this.label13.Text = "Used account: ";
            // 
            // SelAccbtn
            // 
            this.SelAccbtn.Location = new System.Drawing.Point(8, 234);
            this.SelAccbtn.Name = "SelAccbtn";
            this.SelAccbtn.Size = new System.Drawing.Size(196, 23);
            this.SelAccbtn.TabIndex = 40;
            this.SelAccbtn.Text = "Use Selected Account";
            this.SelAccbtn.UseVisualStyleBackColor = true;
            this.SelAccbtn.Click += new System.EventHandler(this.SelAccbtn_Click);
            // 
            // cbSecType
            // 
            this.cbSecType.FormattingEnabled = true;
            this.cbSecType.Items.AddRange(new object[] {
            "Plain",
            "SSL",
            "StartTsl"});
            this.cbSecType.Location = new System.Drawing.Point(297, 151);
            this.cbSecType.Name = "cbSecType";
            this.cbSecType.Size = new System.Drawing.Size(153, 21);
            this.cbSecType.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Security:";
            // 
            // NewBtn
            // 
            this.NewBtn.Location = new System.Drawing.Point(213, 196);
            this.NewBtn.Name = "NewBtn";
            this.NewBtn.Size = new System.Drawing.Size(88, 23);
            this.NewBtn.TabIndex = 36;
            this.NewBtn.Text = "Save as new";
            this.NewBtn.UseVisualStyleBackColor = true;
            this.NewBtn.Click += new System.EventHandler(this.NewBtn_Click);
            // 
            // SetBtn
            // 
            this.SetBtn.Location = new System.Drawing.Point(375, 196);
            this.SetBtn.Name = "SetBtn";
            this.SetBtn.Size = new System.Drawing.Size(75, 23);
            this.SetBtn.TabIndex = 35;
            this.SetBtn.Text = "Set changes";
            this.SetBtn.UseVisualStyleBackColor = true;
            this.SetBtn.Click += new System.EventHandler(this.SetBtn_Click);
            // 
            // txtPassw
            // 
            this.txtPassw.Location = new System.Drawing.Point(297, 98);
            this.txtPassw.Name = "txtPassw";
            this.txtPassw.Size = new System.Drawing.Size(153, 20);
            this.txtPassw.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(210, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Password:";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(297, 72);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(153, 20);
            this.txtLogin.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(210, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Login:";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(297, 124);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(153, 20);
            this.txtPort.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(210, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Port:";
            // 
            // txtInServ
            // 
            this.txtInServ.Location = new System.Drawing.Point(297, 46);
            this.txtInServ.Name = "txtInServ";
            this.txtInServ.Size = new System.Drawing.Size(153, 20);
            this.txtInServ.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Server:";
            // 
            // txtAccName
            // 
            this.txtAccName.Location = new System.Drawing.Point(297, 20);
            this.txtAccName.Name = "txtAccName";
            this.txtAccName.Size = new System.Drawing.Size(153, 20);
            this.txtAccName.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Account Name:";
            // 
            // lbAcc
            // 
            this.lbAcc.FormattingEnabled = true;
            this.lbAcc.Location = new System.Drawing.Point(8, 20);
            this.lbAcc.Name = "lbAcc";
            this.lbAcc.Size = new System.Drawing.Size(196, 199);
            this.lbAcc.TabIndex = 20;
            this.lbAcc.SelectedIndexChanged += new System.EventHandler(this.lbAcc_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "All accounts:";
            // 
            // SubscriptionsTab
            // 
            this.SubscriptionsTab.Controls.Add(this.btnDelSubs);
            this.SubscriptionsTab.Controls.Add(this.btnAddSubs);
            this.SubscriptionsTab.Controls.Add(this.trFolders2);
            this.SubscriptionsTab.Controls.Add(this.label12);
            this.SubscriptionsTab.Controls.Add(this.trSubs);
            this.SubscriptionsTab.Controls.Add(this.label11);
            this.SubscriptionsTab.Controls.Add(this.btnGetSubs);
            this.SubscriptionsTab.Location = new System.Drawing.Point(4, 22);
            this.SubscriptionsTab.Name = "SubscriptionsTab";
            this.SubscriptionsTab.Padding = new System.Windows.Forms.Padding(3);
            this.SubscriptionsTab.Size = new System.Drawing.Size(911, 354);
            this.SubscriptionsTab.TabIndex = 2;
            this.SubscriptionsTab.Text = "Subscriptions";
            this.SubscriptionsTab.UseVisualStyleBackColor = true;
            // 
            // btnDelSubs
            // 
            this.btnDelSubs.Location = new System.Drawing.Point(222, 199);
            this.btnDelSubs.Name = "btnDelSubs";
            this.btnDelSubs.Size = new System.Drawing.Size(36, 23);
            this.btnDelSubs.TabIndex = 6;
            this.btnDelSubs.Text = ">";
            this.btnDelSubs.UseVisualStyleBackColor = true;
            this.btnDelSubs.Click += new System.EventHandler(this.btnDelSubs_Click);
            // 
            // btnAddSubs
            // 
            this.btnAddSubs.Location = new System.Drawing.Point(222, 128);
            this.btnAddSubs.Name = "btnAddSubs";
            this.btnAddSubs.Size = new System.Drawing.Size(36, 23);
            this.btnAddSubs.TabIndex = 5;
            this.btnAddSubs.Text = "<";
            this.btnAddSubs.UseVisualStyleBackColor = true;
            this.btnAddSubs.Click += new System.EventHandler(this.btnAddSubs_Click);
            // 
            // trFolders2
            // 
            this.trFolders2.Location = new System.Drawing.Point(264, 58);
            this.trFolders2.Name = "trFolders2";
            this.trFolders2.Size = new System.Drawing.Size(218, 243);
            this.trFolders2.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(261, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "All folders:";
            // 
            // trSubs
            // 
            this.trSubs.Location = new System.Drawing.Point(6, 58);
            this.trSubs.Name = "trSubs";
            this.trSubs.Size = new System.Drawing.Size(210, 243);
            this.trSubs.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Subscription tree:";
            // 
            // btnGetSubs
            // 
            this.btnGetSubs.Location = new System.Drawing.Point(6, 6);
            this.btnGetSubs.Name = "btnGetSubs";
            this.btnGetSubs.Size = new System.Drawing.Size(112, 23);
            this.btnGetSubs.TabIndex = 0;
            this.btnGetSubs.Text = "Get subscriptions";
            this.btnGetSubs.UseVisualStyleBackColor = true;
            this.btnGetSubs.Click += new System.EventHandler(this.btnGetSubs_Click);
            // 
            // tabSearch
            // 
            this.tabSearch.Controls.Add(this.dgvSearchMessages);
            this.tabSearch.Controls.Add(this.panel27);
            this.tabSearch.Controls.Add(this.panel26);
            this.tabSearch.Controls.Add(this.panel25);
            this.tabSearch.Controls.Add(this.panel24);
            this.tabSearch.Controls.Add(this.panel23);
            this.tabSearch.Controls.Add(this.panel22);
            this.tabSearch.Controls.Add(this.panel21);
            this.tabSearch.Controls.Add(this.groupBox2);
            this.tabSearch.Controls.Add(this.panel20);
            this.tabSearch.Controls.Add(this.panel19);
            this.tabSearch.Controls.Add(this.panel18);
            this.tabSearch.Controls.Add(this.panel17);
            this.tabSearch.Controls.Add(this.panel16);
            this.tabSearch.Controls.Add(this.panel15);
            this.tabSearch.Controls.Add(this.panel14);
            this.tabSearch.Controls.Add(this.panel13);
            this.tabSearch.Controls.Add(this.panel12);
            this.tabSearch.Controls.Add(this.panel11);
            this.tabSearch.Controls.Add(this.panel10);
            this.tabSearch.Controls.Add(this.groupBox5);
            this.tabSearch.Controls.Add(this.groupBox3);
            this.tabSearch.Controls.Add(this.groupBox4);
            this.tabSearch.Controls.Add(this.groupBox6);
            this.tabSearch.Controls.Add(this.groupBox1);
            this.tabSearch.Controls.Add(this.btnSearch);
            this.tabSearch.Location = new System.Drawing.Point(4, 22);
            this.tabSearch.Name = "tabSearch";
            this.tabSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabSearch.Size = new System.Drawing.Size(911, 354);
            this.tabSearch.TabIndex = 3;
            this.tabSearch.Text = "Search";
            this.tabSearch.UseVisualStyleBackColor = true;
            // 
            // dgvSearchMessages
            // 
            this.dgvSearchMessages.AllowUserToAddRows = false;
            this.dgvSearchMessages.AllowUserToDeleteRows = false;
            this.dgvSearchMessages.AutoGenerateColumns = false;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle34.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSearchMessages.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle34;
            this.dgvSearchMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchMessages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.SearchFlag});
            this.dgvSearchMessages.DataMember = "Messages";
            this.dgvSearchMessages.DataSource = this.dsSearchMess;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle35.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle35.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSearchMessages.DefaultCellStyle = dataGridViewCellStyle35;
            this.dgvSearchMessages.Location = new System.Drawing.Point(494, 210);
            this.dgvSearchMessages.Name = "dgvSearchMessages";
            this.dgvSearchMessages.ReadOnly = true;
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle36.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle36.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSearchMessages.RowHeadersDefaultCellStyle = dataGridViewCellStyle36;
            this.dgvSearchMessages.RowHeadersVisible = false;
            this.dgvSearchMessages.RowTemplate.Height = 18;
            this.dgvSearchMessages.Size = new System.Drawing.Size(400, 138);
            this.dgvSearchMessages.TabIndex = 15;
            this.dgvSearchMessages.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            this.dgvSearchMessages.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSearchMessages_CellClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Subject";
            this.dataGridViewTextBoxColumn2.HeaderText = "Subject";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "From";
            this.dataGridViewTextBoxColumn3.HeaderText = "From";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn4.HeaderText = "Date";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // SearchFlag
            // 
            this.SearchFlag.HeaderText = "Flag";
            this.SearchFlag.Name = "SearchFlag";
            this.SearchFlag.ReadOnly = true;
            this.SearchFlag.Text = "Flag";
            this.SearchFlag.ToolTipText = "Look flags";
            this.SearchFlag.UseColumnTextForButtonValue = true;
            this.SearchFlag.Width = 30;
            // 
            // dsSearchMess
            // 
            this.dsSearchMess.DataSetName = "NewDataSet";
            this.dsSearchMess.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1});
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn6,
            this.dataColumn7,
            this.dataColumn8,
            this.dataColumn9});
            this.dataTable1.TableName = "Messages";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "Attachments";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "Subject";
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "From";
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "Date";
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "UID";
            this.dataColumn6.DataType = typeof(uint);
            // 
            // dataColumn7
            // 
            this.dataColumn7.ColumnName = "Seen";
            this.dataColumn7.DataType = typeof(int);
            // 
            // dataColumn8
            // 
            this.dataColumn8.ColumnName = "Del";
            this.dataColumn8.DataType = typeof(bool);
            this.dataColumn8.DefaultValue = false;
            // 
            // dataColumn9
            // 
            this.dataColumn9.Caption = "Flags";
            this.dataColumn9.ColumnName = "Flags";
            this.dataColumn9.DataType = typeof(object);
            // 
            // panel27
            // 
            this.panel27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel27.Controls.Add(this.btnSSelFolder);
            this.panel27.Controls.Add(this.txtSFolder);
            this.panel27.Controls.Add(this.label35);
            this.panel27.Location = new System.Drawing.Point(196, 320);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(292, 28);
            this.panel27.TabIndex = 14;
            // 
            // btnSSelFolder
            // 
            this.btnSSelFolder.Location = new System.Drawing.Point(256, 2);
            this.btnSSelFolder.Name = "btnSSelFolder";
            this.btnSSelFolder.Size = new System.Drawing.Size(31, 23);
            this.btnSSelFolder.TabIndex = 15;
            this.btnSSelFolder.Text = "...";
            this.btnSSelFolder.UseVisualStyleBackColor = true;
            this.btnSSelFolder.Click += new System.EventHandler(this.btnSSelFolder_Click);
            // 
            // txtSFolder
            // 
            this.txtSFolder.Location = new System.Drawing.Point(41, 3);
            this.txtSFolder.Name = "txtSFolder";
            this.txtSFolder.Size = new System.Drawing.Size(209, 20);
            this.txtSFolder.TabIndex = 2;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(1, 7);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(39, 13);
            this.label35.TabIndex = 1;
            this.label35.Text = "Folder:";
            // 
            // panel26
            // 
            this.panel26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel26.Controls.Add(this.label34);
            this.panel26.Controls.Add(this.mtxtSSendSince);
            this.panel26.Controls.Add(this.cbOrSendSince);
            this.panel26.Location = new System.Drawing.Point(494, 176);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(200, 28);
            this.panel26.TabIndex = 13;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(37, 7);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(56, 13);
            this.label34.TabIndex = 1;
            this.label34.Text = "SendSinc:";
            // 
            // mtxtSSendSince
            // 
            this.mtxtSSendSince.Location = new System.Drawing.Point(93, 3);
            this.mtxtSSendSince.Mask = "00/00/0000 90:00";
            this.mtxtSSendSince.Name = "mtxtSSendSince";
            this.mtxtSSendSince.Size = new System.Drawing.Size(100, 20);
            this.mtxtSSendSince.TabIndex = 11;
            this.mtxtSSendSince.ValidatingType = typeof(System.DateTime);
            // 
            // cbOrSendSince
            // 
            this.cbOrSendSince.AutoSize = true;
            this.cbOrSendSince.Location = new System.Drawing.Point(3, 5);
            this.cbOrSendSince.Name = "cbOrSendSince";
            this.cbOrSendSince.Size = new System.Drawing.Size(37, 17);
            this.cbOrSendSince.TabIndex = 0;
            this.cbOrSendSince.Text = "Or";
            this.cbOrSendSince.UseVisualStyleBackColor = true;
            // 
            // panel25
            // 
            this.panel25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel25.Controls.Add(this.label33);
            this.panel25.Controls.Add(this.mtxtSSendOn);
            this.panel25.Controls.Add(this.cbOrSendOn);
            this.panel25.Location = new System.Drawing.Point(494, 142);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(200, 28);
            this.panel25.TabIndex = 13;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(37, 7);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(46, 13);
            this.label33.TabIndex = 1;
            this.label33.Text = "SentOn:";
            // 
            // mtxtSSendOn
            // 
            this.mtxtSSendOn.Location = new System.Drawing.Point(93, 3);
            this.mtxtSSendOn.Mask = "00/00/0000 90:00";
            this.mtxtSSendOn.Name = "mtxtSSendOn";
            this.mtxtSSendOn.Size = new System.Drawing.Size(100, 20);
            this.mtxtSSendOn.TabIndex = 11;
            this.mtxtSSendOn.ValidatingType = typeof(System.DateTime);
            // 
            // cbOrSendOn
            // 
            this.cbOrSendOn.AutoSize = true;
            this.cbOrSendOn.Location = new System.Drawing.Point(3, 5);
            this.cbOrSendOn.Name = "cbOrSendOn";
            this.cbOrSendOn.Size = new System.Drawing.Size(37, 17);
            this.cbOrSendOn.TabIndex = 0;
            this.cbOrSendOn.Text = "Or";
            this.cbOrSendOn.UseVisualStyleBackColor = true;
            // 
            // panel24
            // 
            this.panel24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel24.Controls.Add(this.label32);
            this.panel24.Controls.Add(this.mtxtSSentBefore);
            this.panel24.Controls.Add(this.cbOrSendBefore);
            this.panel24.Location = new System.Drawing.Point(494, 108);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(200, 28);
            this.panel24.TabIndex = 13;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(37, 7);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(57, 13);
            this.label32.TabIndex = 1;
            this.label32.Text = "SentBefor:";
            // 
            // mtxtSSentBefore
            // 
            this.mtxtSSentBefore.Location = new System.Drawing.Point(93, 3);
            this.mtxtSSentBefore.Mask = "00/00/0000 90:00";
            this.mtxtSSentBefore.Name = "mtxtSSentBefore";
            this.mtxtSSentBefore.Size = new System.Drawing.Size(100, 20);
            this.mtxtSSentBefore.TabIndex = 11;
            this.mtxtSSentBefore.ValidatingType = typeof(System.DateTime);
            // 
            // cbOrSendBefore
            // 
            this.cbOrSendBefore.AutoSize = true;
            this.cbOrSendBefore.Location = new System.Drawing.Point(3, 5);
            this.cbOrSendBefore.Name = "cbOrSendBefore";
            this.cbOrSendBefore.Size = new System.Drawing.Size(37, 17);
            this.cbOrSendBefore.TabIndex = 0;
            this.cbOrSendBefore.Text = "Or";
            this.cbOrSendBefore.UseVisualStyleBackColor = true;
            // 
            // panel23
            // 
            this.panel23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel23.Controls.Add(this.label31);
            this.panel23.Controls.Add(this.mtxtSSince);
            this.panel23.Controls.Add(this.cbOrSince);
            this.panel23.Location = new System.Drawing.Point(494, 74);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(200, 28);
            this.panel23.TabIndex = 13;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(37, 7);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(37, 13);
            this.label31.TabIndex = 1;
            this.label31.Text = "Since:";
            // 
            // mtxtSSince
            // 
            this.mtxtSSince.Location = new System.Drawing.Point(93, 3);
            this.mtxtSSince.Mask = "00/00/0000 90:00";
            this.mtxtSSince.Name = "mtxtSSince";
            this.mtxtSSince.Size = new System.Drawing.Size(100, 20);
            this.mtxtSSince.TabIndex = 11;
            this.mtxtSSince.ValidatingType = typeof(System.DateTime);
            // 
            // cbOrSince
            // 
            this.cbOrSince.AutoSize = true;
            this.cbOrSince.Location = new System.Drawing.Point(3, 5);
            this.cbOrSince.Name = "cbOrSince";
            this.cbOrSince.Size = new System.Drawing.Size(37, 17);
            this.cbOrSince.TabIndex = 0;
            this.cbOrSince.Text = "Or";
            this.cbOrSince.UseVisualStyleBackColor = true;
            // 
            // panel22
            // 
            this.panel22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel22.Controls.Add(this.label30);
            this.panel22.Controls.Add(this.mtxtsOn);
            this.panel22.Controls.Add(this.cbOrOn);
            this.panel22.Location = new System.Drawing.Point(494, 40);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(200, 28);
            this.panel22.TabIndex = 13;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(37, 7);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(24, 13);
            this.label30.TabIndex = 1;
            this.label30.Text = "On:";
            // 
            // mtxtsOn
            // 
            this.mtxtsOn.Location = new System.Drawing.Point(93, 3);
            this.mtxtsOn.Mask = "00/00/0000 90:00";
            this.mtxtsOn.Name = "mtxtsOn";
            this.mtxtsOn.Size = new System.Drawing.Size(100, 20);
            this.mtxtsOn.TabIndex = 11;
            this.mtxtsOn.ValidatingType = typeof(System.DateTime);
            // 
            // cbOrOn
            // 
            this.cbOrOn.AutoSize = true;
            this.cbOrOn.Location = new System.Drawing.Point(3, 5);
            this.cbOrOn.Name = "cbOrOn";
            this.cbOrOn.Size = new System.Drawing.Size(37, 17);
            this.cbOrOn.TabIndex = 0;
            this.cbOrOn.Text = "Or";
            this.cbOrOn.UseVisualStyleBackColor = true;
            // 
            // panel21
            // 
            this.panel21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel21.Controls.Add(this.label29);
            this.panel21.Controls.Add(this.mtxtSBefore);
            this.panel21.Controls.Add(this.cbOrBefore);
            this.panel21.Location = new System.Drawing.Point(494, 6);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(200, 28);
            this.panel21.TabIndex = 12;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(37, 7);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(41, 13);
            this.label29.TabIndex = 1;
            this.label29.Text = "Before:";
            // 
            // mtxtSBefore
            // 
            this.mtxtSBefore.Location = new System.Drawing.Point(93, 3);
            this.mtxtSBefore.Mask = "00/00/0000 90:00";
            this.mtxtSBefore.Name = "mtxtSBefore";
            this.mtxtSBefore.Size = new System.Drawing.Size(100, 20);
            this.mtxtSBefore.TabIndex = 11;
            this.mtxtSBefore.ValidatingType = typeof(System.DateTime);
            // 
            // cbOrBefore
            // 
            this.cbOrBefore.AutoSize = true;
            this.cbOrBefore.Location = new System.Drawing.Point(3, 5);
            this.cbOrBefore.Name = "cbOrBefore";
            this.cbOrBefore.Size = new System.Drawing.Size(37, 17);
            this.cbOrBefore.TabIndex = 0;
            this.cbOrBefore.Text = "Or";
            this.cbOrBefore.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbRecent);
            this.groupBox2.Controls.Add(this.rbOld);
            this.groupBox2.Controls.Add(this.cbOrOldRecent);
            this.groupBox2.Location = new System.Drawing.Point(6, -1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(184, 38);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // rbRecent
            // 
            this.rbRecent.AutoSize = true;
            this.rbRecent.Location = new System.Drawing.Point(105, 10);
            this.rbRecent.Name = "rbRecent";
            this.rbRecent.Size = new System.Drawing.Size(60, 17);
            this.rbRecent.TabIndex = 2;
            this.rbRecent.TabStop = true;
            this.rbRecent.Text = "Recent";
            this.rbRecent.UseVisualStyleBackColor = true;
            // 
            // rbOld
            // 
            this.rbOld.AutoSize = true;
            this.rbOld.Location = new System.Drawing.Point(49, 10);
            this.rbOld.Name = "rbOld";
            this.rbOld.Size = new System.Drawing.Size(41, 17);
            this.rbOld.TabIndex = 1;
            this.rbOld.TabStop = true;
            this.rbOld.Text = "Old";
            this.rbOld.UseVisualStyleBackColor = true;
            // 
            // cbOrOldRecent
            // 
            this.cbOrOldRecent.AutoSize = true;
            this.cbOrOldRecent.Location = new System.Drawing.Point(6, 10);
            this.cbOrOldRecent.Name = "cbOrOldRecent";
            this.cbOrOldRecent.Size = new System.Drawing.Size(37, 17);
            this.cbOrOldRecent.TabIndex = 0;
            this.cbOrOldRecent.Text = "Or";
            this.cbOrOldRecent.UseVisualStyleBackColor = true;
            // 
            // panel20
            // 
            this.panel20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel20.Controls.Add(this.txtSUID);
            this.panel20.Controls.Add(this.label28);
            this.panel20.Controls.Add(this.cbOrUID);
            this.panel20.Location = new System.Drawing.Point(6, 320);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(184, 28);
            this.panel20.TabIndex = 10;
            // 
            // txtSUID
            // 
            this.txtSUID.Location = new System.Drawing.Point(86, 1);
            this.txtSUID.Name = "txtSUID";
            this.txtSUID.Size = new System.Drawing.Size(93, 20);
            this.txtSUID.TabIndex = 5;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(34, 4);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(29, 13);
            this.label28.TabIndex = 6;
            this.label28.Text = "UID:";
            // 
            // cbOrUID
            // 
            this.cbOrUID.AutoSize = true;
            this.cbOrUID.Location = new System.Drawing.Point(3, 3);
            this.cbOrUID.Name = "cbOrUID";
            this.cbOrUID.Size = new System.Drawing.Size(37, 17);
            this.cbOrUID.TabIndex = 5;
            this.cbOrUID.Text = "Or";
            this.cbOrUID.UseVisualStyleBackColor = true;
            // 
            // panel19
            // 
            this.panel19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel19.Controls.Add(this.txtSSmaller);
            this.panel19.Controls.Add(this.label27);
            this.panel19.Controls.Add(this.cbOrSmaller);
            this.panel19.Location = new System.Drawing.Point(6, 286);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(184, 28);
            this.panel19.TabIndex = 9;
            // 
            // txtSSmaller
            // 
            this.txtSSmaller.Location = new System.Drawing.Point(86, 1);
            this.txtSSmaller.Name = "txtSSmaller";
            this.txtSSmaller.Size = new System.Drawing.Size(93, 20);
            this.txtSSmaller.TabIndex = 5;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(34, 4);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(44, 13);
            this.label27.TabIndex = 6;
            this.label27.Text = "Smaller:";
            // 
            // cbOrSmaller
            // 
            this.cbOrSmaller.AutoSize = true;
            this.cbOrSmaller.Location = new System.Drawing.Point(3, 3);
            this.cbOrSmaller.Name = "cbOrSmaller";
            this.cbOrSmaller.Size = new System.Drawing.Size(37, 17);
            this.cbOrSmaller.TabIndex = 5;
            this.cbOrSmaller.Text = "Or";
            this.cbOrSmaller.UseVisualStyleBackColor = true;
            // 
            // panel18
            // 
            this.panel18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel18.Controls.Add(this.txtSLarger);
            this.panel18.Controls.Add(this.label26);
            this.panel18.Controls.Add(this.cbOrLarger);
            this.panel18.Location = new System.Drawing.Point(6, 252);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(184, 28);
            this.panel18.TabIndex = 8;
            // 
            // txtSLarger
            // 
            this.txtSLarger.Location = new System.Drawing.Point(86, 1);
            this.txtSLarger.Name = "txtSLarger";
            this.txtSLarger.Size = new System.Drawing.Size(93, 20);
            this.txtSLarger.TabIndex = 5;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(34, 4);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(40, 13);
            this.label26.TabIndex = 6;
            this.label26.Text = "Larger:";
            // 
            // cbOrLarger
            // 
            this.cbOrLarger.AutoSize = true;
            this.cbOrLarger.Location = new System.Drawing.Point(3, 3);
            this.cbOrLarger.Name = "cbOrLarger";
            this.cbOrLarger.Size = new System.Drawing.Size(37, 17);
            this.cbOrLarger.TabIndex = 5;
            this.cbOrLarger.Text = "Or";
            this.cbOrLarger.UseVisualStyleBackColor = true;
            // 
            // panel17
            // 
            this.panel17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel17.Controls.Add(this.txtSValue);
            this.panel17.Controls.Add(this.label25);
            this.panel17.Controls.Add(this.txtSField);
            this.panel17.Controls.Add(this.label24);
            this.panel17.Controls.Add(this.cbOrHeader);
            this.panel17.Location = new System.Drawing.Point(196, 244);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(292, 57);
            this.panel17.TabIndex = 10;
            // 
            // txtSValue
            // 
            this.txtSValue.Location = new System.Drawing.Point(86, 29);
            this.txtSValue.Name = "txtSValue";
            this.txtSValue.Size = new System.Drawing.Size(201, 20);
            this.txtSValue.TabIndex = 7;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(34, 32);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(37, 13);
            this.label25.TabIndex = 8;
            this.label25.Text = "Value:";
            // 
            // txtSField
            // 
            this.txtSField.Location = new System.Drawing.Point(86, 1);
            this.txtSField.Name = "txtSField";
            this.txtSField.Size = new System.Drawing.Size(201, 20);
            this.txtSField.TabIndex = 5;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(34, 4);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(45, 13);
            this.label24.TabIndex = 6;
            this.label24.Text = "Header:";
            // 
            // cbOrHeader
            // 
            this.cbOrHeader.AutoSize = true;
            this.cbOrHeader.Location = new System.Drawing.Point(3, 3);
            this.cbOrHeader.Name = "cbOrHeader";
            this.cbOrHeader.Size = new System.Drawing.Size(37, 17);
            this.cbOrHeader.TabIndex = 5;
            this.cbOrHeader.Text = "Or";
            this.cbOrHeader.UseVisualStyleBackColor = true;
            // 
            // panel16
            // 
            this.panel16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel16.Controls.Add(this.txtSBody);
            this.panel16.Controls.Add(this.label23);
            this.panel16.Controls.Add(this.cbOrBody);
            this.panel16.Location = new System.Drawing.Point(196, 210);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(292, 28);
            this.panel16.TabIndex = 9;
            // 
            // txtSBody
            // 
            this.txtSBody.Location = new System.Drawing.Point(86, 1);
            this.txtSBody.Name = "txtSBody";
            this.txtSBody.Size = new System.Drawing.Size(201, 20);
            this.txtSBody.TabIndex = 5;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(34, 4);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(34, 13);
            this.label23.TabIndex = 6;
            this.label23.Text = "Body:";
            // 
            // cbOrBody
            // 
            this.cbOrBody.AutoSize = true;
            this.cbOrBody.Location = new System.Drawing.Point(3, 3);
            this.cbOrBody.Name = "cbOrBody";
            this.cbOrBody.Size = new System.Drawing.Size(37, 17);
            this.cbOrBody.TabIndex = 5;
            this.cbOrBody.Text = "Or";
            this.cbOrBody.UseVisualStyleBackColor = true;
            // 
            // panel15
            // 
            this.panel15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel15.Controls.Add(this.txtSFrom);
            this.panel15.Controls.Add(this.label22);
            this.panel15.Controls.Add(this.cbOrFrom);
            this.panel15.Location = new System.Drawing.Point(196, 40);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(292, 28);
            this.panel15.TabIndex = 7;
            // 
            // txtSFrom
            // 
            this.txtSFrom.Location = new System.Drawing.Point(86, 1);
            this.txtSFrom.Name = "txtSFrom";
            this.txtSFrom.Size = new System.Drawing.Size(201, 20);
            this.txtSFrom.TabIndex = 5;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(34, 4);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(33, 13);
            this.label22.TabIndex = 6;
            this.label22.Text = "From:";
            // 
            // cbOrFrom
            // 
            this.cbOrFrom.AutoSize = true;
            this.cbOrFrom.Location = new System.Drawing.Point(3, 3);
            this.cbOrFrom.Name = "cbOrFrom";
            this.cbOrFrom.Size = new System.Drawing.Size(37, 17);
            this.cbOrFrom.TabIndex = 5;
            this.cbOrFrom.Text = "Or";
            this.cbOrFrom.UseVisualStyleBackColor = true;
            // 
            // panel14
            // 
            this.panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel14.Controls.Add(this.txtSBlCopy);
            this.panel14.Controls.Add(this.label21);
            this.panel14.Controls.Add(this.cbOrBlCopy);
            this.panel14.Location = new System.Drawing.Point(196, 142);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(292, 28);
            this.panel14.TabIndex = 8;
            // 
            // txtSBlCopy
            // 
            this.txtSBlCopy.Location = new System.Drawing.Point(86, 1);
            this.txtSBlCopy.Name = "txtSBlCopy";
            this.txtSBlCopy.Size = new System.Drawing.Size(201, 20);
            this.txtSBlCopy.TabIndex = 5;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(34, 4);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(46, 13);
            this.label21.TabIndex = 6;
            this.label21.Text = "Bl Copy:";
            // 
            // cbOrBlCopy
            // 
            this.cbOrBlCopy.AutoSize = true;
            this.cbOrBlCopy.Location = new System.Drawing.Point(3, 3);
            this.cbOrBlCopy.Name = "cbOrBlCopy";
            this.cbOrBlCopy.Size = new System.Drawing.Size(37, 17);
            this.cbOrBlCopy.TabIndex = 5;
            this.cbOrBlCopy.Text = "Or";
            this.cbOrBlCopy.UseVisualStyleBackColor = true;
            // 
            // panel13
            // 
            this.panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel13.Controls.Add(this.txtSCopy);
            this.panel13.Controls.Add(this.label20);
            this.panel13.Controls.Add(this.cbOrCopy);
            this.panel13.Location = new System.Drawing.Point(196, 108);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(292, 28);
            this.panel13.TabIndex = 7;
            // 
            // txtSCopy
            // 
            this.txtSCopy.Location = new System.Drawing.Point(86, 1);
            this.txtSCopy.Name = "txtSCopy";
            this.txtSCopy.Size = new System.Drawing.Size(201, 20);
            this.txtSCopy.TabIndex = 5;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(34, 4);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(34, 13);
            this.label20.TabIndex = 6;
            this.label20.Text = "Copy:";
            // 
            // cbOrCopy
            // 
            this.cbOrCopy.AutoSize = true;
            this.cbOrCopy.Location = new System.Drawing.Point(3, 3);
            this.cbOrCopy.Name = "cbOrCopy";
            this.cbOrCopy.Size = new System.Drawing.Size(37, 17);
            this.cbOrCopy.TabIndex = 5;
            this.cbOrCopy.Text = "Or";
            this.cbOrCopy.UseVisualStyleBackColor = true;
            // 
            // panel12
            // 
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel12.Controls.Add(this.txtSTo);
            this.panel12.Controls.Add(this.label19);
            this.panel12.Controls.Add(this.cbOrTo);
            this.panel12.Location = new System.Drawing.Point(196, 74);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(292, 28);
            this.panel12.TabIndex = 7;
            // 
            // txtSTo
            // 
            this.txtSTo.Location = new System.Drawing.Point(86, 1);
            this.txtSTo.Name = "txtSTo";
            this.txtSTo.Size = new System.Drawing.Size(201, 20);
            this.txtSTo.TabIndex = 5;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(34, 4);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(23, 13);
            this.label19.TabIndex = 6;
            this.label19.Text = "To:";
            // 
            // cbOrTo
            // 
            this.cbOrTo.AutoSize = true;
            this.cbOrTo.Location = new System.Drawing.Point(3, 3);
            this.cbOrTo.Name = "cbOrTo";
            this.cbOrTo.Size = new System.Drawing.Size(37, 17);
            this.cbOrTo.TabIndex = 5;
            this.cbOrTo.Text = "Or";
            this.cbOrTo.UseVisualStyleBackColor = true;
            // 
            // panel11
            // 
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel11.Controls.Add(this.txtSText);
            this.panel11.Controls.Add(this.label18);
            this.panel11.Controls.Add(this.cbOrText);
            this.panel11.Location = new System.Drawing.Point(196, 176);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(292, 28);
            this.panel11.TabIndex = 7;
            // 
            // txtSText
            // 
            this.txtSText.Location = new System.Drawing.Point(86, 1);
            this.txtSText.Name = "txtSText";
            this.txtSText.Size = new System.Drawing.Size(201, 20);
            this.txtSText.TabIndex = 5;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(34, 4);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(31, 13);
            this.label18.TabIndex = 6;
            this.label18.Text = "Text:";
            // 
            // cbOrText
            // 
            this.cbOrText.AutoSize = true;
            this.cbOrText.Location = new System.Drawing.Point(3, 3);
            this.cbOrText.Name = "cbOrText";
            this.cbOrText.Size = new System.Drawing.Size(37, 17);
            this.cbOrText.TabIndex = 5;
            this.cbOrText.Text = "Or";
            this.cbOrText.UseVisualStyleBackColor = true;
            // 
            // panel10
            // 
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.txtSSubj);
            this.panel10.Controls.Add(this.label17);
            this.panel10.Controls.Add(this.cbOrSubj);
            this.panel10.Location = new System.Drawing.Point(196, 6);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(292, 28);
            this.panel10.TabIndex = 4;
            // 
            // txtSSubj
            // 
            this.txtSSubj.Location = new System.Drawing.Point(86, 1);
            this.txtSSubj.Name = "txtSSubj";
            this.txtSSubj.Size = new System.Drawing.Size(201, 20);
            this.txtSSubj.TabIndex = 5;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(34, 4);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(46, 13);
            this.label17.TabIndex = 6;
            this.label17.Text = "Subject:";
            // 
            // cbOrSubj
            // 
            this.cbOrSubj.AutoSize = true;
            this.cbOrSubj.Location = new System.Drawing.Point(3, 3);
            this.cbOrSubj.Name = "cbOrSubj";
            this.cbOrSubj.Size = new System.Drawing.Size(37, 17);
            this.cbOrSubj.TabIndex = 5;
            this.cbOrSubj.Text = "Or";
            this.cbOrSubj.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rbUnDraft);
            this.groupBox5.Controls.Add(this.rbDraft);
            this.groupBox5.Controls.Add(this.cbOrDraft);
            this.groupBox5.Location = new System.Drawing.Point(6, 164);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(184, 38);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            // 
            // rbUnDraft
            // 
            this.rbUnDraft.AutoSize = true;
            this.rbUnDraft.Location = new System.Drawing.Point(105, 10);
            this.rbUnDraft.Name = "rbUnDraft";
            this.rbUnDraft.Size = new System.Drawing.Size(62, 17);
            this.rbUnDraft.TabIndex = 2;
            this.rbUnDraft.TabStop = true;
            this.rbUnDraft.Text = "UnDraft";
            this.rbUnDraft.UseVisualStyleBackColor = true;
            // 
            // rbDraft
            // 
            this.rbDraft.AutoSize = true;
            this.rbDraft.Location = new System.Drawing.Point(49, 10);
            this.rbDraft.Name = "rbDraft";
            this.rbDraft.Size = new System.Drawing.Size(48, 17);
            this.rbDraft.TabIndex = 1;
            this.rbDraft.TabStop = true;
            this.rbDraft.Text = "Draft";
            this.rbDraft.UseVisualStyleBackColor = true;
            // 
            // cbOrDraft
            // 
            this.cbOrDraft.AutoSize = true;
            this.cbOrDraft.Location = new System.Drawing.Point(6, 10);
            this.cbOrDraft.Name = "cbOrDraft";
            this.cbOrDraft.Size = new System.Drawing.Size(37, 17);
            this.cbOrDraft.TabIndex = 0;
            this.cbOrDraft.Text = "Or";
            this.cbOrDraft.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbUnAns);
            this.groupBox3.Controls.Add(this.rbAnswered);
            this.groupBox3.Controls.Add(this.cbOrAns);
            this.groupBox3.Location = new System.Drawing.Point(6, 76);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(184, 38);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // rbUnAns
            // 
            this.rbUnAns.AutoSize = true;
            this.rbUnAns.Location = new System.Drawing.Point(127, 10);
            this.rbUnAns.Name = "rbUnAns";
            this.rbUnAns.Size = new System.Drawing.Size(57, 17);
            this.rbUnAns.TabIndex = 2;
            this.rbUnAns.TabStop = true;
            this.rbUnAns.Text = "UnAns";
            this.rbUnAns.UseVisualStyleBackColor = true;
            // 
            // rbAnswered
            // 
            this.rbAnswered.AutoSize = true;
            this.rbAnswered.Location = new System.Drawing.Point(49, 10);
            this.rbAnswered.Name = "rbAnswered";
            this.rbAnswered.Size = new System.Drawing.Size(72, 17);
            this.rbAnswered.TabIndex = 1;
            this.rbAnswered.TabStop = true;
            this.rbAnswered.Text = "Answered";
            this.rbAnswered.UseVisualStyleBackColor = true;
            // 
            // cbOrAns
            // 
            this.cbOrAns.AutoSize = true;
            this.cbOrAns.Location = new System.Drawing.Point(6, 10);
            this.cbOrAns.Name = "cbOrAns";
            this.cbOrAns.Size = new System.Drawing.Size(37, 17);
            this.cbOrAns.TabIndex = 0;
            this.cbOrAns.Text = "Or";
            this.cbOrAns.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbUnDel);
            this.groupBox4.Controls.Add(this.rbDeleted);
            this.groupBox4.Controls.Add(this.cbOrDeleted);
            this.groupBox4.Location = new System.Drawing.Point(6, 120);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(184, 38);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // rbUnDel
            // 
            this.rbUnDel.AutoSize = true;
            this.rbUnDel.Location = new System.Drawing.Point(115, 9);
            this.rbUnDel.Name = "rbUnDel";
            this.rbUnDel.Size = new System.Drawing.Size(55, 17);
            this.rbUnDel.TabIndex = 2;
            this.rbUnDel.TabStop = true;
            this.rbUnDel.Text = "UnDel";
            this.rbUnDel.UseVisualStyleBackColor = true;
            // 
            // rbDeleted
            // 
            this.rbDeleted.AutoSize = true;
            this.rbDeleted.Location = new System.Drawing.Point(49, 10);
            this.rbDeleted.Name = "rbDeleted";
            this.rbDeleted.Size = new System.Drawing.Size(62, 17);
            this.rbDeleted.TabIndex = 1;
            this.rbDeleted.TabStop = true;
            this.rbDeleted.Text = "Deleted";
            this.rbDeleted.UseVisualStyleBackColor = true;
            // 
            // cbOrDeleted
            // 
            this.cbOrDeleted.AutoSize = true;
            this.cbOrDeleted.Location = new System.Drawing.Point(6, 10);
            this.cbOrDeleted.Name = "cbOrDeleted";
            this.cbOrDeleted.Size = new System.Drawing.Size(37, 17);
            this.cbOrDeleted.TabIndex = 0;
            this.cbOrDeleted.Text = "Or";
            this.cbOrDeleted.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.rbUnFlagged);
            this.groupBox6.Controls.Add(this.rbFlagged);
            this.groupBox6.Controls.Add(this.cbOrFlagged);
            this.groupBox6.Location = new System.Drawing.Point(6, 208);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(184, 38);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            // 
            // rbUnFlagged
            // 
            this.rbUnFlagged.AutoSize = true;
            this.rbUnFlagged.Location = new System.Drawing.Point(112, 10);
            this.rbUnFlagged.Name = "rbUnFlagged";
            this.rbUnFlagged.Size = new System.Drawing.Size(59, 17);
            this.rbUnFlagged.TabIndex = 2;
            this.rbUnFlagged.TabStop = true;
            this.rbUnFlagged.Text = "UnFlag";
            this.rbUnFlagged.UseVisualStyleBackColor = true;
            // 
            // rbFlagged
            // 
            this.rbFlagged.AutoSize = true;
            this.rbFlagged.Location = new System.Drawing.Point(49, 10);
            this.rbFlagged.Name = "rbFlagged";
            this.rbFlagged.Size = new System.Drawing.Size(63, 17);
            this.rbFlagged.TabIndex = 1;
            this.rbFlagged.TabStop = true;
            this.rbFlagged.Text = "Flagged";
            this.rbFlagged.UseVisualStyleBackColor = true;
            // 
            // cbOrFlagged
            // 
            this.cbOrFlagged.AutoSize = true;
            this.cbOrFlagged.Location = new System.Drawing.Point(6, 10);
            this.cbOrFlagged.Name = "cbOrFlagged";
            this.cbOrFlagged.Size = new System.Drawing.Size(37, 17);
            this.cbOrFlagged.TabIndex = 0;
            this.cbOrFlagged.Text = "Or";
            this.cbOrFlagged.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbUnSeen);
            this.groupBox1.Controls.Add(this.rbSeen);
            this.groupBox1.Controls.Add(this.cbOrSeen);
            this.groupBox1.Location = new System.Drawing.Point(6, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 38);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // rbUnSeen
            // 
            this.rbUnSeen.AutoSize = true;
            this.rbUnSeen.Location = new System.Drawing.Point(105, 10);
            this.rbUnSeen.Name = "rbUnSeen";
            this.rbUnSeen.Size = new System.Drawing.Size(64, 17);
            this.rbUnSeen.TabIndex = 2;
            this.rbUnSeen.TabStop = true;
            this.rbUnSeen.Text = "UnSeen";
            this.rbUnSeen.UseVisualStyleBackColor = true;
            // 
            // rbSeen
            // 
            this.rbSeen.AutoSize = true;
            this.rbSeen.Location = new System.Drawing.Point(49, 10);
            this.rbSeen.Name = "rbSeen";
            this.rbSeen.Size = new System.Drawing.Size(50, 17);
            this.rbSeen.TabIndex = 1;
            this.rbSeen.TabStop = true;
            this.rbSeen.Text = "Seen";
            this.rbSeen.UseVisualStyleBackColor = true;
            // 
            // cbOrSeen
            // 
            this.cbOrSeen.AutoSize = true;
            this.cbOrSeen.Location = new System.Drawing.Point(6, 10);
            this.cbOrSeen.Name = "cbOrSeen";
            this.cbOrSeen.Size = new System.Drawing.Size(37, 17);
            this.cbOrSeen.TabIndex = 0;
            this.cbOrSeen.Text = "Or";
            this.cbOrSeen.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(715, 142);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(179, 62);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Start Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // NoopLogTab
            // 
            this.NoopLogTab.Controls.Add(this.splitContainer2);
            this.NoopLogTab.Location = new System.Drawing.Point(4, 22);
            this.NoopLogTab.Name = "NoopLogTab";
            this.NoopLogTab.Padding = new System.Windows.Forms.Padding(3);
            this.NoopLogTab.Size = new System.Drawing.Size(911, 354);
            this.NoopLogTab.TabIndex = 4;
            this.NoopLogTab.Text = "Logs";
            this.NoopLogTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.lbNoopLog);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.lbLog);
            this.splitContainer2.Size = new System.Drawing.Size(905, 348);
            this.splitContainer2.SplitterDistance = 321;
            this.splitContainer2.TabIndex = 2;
            // 
            // lbNoopLog
            // 
            this.lbNoopLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbNoopLog.FormattingEnabled = true;
            this.lbNoopLog.HorizontalScrollbar = true;
            this.lbNoopLog.Location = new System.Drawing.Point(0, 0);
            this.lbNoopLog.Name = "lbNoopLog";
            this.lbNoopLog.Size = new System.Drawing.Size(321, 342);
            this.lbNoopLog.TabIndex = 0;
            // 
            // lbLog
            // 
            this.lbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbLog.FormattingEnabled = true;
            this.lbLog.HorizontalScrollbar = true;
            this.lbLog.Location = new System.Drawing.Point(0, 0);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(580, 342);
            this.lbLog.TabIndex = 1;
            // 
            // tabEvents
            // 
            this.tabEvents.Controls.Add(this.label37);
            this.tabEvents.Controls.Add(this.cbServerRespRec);
            this.tabEvents.Controls.Add(this.cbMessReceived);
            this.tabEvents.Controls.Add(this.cbAllMessReceived);
            this.tabEvents.Controls.Add(this.label36);
            this.tabEvents.Controls.Add(this.cbAuth);
            this.tabEvents.Location = new System.Drawing.Point(4, 22);
            this.tabEvents.Name = "tabEvents";
            this.tabEvents.Padding = new System.Windows.Forms.Padding(3);
            this.tabEvents.Size = new System.Drawing.Size(911, 354);
            this.tabEvents.TabIndex = 5;
            this.tabEvents.Text = "Events";
            this.tabEvents.UseVisualStyleBackColor = true;
            // 
            // cbServerRespRec
            // 
            this.cbServerRespRec.AutoSize = true;
            this.cbServerRespRec.Location = new System.Drawing.Point(9, 110);
            this.cbServerRespRec.Name = "cbServerRespRec";
            this.cbServerRespRec.Size = new System.Drawing.Size(147, 17);
            this.cbServerRespRec.TabIndex = 4;
            this.cbServerRespRec.Text = "Server response received";
            this.cbServerRespRec.UseVisualStyleBackColor = true;
            this.cbServerRespRec.CheckedChanged += new System.EventHandler(this.cbServerRespRec_CheckedChanged);
            // 
            // cbMessReceived
            // 
            this.cbMessReceived.AutoSize = true;
            this.cbMessReceived.Location = new System.Drawing.Point(9, 87);
            this.cbMessReceived.Name = "cbMessReceived";
            this.cbMessReceived.Size = new System.Drawing.Size(113, 17);
            this.cbMessReceived.TabIndex = 3;
            this.cbMessReceived.Text = "Message received";
            this.cbMessReceived.UseVisualStyleBackColor = true;
            this.cbMessReceived.CheckedChanged += new System.EventHandler(this.cbMessReceived_CheckedChanged);
            // 
            // cbAllMessReceived
            // 
            this.cbAllMessReceived.AutoSize = true;
            this.cbAllMessReceived.Location = new System.Drawing.Point(9, 64);
            this.cbAllMessReceived.Name = "cbAllMessReceived";
            this.cbAllMessReceived.Size = new System.Drawing.Size(131, 17);
            this.cbAllMessReceived.TabIndex = 2;
            this.cbAllMessReceived.Text = "All messages received";
            this.cbAllMessReceived.UseVisualStyleBackColor = true;
            this.cbAllMessReceived.CheckedChanged += new System.EventHandler(this.cbAllMessReceived_CheckedChanged);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(6, 13);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(92, 13);
            this.label36.TabIndex = 1;
            this.label36.Text = "Watch for events:";
            // 
            // cbAuth
            // 
            this.cbAuth.AutoSize = true;
            this.cbAuth.Location = new System.Drawing.Point(9, 41);
            this.cbAuth.Name = "cbAuth";
            this.cbAuth.Size = new System.Drawing.Size(97, 17);
            this.cbAuth.TabIndex = 0;
            this.cbAuth.Text = "Authentificated";
            this.cbAuth.UseVisualStyleBackColor = true;
            this.cbAuth.CheckedChanged += new System.EventHandler(this.cbAuth_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 380);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(919, 31);
            this.panel1.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.lblMess);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(765, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(152, 29);
            this.panel9.TabIndex = 3;
            // 
            // lblMess
            // 
            this.lblMess.AutoSize = true;
            this.lblMess.Location = new System.Drawing.Point(3, 7);
            this.lblMess.Name = "lblMess";
            this.lblMess.Size = new System.Drawing.Size(58, 13);
            this.lblMess.TabIndex = 2;
            this.lblMess.Text = "Messages:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(43, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 13);
            this.label16.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(2, 8);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Status:";
            // 
            // NoopTimer
            // 
            this.NoopTimer.Enabled = true;
            this.NoopTimer.Interval = 1000;
            this.NoopTimer.Tick += new System.EventHandler(this.NoopTimer_Tick);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Seen";
            this.dataGridViewImageColumn1.Image = global::ImapClientExample.Properties.Resources.seen1;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 35;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Del";
            this.dataGridViewImageColumn2.Image = global::ImapClientExample.Properties.Resources.kor2;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Width = 35;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.Tabs);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(919, 380);
            this.panel8.TabIndex = 5;
            // 
            // iClient
            // 
            this.iClient.AttachmentDirectory = "";
            this.iClient.AuthenticationType = Email.Net.Common.Configurations.EAuthenticationType.Auto;
            this.iClient.Host = "localhost";
            this.iClient.Password = null;
            this.iClient.Port = ((ushort)(25));
            this.iClient.ProxyPort = ((ushort)(0));
            this.iClient.ProxyType = Email.Net.Common.Configurations.EProxyType.No;
            this.iClient.ReceiveTimeout = 10000;
            this.iClient.SendTimeout = 10000;
            this.iClient.SSLInteractionType = Email.Net.Common.Configurations.EInteractionType.Plain;
            this.iClient.Username = null;
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 2000;
            this.toolTip.InitialDelay = 500;
            this.toolTip.ReshowDelay = 100;
            this.toolTip.UseAnimation = false;
            this.toolTip.UseFading = false;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(6, 329);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(352, 13);
            this.label37.TabIndex = 5;
            this.label37.Text = "If event is checked then message will be writen to log after event is faired";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 411);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Tabs.ResumeLayout(false);
            this.MainTab.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Messages)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.AccountsTab.ResumeLayout(false);
            this.AccountsTab.PerformLayout();
            this.SubscriptionsTab.ResumeLayout(false);
            this.SubscriptionsTab.PerformLayout();
            this.tabSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchMessages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSearchMess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            this.panel27.ResumeLayout(false);
            this.panel27.PerformLayout();
            this.panel26.ResumeLayout(false);
            this.panel26.PerformLayout();
            this.panel25.ResumeLayout(false);
            this.panel25.PerformLayout();
            this.panel24.ResumeLayout(false);
            this.panel24.PerformLayout();
            this.panel23.ResumeLayout(false);
            this.panel23.PerformLayout();
            this.panel22.ResumeLayout(false);
            this.panel22.PerformLayout();
            this.panel21.ResumeLayout(false);
            this.panel21.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel20.ResumeLayout(false);
            this.panel20.PerformLayout();
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.NoopLogTab.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.tabEvents.ResumeLayout(false);
            this.tabEvents.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl Tabs;
		private System.Windows.Forms.TabPage MainTab;
		private System.Windows.Forms.TabPage AccountsTab;
		private System.Windows.Forms.Button NewBtn;
		private System.Windows.Forms.Button SetBtn;
		private System.Windows.Forms.TextBox txtPassw;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtLogin;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtPort;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtInServ;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtAccName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ListBox lbAcc;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button ConnBtn;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ComboBox cbSecType;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Button SelAccbtn;
		private System.Windows.Forms.Button DelAccBtn;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Timer NoopTimer;
		private System.Windows.Forms.Button DisconnBtn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TreeView trFolders;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TabPage SubscriptionsTab;
		private System.Windows.Forms.DataGridView dgvMessages;
		private System.Data.DataSet dsMess;
		private System.Data.DataTable Messages;
		private System.Data.DataColumn AttachmentsCol;
		private System.Data.DataColumn SubjectCol;
		private System.Data.DataColumn FromCol;
		private System.Data.DataColumn DateCol;
		private System.Data.DataColumn UIDCol;
		private System.Data.DataColumn SeenCol;
		private System.Windows.Forms.Label lblMess;
		private System.Windows.Forms.Button btnRenameFolder;
		private System.Windows.Forms.Button btnDeleteFolder;
		private System.Windows.Forms.Button btnNewFolder;
		private System.Data.DataColumn dataColumn1;
		private System.Windows.Forms.Button btnDelMess;
		private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
		private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label10;
		private System.Data.DataColumn Flags;
		private System.Windows.Forms.TreeView trSubs;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Button btnGetSubs;
		private System.Windows.Forms.Button btnUpdateMess;
		private System.Windows.Forms.TreeView trFolders2;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Button btnDelSubs;
		private System.Windows.Forms.Button btnAddSubs;
		private System.Windows.Forms.TabPage tabSearch;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Button btnSelFolder;
		private System.Windows.Forms.TabPage NoopLogTab;
		private System.Windows.Forms.ListBox lbNoopLog;
		private System.Windows.Forms.ListBox lbLog;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.DataGridViewTextBoxColumn attachmentsDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn subjectDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn fromDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewImageColumn Seen;
		private System.Windows.Forms.DataGridViewImageColumn Del;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Sel;
		private System.Windows.Forms.DataGridViewButtonColumn Flag;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Panel panel9;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox cbOrSeen;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.RadioButton rbUnDraft;
		private System.Windows.Forms.RadioButton rbDraft;
		private System.Windows.Forms.CheckBox cbOrDraft;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.RadioButton rbUnAns;
		private System.Windows.Forms.RadioButton rbAnswered;
		private System.Windows.Forms.CheckBox cbOrAns;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.RadioButton rbUnDel;
		private System.Windows.Forms.RadioButton rbDeleted;
		private System.Windows.Forms.CheckBox cbOrDeleted;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.RadioButton rbUnFlagged;
		private System.Windows.Forms.RadioButton rbFlagged;
		private System.Windows.Forms.CheckBox cbOrFlagged;
		private System.Windows.Forms.RadioButton rbUnSeen;
		private System.Windows.Forms.RadioButton rbSeen;
		private System.Windows.Forms.Panel panel16;
		private System.Windows.Forms.TextBox txtSBody;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.CheckBox cbOrBody;
		private System.Windows.Forms.Panel panel15;
		private System.Windows.Forms.TextBox txtSFrom;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.CheckBox cbOrFrom;
		private System.Windows.Forms.Panel panel14;
		private System.Windows.Forms.TextBox txtSBlCopy;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.CheckBox cbOrBlCopy;
		private System.Windows.Forms.Panel panel13;
		private System.Windows.Forms.TextBox txtSCopy;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.CheckBox cbOrCopy;
		private System.Windows.Forms.Panel panel12;
		private System.Windows.Forms.TextBox txtSTo;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.CheckBox cbOrTo;
		private System.Windows.Forms.Panel panel11;
		private System.Windows.Forms.TextBox txtSText;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.CheckBox cbOrText;
		private System.Windows.Forms.Panel panel10;
		private System.Windows.Forms.TextBox txtSSubj;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.CheckBox cbOrSubj;
		private System.Windows.Forms.Panel panel17;
		private System.Windows.Forms.TextBox txtSValue;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.TextBox txtSField;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.CheckBox cbOrHeader;
		private System.Windows.Forms.Panel panel20;
		private System.Windows.Forms.TextBox txtSUID;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.CheckBox cbOrUID;
		private System.Windows.Forms.Panel panel19;
		private System.Windows.Forms.TextBox txtSSmaller;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.CheckBox cbOrSmaller;
		private System.Windows.Forms.Panel panel18;
		private System.Windows.Forms.TextBox txtSLarger;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.CheckBox cbOrLarger;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton rbRecent;
		private System.Windows.Forms.RadioButton rbOld;
		private System.Windows.Forms.CheckBox cbOrOldRecent;
		private System.Windows.Forms.MaskedTextBox mtxtSBefore;
		private System.Windows.Forms.Panel panel21;
		private System.Windows.Forms.Panel panel26;
		private System.Windows.Forms.Label label34;
		private System.Windows.Forms.MaskedTextBox mtxtSSendSince;
		private System.Windows.Forms.CheckBox cbOrSendSince;
		private System.Windows.Forms.Panel panel25;
		private System.Windows.Forms.Label label33;
		private System.Windows.Forms.MaskedTextBox mtxtSSendOn;
		private System.Windows.Forms.CheckBox cbOrSendOn;
		private System.Windows.Forms.Panel panel24;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.MaskedTextBox mtxtSSentBefore;
		private System.Windows.Forms.CheckBox cbOrSendBefore;
		private System.Windows.Forms.Panel panel23;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.MaskedTextBox mtxtSSince;
		private System.Windows.Forms.CheckBox cbOrSince;
		private System.Windows.Forms.Panel panel22;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.MaskedTextBox mtxtsOn;
		private System.Windows.Forms.CheckBox cbOrOn;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.CheckBox cbOrBefore;
		private System.Windows.Forms.Button btnSSelFolder;
		private System.Windows.Forms.Panel panel27;
		private System.Windows.Forms.TextBox txtSFolder;
		private System.Windows.Forms.Label label35;
		private System.Data.DataSet dsSearchMess;
		private System.Data.DataTable dataTable1;
		private System.Data.DataColumn dataColumn2;
		private System.Data.DataColumn dataColumn3;
		private System.Data.DataColumn dataColumn4;
		private System.Data.DataColumn dataColumn5;
		private System.Data.DataColumn dataColumn6;
		private System.Data.DataColumn dataColumn7;
		private System.Data.DataColumn dataColumn8;
		private System.Data.DataColumn dataColumn9;
        private System.Windows.Forms.DataGridView dgvSearchMessages;
        private Email.Net.Imap.ImapClient iClient;
        private System.Windows.Forms.TabPage tabEvents;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.CheckBox cbAuth;
        private System.Windows.Forms.CheckBox cbAllMessReceived;
        private System.Windows.Forms.CheckBox cbMessReceived;
        private System.Windows.Forms.CheckBox cbServerRespRec;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewButtonColumn SearchFlag;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label label37;
	}
}

