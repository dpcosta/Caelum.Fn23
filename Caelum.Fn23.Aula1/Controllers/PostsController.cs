using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Caelum.Fn23.Aula1.RouteHandlers
{
    public class PostsController : Controller
    {

        [Route("posts/{categoria?}")]
        public ActionResult Lista(string categoria)
        {
            //REGRA DE NEGÓCIO:
            var posts = new List<Post>
                {
                   new Post { Titulo = "Inferno", Categoria = "Livros" },
                   new Post { Titulo = "Pantera Negra", Categoria = "Filmes"},
                   new Post { Titulo = "Cassino Royale", Categoria = "Filmes"}
                };

            if (!string.IsNullOrEmpty(categoria))
            {
                posts = posts.Where(p => p.Categoria.ToUpper() == categoria.ToUpper()).ToList();
            }
            ViewBag.Posts = posts;

            return View();
            
        }
    }
}