using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TesteNESS.Models;
using TesteNESS.Repositories;

namespace TesteNESS.Controllers
{
    public class UsuarioController : Controller
    {
        public UsuarioRepository repository { get; set; }

        public UsuarioController()
        {
            repository = new UsuarioRepository();
        }

        [HttpGet]
        public IActionResult Index()
        {
            IList<UsuarioModel> usuarios = repository.FindAll();
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
                repository.Insert(usuario);
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
            return View(repository.FindById(id));
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            return View(repository.FindById(id));
        }

        [HttpPost]
        public IActionResult Editar(UsuarioModel usuario)
        {
            if (ModelState.IsValid)
            {
                repository.Update(usuario);
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
            repository.Delete(id);
            TempData["mensagem"] = "Usuário apagado com sucesso!";
            return RedirectToAction("Index", "Usuario");
        }
    }
}