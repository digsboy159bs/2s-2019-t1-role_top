using System;
using ROLE_TOP.Models;
using ROLE_TOP.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ROLE_TOP.ViewModels;
using ROLE_TOP.Enums;

namespace ROLE_TOP.Controllers
{
    public class CadastroController : AbstractController
    {

    ClienteRepository clienteRepository = new ClienteRepository();
        public IActionResult Index()
        {
             return View(new BaseViewModel()
            {
                NomeView = "Cadastro",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession() 
            });

           
        }
          public IActionResult Cadastrar(IFormCollection form)
        {
            Cliente cliente = new Cliente();
            ViewData["Action"] = "Cadastro";
            try
            {
                cliente = new Cliente(form["nome"],form["cpf"],form["telefone"],form["senha"],form["email"],DateTime.Parse(form["data-nascimento"]));
                cliente.TipoUsuario = (uint) TiposUsuario.CLIENTE;

                clienteRepository.Inserir(cliente);
                return View("Sucesso", new RespostaViewModel()
                {
                    NomeView = "Cadastro",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession() 
                });
                
            }
             catch(Exception e)
            {
                System.Console.WriteLine(e.StackTrace);
                return View("Erro", new RespostaViewModel()
                {
                    NomeView = "Cadastro",
                    Mensagem = $"{cliente.Nome} seu cadastro foi concluído!"
                });
            }
        
    }
}
}