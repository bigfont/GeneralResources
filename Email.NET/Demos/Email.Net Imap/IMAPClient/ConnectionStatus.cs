namespace ImapClientExample
{
    /// <summary>
    /// List of all possible ImapClientExample states
    /// </summary>
	public enum ConnectionStatus
	{
		Disconnected,
		Connecting,
		Connected,
		FailedConnect,
		FailedDisconnect,
		BadResponse
	}
}
