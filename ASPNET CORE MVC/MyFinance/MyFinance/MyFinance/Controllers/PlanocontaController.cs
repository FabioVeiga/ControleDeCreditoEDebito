using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFinance.Models;

namespace MyFinance.Controllers
{
    public class PlanoContaController : Controller
    {
        IHttpContextAccessor HttpContextAccessor;
        //Ter a mesma estrutura do Model
        public PlanoContaController(IHttpContextAccessor httpContextAccessor)
        {
            HttpContextAccessor = httpContextAccessor;
        }


        public IActionResult Index()
        {
            //criar um instacia da Plano conta model
            //usar a sobrecarga do construtor passando por paramentro o context acessor
            PlanoContaModel objPlanoConta = new PlanoContaModel(HttpContextAccessor);
            //para usar o VIEWBAG para trafegar na lista de dados entre a controller e a model
            ViewBag.ListaPlanoConta = objPlanoConta.ListaPlanoConta();
            return View();
        }

        [HttpPost]
        public IActionResult CriarPlanoConta(PlanoContaModel formulario)
        {
            if (ModelState.IsValid)
            {
                formulario.HttpContextAccessor = HttpContextAccessor;
                formulario.Insert();
                return RedirectToAction("Index");
            }
            return View();
        }
        //Colocado como parametro opcional o Id, se tiver preenchido o paramentro
        //tera uma condicional para editar o cdastro
        [HttpGet]
        public IActionResult CriarPlanoConta(int? id)
        {
            //se nao for nulo era chamar o metodo para carregar o registro
            if(id != null)
            {
                PlanoContaModel objPlanoConta = new PlanoContaModel(HttpContextAccessor);
                ViewBag.Registro = objPlanoConta.CarregarRegistro(id);
            }
            return View();
        }

        [HttpGet]
        public IActionResult ExcluirPlanoConta(int id)
        {
            PlanoContaModel objPlanoConta = new PlanoContaModel(HttpContextAccessor);
            objPlanoConta.Excluir(id);
            return RedirectToAction("Index");
        }

    }
}