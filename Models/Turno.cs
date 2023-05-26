using reserva_salas_csharp.Repository;

namespace Models
{
    public class Turno{

        public int id { get; set; }
        public string descricao { get; set;}

        public Turno() {}

        public Turno(string descricao)
        {
            this.descricao = descricao;

            Database db = new Database();
            db.Turnos.Add(this);
            db.SaveChanges();
        }

        public static void AlterarTurno(int id, string descricao){
            Database db = new Database();
            Turno turno = db.Turnos.Find(id);
            turno.descricao = descricao;
            db.SaveChanges();
        }
        
        public static void ExcluirTurno(int id){
            Database db = new Database();
            Turno turno = db.Turnos.Find(id);
            db.Turnos.Remove(turno);
            db.SaveChanges();
        }
        public static List<Turno> GetTurnos(int id){
            Database db = new Database();
            List<Turno> turnos = db.Turnos.ToList();
            return turnos;
        }
        public static List<Turno> GetAllTurnos()
        {
            Database db = new Database();
            List<Turno> turnos = db.Turnos.ToList();
            return turnos;
        }
    }   
}