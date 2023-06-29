# ASP.NET Web Forms - How to use HTTP handlers to display the progress of a server-side process on the client
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/128565347/)**
<!-- run online end -->

This example demonstrates how to use an HTTP handler to get information about the current progress from the server and display it on the client without refreshing the whole page.

![HTTP handlers to display the progress](HTTPHandlers.png)

## Overview

Declare a custom **HttpHandler** class to send a request from the client to the server and return information about the current progress without refreshing the whole page.

```cs
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
```

> **Note**  
> After you create a custom **HttpHandler** class, register it in the *Web.config* file. For more information, refer to the following article: [How to: Register HTTP Handlers](https://learn.microsoft.com/en-us/previous-versions/aspnet/46c5ddfy(v=vs.100)?redirectedfrom=MSDN).

## Files to Review

* [Operation.cs](./CS/App_Code/Operation.cs) (VB: [Operation.vb](./VB/App_Code/Operation.vb))
* [TestHandler.cs](./CS/App_Code/TestHandler.cs) (VB: [TestHandler.vb](./VB/App_Code/TestHandler.vb))
* [Default.aspx](./CS/Default.aspx) (VB: [Default.aspx](./VB/Default.aspx))
* [Default.aspx.cs](./CS/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/Default.aspx.vb))

## Documentation

* [Create an Asynchronous HTTP Handler](https://learn.microsoft.com/en-us/previous-versions/aspnet/ms227433(v=vs.100)?redirectedfrom=MSDN)
* [Create a Synchronous HTTP Handler](https://learn.microsoft.com/en-us/previous-versions/aspnet/ms228090(v=vs.100)?redirectedfrom=MSDN)

## More Examples

* [ASP.NET Web Forms - How to display progress information about server-side callback processing](https://github.com/DevExpress-Examples/web-forms-display-progress-information-about-callback-process)
* [Progress Bar for ASP.NET Web Forms - How to use the WebMethod attribute to display the progress of a server-side process on the client](https://github.com/DevExpress-Examples/asp-net-web-forms-progress-bar-display-server-process-progress)
