using Caelum.Fn23.WebAppZerada.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Caelum.Fn23.WebAppZerada.RouteHandlers
{
    public class PostsController : Controller
    {
        [Route("posts/{categoria?}")]
        public void Lista(string categoria)
        {
            var lista = new List<Post>
                {
                    new Post{ Id=1, Titulo="007 - O Espião que me avama", Categoria="Filmes"},
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

            //mas como disponibilizar essa lista no navegador?
            var context = this.HttpContext;
            context.Response.Write("<html>");
            context.Response.Write("<ul>");
            foreach (var post in lista)
            {
                context.Response.Write($"<li>{post.Titulo} - {post.Categoria}</li>");
            }
            context.Response.Write("</ul>");
            context.Response.Write("</html>");
            context.Response.End();
        }
    }
}