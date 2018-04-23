using System;
using System.Web;
using System.Web.SessionState;

public class TestHandler : IHttpHandler, IRequiresSessionState {
    
    String GetProgress(HttpSessionState session) {
        if(session == null || !(session["_Operation"] is Operation))
            return "NaN";
        var progress = (session["_Operation"] as Operation).Progress;
        return progress.ToString();
    }

    public Boolean IsReusable {
        get { return false; }
    }

    public void ProcessRequest(HttpContext context) {
        var response = GetProgress(context.Session);
        context.Response.CacheControl = "No-cache";
        context.Response.Write(response);
    }
}