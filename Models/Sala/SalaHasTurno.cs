using reserva_salas_csharp.Repository;

namespace reserva_salas_csharp.Models
{
    public class SalaHasTurno
    {
        public int Id { get; set; }
        public int SalaId { get; set; }
        public virtual Sala Sala { get; set; }
        public int TurnoId { get; set; }
        public virtual Turno Turno { get; set; }

        public SalaHasTurno() {}

        public SalaHasTurno(int salaId, int turnoId)
        {
            this.SalaId = salaId;
            this.TurnoId = turnoId;
        }

        public void ExcluirTurno()
        {
            Database db = new Database();
            db.SalaHasTurnos.Remove(this);
            db.SaveChanges();
        }

        public static List<SalaHasTurno> GetSalaHasTurnos(int salaId)
        {
            Database db = new Database();
            List<SalaHasTurno> salaHasTurnos = db.SalaHasTurnos.Where(s => s.SalaId == salaId).ToList();
            return salaHasTurnos;
        }

        public static List<SalaHasTurno> GetAllSalaHasTurnos()
        {
            Database db = new Database();
            List<SalaHasTurno> salaHasTurnos = db.SalaHasTurnos.ToList();
            return salaHasTurnos;
        }

        public static void AlterarTurno(int id, int salaId, int turnoId)
        {
            Database db = new Database();
            SalaHasTurno salaHasTurno = db.SalaHasTurnos.Find(id);
            salaHasTurno.SalaId = salaId;
            salaHasTurno.TurnoId = turnoId;
            db.SalaHasTurnos.Update(salaHasTurno);
            db.SaveChanges();
        }

        public static Models.SalaHasTurno GetSalaHasTurnoById(int id)
        {
            Database db = new Database();
            return (from sht in db.SalaHasTurnos where sht.Id == id select sht).First();
        }
    }
}