using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Caelum.Fn23.Aula1.Controllers
{
    public class HomeController : Controller
    {
        public void Index()
        {
            //RESPOSTA:
            var context = this.HttpContext;
            context.Response.Write("<html>");
            context.Response.Write("<h1>");
            context.Response.Write("Este é um blog sobre resenhas culturais.");
            context.Response.Write("</h1>");
            context.Response.Write("</html>");
            context.Response.End();
        }
    }
}