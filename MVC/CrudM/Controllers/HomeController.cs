using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CrudM.Models;

namespace CrudM.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    // ACAO PADRAO INICIAL SEMPRE
    public IActionResult Index()
    {
        return View();
    }

    
    public IActionResult MinhaAcao()
    {
        return View(); //VAI RETORNAR A PAGINA MINHA ACAO
    }

    public IActionResult ListaNomes()
    {
        String[] nomes = {"Eduardo, Joao, Felipe salgado, felipe gomes, Rafael, Becker"};

        ViewBag.Teste = "Ola vim atraves do ViewBag";
        ViewBag.nomes = nomes;

        return View(); // VAI RETORNAR A PAGINA LISTAR NOME
    }


    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
