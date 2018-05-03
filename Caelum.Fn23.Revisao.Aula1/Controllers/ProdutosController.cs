using Caelum.Fn23.Revisao.Aula1.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.Mvc;

namespace Caelum.Fn23.Revisao.Aula1.Controllers
{
    public class ProdutosController : Controller
    {
        public ActionResult Index()
        {
            IList<Produto> model = new List<Produto>();
            string connString = ConfigurationManager.ConnectionStrings["loja"].ConnectionString;
            using (var cnx = new SqlConnection(connString))
            {
                cnx.Open();
                using (var select = cnx.CreateCommand())
                {
                    select.CommandText = "select * from produtos";
                    var leitor = select.ExecuteReader();
                    while (leitor.Read())
                    {
                        var produto = new Produto
                        {
                            Id = Convert.ToInt32(leitor["Id"]),
                            Nome = Convert.ToString(leitor["Nome"]),
                            PrecoUnitario = Convert.ToDecimal(leitor["PrecoUnitario"]),
                            Categoria = Convert.ToString(leitor["Categoria"])
                        };
                        model.Add(produto);
                    }
                }
            }
            return View(model);
        }
    }
}