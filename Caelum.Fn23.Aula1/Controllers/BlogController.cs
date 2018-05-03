using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Caelum.Fn23.Aula1.RouteHandlers
{
    public class BlogController : Controller
    {
        public ViewResult Sobre()
        {
            return View();
        }
    }
}