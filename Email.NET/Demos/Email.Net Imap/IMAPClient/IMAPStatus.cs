namespace ImapClientExample
{
	public delegate void StatusUpdater();

	public class IMAPStatus
	{
		private static ConnectionStatus connStatus;

        /// <summary>
        /// Gets or sets current connection status of ImapClientExample
        /// </summary>
		public static ConnectionStatus ConnStatus { 
			get{
				return connStatus;
			} 
			set{
				connStatus = value;
                
                //Update status value on main form
				statUpd.Invoke();

                //If client just connected then activate buttons and prepare main form
				if (connStatus == ConnectionStatus.Connected)
					activateFunc.Invoke();

                //If client just connected then deactivate buttons
				if (connStatus == ConnectionStatus.Disconnected)
					deactivateFunc.Invoke();
			} }

        /// <summary>
        /// Gets or sets delegate for function to update status value on main form
        /// </summary>
		public static StatusUpdater statUpd { get; set; }

        /// <summary>
        /// Gets or sets delegate for function to activate buttons
        /// </summary>
		public static StatusUpdater activateFunc { get; set; }

        /// <summary>
        /// Gets or sets delegate for function to deactivate buttons
        /// </summary>
		public static StatusUpdater deactivateFunc { get; set; }

		private IMAPStatus()
		{
			ConnStatus = ConnectionStatus.Disconnected;
		}
	}
}
