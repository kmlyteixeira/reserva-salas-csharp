using reserva_salas_csharp.Models;
using reserva_salas_csharp.Repository;

namespace reserva_salas_csharp.Controllers {


    public class Higienizacao {
       

        public static void cadastraHigienizacao(Models.Sala sala,
            Models.Funcionario funcionario,
            Models.Usuario usuario,Models.Higienizacao higienizacao) {
            using var context = new Database();
            
            var higienizacoes = new Models.Higienizacao(sala,funcionario,usuario,higienizacao.Observacao);
        }


        public static void alterarHigienizacao(int id, string observacao, string idhorario,string idSala,string idUsusario, string idFunc) {
            var camposParaAtualizar = new Dictionary<string, string>
            {
                { "Observacao", observacao },
                { "Idhorario", idhorario },
                { "IdSala", idSala },
                { "IdUsusario", idUsusario },
                { "IdFunc", idFunc }
            };

            Models.Higienizacao.alterarHigienizacao(id, camposParaAtualizar);
        }
        
        
       public static void excluirHigienizacao(int id)
        {
            Models.Higienizacao.excluirHigienizacao(id);
        }


         public static void mostrarHigien(int id)
        {
            Models.Higienizacao.GetByIdHigi(id);
        }

         public static void mostrarAllHigien()
        {
            Models.Higienizacao.GetAllHigienizacao();
        }

    }

}