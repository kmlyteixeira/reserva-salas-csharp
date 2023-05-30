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



        public static void alterarFuncionario(int id, Dictionary<string, string> novosCampos)
{
            using var context = new Database();
            var funcionario = context.funcionario.Find(id);

            if (funcionario != null)
            {
                foreach (var campo in novosCampos)
                {
                    var propertyInfo = funcionario.GetType().GetProperty(campo.Key);
                    if (propertyInfo != null && campo.Value != "")
                    {
                        propertyInfo.SetValue(funcionario, campo.Value);
                    }
                    else
                    {
                        Console.WriteLine($"Campo inválido: {campo.Key}");
                    }
                }

                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Funcionario no encontrado.");
            }
        }



       public static void excluirFuncionario(int id)
        {
            using var context = new Database();
            var funcionario = context.funcionario.Find(id);

            if (funcionario != null)
            {
                context.funcionario.Remove(funcionario);
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Funcionario no encontrado.");
            }
        }


        public static void GetByIdFunc(int id)
        {
           using var context = new Database();
                    var funcionario = context.funcionario.Find(id);

            if (funcionario != null)
            {
                Console.WriteLine("Datos del funcionario:");
                Console.WriteLine($"ID: {funcionario.Id}");
                Console.WriteLine($"Nombre: {funcionario.Nome}");
                Console.WriteLine($"Apellido: {funcionario.Sobrenome}");
                Console.WriteLine($"Cpf: {funcionario.Cpf}");
                Console.WriteLine($"Fecha de Nacimiento: {funcionario.DataNasc}");
            }
            else
            {
                Console.WriteLine("Funcionario no encontrado.");
            }
        }

        
       

        public static void GetAllFuncionario()
        {
        

    using var context = new Database();
    var funcionarios = context.funcionario.ToList();

    if (funcionarios.Count > 0)
    {
        Console.WriteLine("Lista de funcionarios:");
        foreach (var funcionario in funcionarios)
        {
            Console.WriteLine($"ID: {funcionario.Id}");
            Console.WriteLine($"Nombre: {funcionario.Nome}");
            Console.WriteLine($"Apellido: {funcionario.Sobrenome}");
            Console.WriteLine($"Cpf: {funcionario.Cpf}");
            Console.WriteLine($"Fecha de Nacimiento: {funcionario.DataNasc}");
            Console.WriteLine();
        }
    }
    else
    {
        Console.WriteLine("No se encontraron funcionarios en la base de datos.");
    }


        }
        

        
    }

}