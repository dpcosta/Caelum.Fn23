using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
            //uso de rotas
            var rotas = RouteTable.Routes;
            rotas.Add(new Route("posts", new PostsRouteHandler()));
            rotas.Add(new Route("posts/{categoria}", new PostsRouteHandler()));
            rotas.Add(new Route("blog/sobre", new InfoBlogRouteHandler()));
        }

        
    }
}