<!-- default file list -->
*Files to look at*:

* [Operation.cs](./CS/App_Code/Operation.cs) (VB: [Operation.vb](./VB/App_Code/Operation.vb))
* [TestHandler.cs](./CS/App_Code/TestHandler.cs) (VB: [TestHandler.vb](./VB/App_Code/TestHandler.vb))
* [Default.aspx](./CS/Default.aspx) (VB: [Default.aspx](./VB/Default.aspx))
* [Default.aspx.cs](./CS/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/Default.aspx.vb))
<!-- default file list end -->
# How to track progress of server side processing on the client side (using HttpHandler)


<p>This example demonstrates one of many possible scenarios when a client should be notified of the progress of a server process. The sample includes a class declaration of a custom HttpHandler; the latter processes the simplest request from the client and returns information that can be restored and used to display current progress, without refreshing the whole page. The other defined class emulates long-time processing, which starts with a standalone thread and is executed in the background. This is an advantage because a callback is performed on the server side quickly if a client requests a new process.</p>
<p>Note that any custom HttpHandler should be registered via the IIS Console Manager or manually through the web.config file. More details are available here: <a href="http://msdn.microsoft.com/en-us/library/46c5ddfy(v=vs.100).aspx"><u>How to register HTTP Handlers</u></a>.</p>
<p>Please refer to the following links to know more:<br> <a href="http://msdn.microsoft.com/en-us/library/ms227433(v=vs.100).aspx"><u>Creating an Asynchronous HTTP Handler</u></a><u><br> </u><a href="http://msdn.microsoft.com/en-us/library/ms228090(v=vs.100).aspx"><u>Creating a Synchronous HTTP Handler</u></a></p>
<p>This example extends the following one: <a href="https://www.devexpress.com/Support/Center/p/E918">How to display progress information about server-side callback processing</a>.</p>
<p><strong>See also</strong><strong>:<br> </strong><a href="https://www.devexpress.com/Support/Center/p/E4656">How to track progress of server side processing on the client side (using HttpModule)</a><br><a href="https://www.devexpress.com/Support/Center/p/T156786">How to track progress of server side processing on the client side (using WebMethods)</a><br><a href="https://www.devexpress.com/Support/Center/p/T518056">ASPxGridView - How to show a lengthy operation's progress and allow canceling such operations</a></p>

<br/>


