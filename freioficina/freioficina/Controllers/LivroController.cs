using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace freioficina.Controllers
{
    public class LivroController : Controller
    {
    
        // GET: Livro
     
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
        public ActionResult alterar(model.livromodel livro)
        {
       
            bussines.bussines blivro = new bussines.bussines();
            blivro.alterar(livro);
            return View();
        }
        public ActionResult alterar()
        {
            return View();
        }
        public ActionResult deletar(int id)
        {
         
            bussines.bussines blivro = new bussines.bussines();
            blivro.delete(id);
            return View();
        }
        public ActionResult deletar()
        {

         
            return View();
        }
        public ActionResult listar()
        {
            bussines.bussines blivro = new bussines.bussines();
            List<model.livromodel> lista = blivro.ltodos();
            return View(lista);
        }

    }
}