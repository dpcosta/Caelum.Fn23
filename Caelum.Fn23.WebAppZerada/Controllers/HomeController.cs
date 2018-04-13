using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Caelum.Fn23.WebAppZerada.Controllers
{
    public class HomeController : Controller
    {
        public void Index()
        {
            var context = this.HttpContext;
            context.Response.Write("<html>");
            context.Response.Write("<h1>Resenha Cultural</h1)");
            context.Response.Write("</html>");
            context.Response.End();
        }
    }
}