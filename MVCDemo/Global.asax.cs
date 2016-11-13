using System;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;


namespace MVCDemo
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Application_End()
        {
            Console.WriteLine("End");
            Console.ReadLine();
        }
    }
}


/*
 
     The Global.asax file, also known as the ASP.NET application file, is an optional file that contains code for responding to application-level 
     events raised by ASP.NET or by HttpModules.
     The Global.asax file resides in the root directory of an ASP.NET-based
     application. At run time, Global.asax is parsed and 
     compiled into a dynamically generated .NET Framework class derived 
     from the HttpApplication base class. The Global.asax file itself is 
     configured so that any direct URL request for it is automatically rejected; 
     external users cannot download or view the code written within it.

The ASP.NET Global.asax file can coexist with the ASP Global.asax file. 
You can create a Global.asax file either in a WYSIWYG designer, in Notepad, 
or as a compiled class that you deploy in your application's \Bin directory as 
an assembly. However, in the latter case, you still need a Global.asax file that 
refers to the assembly.
The Global.asax file is optional. If you do not define the file, the ASP.NET page framework assumes that you have not defined any application or session event handlers.
When you save changes to an active Global.asax file, the ASP.NET page framework detects that the file has been changed. It completes all current requests for the application, sends the Application_OnEnd event to any listeners, and restarts the application domain. In effect, this reboots the application, closing all browser sessions and flushing all state information. When the next incoming request from a browser arrives, the ASP.NET page framework reparses and recompiles the Global.asax file and raises the Application_OnStart event.
     
     
     */
