Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Actions

Namespace CustomizeWinFormsTemplateExample.Module.Controllers
    Public Class MyViewController
        Inherits ViewController

        Public Sub New()
            Dim myAction As New SimpleAction(Me, "MyAction", "My Actions")
            myAction.ImageName = "Action_SimpleAction"
        End Sub
    End Class
End Namespace
