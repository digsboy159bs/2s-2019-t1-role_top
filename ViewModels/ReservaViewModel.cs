using System.Collections.Generic;
using ROLE_TOP.Models;

namespace ROLE_TOP.ViewModels
{
    public class ReservaViewModel : BaseViewModel
    {
        public List<Evento> Eventos  {get;set;} 
       

        public Cliente Cliente {get;set;} 
        public string NomeCliente {get;set;} 

        public ReservaViewModel()
        {
            this.Eventos = new List<Evento>();
            
            this.Cliente = new Cliente();
            this.NomeCliente = "Jovem";
        }
    }
}