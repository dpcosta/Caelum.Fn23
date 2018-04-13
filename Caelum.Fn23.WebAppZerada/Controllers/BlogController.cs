using Caelum.Fn23.WebAppZerada.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Caelum.Fn23.WebAppZerada.RouteHandlers
{
    public class BlogController : Controller
    {
        public void Sobre()
        {
            var context = this.HttpContext;
            context.Response.Write("<html>");
            context.Response.Write("<body>");
            context.Response.Write("Este é um blog de resenhas culturais.");
            context.Response.Write("</body>");
            context.Response.Write("</html>");
            context.Response.End();
        }
    }
}