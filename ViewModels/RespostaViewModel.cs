namespace ROLE_TOP.ViewModels
{
    public class RespostaViewModel : BaseViewModel
    {
         public string Mensagem {get;set;} 

            public RespostaViewModel () {

            }
            public RespostaViewModel (string mensagem) {
                this.Mensagem = mensagem;
            }
    }
}