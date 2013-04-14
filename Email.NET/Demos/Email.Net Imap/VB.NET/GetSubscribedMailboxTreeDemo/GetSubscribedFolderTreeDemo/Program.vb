Imports System.Collections.Generic
Imports System.Windows.Forms

Namespace getSubscribedFolderTreeDemo
	NotInheritable Class Program
		Private Sub New()
		End Sub
		<STAThread> _
		Friend Shared Sub Main()
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			Application.Run(New Form1())
		End Sub
	End Class
End Namespace
