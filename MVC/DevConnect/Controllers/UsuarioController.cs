using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DevConnect.Contexts;
using DevConnect.Models;
using Microsoft.AspNetCore.Mvc; 
using Microsoft.Extensions.Logging;

namespace DevConnect.Controllers
{
    
    public class UsuarioController : Controller
    {
          private readonly DevConnectContext _context;
        private readonly ILogger<UsuarioController> _logger;

        public UsuarioController(ILogger<UsuarioController> logger, DevConnectContext context)
        {
            _logger = logger;
            _context = context;
            
        }

            public IActionResult Perfil()
        {
            return View();
        }

[HttpGet]
        public IActionResult Index()
        {
            ViewData["MensagemParaOUsuario"] = "";
            ViewBag.MensagemParaOUsuario = "";
            
            return View();
        }

[HttpPost]
        public async Task<IActionResult> Index(IFormCollection form)
        {
            TbUsuario novoUsuario = new TbUsuario()
            {
                NomeCompleto = form["NomeCompleto"].ToString(),
                NomeUsuario = form ["NomeUsuario"].ToString(),
                Email = form ["Email"].ToString(),
                Senha = form ["Senha"].ToString(),
            };

            if (form.Files.Count > 0)
                   //aqui ele verifica o campo
            {
                //se selecionou uma imagem entra dentro do if
                 IFormFile file = form.Files[0];
                var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/imagem");


                 if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }


            var path = Path.Combine(folder, file.FileName);

            using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                    
                }

                //passa o nome da imagmem para o objeto
                novoUsuario.FotoPerfilUrl = file.FileName;
            }

           
            else 
            {
                //esta mandando uma imagem padrao caso o usuario nao selecione nenhuma
                novoUsuario.FotoPerfilUrl = "";
            }

            try
            {
                _context.TbUsuario.Add(novoUsuario);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Home");

               // TempData["UsuarioCadastrado"] = "Usuario cadastrado com sucesso!";

                ViewData["MensagemParaOUsuario"] = "Usuario foi cadastrado com sucesso!";
                ViewBag.MensagemParaOUsuario = "";
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao cadastrar usuário");
                ViewData["MensagemParaOUsuario"] = "Erro ao se cadastrar usuario.";
                ViewBag.MensagemParaOUsuario = "";
                 return View();
            }

           
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}