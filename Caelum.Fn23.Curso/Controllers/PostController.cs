using Caelum.Fn23.Curso.DAO;
using Caelum.Fn23.Curso.Models;
using System;
using System.Diagnostics;
using System.Web.Mvc;

namespace Caelum.Fn23.Curso.Controllers
{
    public class PostController : Controller
    {
        private readonly IDataAccessObject<Post> _dao;

        public PostController()
        {
            this._dao = new PostDaoEF();
        }

        public ActionResult Index()
        {
            return View(_dao.Lista);
        }

        public ActionResult Novo()
        {
            return View(new Post());
        }

        public ActionResult Detalhe(int id)
        {
            Post model = _dao.BuscaPorId(id);
            if (model != null)
            {
                return View(model);
            }
            return HttpNotFound();
        }

        [HttpPost]
        public ActionResult Remove(int id)
        {
            Post post = _dao.BuscaPorId(id);
            if (post != null)
            {
                _dao.Remover(post);
                return RedirectToAction("Index");
            }
            return HttpNotFound();
        }

        [HttpPost]
        public ActionResult Adiciona(Post post)
        {
            if (ModelState.IsValid)
            {
                _dao.Incluir(post);
                return RedirectToAction("Index");
            }
            //Bad Request
            HttpContext.Response.StatusCode = 400;
            return View("Novo", post);
        }

        [HttpPost]
        public ActionResult Altera(Post post)
        {
            if (!ModelState.IsValid)
            {
                HttpContext.Response.StatusCode = 400;
                return View("Detalhe", post);
            }
            if (post.Publicado && (post.DataPublicacao == null))
            {
                post.DataPublicacao = DateTime.Now;
            }
            else if(!post.Publicado && (post.DataPublicacao != null))
            {
                post.DataPublicacao = null;
            }
            _dao.Alterar(post);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Publica(int id)
        {
            var post = _dao.BuscaPorId(id);
            if (post == null)
            {
                return HttpNotFound();
            }
            post.Publicado = true;
            post.DataPublicacao = DateTime.Now;
            _dao.Alterar(post);
            return RedirectToAction("Index");
        }
    }
}