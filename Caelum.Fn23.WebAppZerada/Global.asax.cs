using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

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
            //esse evento é chamado qdo a requisição começará a ser tratada
            var lista = new List<string>
            {
                "Highway to Hell",
                "If You Want Blood",
                "TNT",
                "Thunderstruck",
            };
            var artigos = "";
            foreach (var post in lista)
            {
                artigos += $"<li>{post}</li>";
            }
            //mas como disponibilizar essa lista no navegador?
            HttpContext.Current.Response.Write(artigos);
            HttpContext.Current.Response.End();
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