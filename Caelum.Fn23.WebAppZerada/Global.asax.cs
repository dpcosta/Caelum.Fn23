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
            //uso de rotas
            var rotas = RouteTable.Routes;
            rotas.Add(new Route("posts", new PostsRouteHandler()));
            rotas.Add(new Route("posts/filmes", new PostsRouteHandler()));
            rotas.Add(new Route("contato", new InfoBlogRouteHandler()));

            //problema é que pra cada nova rota terei que criar 2 novas classes!!!
            //mas posso pensar em criar apenas uma rota que vai repassar as requisições
            //para classes específicas. Para isso será necessário que todas as rotas sigam
            //um padrão. Mas repare que já fiz isso: posts/musicas, posts, posts/novo
            //se fôssemos padronizar seria assim:
            //{nome do tipo do objeto}/{nome do metodo a ser invocado}

            //É isso que o MVC faz! Todas as rotas passam por esse padrão
            //a diferença é que o nome do tipo de objeto é controller e do método é action
            //então:
            //{controller}/{action}

            //e pros casos assim?
            //http://localhost:819893/
            //http://localhost:819893/posts
            //etc?

            //nessas situações seria legal se o parâmetro pudesse ter um valor default
            //no MVC esses valores padrão são controller=Home, action=Index
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}