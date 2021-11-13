using Microsoft.AspNetCore.Mvc;
using MyBook.Data;
using MyBook.Models;
using MyBook.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBook.Controllers
{
    public class LivrosController : Controller
    {
        private readonly LivroServices _service;
       
        public LivrosController(LivroServices service)
        {
            _service = service;
        }

        public IActionResult Create()
        {
            return View("Create");
        }
        public async Task<IActionResult> index()
        {
            ViewBag.Livros = _service.FindAll();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateLivro([Bind("Id,Titulo,Autor,Capitulos")] Livro livro)
        {
            _service.Inserir(livro);
            return RedirectToAction(nameof(Create));
        }

        public async Task<IActionResult> Edit(int? id)
        {
            var livro = await _service.EditarAsync(id);
            return View(livro);
        }

    }
}
