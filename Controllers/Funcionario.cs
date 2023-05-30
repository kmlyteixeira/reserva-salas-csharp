using Models;
using reserva_salas_csharp.Repository;

namespace Controllers {


    public class Funcionario {
       

        public static void cadastraFuncionario(Models.Funcionario funcionario) {
            using var context = new Database();
            var funcionarios = new Models.Funcionario(funcionario.Nome,funcionario.Sobrenome,funcionario.Cpf,funcionario.DataNasc);
            funcionarios.cadastrarFuncionario(funcionario.Nome,funcionario.Sobrenome,funcionario.Cpf,funcionario.DataNasc);
        }


        public static void alterarFuncionario(int id, string nome, string sobrenome,string cpf,string dataNasc) {
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