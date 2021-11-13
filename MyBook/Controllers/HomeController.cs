using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyBook.Models;
using MyBook.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyBook.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly LivroServices _service;
        public HomeController(ILogger<HomeController> logger, LivroServices service)
        {
            _logger = logger;
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.Livros = _service.FindAll();
            return View();
        }

        
    }
}
