using System.Web.Mvc;

namespace Caelum.Fn23.Revisao.Aula1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //return new ViewResult { ViewName = "Index" };
            //ou...
            return View();
        }
    }
}