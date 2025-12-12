using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CrudM.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CrudM.Controllers
{
   
    public class FrutasController : Controller
    {
        private readonly ILogger<FrutasController> _logger;

        public List<Frutas> ListarDeFrutas = new List<Frutas> 
        {
             new Frutas{Id = 1, Nome = "Morango", Preco = 5.99f, Quantidade = 10, Categoria = "Tropical"},
             new Frutas{Id = 2, Nome = "Manga", Preco = 5.49f, Quantidade = 11, Categoria = "Tropical"},
             new Frutas{Id = 3, Nome = "Melancia", Preco = 15.99f, Quantidade = 15, Categoria = "Tropical"},

        
        };
    
       
    
        public FrutasController(ILogger<FrutasController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListarFrutas()
        {

                ViewBag.frutas = ListarDeFrutas;

            return View();
        }


        //mostra a tela de cadastro
        public IActionResult Create()
        {
            return View();
        }

        //SALVAR A FRUTA NA LISTA DE FRUTA
        //EM SEGUDA REDIRECIONA PARA A LISAT/TELA DE FRUTA
        public IActionResult SalvarFrutas(Frutas frutasCadastro)
        {
           return RedirectToAction("ListarFrutas");
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}