using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFinance.Models;

namespace MyFinance.Controllers
{
    public class UsuarioController : Controller
    {
        [HttpGet]
        public IActionResult Login(int? id)
        {
            if(id != null)
                {
                    if(id == 0)
                {
                    HttpContext.Session.SetString("NomeUsuarioLogado", string.Empty);
                    HttpContext.Session.SetString("IdUsuarioLogado", string.Empty);
                }
                }
            return View();
        }
        [HttpPost]
        public IActionResult ValidarLogin(UsuarioModel usuario)
        {
            bool login = usuario.ValidarLogin();

            //testa se a validacao esta valida
            if (login)
            {
                HttpContext.Session.SetString("NomeUsuarioLogado", usuario.Nome);
                HttpContext.Session.SetString("IdUsuarioLogado", usuario.Id.ToString());
                return RedirectToAction("Menu", "Home");
            }
            else
            {
                TempData["MensagemLoginInvalida"] = "Dados de login invalidos!";
                return RedirectToAction("Login");
            }
        }

        //add na controler a view do registrar criado na pasta view
        //por convencao ded nomes eh obrigatorio colocar o mesmo nome da View
        //pode receber um tipo Model, neste caso o model do usuario
        //e so vai receber dados via post, quando submeter o formulario
        [HttpPost]
        public IActionResult Registrar(UsuarioModel usuario)
        {
            //vai verificar o estado dos dados do  meu modelo
            if (ModelState.IsValid)
            {
                //registrar o usuario, vai chamar o model do usuario na funcao RegistrarUsuario
                usuario.RegistrarUsuario();
                return RedirectToAction("SucessoRegistroUsuario");
            }
            return View();
        }

        //Como nao esta recebendo nenhum paramentro no metodo de envio do GET
        //Deve se criar um novo Iaction implicando o HttpGet
        [HttpGet]
        public IActionResult Registrar()
        {
            return View();
        }

        //Criar um IactionResulto para direcionar para pagina de sucecsso
        public IActionResult SucessoRegistroUsuario()
        {
            return View();
        }
    }
}