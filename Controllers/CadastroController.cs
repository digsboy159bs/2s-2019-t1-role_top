using System;
using ROLE_TOP.Models;
using ROLE_TOP.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ROLE_TOP.Controllers
{
    public class CadastroController : Controller
    {

        ClienteRepository clienteRepository = new ClienteRepository();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CadastrarCliente(IFormCollection form)
        {
            ViewData["Action"] = "Cadastro";
            try
            {
                Cliente cliente = new Cliente(form["nome"],form["endereco"],form["telefone"],form["senha"],form["email"],DateTime.Parse(form["data-nascimento"]));

                clienteRepository.Inserir(cliente);
                return View("Sucesso");
                
            }
            catch(Exception e)
            {
                System.Console.WriteLine(e.StackTrace);
                return View("Erro");
            }
           
        }
    }
}