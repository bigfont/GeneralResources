using System;
using System.Windows.Forms;
using Email.Net.Common;

namespace VerifyAddress
{
	public partial class Verify : Form
	{
		public Verify()
		{
			InitializeComponent();
		}

		private void bCheck_Click(object sender, EventArgs e)
		{
			epAddressChecker.SetError(tbEmail, EmailAddress.IsValid(tbEmail.Text) ? "" : "invalid email");
		}
	}
}
