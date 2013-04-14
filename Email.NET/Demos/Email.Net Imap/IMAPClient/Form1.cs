using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Email.Net.Common.Configurations;
using Email.Net.Imap;
using Email.Net.Imap.Collections;
using Email.Net.Imap.Responses;
using Email.Net.Imap.Sequences;
using Message = Email.Net.Imap.ImapMessage;

namespace ImapClientExample
{
	public partial class Form1 : Form
	{
        /// <summary>
        /// List of all accounts
        /// </summary>
		List<MailAccount> accounts;

        /// <summary>
        /// Currently selected account
        /// </summary>
		MailAccount selAccount;
        
        /// <summary>
        /// Selected mailbox
        /// </summary>
		Mailbox selMailbox = null;

		SimpleLogger noopLogger, logger;

        /// <summary>
        /// Plain list of all subscribed folders
        /// </summary>
		List<Mailbox> subsFolders;

		public Form1()
		{
			InitializeComponent();     

            // Fill accounts
			accounts = new List<MailAccount>();
			accounts.Add(new MailAccount() {AccountName="GMail IMAP", InServer="imap.gmail.com", Login="mail.net.777@gmail.com", Password="qwe12345", SecType = EInteractionType.SSLPort, Port = 993});
			accounts.Add(new MailAccount() {AccountName = "Rambler IMAP", InServer = "mail.rambler.ru", Login = "mail-net-777@rambler.ru", Password = "qwe12345", SecType = EInteractionType.SSLPort, Port = 993});
			accounts.Add(new MailAccount() {AccountName = "Yandex IMAP", InServer = "imap.yandex.ru", Login = "mail.net.777@yandex.ru", Password = "qwe12345", SecType = EInteractionType.Plain, Port = 143});
            
            // And select GMail.com as current account
			selAccount = accounts[0];

			label14.Text = selAccount.AccountName;
			lbAcc.Items.AddRange(accounts.ToArray());

			subsFolders = new List<Mailbox>();

            // Set loggers output to ListBoxes
			logger = new SimpleLogger(lbLog.Items);
			noopLogger = new SimpleLogger(lbNoopLog.Items);

            // Set current status of ImapClientExample
			IMAPStatus.statUpd = this.SetStatus;
			IMAPStatus.activateFunc = this.ActivateButtons;
			IMAPStatus.deactivateFunc = this.DeactivateButtons;
			IMAPStatus.ConnStatus = ConnectionStatus.Disconnected;

			iClient = new ImapClient();

            setToolTips();
    	}

		~Form1()
		{
			if (IMAPStatus.ConnStatus == ConnectionStatus.Connected)
			{
				iClient.Logout();
			}
		}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (IMAPStatus.ConnStatus == ConnectionStatus.Connected)
			{
				iClient.Logout();
			}
		}

        private void setToolTips()
        {
            toolTip.SetToolTip(this.ConnBtn, "Connect to server");
            toolTip.SetToolTip(this.DisconnBtn, "Disonnect from server");
            toolTip.SetToolTip(this.btnSelFolder, "Select mailbox");
            toolTip.SetToolTip(this.btnNewFolder, "Create new child mailbox");
            toolTip.SetToolTip(this.btnRenameFolder, "Rename current mailbox");
            toolTip.SetToolTip(this.btnDeleteFolder, "Delete selected mailbox");
            toolTip.SetToolTip(this.btnUpdateMess, "Update messages for selected mailbox");
            toolTip.SetToolTip(this.btnDelMess, "Delete messages marked as \"deleted\"");
            toolTip.SetToolTip(this.comboBox1, "Choose action with checked messages");
            toolTip.SetToolTip(this.NewBtn, "Save credentials as new account");
            toolTip.SetToolTip(this.SetBtn, "Update credentials for current account");
            toolTip.SetToolTip(this.btnGetSubs, "Get subscription tree");
            toolTip.SetToolTip(this.btnAddSubs, "Add selected mailbox to subscriptions");
            toolTip.SetToolTip(this.btnDelSubs, "Remove selected mailbox from subscriptions");
        }

		#region EventHandlers

        private void cbAuth_CheckedChanged(object sender, EventArgs e)
        {
            if(cbAuth.Checked)
                iClient.Authentificated += new Email.Net.Imap.Events.ClientEventHandler(iClient_Authentificated);
            else
                iClient.Authentificated += new Email.Net.Imap.Events.ClientEventHandler(iClient_Authentificated);
        }

        void iClient_Authentificated(ImapClient sender)
        {
            logger.addLogMessage("Authentificated!");
        }

        private void cbAllMessReceived_CheckedChanged(object sender, EventArgs e)
        {
            if(cbAllMessReceived.Checked)
                iClient.AllMessagesReceived += new Email.Net.Imap.Events.ClientEventHandler(iClient_AllMessagesReceived);
            else
                iClient.AllMessagesReceived -= new Email.Net.Imap.Events.ClientEventHandler(iClient_AllMessagesReceived);
        }

        void iClient_AllMessagesReceived(ImapClient sender)
        {
            logger.addLogMessage("All Messages Received!");
        }

        private void cbMessReceived_CheckedChanged(object sender, EventArgs e)
        {
            if(cbMessReceived.Checked)
                iClient.MessageReceived += new Email.Net.Imap.Events.MessageReceivedEventHandler(iClient_MessageRecived);
            else
                iClient.MessageReceived -= new Email.Net.Imap.Events.MessageReceivedEventHandler(iClient_MessageRecived);
        }

        void  iClient_MessageRecived(ImapClient sender, ImapMessage message)
        {
 	        logger.addLogMessage("Messages from " + message.From + " with subject\"" + message.Subject + "\" received!");
        }

