using System.Collections.Generic;
using Email.Net.Imap;


namespace ImapClientExample
{
    /// <summary>
    /// Compares two mailboxes to decide if they equals or not
    /// </summary>
	public class MailboxComparer : IEqualityComparer<Mailbox>
	{
		public int GetHashCode(Mailbox mb){
			return mb.GetHashCode();
		}

		public bool Equals(Mailbox mb, Mailbox mb2)
		{
			if(mb == null || mb2 == null)
                // If both mb and mb2 are null then they are equal
				if(mb == mb2)
					return true;
				else
					return false;

			Mailbox par = mb.Parent;
			Mailbox par2 = mb2.Parent;
            // If two mailboxes have same names
			if (mb.FullName.Equals(mb2.FullName))
                // And same count of childrens
				if (mb.Children.Count == mb2.Children.Count)
                    // And parents with same names
					if ((par == null && par2 == null) || par.FullName.Equals(par2.FullName))
                        // Then decide them equal
						return true;
            // Otherwise not
			return false;
		}
	}
}
