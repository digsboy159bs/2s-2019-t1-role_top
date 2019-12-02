using System.Collections.Generic;
using ROLE_TOP.Models;

namespace ROLE_TOP.ViewModels
{
    public class AlugarViewModel : BaseViewModel
    {
        public List<Lugar> Lugares  {get;set;} 
       

        public Cliente Cliente {get;set;} 
        public string NomeCliente {get;set;} 

        public AlugarViewModel()
        {
            this.Lugares = new List<Lugar>();
            
            this.Cliente = new Cliente();
            this.NomeCliente = "Jovem";
        }
    }
}