using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace AS.MVCFramework
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

        // Global error handling
        protected void Application_Error()
        {            
            Exception exception = Server.GetLastError();
            // Log the exception (you can use a logging framework like log4net or NLog)
            // For simplicity, we will just write it to the console
            Console.WriteLine("An error occurred: " + exception.Message);
            // Clear the error and redirect to a custom error page
            Server.ClearError();
            Session["greska"] = exception.Message; // Optionally pass the error message to the error page


            Response.Redirect("~/Error/General");

        }
    }
}
