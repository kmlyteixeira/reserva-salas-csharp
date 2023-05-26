using Models;
using reserva_salas_csharp.Repository;

namespace Controllers {


    public class Funcionario {
       

        public static void cadastraFuncionario(Models.Funcionario funcionario) {
            using var context = new Database();
            var funcionarios = new Models.Funcionario(funcionario.Nome,funcionario.Sobrenome,funcionario.Cpf,funcionario.DataNasc);
            funcionarios.cadastrarFuncionario(funcionario.Nome,funcionario.Sobrenome,funcionario.Cpf,funcionario.DataNasc);
        }


        public static void alterarProdutos(int id, string nome, float preco) {
           
        }
        
        
        /*

        public static void excluirProdutos(int id) {
            Models.Produto.ExcluirProduto(id);
        }*/
    }

}