using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace freioficina.Controllers
{
    public class livroController : Controller
    {
        // GET: livro
        public ActionResult Index()
        {
            return View();
        }
        // GET: Livro

        //inserir
        [HttpPost]
        public ActionResult cadastrar(model.livromodel livro)
        {
            bussines.bussines blivro = new bussines.bussines();
            blivro.inserir(livro);
            return View();
        }
        public ActionResult cadastrar()
        {
            return View();
        }

        //listar
        public ActionResult listar()
        {
            bussines.bussines blivro = new bussines.bussines();
            List<model.livromodel> lista = blivro.ltodos();
            return View(lista);
        }
        //deletar



        public ActionResult deletar(int idlivro)
        {
            bussines.bussines blivro = new bussines.bussines();
            model.livromodel lista = blivro.flivro(idlivro);
            return View(lista);
        }
        [HttpPost]
        public ActionResult deletar(model.livromodel l)
        {
            bussines.bussines blivro = new bussines.bussines();
            blivro.delete(l.idlivro);
            return View("listar");
        }

        //alterar
        public ActionResult alterar(int idlivro)
        {
            bussines.bussines blivro = new bussines.bussines();
            model.livromodel lista = blivro.flivro(idlivro);
            return View(lista);
        }

        [HttpPost]
        public ActionResult alterar(model.livromodel livro)
        {

            bussines.bussines blivro = new bussines.bussines();
            blivro.alterar(livro);
            return View("listar");
        }

    }
}