        private void cbServerRespRec_CheckedChanged(object sender, EventArgs e)
        {
            if(cbServerRespRec.Checked)
                iClient.ServerResponseReceived += new Email.Net.Imap.Events.ServerResponseReceived(iClient_ServerResponseReceived);
            else
                iClient.ServerResponseReceived -= new Email.Net.Imap.Events.ServerResponseReceived(iClient_ServerResponseReceived);
        }

        void  iClient_ServerResponseReceived(object sender, IMAP4Response response)
        {
 	        logger.addLogMessage("Server response \"" + response.Response + "\" received! ");
        }

		#endregion

		#region Accounts managment

		private void SetBtn_Click(object sender, EventArgs e)
		{
			MailAccount ma = (MailAccount)lbAcc.SelectedItem;
			if (ma == null)
				return;
			if (cbSecType.SelectedIndex == -1)
				cbSecType.SelectedIndex = 0;
			ma.AccountName = txtAccName.Text;
			ma.InServer = txtInServ.Text;
			ma.Port = Int32.Parse(txtPort.Text);
			ma.Login = txtLogin.Text;
			ma.Password = txtPassw.Text;
			ma.SecType = (EInteractionType) cbSecType.SelectedIndex;
		}

		private void NewBtn_Click(object sender, EventArgs e)
		{
			if (cbSecType.SelectedIndex == -1)
				cbSecType.SelectedIndex = 0;
			MailAccount ma = new MailAccount() { AccountName = txtAccName.Text, InServer = txtInServ.Text, Password = txtPassw.Text, Login = txtLogin.Text, Port = Int32.Parse(txtPort.Text), SecType = (EInteractionType) cbSecType.SelectedIndex };
			accounts.Add(ma);
			lbAcc.Items.Add(ma);
		}

		private void lbAcc_SelectedIndexChanged(object sender, EventArgs e)
		{
			MailAccount ma = (MailAccount)lbAcc.SelectedItem;
			if (ma == null)
				return;
			txtAccName.Text = ma.AccountName;
			txtInServ.Text = ma.InServer;
			txtPort.Text = ma.Port.ToString();
			txtLogin.Text = ma.Login;
			txtPassw.Text = ma.Password;
			cbSecType.SelectedIndex = (int) ma.SecType;
		}

		private void SelAccbtn_Click(object sender, EventArgs e)
		{
			if (lbAcc.SelectedIndex == -1)
				return;
			selAccount = (MailAccount)lbAcc.Items[lbAcc.SelectedIndex];
			label14.Text = selAccount.AccountName;
		}

		private void DelAccBtn_Click_1(object sender, EventArgs e)
		{
			int index = lbAcc.SelectedIndex;
			List<MailAccount> remList = new List<MailAccount>();
			remList.Add((MailAccount)lbAcc.Items[index]);
			if (MessageBox.Show("Do you really want to delete account " + ((MailAccount)lbAcc.Items[index]).AccountName + " ?", "MailAccount Delete", MessageBoxButtons.YesNo) == DialogResult.No)
				return;

		    accounts.Remove((MailAccount) lbAcc.Items[index]);
			
			lbAcc.Items.Clear();
			lbAcc.Items.AddRange(accounts.ToArray());
		}

		#endregion

		public void SetStatus()
		{
			label16.Text = IMAPStatus.ConnStatus.ToString();
		}

		public void ActivateButtons()
		{
			logger.addLogMessage("Connection successfull!");

			btnDeleteFolder.Enabled = btnDelMess.Enabled = btnNewFolder.Enabled = btnSelFolder.Enabled =
				comboBox1.Enabled = btnRenameFolder.Enabled = btnSearch.Enabled = true;
			comboBox1.SelectedIndex = 0;

			ConnBtn.Enabled = false;
			DisconnBtn.Enabled = true;

            // Show mailbox tree
			getAllFolders();
		}

		public void DeactivateButtons()
		{
			logger.addLogMessage("Disonnection successfull!");

			btnDeleteFolder.Enabled = btnDelMess.Enabled = btnNewFolder.Enabled = btnSelFolder.Enabled =
				comboBox1.Enabled = btnRenameFolder.Enabled = btnSearch.Enabled = false;

			ConnBtn.Enabled = true;
			DisconnBtn.Enabled = false;

			trFolders.Nodes.Clear();
			dsMess.Tables[0].Rows.Clear();
			lbNoopLog.Items.Clear();
		}

		#region Connect/Disconnect

