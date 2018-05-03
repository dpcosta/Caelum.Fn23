﻿using Caelum.Fn23.Aula1.RouteHandlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace Caelum.Fn23.Aula1
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            var rotas = RouteTable.Routes;
            rotas.MapMvcAttributeRoutes();
            rotas.MapRoute(
                name: "Default", 
                url: "{controller}/{action}",
                defaults: new { controller = "Home", action = "Index" }
                ); //MvcHandler
        }
    }
}