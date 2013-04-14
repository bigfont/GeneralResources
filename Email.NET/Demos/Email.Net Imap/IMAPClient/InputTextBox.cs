using System.Windows.Forms;

namespace ImapClientExample
{
	public partial class InputTextBox : Form
	{
		public string TextEntered
		{
			get
			{
				return textBox1.Text;
			}
		}	

		public InputTextBox()
		{
			InitializeComponent();
		}

		public InputTextBox(string formCaption, string inputMessage)
		{
			InitializeComponent();
			label1.Text = inputMessage;
			this.Text = formCaption;
		}

		private void textBox1_KeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyData == Keys.Enter){
				DialogResult = DialogResult.OK;
				Close();
			}
		}

	}
}
