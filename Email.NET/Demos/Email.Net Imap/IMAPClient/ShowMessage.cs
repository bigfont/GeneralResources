using System.Windows.Forms;

using Email.Net.Common;
using Email.Net.Common.MessageParts;
using Message = Email.Net.Imap.ImapMessage;

namespace ImapClientExample
{
	public partial class ShowMessage : Form
	{
		public ShowMessage()
		{
			InitializeComponent();
		}

		public ShowMessage(Message message)
		{
			InitializeComponent();
			//ParsedMailMessage mes = message.Message;
			foreach (EmailAddress addr in message.Header.To)
				txtTo.Text += addr.DisplayName + " (" + addr.Address + "); ";
			foreach (EmailAddress addr in message.Header.CarbonCopies)
				txtCopy.Text += addr.DisplayName + " (" + addr.Address + "); ";
			foreach (EmailAddress addr in message.Header.BlindedCarbonCopies)
				txtBlCopy.Text += addr.DisplayName + " (" + addr.Address + "); ";
			txtFrom.Text = message.Header.From.DisplayName + " (" + message.Header.From.Address + "); ";
			foreach (EmailAddress addr in message.Header.ReplyTo)
				txtReplTo.Text += addr.DisplayName + " (" + addr.Address + "); ";
			txtInReplTo.Text = message.Header.InReplyTo;
			lbKeywords.Items.Clear();
			foreach (string kw in message.Header.Keywords)
				lbKeywords.Items.Add(kw);
			lblSubj.Text = "Subject: " + message.Header.Subject;
			lblDate.Text = "Date: " + message.Header.Date.ToLongDateString() + " " + message.Header.Date.ToShortTimeString();
			lblEnc.Text = "Encoding: " + message.Header.ContentTransferEncoding;
			lblRecieved.Text = "Recieved: " + message.Header.Received;
			lblMultiPart.Text = "MultiPart: " + "unknown";// +message.Header.IsMultipart;
			lblComm.Text = "Comment: " + message.Header.Comments;
			lblTextType.Text = "Text: " + message.Header.ContentType.ToString();// .TextContentType.ToString();
			//if (!message.Header.ContentType.ToString().Equals("text/plain"))
			//{
			//    rtbText.Visible = false;
			    wbText.DocumentText = message.Text;
			//}
			//if (mes.TextContentType.ToString().Equals("Plain"))
			//{
			//    wbText.Visible = false;
			//    rtbText.Text = mes.Text;
			//}
			txtText.Text = message.PlainText;
			lvAtt.Items.Clear();
			foreach (Attachment att in message.Attachments)
			{
				ListViewItem lvi = new ListViewItem(att.FullFilename);
				lvi.Tag = att;
				lvAtt.Items.Add(lvi);
			}
		}
	}
}
