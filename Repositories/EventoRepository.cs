using System.Collections.Generic;
using System.IO;
using ROLE_TOP.Models;

namespace ROLE_TOP.Repositories
{
    public class EventoRepository
    {
        
   
        private const string PATH = "Database/Evento.csv";

        public double ObterPrecoDe(string nomeEvento)
        {
            var lista = ObterTodos();
            var preco = 0.0;
            foreach(var item in lista)
            {
                if(item.Nome.Equals(nomeEvento))
                {
                    preco = item.Preco;
                    break;

                }
            }
            return preco;
        }

        public List<Evento> ObterTodos()
        {
            List<Evento> eventos = new List<Evento>();
            string[] linhas = File.ReadAllLines(PATH);
            foreach (var linha in linhas)
            {
                Evento h = new Evento();
                string[] dados = linha.Split(";");
                h.Nome = dados[0];
         
                eventos.Add(h);
                
            }

            return eventos;
        }
    }
}