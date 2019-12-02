namespace ROLE_TOP.Models
{
    public class Lugar : Produto
    {
         public Lugar()
        {

        }

        public Lugar(string nome, double preco)
        {
            this.Nome= nome;
            this.Preco = preco;
        }
    }
}