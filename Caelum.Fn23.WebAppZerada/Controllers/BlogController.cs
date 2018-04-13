using Caelum.Fn23.WebAppZerada.Negocio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Caelum.Fn23.WebAppZerada.RouteHandlers
{
    public class BlogController : Controller
    {
        public string Sobre()
        {
            var caminhoArquivo = Server.MapPath("~/Views/sobre.html");
            using (var file = System.IO.File.OpenRead(caminhoArquivo))
            using(var leitor = new StreamReader(file))
            {
                return leitor.ReadToEnd();
            }
        }
    }
}