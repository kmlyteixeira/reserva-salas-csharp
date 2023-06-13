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


        public static void alterarHigienizacao(int id, string nome, string sobrenome,string cpf,string dataNasc) {
            var camposParaAtualizar = new Dictionary<string, string>
            {
                { "Nome", nome },
                { "Sobrenome", sobrenome },
                { "Cpf", cpf },
                { "DataNasc", dataNasc }
            };

            Models.Funcionario.alterarFuncionario(id, camposParaAtualizar);
        }
        
        
       public static void excluirFuncionario(int id)
        {
            Models.Funcionario.excluirFuncionario(id);
        }


         public static void mostrarFunc(int id)
        {
            Models.Funcionario.GetByIdFunc(id);
        }

         public static void mostrarAllFunc()
        {
            Models.Funcionario.GetAllFuncionario();
        }

    }

}