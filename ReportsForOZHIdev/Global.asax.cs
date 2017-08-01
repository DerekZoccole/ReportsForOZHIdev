using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Data.Entity;
using ReportsForOZHIdev.Models;
using ReportsForOZHIdev.Logic;

namespace ReportsForOZHIdev
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // Initialize database
            Database.SetInitializer(new ReportsDatabaseInitializer());

            // Create custom role and user
            RoleActions roleActions = new RoleActions();
            roleActions.AddUserAndRole();
        }
    }
}