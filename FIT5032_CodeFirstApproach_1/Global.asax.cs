using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using FIT5032_CodeFirstApproach_1.Models;

namespace FIT5032_CodeFirstApproach_1
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            Database.SetInitializer<PhotographerContext> (new DropCreateDatabaseIfModelChanges<PhotographerContext>());
        }
    }
}
