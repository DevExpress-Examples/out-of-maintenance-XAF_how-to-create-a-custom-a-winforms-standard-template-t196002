using System;
using System.Configuration;
using System.Windows.Forms;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Security;
using DevExpress.ExpressApp.Win;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.ExpressApp.Xpo;
using DevExpress.ExpressApp.Win.SystemModule;
using DevExpress.XtraBars.Ribbon;

namespace CustomizeWinFormsTemplateExample.Win {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
#if EASYTEST
            DevExpress.ExpressApp.Win.EasyTest.EasyTestRemotingRegistration.Register();
#endif
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            EditModelPermission.AlwaysGranted = System.Diagnostics.Debugger.IsAttached;
            CustomizeWinFormsTemplateExampleWindowsFormsApplication winApplication = new CustomizeWinFormsTemplateExampleWindowsFormsApplication();
            winApplication.ConnectionString = InMemoryDataStoreProvider.ConnectionString;

            //Customize templates
            winApplication.CreateCustomTemplate += delegate(object sender, CreateCustomTemplateEventArgs e) {
                if (((IModelOptionsWin)winApplication.Model.Options).FormStyle == RibbonFormStyle.Standard) {
                    if (e.Context == TemplateContext.ApplicationWindow) {
                        e.Template = new MainForm1();
                    }
                    else if (e.Context == TemplateContext.View) {
                        e.Template = new DetailForm1();
                    }
                }
            };


            try {
                winApplication.Setup();
                winApplication.Start();
            }
            catch(Exception e) {
                winApplication.HandleException(e);
            }
        }
    }
}
