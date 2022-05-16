using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LocadoraA3.Conexao;
using LocadoraA3.Models;
using Microsoft.AspNetCore.Mvc;

namespace LocadoraA3.Controllers
{
    public class Login : Controller
    {
        conexaoDAO conexaoDao = new conexaoDAO();
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public IActionResult entrar(LoginModel loginModel)
        {
            try
            {
                loginModel = conexaoDao.Login(loginModel.Email);
                if (ModelState.IsValid)
                {
                    return RedirectToAction("Index", "Home");
                }
                return View("Index");
            }
            catch (Exception e)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos realizar seu login, tente novamente, detatlhe do erro" + e;
                return RedirectToAction("Index");
            }
        }
    }
}
