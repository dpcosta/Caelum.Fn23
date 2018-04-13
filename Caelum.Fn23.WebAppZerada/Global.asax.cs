using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using Caelum.Fn23.WebAppZerada.Negocio;
using Caelum.Fn23.WebAppZerada.RouteHandlers;

namespace Caelum.Fn23.WebAppZerada
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            
            var rotas = RouteTable.Routes;
            rotas.MapRoute(
                name: "Default",
                url: "{controller}/{action}"
            );
        }

        
    }
}