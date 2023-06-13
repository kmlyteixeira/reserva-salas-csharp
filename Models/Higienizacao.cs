using System;
using reserva_salas_csharp.Repository;
using Microsoft.EntityFrameworkCore;

namespace reserva_salas_csharp.Models {

    public class Higienizacao {

        public int Id { get; set; }
        public string Observacao { get; set; }
       
        public int idSala { get; set; }
        public virtual Sala sala { get; set; }
    
        public int idFuncionario { get; set; }
        public virtual Funcionario funcionario { get; set; }

        public int idUsusario { get; set; }
        public virtual Usuario usuario { get; set; }
   

         public Higienizacao() {
            
        }


        public Higienizacao(Sala Salaid, Funcionario Funcionarioid,Usuario Usuarioid, string observacao) {
           this.Id = Id;
           this.idSala = Salaid.id;
           this.idFuncionario = Funcionarioid.Id;
           this.idUsusario = Usuarioid.Id;
           this.Observacao = observacao;
   
        }


        public void cadastrarHigienizacao(int id_sala,int id_funcionario, string observacao)
        {
                using var context = new Database();
                var hizienizacao = new Higienizacao { idSala = id_sala, idFuncionario = id_funcionario , Observacao = observacao};
                context.Higienizacao.Add(hizienizacao);
                context.SaveChanges();
        }



        public static void alterarHigienizacao(int id, int salaId,int  funcId, int userId)
{
            using var context = new Database();
            var higienizacao = context.Higienizacao.Find(id);

            if (higienizacao != null)
            {
                  Database db = new Database();
                  Usuario usuario = GetUsuarioById(id);
                  usuario.Nome = nome;
                  usuario.Sobrenome = sobrenome;
                  usuario.CPF = cpf;
                  usuario.DataNascimento = dataNascimento;
                  usuario.TipoUsuario = tipoUsuario;
                  db.SaveChanges();
            }
            else
            {
                Console.WriteLine("Higienização no encontrada.");
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
                Console.WriteLine("Higienização no encontrada.");
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
                Console.WriteLine("Higienização no encontrada.");
            }
        }

        
       

        public static void GetAllHigienizacao()
        {
        

    using var context = new Database();
    var higienizacoes = context.Higienizacao.ToList();

    if (higienizacoes.Count > 0)
    {
        Console.WriteLine("Lista de higienizações:");
        foreach (var higienizacao in higienizacoes)
        {
             Console.WriteLine("Datos da higienização:");
             Console.WriteLine($"ID: {higienizacao.Id}");
             Console.WriteLine($"Id_sala: {higienizacao.idSala}");
             Console.WriteLine($"id_func: {higienizacao.idFuncionario}");
             Console.WriteLine($"Observação: {higienizacao.Observacao}");
            
        }
    }
    else
    {
        Console.WriteLine("No se encontraram higienizações.");
    }


        }

    }


}