using FiapWeb.Data;
using FiapWeb.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiapWeb.Controllers
{
    public class HomeController: Controller
    {
        private readonly PerguntaContext _context;
        public HomeController(PerguntaContext context)
        {
            _context = context;
        }

        //public string Index()
        //{
        //    return DateTime.Now.ToString();
        //}

        public IActionResult Index()
        {
            //ViewBag.Nome = "Rodolfo";
            //ViewData["NomeDoAluno"] = $"Outro Nome {ViewBag.Nome}";

            //var pergunta = new Pergunta(1, "qual a pergunta", "Diogo");

            return View(_context.Perguntas.ToList());
        }
        public IActionResult Sobre()
        {
            return View();
        }

        public IActionResult Ajuda()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Pergunta pergunta)
        {
            if(ModelState.IsValid)
            {
                _context.Perguntas.Add(pergunta);
                await _context.SaveChangesAsync();
            }

            return View();
        }

        //[HttpPost]
        //public IActionResult Create(IFormCollection collection)
        //{
        //    var desc = collection["Descricao"];
        //    var aluno = collection["Autor"];
        //    return View();
        //}
    }
}
