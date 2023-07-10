using System;
using reserva_salas_csharp.Repository;
using Microsoft.EntityFrameworkCore;

namespace reserva_salas_csharp.Models
{
    public class Higienizacao
    {
        public int Id { get; set; }
        public string Observacao { get; set; }
        public DateTime Data { get; set; }
        public int idSala { get; set; }
        //public virtual Sala sala { get; set; }
        public int idFuncionario { get; set; }
        //public virtual Funcionario funcionario { get; set; }
        public int idTurno { get; set; }
        //public virtual Turno turno { get; set; }
        public bool Ativo { get; set; } = true;

        public Higienizacao() { }

        public Higienizacao(Sala sala, Turno turno, Funcionario funcionario, string observacao, DateTime data)
        {
            this.idSala = sala.id;
            this.idTurno = turno.id;
            this.idFuncionario = funcionario.Id;
            this.Observacao = observacao;
            this.Data = data;

            Database db = new Database();
            db.Higienizacao.Add(this);
            db.SaveChanges();
        }

        public static void alterarHigienizacao(int id, Dictionary<string, string> novosCampos)
        {
            using var context = new Database();
            var higienizacao = context.Higienizacao.Find(id);

            if (higienizacao != null)
            {
                foreach (var campo in novosCampos)
                {
                    var propertyInfo = higienizacao.GetType().GetProperty(campo.Key);
                    if (propertyInfo != null && campo.Value != "")
                    {
                        propertyInfo.SetValue(higienizacao, campo.Value);
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
                Console.WriteLine("Higienização não encontrada.");
            }
        }

        public static void excluirHigienizacao(int id)
        {
            using var context = new Database();
            var higienizacao = context.Higienizacao.Find(id);

            if (higienizacao != null)
            {
                context.Higienizacao.Remove(higienizacao);
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Higienização não encontrada.");
            }
        }

        public static void GetByIdHigi(int id)
        {
            using var context = new Database();
            var higienizacao = context.Higienizacao.Find(id);

            if (higienizacao != null)
            {
                Console.WriteLine("Datos da higienização:");
                Console.WriteLine($"ID: {higienizacao.Id}");
                Console.WriteLine($"Id_sala: {higienizacao.idSala}");
                Console.WriteLine($"id_func: {higienizacao.idFuncionario}");
                Console.WriteLine($"Observação: {higienizacao.Observacao}");

            }
            else
            {
                Console.WriteLine("Higienização não encontrada.");
            }
        }

        public static IEnumerable<Higienizacao> GetAllHigienizacoes()
        {
            Database db = new Database();
            return from h in db.Higienizacao
                select h;
        }

        public static void InativarHigienizacao(int id)
        {
            Database context = new Database();
            Higienizacao higienizacao = context.Higienizacao.Find(id);
            higienizacao.Ativo = false;
            context.SaveChanges();
        }
    }
}