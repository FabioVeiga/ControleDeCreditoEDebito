using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFinance.Models;

namespace MyFinance.Controllers
{
    public class TransacaoController : Controller
    {
        IHttpContextAccessor HttpContextAccessor;
        //Ter a mesma estrutura do Model
        public TransacaoController(IHttpContextAccessor httpContextAccessor)
        {
            HttpContextAccessor = httpContextAccessor;
        }

        public IActionResult Index()
        {
            TransacaoModel objTransacao = new TransacaoModel(HttpContextAccessor);
            //para usar o VIEWBAG para trafegar na lista de dados entre a controller e a model
            ViewBag.ListaTransacao = objTransacao.ListaTransacao();
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(TransacaoModel formulario)
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
        public IActionResult Registrar(int? id)
        {
            //se nao for nulo era chamar o metodo para carregar o registro
            if (id != null)
            {
                TransacaoModel objTransacao = new TransacaoModel(HttpContextAccessor);
                ViewBag.Registro = objTransacao.CarregarRegistro(id);
            }

            //para carregar a lista de contas no formulario
            //cria uma viewbag instacionando o CotaModel e trasazendo a lista
            ViewBag.ListaContas = new ContaModel(HttpContextAccessor).ListaConta();
            ViewBag.ListaPlanoContas = new PlanoContaModel(HttpContextAccessor).ListaPlanoConta();
            return View();
        }

        public IActionResult Registrar()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ExcluirTransacao(int id)
        {
            TransacaoModel objTransacao = new TransacaoModel(HttpContextAccessor);
            ViewBag.Registro = objTransacao.CarregarRegistro(id);
            return View();
        }

        public IActionResult Excluir(int id)
        {
            TransacaoModel objTransacao = new TransacaoModel(HttpContextAccessor);
            objTransacao.Excluir(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        [HttpPost]
        public IActionResult Extrato(TransacaoModel formulario)
        {
            //Cria a vieabag da Conta e transacoes
            formulario.HttpContextAccessor = HttpContextAccessor;
            ViewBag.ListaTransacao = formulario.ListaTransacao();
            ViewBag.ListaContas = new ContaModel(HttpContextAccessor).ListaConta();
            return View();
        }

        [HttpPost]
        [HttpGet]
        public IActionResult Dashboard(Dashboard formulario)
        {
            string cores = "";
            string labels = "";
            string valores = "";
            var random = new Random();

            //preencher o dropdown
            ViewBag.ListaContas = new ContaModel(HttpContextAccessor).ListaConta();

            List<Dashboard> lista = new Dashboard(HttpContextAccessor).RetornarDadosGraficoPie(formulario);

            //percorrer todo o tamanho da lista
            for (int i = 0; i < lista.Count; i++)
            {
                valores += lista[i].Total.ToString() + ",";
                labels += "'" + lista[i].PlanoConta.ToString() + "',";
                cores += "'" + String.Format("#{0:X6}", random.Next(0x1000000)) + "',";
            }
            ViewBag.Cores = cores;
            ViewBag.Labels = labels;
            ViewBag.Valores = valores;            
            return View();
        }
    }
}