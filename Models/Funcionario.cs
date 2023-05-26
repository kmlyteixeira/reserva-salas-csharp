using System;
using Microsoft.EntityFrameworkCore;    
using reserva_salas_csharp.Repository;

namespace Models {


    public class Funcionario {
        public int Id {get ; set;}
        public string Nome {get ; set;}
        public string Sobrenome {get ; set;}
        public string Cpf {get ; set;}
        public string DataNasc {get ; set;}

    
        public Funcionario() {
            
        }

       

        public Funcionario(string nome,string sobrenome, string cpf,string dataNasc) {
            this.Id = Id;
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.Cpf = cpf; 
            this.DataNasc = dataNasc;
        }

         public void cadastrarFuncionario(string nome,string sobrenome, string cpf,string dataNasc)
        {
                using var context = new Database();
                var funcionario = new Funcionario { Nome = nome, Sobrenome = sobrenome , Cpf = cpf, DataNasc = dataNasc};
                context.funcionario.Add(funcionario);
                context.SaveChanges();
        }



       public static void alterarFuncionario(int id, string novoNome, float preco)
        {
          using var context = new Context();
            var produto = context.produtos.Find(id);
            if (produto != null)
            {
                produto.nome = novoNome;
                produto.preco = preco;
                context.SaveChanges();
            }
        }


        public static void exculirFuncionario(int id, string novoNome, float preco)
        {
        
        }

        public static void getFuncionario(int id)
        {
        
        }


        public static void GetAllFuncionario()
        {
        
        }
        

        
    }

}