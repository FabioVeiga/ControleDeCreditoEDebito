using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspnetCoreMCV.Models;
using Microsoft.AspNetCore.Mvc;

namespace aspnetCoreMCV.Controllers
{
    public class HomeController : Controller
    {
        [HttpPost]
        [HttpGet]
        public IActionResult Index(HomeModel formulario)
        {
            carregarListaDados();
            return View();
        }

        public void carregarListaDados()
        {
            HomeModel objHomeModel = new HomeModel();
            ViewBag.Lista = objHomeModel.GetAll();
        }
    }
}