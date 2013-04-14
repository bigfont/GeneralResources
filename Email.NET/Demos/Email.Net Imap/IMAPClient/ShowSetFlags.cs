using System;
using System.Windows.Forms;
using Email.Net.Imap;
using Email.Net.Imap.Collections;

namespace ImapClientExample
{
	public partial class ShowSetFlags : Form
	{
		public enum ShowSetFlagMode
		{
			Show,
			Edit
		}

		public MessageFlagCollection NewFlagCollection
		{
			get
			{
				MessageFlagCollection col = new MessageFlagCollection();
				foreach (MessageFlag flag in lbFlags1.Items)
					col.Add(flag);
				return col;
			}
		}

		public EFlagMode FlagMode
		{
			get
			{
				switch(comboBox1.SelectedIndex){
					case 0:
                        return EFlagMode.Add;
					case 1:
                        return EFlagMode.Remove;
					default:
                        return EFlagMode.Replace;
				}
			}
			
		}

		public ShowSetFlags()
		{
			InitializeComponent();
			comboBox1.SelectedIndex = 0;
			lbFlags1.Items.Clear();
			lbFlags2.Items.Clear();
			lbFlags2.Items.Add(new MessageFlag(EFlag.Answered));
            lbFlags2.Items.Add(new MessageFlag(EFlag.Deleted));
            lbFlags2.Items.Add(new MessageFlag(EFlag.Draft));
            lbFlags2.Items.Add(new MessageFlag(EFlag.Flagged));
			//lbFlags2.Items.Add(new MessageFlag(EIMAP4Flag.NonStandart));
            lbFlags2.Items.Add(new MessageFlag(EFlag.Recent));
            lbFlags2.Items.Add(new MessageFlag(EFlag.Seen));
		}

		public ShowSetFlags(MessageFlagCollection flagCol)
		{
			InitializeComponent();
			//comboBox1.Enabled = lbFlags2.Enabled = false;
			label3.Text = "";
			label1.Text = "Currently setted flags:";
			lbFlags1.Items.Clear();
			lbFlags2.Items.Clear();
			foreach (MessageFlag flag in flagCol)
			{
				lbFlags1.Items.Add(flag);
			}
		}

		public ShowSetFlags(MessageFlagCollection flagCol, ShowSetFlagMode ssfm)
		{
			InitializeComponent();
			label3.Text = "";
			label1.Text = "Currently setted flags:";
			lbFlags1.Items.Clear();
			lbFlags2.Items.Clear();
			foreach (MessageFlag flag in flagCol)
			{
				lbFlags1.Items.Add(flag);
			}
			if (ssfm == ShowSetFlagMode.Show)
			{
				comboBox1.Enabled = lbFlags2.Enabled =
				btnAdd.Enabled = btnAddAll.Enabled = btnDel.Enabled = btnDelAll.Enabled = false;
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (lbFlags2.SelectedIndex < 0)
				return;
			lbFlags1.Items.Add(lbFlags2.SelectedItem);
			lbFlags2.Items.RemoveAt(lbFlags2.SelectedIndex);
		}

		private void btnAddAll_Click(object sender, EventArgs e)
		{
			lbFlags1.Items.Clear();
			lbFlags2.Items.Clear();
            lbFlags1.Items.Add(new MessageFlag(EFlag.Answered));
            lbFlags1.Items.Add(new MessageFlag(EFlag.Deleted));
            lbFlags1.Items.Add(new MessageFlag(EFlag.Draft));
            lbFlags1.Items.Add(new MessageFlag(EFlag.Flagged));
			//lbFlags1.Items.Add(new MessageFlag(EIMAP4Flag.NonStandart));
            lbFlags1.Items.Add(new MessageFlag(EFlag.Recent));
            lbFlags1.Items.Add(new MessageFlag(EFlag.Seen));
		}

		private void btnDelAll_Click(object sender, EventArgs e)
		{
			lbFlags1.Items.Clear();
			lbFlags2.Items.Clear();
            lbFlags2.Items.Add(new MessageFlag(EFlag.Answered));
            lbFlags2.Items.Add(new MessageFlag(EFlag.Deleted));
            lbFlags2.Items.Add(new MessageFlag(EFlag.Draft));
            lbFlags2.Items.Add(new MessageFlag(EFlag.Flagged));
			//lbFlags2.Items.Add(new MessageFlag(EIMAP4Flag.NonStandart));
            lbFlags2.Items.Add(new MessageFlag(EFlag.Recent));
            lbFlags2.Items.Add(new MessageFlag(EFlag.Seen));
		}

		private void btnDel_Click(object sender, EventArgs e)
		{
			if (lbFlags1.SelectedIndex < 0)
				return;
			lbFlags2.Items.Add(lbFlags1.SelectedItem);
			lbFlags1.Items.RemoveAt(lbFlags1.SelectedIndex);
		}
	}
}
