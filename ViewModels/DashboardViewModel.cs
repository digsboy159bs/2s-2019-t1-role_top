using System.Collections.Generic;
using ROLE_TOP.Models;

namespace ROLE_TOP.ViewModels
{
    public class DashboardViewModel : BaseViewModel
    {
        public List<Alugar> Agendamentos {get;set;}
        public uint AgendamentosAprovados {get;set;}
        public uint AgendamentosReprovados {get;set;}
        public uint AgendamentosPendentes {get;set;}
        public DashboardViewModel()
        {
            this.Agendamentos = new List<Alugar>();
        }
    }
}