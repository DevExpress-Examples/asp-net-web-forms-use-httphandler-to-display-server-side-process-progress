
using System;
public partial class _Default : System.Web.UI.Page
{
    Operation Operation {
        get {
            if(Session["_Operation"] == null)
                Session["_Operation"] = new Operation();
            return Session["_Operation"] as Operation;
        }
    }

    protected void Page_Load(object sender, EventArgs e) {

    }

    protected void cbak_Callback(object source, DevExpress.Web.CallbackEventArgs e) {     
        Operation.AsyncStart(5000);
    }
}