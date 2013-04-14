using System;
using Email.Net.Common.Configurations;

namespace ImapClientExample
{
    /// <summary>
    /// Represents mail account
    /// </summary>
	public class MailAccount : IComparable
	{
        /// <summary>
        /// Account name. Haven't used for connection to server
        /// </summary>
		public String AccountName { get; set; }

        /// <summary>
        /// Mail server domain name, i.e. mail.server.com
        /// </summary>
		public String InServer { get; set; }

        /// <summary>
        /// Mail server login
        /// </summary>
		public String Login { get; set; }

        /// <summary>
        /// Mail server password
        /// </summary>
		public String Password { get; set; }

        /// <summary>
        /// port to connect ot mail server
        /// </summary>
		public int Port { get; set; }

        /// <summary>
        /// Type of interaction with the mail server
        /// </summary>
		public EInteractionType SecType { get; set; }

		public override string ToString()
		{
			return AccountName;
		}

        /// <summary>
        /// Deside two accounts are equal if they have same names
        /// </summary>
        /// <param name="obj">mail accoutn to compare with</param>
        /// <returns></returns>
		public int CompareTo(Object obj)
		{
			if (!(obj is MailAccount))
				throw new Exception("Try to compare MailAccount with unknown value");
			MailAccount ma = (MailAccount)obj;
			if (ma == null)
				throw new Exception("Try to compare MailAccount with null value");
			return ma.AccountName.CompareTo(AccountName);
		}
	}
}
