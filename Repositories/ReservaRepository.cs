using System;
using System.Collections.Generic;
using System.IO;
 using ROLE_TOP.Models;
 namespace ROLE_TOP.Repositories
 {
     public class ReservaRepository : RepositoryBase
     {
            private const string PATH = "Database/Reserva.csv";
        public ReservaRepository()
        {
            if(!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }

        public bool Inserir(Reserva reserva)
        {
            var quantidadeReservas = File.ReadAllLines(PATH).Length;
            reserva.Id = (ulong) ++quantidadeReservas;
            var linha = new string[] {PrepararReservaCSV(reserva)};
            File.AppendAllLines(PATH, linha);
            return true;
        }
        public List<Reserva> ObterTodosPorCliente(string emailCliente)
        {
            var reservas = ObterTodos();
            List<Reserva> reservasCliente = new List<Reserva>();
            foreach (var reserva in reservas)
            {
                if(reserva.Cliente.Email.Equals(emailCliente))
                {
                    reservasCliente.Add(reserva);
                }
            }
            return reservasCliente;
        }
         

        public List<Reserva> ObterTodos()
        
        {
           var linhas =  File.ReadAllLines(PATH);
           List<Reserva> reservas = new List<Reserva>();
           foreach (var linha in linhas)
           {
            Reserva reserva = new Reserva();
            reserva.Cliente = new Cliente();
            reserva.Id = ulong.Parse(ExtrairValorDoCampo("id", linha));
            reserva.Status = uint.Parse(ExtrairValorDoCampo("status_reserva", linha));
            reserva.Cliente.Nome = ExtrairValorDoCampo("cliente_nome", linha);
            reserva.Cliente.Cpf = ExtrairValorDoCampo("cliente_cpf", linha);
            reserva.Cliente.Telefone = ExtrairValorDoCampo("cliente_telefone", linha);
            reserva.Cliente.Email = ExtrairValorDoCampo("cliente_email", linha);
            reserva.Evento.Nome = ExtrairValorDoCampo("evento_nome", linha);
            reserva.Evento.Preco = double.Parse(ExtrairValorDoCampo("evento_preco", linha));
            reserva.PrecoTotal = double.Parse(ExtrairValorDoCampo("preco_total", linha));
            reserva.DataDaReserva = DateTime.Parse(ExtrairValorDoCampo("data_reserva", linha));

            reservas.Add(reserva);
           
             
            
           }
           return reservas;
        }

        public Reserva ObterPor(ulong id)
        {
            var reservasTotais = ObterTodos();
            foreach (var reserva in reservasTotais)
            {
                if(id.Equals(reserva.Id))
                {
                    return reserva;
                }
            }
            return null;
        }

        public bool Atualizar(Reserva reserva)
        {
            var reservasTotais = File.ReadAllLines(PATH);
            var reservaCSV = PrepararReservaCSV(reserva);
            var linhaReserva = -1;
            var resultado = false;
            for (int i = 0; i < reservasTotais.Length; i++)
            {
                var idConvertido = ulong.Parse(ExtrairValorDoCampo("id", reservasTotais[i]));
                if (reserva.Id.Equals(idConvertido))
                {
                    linhaReserva = i;
                    resultado = true;
                    break;
                }
            }

            if (resultado)
            {
                reservasTotais[linhaReserva] = reservaCSV;
                File.WriteAllLines(PATH, reservasTotais);
            }

            return resultado;
        }

        
        private string PrepararReservaCSV(Reserva reserva)
        {
            Cliente cliente = reserva.Cliente;
            Evento evento = reserva.Evento;
           
            return $"id={reserva.Id};status_reserva={reserva.Status};cliente_nome={cliente.Nome};cliente_cpf={cliente.Cpf};cliente_telefone={cliente.Telefone};cliente_email={cliente.Email};evento_nome={evento.Nome};evento_preco={evento.Preco};data_reserva={reserva.DataDaReserva};preco_total={reserva.PrecoTotal}";

        }
    }
}