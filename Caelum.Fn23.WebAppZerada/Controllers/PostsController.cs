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
    public class PostsController : Controller
    {
        [Route("posts/{categoria?}")]
        public ViewResult Lista(string categoria)
        {
            var lista = new List<Post>
                {
                    new Post{ Id=1, Titulo="007 - O Espião que me amava", Categoria="Filmes"},
                    new Post{ Id=2, Titulo="Cassino Royale", Categoria="Filmes"},
                    new Post{ Id=3, Titulo="Inferno", Categoria="Livros"},
                    new Post{ Id=4, Titulo="Fear of the Dark", Categoria="Músicas"},
                    new Post{ Id=5, Titulo="Ciranda, Cirandinha", Categoria="Músicas"},
                };
            if (!string.IsNullOrEmpty(categoria))
            {
                //filtra por categoria
                lista = lista.Where(p => p.Categoria.ToUpper() == categoria.ToUpper()).ToList();
            }

            ViewBag.Posts = lista;
            return View("lista");
        }
    }
}