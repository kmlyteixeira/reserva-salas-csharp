using System;
using Microsoft.EntityFrameworkCore;
using reserva_salas_csharp.Repository;

namespace reserva_salas_csharp.Models
{


    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Cpf { get; set; }
        public string DataNasc { get; set; }


        public Funcionario() { }

        public Funcionario(string nome, string sobrenome, string cpf, string dataNasc)
        {
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.Cpf = cpf;
            this.DataNasc = dataNasc;

            Database context = new Database();
            context.funcionario.Add(this);
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

        public static Funcionario GetByIdfunc(int id)
        {
            Database db = new Database();
            return (from f in db.funcionario where f.Id == id select f).First();
        }

        public static IEnumerable<Funcionario> GetAllFuncionario()
        {
            Database db = new Database();
            return from fucionarios in db.funcionario select fucionarios;
        }
    }
}