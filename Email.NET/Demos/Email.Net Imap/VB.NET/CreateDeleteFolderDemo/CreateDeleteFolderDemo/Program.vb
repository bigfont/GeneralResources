Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms

NotInheritable Class Program
	Private Sub New()
	End Sub
	<STAThread> _
	Friend Shared Sub Main()
		Application.EnableVisualStyles()
		Application.SetCompatibleTextRenderingDefault(False)
        Application.Run(New Demo())
	End Sub
End Class
