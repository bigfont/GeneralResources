using System;
using System.Windows.Forms;
using Email.Net.Imap;
using Email.Net.Imap.Collections;

namespace ImapClientExample
{
	public partial class SelFolderForm : Form
	{
		private ImapClient iClient;

		public Mailbox selFolder { get; set; }

		public SelFolderForm()
		{
			InitializeComponent();
		}

		public SelFolderForm(ImapClient client)
		{
			InitializeComponent();
			iClient = client;
			getAllFolders();
		}

		public SelFolderForm(ImapClient client, String actionName)
		{
			InitializeComponent();
			btnOk.Text = actionName;
			iClient = client;
			getAllFolders();
		}

		private void getAllFolders()
		{
			Mailbox mailbox = iClient.GetMailboxTree();
			trFolders.Nodes.Clear();
			String nodeName = mailbox.DisplayName;
			if (String.IsNullOrEmpty(nodeName))
				nodeName = mailbox.FullName;
			if (String.IsNullOrEmpty(nodeName))
				nodeName = mailbox.Name;
			if (String.IsNullOrEmpty(nodeName))
				nodeName = "RootNode";
			TreeNode tn = new TreeNode(nodeName);
			tn.Tag = mailbox;
			trFolders.Nodes.Add(tn);
			//Add childrens
			addFoldersToTree(tn, mailbox.Children);
			tn.ExpandAll();
		}

		private void addFoldersToTree(TreeNode rootNode, MailboxCollection folders)
		{
			foreach (Mailbox mb in folders)
			{
				TreeNode tn = new TreeNode(mb.DisplayName);
				tn.Tag = mb;
				rootNode.Nodes.Add(tn);
				addFoldersToTree(tn, mb.Children);
			}
		}

		private void trFolders_AfterSelect(object sender, TreeViewEventArgs e)
		{
			if (e.Node == null)
				return;
			selFolder = (Mailbox)e.Node.Tag;
		}
	}
}
