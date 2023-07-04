using Microsoft.EntityFrameworkCore;
using reserva_salas_csharp.Repository;

namespace reserva_salas_csharp.Models
{
    public class Agendamento
    {
        public int Id { get; set; }
        public string Observacao { get; set; }
        public DateTime Data { get; set; }
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public int SalaHasTurnoId { get; set; }
        public virtual SalaHasTurno SalaHasTurno { get; set; }

        public Agendamento() { }

        public Agendamento(string observacao, DateTime date, int usuarioId, SalaHasTurno salaHasTurno)
        {
            this.Observacao = observacao;
            this.Data = date;
            this.UsuarioId = usuarioId;
            this.SalaHasTurnoId = salaHasTurno.Id;

            Database db = new Database();
            db.Agendamentos.Add(this);
            db.SaveChanges();
            
            this.SalaHasTurno = salaHasTurno;
        }

        public static Agendamento GetAgendamentoById(int id)
        {
            Database db = new Database();
            return (from a in db.Agendamentos where a.Id == id select a).First();
        }

        public static IEnumerable<Agendamento> GetAllAgendamentos()
        {
            Database db = new Database();
            return from agendamento in db.Agendamentos.Include(a => a.SalaHasTurno) select agendamento;
        }

        public static void DeleteAgendamento(int id)
        {
            Database db = new Database();
            db.Agendamentos.Remove(GetAgendamentoById(id));
            db.SaveChanges();
        }

        public static void AlterarAgendamento(int id, string observacao, int usuarioId, int salaHasTurnoId)
        {
            Database db = new Database();
            Agendamento agendamento = db.Agendamentos.Find(id);
            agendamento.Observacao = observacao;
            agendamento.UsuarioId = usuarioId;
            agendamento.SalaHasTurnoId = salaHasTurnoId;
            db.Agendamentos.Update(agendamento);
            db.SaveChanges();
        }
    }
}