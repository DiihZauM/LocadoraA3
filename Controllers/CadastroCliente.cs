using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LocadoraA3.Conexao;
using LocadoraA3.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LocadoraA3.Controllers
{
    public class CadastroCliente : Controller
    {

        conexaoDAO conexaoDao = new conexaoDAO();
        Cliente Cli = new Cliente();
        public ViewResult index()
        {
            return View();
        }
        
        public IActionResult cadastroCliente()
        {
            
            return View();
        }
        [HttpPost]

        public ActionResult cadastroCliente(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                
                conexaoDao.CadCliente(cliente);

                return View("confirmacao");
            }
            return View();
        }

        public ActionResult Confirmacao (CadastroCliente cliente)
        {
            return View(cliente);
        }

        public ActionResult login (conexaoDAO login)
        {

        }

    }
}
