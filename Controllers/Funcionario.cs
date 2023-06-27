using reserva_salas_csharp.Models;
using reserva_salas_csharp.Repository;

namespace reserva_salas_csharp.Controllers {


    public class Funcionario {
       

        public static void cadastraFuncionario(string nome,string sobrenome, string cpf,string dataNasc) {
            using var context = new Database();
            var funcionarios = new Models.Funcionario(nome,sobrenome,cpf,dataNasc);
            funcionarios.cadastrarFuncionario(nome,sobrenome,cpf,dataNasc);
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


        public static int mostrarFuncById(int id)
    {
        return Models.Funcionario.GetByIdfunc(id);
    }


        
        public static IEnumerable<Models.Usuario> mostrarAllFunc()
        {
            return (IEnumerable<Models.Usuario>)Models.Funcionario.GetAllFuncionario();
        }
         
    }

}