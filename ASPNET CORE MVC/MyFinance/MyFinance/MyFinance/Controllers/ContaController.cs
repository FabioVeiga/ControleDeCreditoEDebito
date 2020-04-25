using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFinance.Models;

namespace MyFinance.Controllers
{
    public class ContaController : Controller
    {
        IHttpContextAccessor HttpContextAccessor;
        //Ter a mesma estrutura do Model
        public ContaController(IHttpContextAccessor httpContextAccessor)
        {
            HttpContextAccessor = httpContextAccessor;
        }


        public IActionResult Index()
        {
            //criar um instacia da conta model
            //usar a sobrecarga do construtor passando por paramentro o context acessor
            ContaModel objConta = new ContaModel(HttpContextAccessor);
            //para usar o VIEWBAG para trafegar na lista de dados entre a controller e a model
            ViewBag.ListaConta = objConta.ListaConta();
            return View();
        }

        [HttpPost]
        public IActionResult CriarConta(ContaModel formulario)
        {
            if (ModelState.IsValid)
            {
                formulario.HttpContextAccessor = HttpContextAccessor;
                formulario.Insert();
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult CriarConta()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ExcluirConta(int id)
        {
            ContaModel objConta = new ContaModel(HttpContextAccessor);
            objConta.Excluir(id);
            return RedirectToAction("Index");
        }
    }
}