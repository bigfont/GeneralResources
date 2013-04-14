using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Email.Net.Common;
using Email.Net.Common.Collections;
using Email.Net.Common.MessageParts;

namespace Browser
{
	public partial class MessageViewer : Form
	{
		public MessageViewer(Rfc822Message message)
		{
			InitializeComponent();
			Fill(message);
		}

		private void Fill(Rfc822Message message)
		{
			//Clearing attachment's list
			lvAttachments.Items.Clear();

			//Get message's subject, from, to and carbon copy
			tbFrom.Text = message.From.ToString();
			tbTo.Text = message.To.Count > 0 ? message.To[0].ToString() : "";
			tbCc.Text = message.CarbonCopies.Count > 0 ? message.CarbonCopies[0].ToString() : "";
			tbSubject.Text = message.Subject;

			//if html message
			if (message.TextContentType == ETextContentType.Html)
			{
				//filling bodys
				wbBody.DocumentText = message.Text;
				tbBody.Text = message.PlainText;
			}
			else //if text message
			{
				//filling bodys
				tbBody.Text = message.Text;
			}

			//filling attachment's list
			foreach (Attachment attachment in message.Attachments)
			{
				//Create ListView item
				ListViewItem item = new ListViewItem(attachment.TransferFilename);
				item.SubItems.Add(attachment.ContentType.ToString());
				//Adding item to attachmetn's list
				lvAttachments.Items.Add(item);
			}
		}
	}
}
