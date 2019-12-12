using System.Collections.Generic;
using ROLE_TOP.Models;

namespace ROLE_TOP.ViewModels
{
    public class DashboardViewModel : BaseViewModel
    {
        public List<Reserva> Reservas {get;set;}
        public uint ReservasAprovados {get;set;}
        public uint ReservasReprovados {get;set;}
        public uint ReservasPendentes {get;set;}
        public DashboardViewModel()
        {
            this.Reservas = new List<Reserva>();
        }
    }
}