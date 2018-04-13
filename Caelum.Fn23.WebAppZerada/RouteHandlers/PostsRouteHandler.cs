﻿using Caelum.Fn23.WebAppZerada.Negocio;
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
        public string ProcessRequest(string categoria)
        {
            var context = this.HttpContext;
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
            context.Response.Write("<html>");
            context.Response.Write("<ul>");
            foreach (var post in lista)
            {
                context.Response.Write($"<li>{post.Titulo} - {post.Categoria}</li>");
            }
            context.Response.Write("</ul>");
            context.Response.Write("</html>");
            context.Response.End();
            return context.Response.ToString();
        }
    }

    //public class PostsRouteHandler : IRouteHandler
    //{
    //    public IHttpHandler GetHttpHandler(RequestContext requestContext)
    //    {
    //        var categoria = string.Empty;
    //        if (requestContext.RouteData.Values.ContainsKey("categoria"))
    //        {
    //            categoria = requestContext.RouteData.Values["categoria"].ToString();
    //        }
    //        return new PostsController() { Categoria = categoria };
    //    }
    //}
}