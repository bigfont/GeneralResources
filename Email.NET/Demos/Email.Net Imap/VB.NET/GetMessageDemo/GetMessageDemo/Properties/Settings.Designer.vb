Namespace Properties


    <System.Runtime.CompilerServices.CompilerGeneratedAttribute()> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")> _
    Partial Friend NotInheritable Class Settings
        Inherits Global.System.Configuration.ApplicationSettingsBase

        Private Shared defaultInstance As Settings = DirectCast(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New Settings()), Settings)

        Public Shared ReadOnly Property [Default]() As Settings
            Get
                Return defaultInstance
            End Get
        End Property
    End Class
End Namespace
