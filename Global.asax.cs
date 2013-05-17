﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using System.Data.Entity;
using Blog.Models;
using Clutch.Diagnostics.EntityFramework;

namespace Blog
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Logger logger = new Logger();
            DbTracing.Enable(
                new GenericDbTracingListener().OnFinished(
                    c => logger.Log(c.Command.ToTraceString())
                )
            );

            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<DataContext>());

            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}