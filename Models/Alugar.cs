using System;
using ROLE_TOP.Enums;

namespace ROLE_TOP.Models
{
    public class Alugar
    {
       
        public ulong Id {get;set;}
        public Cliente Cliente {get;set;}

        public Lugar Lugar {get;set;}

        

        public DateTime DataDoAlugar {get;set;}

        public double PrecoTotal {get;set;}

        public uint Status {get;set;}

        public Alugar()
        {
            this.Cliente = new Cliente();
            this.Lugar = new Lugar();
            
            this.Id = 0;
            this.Status = (uint) StatusAlugar.PENDENTE; 
        }
    }
}