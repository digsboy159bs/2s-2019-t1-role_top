using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ROLE_TOP.Enums;
using ROLE_TOP.Models;
using ROLE_TOP.Repositories;
using ROLE_TOP.ViewModels;

namespace ROLE_TOP.Controllers
{
    public class ReservaController : AbstractController
    {
          ClienteRepository clienteRepository = new ClienteRepository ();
        ReservaRepository reservaRepository = new ReservaRepository ();
        EventoRepository eventoRepository = new EventoRepository ();
        
        public IActionResult Index () {
            ReservaViewModel rvm = new ReservaViewModel ();
            rvm.Eventos = eventoRepository.ObterTodos ();
           
            var emailCliente = ObterUsuarioSession ();
            if (!string.IsNullOrEmpty (emailCliente)) {
                rvm.Cliente = clienteRepository.ObterPor (emailCliente);
            }

            var nomeUsuario = ObterUsuarioNomeSession ();
            if (!string.IsNullOrEmpty (nomeUsuario)) {
                rvm.NomeCliente = nomeUsuario;
            }

            rvm.NomeView = "Reserva";
            rvm.UsuarioEmail = emailCliente;
            rvm.UsuarioNome = nomeUsuario;

            return View (rvm);

        }

        public IActionResult Registrar (IFormCollection form) {
            ViewData["Action"] = "Reserva";
            Reserva reserva = new Reserva ();

           

            var nomeEvento = form["evento"];
            Evento evento = new Evento (nomeEvento, eventoRepository.ObterPrecoDe (nomeEvento));
            reserva.Evento = evento;

            Cliente cliente = new Cliente ();
            cliente.Nome = form["nome"];
            cliente.Cpf = form["cpf"];
            cliente.Telefone = form["telefone"];
            cliente.Email = form["email"];

            reserva.Cliente = cliente;
            reserva.DataDaReserva = DateTime.Now;
            reserva.PrecoTotal = evento.Preco ;

            if (reservaRepository.Inserir (reserva)) {
                return View ("Sucesso", new RespostaViewModel () {
                    NomeView = "Reserva",
                        Mensagem = $"{cliente.Nome} sua reserva foi concluida!"
                });

            } else {
                return View ("Erro", new RespostaViewModel () {
                    NomeView = "Reserva",
                        Mensagem = $"{cliente.Nome} sua reserva nao foi concluida!"
                });
            }

        }

        public IActionResult Aprovar (ulong id) {
            var reserva = reservaRepository.ObterPor (id);
            reserva.Status = (uint) StatusReserva.APROVADO;

            if (reservaRepository.Atualizar (reserva)) {
                return RedirectToAction ("Dashboard", "Administrador");
            } else {
                return View ("Erro", new RespostaViewModel ("Nao foi possivel aprovar") {
                    NomeView = "Dashboard",
                        UsuarioEmail = ObterUsuarioSession (),
                        UsuarioNome = ObterUsuarioNomeSession ()
                });

            }
        }
        public IActionResult Reprovar (ulong id) {
            var reserva = reservaRepository.ObterPor (id);
            reserva.Status = (uint) StatusReserva.REPROVADO;

            if (reservaRepository.Atualizar (reserva)) {
                return RedirectToAction ("Dashboard", "Administrador");
            } else {
                return View ("Erro", new RespostaViewModel ("Nao foi possivel reprovar esta reserva") {
                    NomeView = "Dashboard",
                        UsuarioEmail = ObterUsuarioSession (),
                        UsuarioNome = ObterUsuarioNomeSession ()
                });
            }
        }
    }
}
    
