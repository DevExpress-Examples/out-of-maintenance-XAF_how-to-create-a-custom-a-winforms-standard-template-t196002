Imports System
Imports System.Configuration
Imports System.Windows.Forms

Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Security
Imports DevExpress.ExpressApp.Win
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.ExpressApp.Xpo
Imports DevExpress.ExpressApp.Win.SystemModule
Imports DevExpress.XtraBars.Ribbon

Namespace CustomizeWinFormsTemplateExample.Win
    Friend NotInheritable Class Program

        Private Sub New()
        End Sub

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread> _
        Shared Sub Main()
#If EASYTEST Then
            DevExpress.ExpressApp.Win.EasyTest.EasyTestRemotingRegistration.Register()
#End If
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            EditModelPermission.AlwaysGranted = System.Diagnostics.Debugger.IsAttached
            Dim winApplication As New CustomizeWinFormsTemplateExampleWindowsFormsApplication()
            winApplication.ConnectionString = InMemoryDataStoreProvider.ConnectionString

            'Customize templates
            AddHandler winApplication.CreateCustomTemplate, Sub(sender As Object, e As CreateCustomTemplateEventArgs)
                If DirectCast(winApplication.Model.Options, IModelOptionsWin).FormStyle = RibbonFormStyle.Standard Then
                    If e.Context = TemplateContext.ApplicationWindow Then
                        e.Template = New MainForm1()
                    ElseIf e.Context = TemplateContext.View Then
                        e.Template = New DetailForm1()
                    End If
                End If
            End Sub


            Try
                winApplication.Setup()
                winApplication.Start()
            Catch e As Exception
                winApplication.HandleException(e)
            End Try
        End Sub
    End Class
End Namespace
