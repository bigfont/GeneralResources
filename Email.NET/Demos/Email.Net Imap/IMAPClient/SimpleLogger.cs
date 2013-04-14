using System;
using System.Collections;
using Email.Net.Imap.Responses;

namespace ImapClientExample
{
    /// <summary>
    /// Simple log writer
    /// </summary>
	public class SimpleLogger
	{
		private IList destination;

        /// <summary>
        /// Creates instance of SimpleLogger with destination set to IList interface
        /// </summary>
        /// <param name="logDest">IList interface of log messages acceptor</param>
		public SimpleLogger(IList logDest)
		{
			destination = logDest;
		}

		public void setOutput(IList logDest)
		{
			destination = logDest;
		}

        /// <summary>
        /// Log message string
        /// </summary>
        /// <param name="mes">Message to log</param>
		public void addLogMessage(string mes)
		{
			destination.Add(DateTime.Now.ToLongTimeString() + mes);
		}

        /// <summary>
        /// Log CompletionResponse
        /// </summary>
        /// <param name="resp">CompletionResponse to log</param>
		public void addLogMessage(CompletionResponse resp)
		{
			destination.Add(DateTime.Now.ToLongTimeString() + ". Response: " + resp.Response + " Message: " + resp.Message);
		}

        /// <summary>
        /// Log a CompletionResponse andexplanation message
        /// </summary>
        /// <param name="mes">Explanation message</param>
        /// <param name="resp">CompletionResponse to log</param>
		public void addLogMessage(String mes, CompletionResponse resp)
		{
			destination.Add(DateTime.Now.ToLongTimeString() + " " + mes + ". Response: " + resp.Response + " Message: " + resp.Message);
		}
	}
}
