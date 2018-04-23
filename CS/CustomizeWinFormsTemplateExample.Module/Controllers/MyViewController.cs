using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;

namespace CustomizeWinFormsTemplateExample.Module.Controllers {
    public class MyViewController : ViewController {
        public MyViewController() {
            SimpleAction myAction = new SimpleAction(this, "MyAction", "My Actions");
            myAction.ImageName = "Action_SimpleAction";
        }
    }
}
