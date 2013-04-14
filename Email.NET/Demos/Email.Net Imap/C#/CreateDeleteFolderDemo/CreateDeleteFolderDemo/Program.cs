using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CreateDeleteFolderDemo
{
	static class Program
	{
		/// <summary>
		/// 
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Demo());
		}
	}
}
