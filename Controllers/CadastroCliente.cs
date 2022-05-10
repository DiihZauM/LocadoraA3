using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LocadoraA3.Conexao;
using LocadoraA3.Models;
using Microsoft.AspNetCore.Mvc;

namespace LocadoraA3.Controllers
{
    public class CadastroCliente : Controller
    {

        conexaoDAO conexaoDao = new conexaoDAO();
        public IActionResult Index()
        {
            var Cliente = new Cliente();
            return View(Cliente);
        }
        [HttpPost]

        public ActionResult Index(CadastroCliente cliente)
        {
            if (ModelState.IsValid)
            {
                return View("cliente", cliente);
            }
            return View(cliente);
        }

        public ActionResult Confirmacao (CadastroCliente cliente)
        {
            return View(cliente);
        }

    }
}