        /// <summary>
        /// Connect to server with selected credentials
        /// </summary>
		private void ConnBtn_Click(object sender, EventArgs e)
		{
            // Set credentials
			iClient.Host = selAccount.InServer;
			iClient.Port = (ushort)selAccount.Port;
			iClient.Password = selAccount.Password;
			iClient.Username = selAccount.Login;
			iClient.SSLInteractionType = selAccount.SecType;

			try
			{
                // Try to login
				CompletionResponse response = iClient.Login();

                // Log server response
				logger.addLogMessage("Connection.", response);

				if (response.CompletionResult == ECompletionResponseType.OK)
				{
					IMAPStatus.ConnStatus = ConnectionStatus.Connected;
				}
				else if (response.CompletionResult == ECompletionResponseType.NO)
				{
					IMAPStatus.ConnStatus = ConnectionStatus.FailedConnect;
					MessageBox.Show("Connection failed. Response=" + response.Response + ". Message=" + response.Message + ". Data=" + response.Data, "Connection failed", MessageBoxButtons.OK);
					//iClient.Logout();
				}
				else if (response.CompletionResult == ECompletionResponseType.BAD)
				{
					IMAPStatus.ConnStatus = ConnectionStatus.BadResponse;
					MessageBox.Show("Connection bad response. Response=" + response.Response + ". Message=" + response.Message + ". Data=" + response.Data, "Connection bad response", MessageBoxButtons.OK);
					//iClient.Logout();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Exception during login. Message=" + ex.Message + ". Trace=" + ex.StackTrace + ". Source=" + ex.Source, "Exception during login", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

        /// <summary>
        /// Disconnect from server
        /// </summary>
		private void DisconnBtn_Click(object sender, EventArgs e)
		{
			try
			{
                // Try to disconnect
				CompletionResponse response = iClient.Logout();

                // Log server response
				logger.addLogMessage("Disconnection.", response);

				if (response.CompletionResult == ECompletionResponseType.OK)
				{
					IMAPStatus.ConnStatus = ConnectionStatus.Disconnected;
				}
				else if (response.CompletionResult == ECompletionResponseType.NO)
				{
					IMAPStatus.ConnStatus = ConnectionStatus.FailedDisconnect;
					MessageBox.Show("Logout failed. Response=" + response.Response + ". Message=" + response.Message + ". Data=" + response.Data, "Logout failed", MessageBoxButtons.OK);
					iClient.Logout();
				}
				else if (response.CompletionResult == ECompletionResponseType.BAD)
				{
					IMAPStatus.ConnStatus = ConnectionStatus.BadResponse;
					MessageBox.Show("Logout bad response. Response=" + response.Response + ". Message=" + response.Message + ". Data=" + response.Data, "Logout bad response", MessageBoxButtons.OK);
					iClient.Logout();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Exception during logout. Message=" + ex.Message + ". Trace=" + ex.StackTrace + ". Source=" + ex.Source, "Exception during logout", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		#endregion

        /// <summary>
        /// Function sends Noop command if client is connected to stay connection alive
        /// </summary>
		private void NoopTimer_Tick(object sender, EventArgs e)
		{
			if (IMAPStatus.ConnStatus == ConnectionStatus.Connected)
			{
                CompletionResponse resp = iClient.Noop();

                // Add response to log
				noopLogger.addLogMessage(resp);
			}
		}

        /// <summary>
        /// Functions checks is two mailboxes are equal
        /// </summary>
        /// <param name="mb1">First mailbox to compare</param>
        /// <param name="mb2">Second mailbox to compare</param>
        /// <returns>True if two mailboxes are equal, False otherwise</returns>
		bool MailboxesEquals(Mailbox mb1, Mailbox mb2)
		{
			MailboxComparer mc = new MailboxComparer();
			return mc.Equals(mb1, mb2);
		}

		#region ShowTree

        /// <summary>
        /// Function gets mailboxes tree and shows it on form
        /// </summary>
		private void getAllFolders()
		{
			logger.addLogMessage("Calling GetMailboxTree");
			Mailbox mailbox = iClient.GetMailboxTree();

			trFolders.Nodes.Clear();
			// Create root node
			String nodeName = mailbox.DisplayName;
			if (String.IsNullOrEmpty(nodeName))
				nodeName = mailbox.FullName;
			if (String.IsNullOrEmpty(nodeName))
				nodeName = mailbox.Name;
			if (String.IsNullOrEmpty(nodeName))
				nodeName = "RootNode";
			TreeNode tn = new TreeNode(nodeName);
            // Save Mailbox in node tag
			tn.Tag = mailbox;

            // Mark selected mailbox with red
			if(MailboxesEquals(mailbox, selMailbox))
				tn.ForeColor = Color.Red;

			trFolders.Nodes.Add(tn);
			
            //Add childrens to current node
			addFoldersToTree(tn, mailbox.Children);
			tn.ExpandAll();
		}

        /// <summary>
        /// Recursive function to add childrens to current tree node
        /// </summary>
        /// <param name="rootNode">Root node for childrens</param>
        /// <param name="folders">Collection of mailboxes to add like childrens</param>
		private void addFoldersToTree(TreeNode rootNode, MailboxCollection folders)
		{
			foreach (Mailbox mb in folders)
			{
				TreeNode tn = new TreeNode(mb.DisplayName);

                // Mark selected mailbox with red
				if(MailboxesEquals(mb, selMailbox))
					tn.ForeColor = Color.Red;
				tn.Tag = mb;
    			rootNode.Nodes.Add(tn);

				addFoldersToTree(tn, mb.Children);
			}
		}
		#endregion

		#region ShowSubscriptionTree

        /// <summary>
        /// Loads tree of current mailbox subscriptions
        /// </summary>
		private void getAllSubsFolders()
		{
            trSubs.Nodes.Clear();
            trFolders2.Nodes.Clear();
            subsFolders.Clear();

			//Load tree of mailbpx subscriptions
			logger.addLogMessage("Calling GetSubscribedMailboxTree");

			Mailbox subsMailbox = iClient.GetSubscribedMailboxTree();
			
			String nodeName = subsMailbox.DisplayName;
			if (String.IsNullOrEmpty(nodeName))
				nodeName = subsMailbox.FullName;
			if (String.IsNullOrEmpty(nodeName))
				nodeName = subsMailbox.Name;
			if (String.IsNullOrEmpty(nodeName))
				nodeName = "RootNode";
			TreeNode tn = new TreeNode(nodeName);
            // Add subscribed folder to subsFolders list
			subsFolders.Add(subsMailbox);
			tn.Tag = subsMailbox;
			trSubs.Nodes.Add(tn);
			//Add childrens
			addSubsFoldersToTree(tn, subsMailbox.Children);
			tn.ExpandAll();

			//Load tree of all mailbox folders
			logger.addLogMessage("Calling GetMailboxTree");

			Mailbox mailbox = iClient.GetMailboxTree();

			nodeName = mailbox.DisplayName;
			if (String.IsNullOrEmpty(nodeName))
				nodeName = mailbox.FullName;
			if (String.IsNullOrEmpty(nodeName))
				nodeName = mailbox.Name;
			if (String.IsNullOrEmpty(nodeName))
				nodeName = "RootNode";
			TreeNode tn2 = new TreeNode(nodeName);
			tn2.Tag = mailbox;
			trFolders2.Nodes.Add(tn2);
            //Add childrens
			addFoldersToTree(tn2, mailbox.Children, Color.Gray);
			tn2.ExpandAll();
		}

		private void addSubsFoldersToTree(TreeNode rootNode, MailboxCollection folders)
		{
			foreach (Mailbox mb in folders)
			{
				TreeNode tn = new TreeNode(mb.DisplayName);
				tn.Tag = mb;
				rootNode.Nodes.Add(tn);
                // Add subscribed folder to subsFolders list
				subsFolders.Add(mb);
				addSubsFoldersToTree(tn, mb.Children);
			}
		}

		private void addFoldersToTree(TreeNode rootNode, MailboxCollection folders, Color color)
		{
			foreach (Mailbox mb in folders)
			{
				TreeNode tn = new TreeNode(mb.DisplayName);
				tn.Tag = mb;
				rootNode.Nodes.Add(tn);

                //If current mailbox is subscribed then mark it with gray color
			    foreach(Mailbox box in subsFolders)
                    if(new MailboxComparer().Equals(box, mb))
                        tn.ForeColor = color;

				addFoldersToTree(tn, mb.Children, color);
			}
		}

		private void btnGetSubs_Click(object sender, EventArgs e)
		{
			getAllSubsFolders();
		}
		#endregion

        #region Add Delete Subscriptions
        /// <summary>
        /// Adds selected mailbox to subscription tree
        /// </summary>
        private void btnAddSubs_Click(object sender, EventArgs e)
        {
            if (trFolders2.SelectedNode == null)
                return;
            TreeNode tn = trFolders2.SelectedNode;
            Mailbox mb = (Mailbox)tn.Tag;

            // Don't add root mailbox
            if (mb.Parent == null)
                return;

            // If selected mailbox was subscribes early then return
            foreach(Mailbox box in subsFolders)
                if(new MailboxComparer().Equals(box, mb))
                    return;

            iClient.Subscribe(mb);
            // Renew subscription tree
            getAllSubsFolders();
        }

        /// <summary>
        /// Delete selected mailbox from subscription tree
        /// </summary>
        private void btnDelSubs_Click(object sender, EventArgs e)
        {
            if (trSubs.SelectedNode == null)
                return;
            TreeNode tn = trSubs.SelectedNode;
            Mailbox mb = (Mailbox)tn.Tag;

            iClient.Unsubscribe(mb);
            getAllSubsFolders();
        }
        #endregion

		#region ShowAllMessagesForSelectedFolder
        /// <summary>
        /// Update list of messages for selected mailbox after mailbox selection changed
        /// </summary>
		private void trFolders_AfterSelect(object sender, TreeViewEventArgs e)
		{
			if (e.Node == null)
				return;
			if (IMAPStatus.ConnStatus != ConnectionStatus.Connected)
				return;
			if (((Mailbox)e.Node.Tag).Parent == null)
				return;

            // Update messages
			getAllMessages((Mailbox)e.Node.Tag);
            // Update message count label in status bar
			showMessCount((Mailbox)e.Node.Tag);
		}

        /// <summary>
        /// Show all messages for specified mailbox
        /// </summary>
        /// <param name="folder">Mailbox to show messages from</param>
		private void getAllMessages(Mailbox folder)
		{
			fillAllMessagesForFolder(folder);
		}

        /// <summary>
        /// Shows all messages for currently selected mailbox
        /// </summary>
		private void getAllMessages()
		{
			if (IMAPStatus.ConnStatus != ConnectionStatus.Connected)
				return;

			if (trFolders.SelectedNode == null)
				return;

			Mailbox folder = (Mailbox)trFolders.SelectedNode.Tag;

			if (folder.Parent == null)
				return;

			fillAllMessagesForFolder(folder);
		}

        /// <summary>
        /// Loads all messages from mailbox and fills dataSet with them 
        /// </summary>
        /// <param name="folder">Mailbox to load messages from</param>
		private void fillAllMessagesForFolder(Mailbox folder)
		{
			try
			{
                // Load messages
				MessageCollection messages = iClient.GetAllMessageHeaders(folder);
				logger.addLogMessage("Calling GetAllMessageHeaders. Got " + messages.Count + " messages");
                // Fill table with messages
				fillTableWithMessages(dsMess.Tables[0], messages);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Exception during GetAllMessages. Message=" + ex.Message + ". Trace=" + ex.StackTrace + ". Source=" + ex.Source, "Exception during GetAllMessages", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

        /// <summary>
        /// Loads all messages from messages collection to DataSet table
        /// </summary>
        /// <param name="dt">Table to fill in with messages</param>
        /// <param name="messages">Messages collection</param>
		private void fillTableWithMessages(DataTable dt, MessageCollection messages)
		{
			dt.Rows.Clear();
			foreach (Message message in messages)
			{
				DataRow row = dt.NewRow();
				row["Subject"] = message.Header.Subject;
                if (message.Header.From != null)
                    row["From"] = message.Header.From.DisplayName + " (" + message.Header.From.Address + ")";
                else
                    row["From"] = "message.Header.From is null!";
				if (message.Attachments.Count > 0)
					row["Attachments"] = "A";
				else
					row["Attachments"] = "";
				row["UID"] = message.UID;
				row["Date"] = message.Header.Date.ToShortDateString() + " " + message.Header.Date.ToShortTimeString();
				MessageFlagCollection mfc = message.Flags;
                if (mfc.Contains(new MessageFlag(EFlag.Seen)))
					row["Seen"] = 1;
				else
					row["Seen"] = 0;
				row["Del"] = message.IsDeleted;
				row["Flags"] = message.Flags;
				dt.Rows.Add(row);
			}
		}

        /// <summary>
        /// Gets messages count in mailbox and shows it in status bar
        /// </summary>
        /// <param name="folder">Mailbox to get count of messages</param>
		private void showMessCount(Mailbox folder)
		{
			try
			{
				uint count = iClient.GetMessageCount(folder);
				logger.addLogMessage("Calling GetMessageCount. Got " + count);
				lblMess.Text = "Messages: " + count;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Exception during GetMessageCount. Message=" + ex.Message + ". Trace=" + ex.StackTrace + ". Source=" + ex.Source, "Exception during GetAllMessages", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

        /// <summary>
        /// Formats DataGridView row to show message
        /// </summary>
		private void dgvMessages_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			DataGridViewRow row = dgvMessages.Rows[e.RowIndex];
            
            // If message not seen yet then show it with bold font and orange circle
			if (((Int32)dsMess.Tables[0].Rows[e.RowIndex]["Seen"]) == 0)
			{
				dgvMessages.Rows[e.RowIndex].DefaultCellStyle.Font = new Font("Verdana", (float)7, FontStyle.Bold);
				((DataGridViewImageCell)row.Cells["Seen"]).Value = ImapClientExample.Properties.Resources.seen1;
			}
			else
                // Seen messages show with gray circle
				((DataGridViewImageCell)row.Cells["Seen"]).Value = ImapClientExample.Properties.Resources.seen2;
			
            // Deleted messages show with color "trash box" picture
            if (((Boolean)dsMess.Tables[0].Rows[e.RowIndex]["Del"]))
			{
				dgvMessages.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.DarkMagenta;
				((DataGridViewImageCell)row.Cells["Del"]).Value = ImapClientExample.Properties.Resources.kor1;
			}
			else
				((DataGridViewImageCell)row.Cells["Del"]).Value = ImapClientExample.Properties.Resources.kor2;

			row.Cells["Sel"].Value = false;
		}

        /// <summary>
        /// Updates message list for selected mailbox
        /// </summary>
		private void btnUpdateMess_Click(object sender, EventArgs e)
		{
			getAllMessages();
		}
		#endregion	

		#region ShowMessage
        /// <summary>
        /// Event handler for double-click on DataGridView row. Shows message in separate window
        /// </summary>
		private void dgvMessages_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			TreeNode tn = trFolders.SelectedNode;
			if (tn == null)
				return;
			DataRow row = dsMess.Tables[0].Rows[e.RowIndex];
			getMessage((uint)row["UID"], (Mailbox)tn.Tag);
		}

        /// <summary>
        /// Shows specified message in separate window
        /// </summary>
        /// <param name="messUID">UID of message</param>
        /// <param name="folder">Mailbox that contains message</param>
		private void getMessage(uint messUID, Mailbox folder)
		{
			logger.addLogMessage("Get full message from folder " + folder.DisplayName + " for uid="+messUID);
			Message message = iClient.GetFullMessage(messUID, folder);
			ShowMessage sm = new ShowMessage(message);
			sm.Show();

			// Update messages (for case then messages are marked as seen automatically by server)
			getAllMessages();
		}
		#endregion

		#region CreateRenameDeleteFolders
        /// <summary>
        /// Create new child mailbox for selected mailbox 
        /// </summary>
		private void btnNewFolder_Click(object sender, EventArgs e)
		{
			TreeNode selNode = trFolders.SelectedNode;
			if (selNode == null)
				return;

			if (IMAPStatus.ConnStatus != ConnectionStatus.Connected)
				return;
			
            // Get name for new mailbox
            InputTextBox itb = new InputTextBox("New Folder Name", "Input new folder name");
			if (itb.ShowDialog() != DialogResult.OK)
				return;

			CompletionResponse response;
			if (((Mailbox)selNode.Tag).Parent == null)
				// New mailbox for root node
				response = iClient.CreateMailbox(itb.TextEntered);
			else
                // New mailbox for selected mailbox
				response = iClient.CreateMailbox(itb.TextEntered, (Mailbox)selNode.Tag);
			logger.addLogMessage("CreateMailbox: ", response);
			
            if (response.CompletionResult != ECompletionResponseType.OK)
				MessageBox.Show("Creation failed. Response=" + response.Response + ". Message=" + response.Message + ". Data=" + response.Data, "Connection failed", MessageBoxButtons.OK);
			else
                // Update mailbox tree
				getAllFolders();
		}
		
        /// <summary>
        /// Remove selected mailbox
        /// </summary>
		private void btnDeleteFolder_Click(object sender, EventArgs e)
		{
			TreeNode selNode = trFolders.SelectedNode;
			if (selNode == null)
				return;
			
            if (IMAPStatus.ConnStatus != ConnectionStatus.Connected)
				return;
			
            CompletionResponse response = iClient.DeleteMailbox((Mailbox)selNode.Tag);
			logger.addLogMessage("DeleteMailbox: ", response);
			
            if (response.CompletionResult != ECompletionResponseType.OK)
				MessageBox.Show("Delete failed. Response=" + response.Response + ". Message=" + response.Message + ". Data=" + response.Data, "Connection failed", MessageBoxButtons.OK);
			else
                // Update mailbox tree
				getAllFolders();
		}

        /// <summary>
        /// Rename currently selected mailbox
        /// </summary>
		private void btnRenameFolder_Click(object sender, EventArgs e)
		{
			TreeNode selNode = trFolders.SelectedNode;
			if (selNode == null)
				return;
			
            if (IMAPStatus.ConnStatus != ConnectionStatus.Connected)
				return;
			
            // Get new name for mailbox
            InputTextBox itb = new InputTextBox("Rename Folder", "Input new name for folder");
			if (itb.ShowDialog() != DialogResult.OK)
				return;
			
            CompletionResponse response = iClient.RenameMailbox((Mailbox)selNode.Tag, itb.TextEntered);
			logger.addLogMessage("RenameMailbox: ", response);
			
            if (response.CompletionResult != ECompletionResponseType.OK)
				MessageBox.Show("Rename failed. Response=" + response.Response + ". Message=" + response.Message + ". Data=" + response.Data, "Connection failed", MessageBoxButtons.OK);
			else
                // Update mailbox tree
				getAllFolders();
		}

		#endregion

		#region Seen, Delete, Copy and changing flags for message
		
        /// <summary>
		/// Event handler for click on DataGridView row. Marks message as seen/unseen, deleted/undeleted. Shows flags for message
		/// </summary>
        private void dgvMessages_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			DataRow row = dsMess.Tables[0].Rows[e.RowIndex];
			
            // If "Seen" column was
			if (dgvMessages.Columns[e.ColumnIndex].Name.Equals("Seen"))
			{
				Mailbox folder = (Mailbox)trFolders.SelectedNode.Tag;
				uint messUID = (uint)row["UID"];
                MessageSequenceNumbers n = new MessageSequenceNumbers();
				n.Add(new SequenceNumber(messUID));
                // If message wasn't seen
				if ((Int32)row["Seen"] == 0)
				{
                    // Then mark it as seen
					logger.addLogMessage("MarkAsSeen message with uid=" + messUID);
					iClient.MarkAsSeen(n, folder);
				}
				else
				{
                    // Mark message as unseen
					logger.addLogMessage("MarkAsUnseen message with uid=" + messUID);
					iClient.MarkAsUnseen(n, folder);
				}

				//Update messages
				getAllMessages();
			}

			//If "Delete" column was clicked
			if (dgvMessages.Columns[e.ColumnIndex].Name.Equals("Del"))
			{
				Mailbox folder = (Mailbox)trFolders.SelectedNode.Tag;
				uint messUID = (uint)row["UID"];
				MessageSequenceNumbers n = new MessageSequenceNumbers();
				n.Add(new SequenceNumber(messUID));
                // If message was marked as deleted
				if ((Boolean)row["Del"])
				{
                    // Then mark it as undeleted
					logger.addLogMessage("MarkAsUndeleted message with uid=" + messUID);
					iClient.MarkAsUndeleted(n, folder);
				}
				else
				{
					logger.addLogMessage("MarkAsDeleted message with uid=" + messUID);
					iClient.MarkAsDeleted(n, folder);
				}

                //Update messages
				getAllMessages();
			}

            // If "Flag" column was clicked then show flags for current message in separate window
			if (dgvMessages.Columns[e.ColumnIndex].Name.Equals("Flag"))
			{
				MessageFlagCollection flCol = (MessageFlagCollection)row["Flags"];
				ShowSetFlags sst = new ShowSetFlags(flCol, ShowSetFlags.ShowSetFlagMode.Show);
				sst.ShowDialog();
			}
            
            // Change check box state
			if (dgvMessages.Columns[e.ColumnIndex].Name.Equals("Sel"))
			{
				((DataGridViewCheckBoxCell)dgvMessages.Rows[e.RowIndex].Cells["Sel"]).Value = !((Boolean)((DataGridViewCheckBoxCell)dgvMessages.Rows[e.RowIndex].Cells["Sel"]).Value);
			}
		}

        /// <summary>
        /// Delete message marked for deletion from mailbox
        /// </summary>
		private void btnDelMess_Click(object sender, EventArgs e)
		{
            if (trFolders.SelectedNode == null)
                return;

			Mailbox folder = (Mailbox)trFolders.SelectedNode.Tag;

			if (folder.Parent == null)
				return;
			
            logger.addLogMessage("Calling DeleteMarkedMessages");
			iClient.DeleteMarkedMessages(folder);

			//Update messages
			getAllMessages();
		}

        /// <summary>
        /// Event handler for ComboBox selection changed. Copy messages. Marks messages as seen/unseen, delete/undelete. Sets flags for selected messages
        /// </summary>
		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (trFolders.SelectedNode == null)
				return;
			Mailbox folder = (Mailbox)trFolders.SelectedNode.Tag;

			if (folder.Parent == null)
				return;

			if (comboBox1.SelectedIndex == 0)
				// None action
				return;

			if (comboBox1.SelectedIndex >= 1 && comboBox1.SelectedIndex <= 6)
			{
                // Fill list of selected messages UIDs
				MessageSequenceNumbers n = new MessageSequenceNumbers();
				foreach (DataGridViewRow row in dgvMessages.Rows)
				{
					if (((bool)((DataGridViewCheckBoxCell)row.Cells["Sel"]).Value))
					{
						DataRow dr = dsMess.Tables[0].Rows[row.Index];
						n.Add(new SequenceNumber((uint)dr["UID"]));
					}
				}

				switch (comboBox1.SelectedIndex)
				{
					case 1:	//Copy messages
						// Choose destinatin mailbox
                        SelFolderForm ssf = new SelFolderForm(iClient);
						if (ssf.ShowDialog() != DialogResult.OK)
							return;
						Mailbox folderTo = ssf.selFolder;
						if (folderTo.Parent == null)
							return;
						
                            logger.addLogMessage("Copy " + n.Count + " messages from " + folder.DisplayName + " to " + folderTo.DisplayName);
						iClient.Copy(n, folder, folderTo);
						break;
					case 2:	// Mark Seen
						logger.addLogMessage("MarkAsSeen " + n.Count + " messages from " + folder.DisplayName + " folder ");
						iClient.MarkAsSeen(n,folder);
						break;
					case 3:	// Mark UnSeen
						logger.addLogMessage("MarkAsUnseen " + n.Count + " messages from " + folder.DisplayName + " folder ");
						iClient.MarkAsUnseen(n, folder);
						break;
					case 4:	// Mark To Delete
						logger.addLogMessage("MarkAsDelete " + n.Count + " messages from " + folder.DisplayName + " folder ");
						iClient.MarkAsDeleted(n, folder);
						break;
					case 5:	// Mark To Undelete
						logger.addLogMessage("MarkAsUndelete " + n.Count + " messages from " + folder.DisplayName + " folder ");
						iClient.MarkAsUndeleted(n, folder);
						break;
					case 6: // Set message flags for selected messages
						// Get new flags
                        ShowSetFlags sst = new ShowSetFlags();
						if (sst.ShowDialog() != DialogResult.OK)
							return;
						logger.addLogMessage("SetMessageFlags for " + n.Count + " messages from " + folder.DisplayName + " folder. FlagMode=" + sst.FlagMode);
						iClient.SetMessageFlags(n, folder, sst.NewFlagCollection, sst.FlagMode);
						break;
				}
			}

			comboBox1.SelectedIndex = 0;

			//Update messages
			getAllMessages();
		}
		#endregion

        /// <summary>
        /// Select mailbox
        /// </summary>
		private void SelBtn_Click(object sender, EventArgs e)
		{
			TreeNode selNode = trFolders.SelectedNode;
			if (selNode == null)
				return;
			
            // Mark mailbox as selected
            logger.addLogMessage("Select " + ((Mailbox)selNode.Tag).DisplayName + " folder");
			CompletionResponse resp = iClient.Select((Mailbox)selNode.Tag);
			
            if (resp.CompletionResult == ECompletionResponseType.OK)
				selMailbox = (Mailbox)selNode.Tag;
			
            // Update mailbox tree
            getAllFolders();
		}

		#region Search
		private void btnSearch_Click(object sender, EventArgs e)
		{
            if (txtSFolder.Tag == null)
            {
                MessageBox.Show("Please choose mailbox to search in", "Choose mailbox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Define query
			Query q = null;

			#region RadioButton conditions
			if (cbOrOldRecent.Checked)
			{
                if (rbOld.Checked)
                    if (q == null)
                        q = Query.Old();
                    else
        				q = Query.Or(q, Query.Old());
				if (rbRecent.Checked)
                    if (q == null)
                        q = Query.Recent();
                    else
    					q = Query.Or(q, Query.Recent());
			}

			if (cbOrSeen.Checked)
			{
				if (rbSeen.Checked)
                    if (q == null)
                        q = Query.Seen();
                    else
    					q = Query.Or(q, Query.Seen());
				if (rbUnSeen.Checked)
                    if (q == null)
                        q = Query.Unseen();
                    else
    					q = Query.Or(q, Query.Unseen());
			}

			if (cbOrAns.Checked)
			{
				if (rbAnswered.Checked)
                    if (q == null)
                        q = Query.Answered();
                    else
    					q = Query.Or(q, Query.Answered());
				if (rbUnAns.Checked)
                    if (q == null)
                        q = Query.UnAnswered();
                    else
    					q = Query.Or(q, Query.UnAnswered());
			}

			if (cbOrDeleted.Checked)
			{
				if (rbDeleted.Checked)
                    if (q == null)
                        q = Query.Deleted();
                    else
    					q = Query.Or(q, Query.Deleted());
				if (rbUnDel.Checked)
                    if (q == null)
                        q = Query.UnDeleted();
                    else
    					q = Query.Or(q, Query.UnDeleted());
			}

			if (cbOrDraft.Checked)
			{
				if (rbDraft.Checked)
                    if (q == null)
                        q = Query.Draft();
                    else
    					q = Query.Or(q, Query.Draft());
				if (rbUnDraft.Checked)
                    if (q == null)
                        q = Query.UnDraft();
                    else
    					q = Query.Or(q, Query.UnDraft());
			}

			if (cbOrFlagged.Checked)
			{
				if (rbFlagged.Checked)
                    if (q == null)
                        q = Query.Flagged();
                    else
    					q = Query.Or(q, Query.Flagged());
				if (rbUnFlagged.Checked)
                    if (q == null)
                        q = Query.UnFlagged();
                    else
    					q = Query.Or(q, Query.UnFlagged());
			}
			#endregion

			#region UInt conditions
			if (cbOrLarger.Checked)
			{
				uint value;
				if (UInt32.TryParse(txtSLarger.Text, out value))
                    if (q == null)
                        q = Query.Larger(value);
                    else
    				    q = Query.Or(q, Query.Larger(value));
			}

			if (cbOrSmaller.Checked)
			{
				uint value;
				if (UInt32.TryParse(txtSSmaller.Text, out value))
                    if (q == null)
                        q = Query.Smaller(value);
                    else
    					q = Query.Or(q, Query.Smaller(value));
			}

			if (cbOrUID.Checked)
			{
				MessageSequenceNumbers uids = new MessageSequenceNumbers();
				foreach (String uidStr in txtSUID.Text.Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries))
				{
					uint value;
					if (UInt32.TryParse(uidStr,out value))
						uids.Add(new SequenceNumber(value));
				}
                if (q == null)
                    q = Query.UID(uids);
                else
    				q = Query.Or(q, Query.UID(uids));
			}
			#endregion

			#region Text conditions
			if (cbOrSubj.Checked)
				if (!String.IsNullOrEmpty(txtSSubj.Text))
                    if (q == null)
                        q = Query.Subject(txtSSubj.Text);
                    else
    					q = Query.Or(q, Query.Subject(txtSSubj.Text));

			if (cbOrFrom.Checked)
				if (!String.IsNullOrEmpty(txtSFrom.Text))
                    if (q == null)
                        q = Query.From(txtSFrom.Text);
                    else
    					q = Query.Or(q, Query.From(txtSFrom.Text));

			if (cbOrTo.Checked)
				if (!String.IsNullOrEmpty(txtSTo.Text))
                    if (q == null)
                        q = Query.To(txtSTo.Text);
                    else
    					q = Query.Or(q, Query.To(txtSTo.Text));

			if (cbOrCopy.Checked)
				if (!String.IsNullOrEmpty(txtSCopy.Text))
                    if (q == null)
                        q = Query.CC(txtSCopy.Text);
                    else
    					q = Query.Or(q, Query.CC(txtSCopy.Text));

			if (cbOrBlCopy.Checked)
				if (!String.IsNullOrEmpty(txtSBlCopy.Text))
                    if (q == null)
                        q = Query.BCC(txtSBlCopy.Text);
                    else
    					q = Query.Or(q, Query.BCC(txtSBlCopy.Text));

			if (cbOrText.Checked)
				if (!String.IsNullOrEmpty(txtSText.Text))
                    if (q == null)
                        q = Query.Text(txtSText.Text);
                    else
    					q = Query.Or(q, Query.Text(txtSText.Text));

			if (cbOrBody.Checked)
				if (!String.IsNullOrEmpty(txtSBody.Text))
                    if (q == null)
                        q = Query.Body(txtSBody.Text);
                    else
    					q = Query.Or(q, Query.Body(txtSBody.Text));

			if (cbOrHeader.Checked)
				if (!String.IsNullOrEmpty(txtSField.Text))
					if (!String.IsNullOrEmpty(txtSValue.Text))
                        if (q == null)
                            q = Query.Header(txtSField.Text, txtSValue.Text);
                        else
    						q = Query.Or(q, Query.Header(txtSField.Text, txtSValue.Text));
			#endregion

			#region Date conditions
			if (cbOrSince.Checked)
			{
				DateTime dt;
				if(DateTime.TryParse(mtxtSSince.Text,System.Globalization.CultureInfo.GetCultureInfo("ru-RU"),System.Globalization.DateTimeStyles.AssumeLocal,out dt))
                    if (q == null)
                        q = Query.Since(dt);
                    else
    					q = Query.Or(q,Query.Since(dt));					
			}

			if (cbOrOn.Checked)
			{
				DateTime dt;
				if(DateTime.TryParse(mtxtsOn.Text,System.Globalization.CultureInfo.GetCultureInfo("ru-RU"),System.Globalization.DateTimeStyles.AssumeLocal,out dt))
                    if (q == null)
                        q = Query.On(dt);
                    else
    					q = Query.Or(q,Query.On(dt));					
			}

			if (cbOrBefore.Checked)
			{
				DateTime dt;
				if (DateTime.TryParse(mtxtSBefore.Text, System.Globalization.CultureInfo.GetCultureInfo("ru-RU"), System.Globalization.DateTimeStyles.AssumeLocal, out dt))
                    if (q == null)
                        q = Query.Before(dt);
                    else
    					q = Query.Or(q, Query.Before(dt));
			}

			if (cbOrSendSince.Checked)
			{
				DateTime dt;
				if (DateTime.TryParse(mtxtSSendSince.Text, System.Globalization.CultureInfo.GetCultureInfo("ru-RU"), System.Globalization.DateTimeStyles.AssumeLocal, out dt))
                    if (q == null)
                        q = Query.SentSince(dt);
                    else
    					q = Query.Or(q, Query.SentSince(dt));
			}

			if (cbOrSendOn.Checked)
			{
				DateTime dt;
				if (DateTime.TryParse(mtxtSSendOn.Text, System.Globalization.CultureInfo.GetCultureInfo("ru-RU"), System.Globalization.DateTimeStyles.AssumeLocal, out dt))
                    if (q == null)
                        q = Query.SentOn(dt);
                    else
    					q = Query.Or(q, Query.SentOn(dt));
			}

			if (cbOrSendBefore.Checked)
			{
				DateTime dt;
				if (DateTime.TryParse(mtxtSSentBefore.Text, System.Globalization.CultureInfo.GetCultureInfo("ru-RU"), System.Globalization.DateTimeStyles.AssumeLocal, out dt))
                    if (q == null)
                        q = Query.SentBefore(dt);
                    else
    					q = Query.Or(q, Query.SentBefore(dt));
			}
			#endregion

            if (q == null)
                q = Query.All();

            // Get messages for query
			IEnumerable<uint>  res = iClient.Search(q, (Mailbox)txtSFolder.Tag);
			MessageCollection messages = iClient.GetMessagesHeader((Mailbox)txtSFolder.Tag, res);
            
            // Show messages in DataGridView
			fillTableWithMessages(dsSearchMess.Tables[0], messages);
		}

        /// <summary>
        /// Select mailbox to search messages in
        /// </summary>
		private void btnSSelFolder_Click(object sender, EventArgs e)
		{
            // Choose mailbox
			SelFolderForm ssf = new SelFolderForm(iClient, "Select");
			if (ssf.ShowDialog() != DialogResult.OK)
				return;
            Mailbox folderTo = ssf.selFolder;

            // Cann't chhose root mailbox
            if (folderTo.Parent == null)
				return;
			
            txtSFolder.Tag = folderTo;
			txtSFolder.Text = folderTo.DisplayName;
		}

        /// <summary>
        /// Mark unseen messages with bold font
        /// </summary>
		private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			DataGridViewRow row = dgvSearchMessages.Rows[e.RowIndex];
			if (((Int32)dsSearchMess.Tables[0].Rows[e.RowIndex]["Seen"]) == 0)
			{
				dgvSearchMessages.Rows[e.RowIndex].DefaultCellStyle.Font = new Font("Verdana", (float)7, FontStyle.Bold);
			}
		}

        /// <summary>
        /// Shows flags for current message
        /// </summary>
		private void dgvSearchMessages_CellClick(object sender, DataGridViewCellEventArgs e)
		{
            if (e.RowIndex == -1)
                return;

			DataRow row = dsSearchMess.Tables[0].Rows[e.RowIndex];
            if (dgvSearchMessages.Columns[e.ColumnIndex].Name.Equals("SearchFlag"))
			{
				MessageFlagCollection flCol = (MessageFlagCollection)row["Flags"];
				ShowSetFlags sst = new ShowSetFlags(flCol, ShowSetFlags.ShowSetFlagMode.Show);
				sst.ShowDialog();
			}
		}
		#endregion


    }
}
