using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using Caelum.Fn23.WebAppZerada.Negocio;

namespace Caelum.Fn23.WebAppZerada
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            if (HttpContext.Current.Request.Path == "/")
            {
                var lista = new List<Post>
                {
                    new Post{ Id=1, Titulo="Highway to Hell", Categoria="Músicas"},
                    new Post{ Id=2, Titulo="Cassino Royale", Categoria="Filmes"},
                    new Post{ Id=3, Titulo="Inferno", Categoria="Livros"},
                    new Post{ Id=4, Titulo="Fear of the Dark", Categoria="Músicas"},
                    new Post{ Id=5, Titulo="Ciranda, Cirandinha", Categoria="Músicas"},
                };
                var artigos = "";
                foreach (var post in lista)
                {
                    artigos += $"<li>{post.Titulo} - {post.Categoria}</li>";
                }
                //mas como disponibilizar essa lista no navegador?
                HttpContext.Current.Response.Write("<html>");
                HttpContext.Current.Response.Write("<ul>");
                HttpContext.Current.Response.Write(artigos);
                HttpContext.Current.Response.Write("</ul>");
                HttpContext.Current.Response.Write("</html>");
                HttpContext.Current.Response.End();
            }
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