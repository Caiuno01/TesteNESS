using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TesteNESS.Business;
using TesteNESS.Models;
using TesteNESS.Repositories;

namespace TesteNESS.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly UsuarioBusiness business;

        public UsuarioController()
        {
            business = new UsuarioBusiness();
        }

        [HttpGet]
        public IActionResult Index()
        {
            IList<UsuarioModel> usuarios = business.FindAll();
            return View(usuarios);
        }

        [HttpGet]
        public IActionResult Novo()
        {
            return View(new UsuarioModel());
        }

        [HttpPost]
        public IActionResult Novo(UsuarioModel usuario)
        {
            if (ModelState.IsValid)
            {
                business.Insert(usuario);
                TempData["mensagem"] = "Usuário inserido com sucesso!";
                return RedirectToAction("Index","Usuario");
            } else
            {
                return View(usuario);
            }
        }

        [HttpGet]
        public IActionResult Detalhes(int id)
        {
            return View(business.FindById(id));
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            return View(business.FindById(id));
        }

        [HttpPost]
        public IActionResult Editar(UsuarioModel usuario)
        {
            if (ModelState.IsValid)
            {
                business.Update(usuario);
                TempData["mensagem"] = "Usuário alterado com sucesso!";
                return RedirectToAction("Index", "Usuario");
            }
            else
            {
                return View(usuario);
            }
        }

        [HttpGet]
        public IActionResult Apagar(int id)
        {
            business.Delete(id);
            TempData["mensagem"] = "Usuário apagado com sucesso!";
            return RedirectToAction("Index", "Usuario");
        }
    }
}