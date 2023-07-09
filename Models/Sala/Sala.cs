using reserva_salas_csharp.Repository;

namespace reserva_salas_csharp.Models 
{

    public class Sala
    {
        public int id { get; set; }
        public int numeroSala { get; set; }
        public int numeroAndar { get; set; }
    
        public Sala() {}

        public Sala(int numeroSala, int numeroAndar)
        {
            this.numeroSala = numeroSala;
            this.numeroAndar = numeroAndar;

            Database db = new Database();
            db.Salas.Add(this);
            db.SaveChanges();

            SalaHasTurno salaHasTurnoManha = new SalaHasTurno(this.id, 1);
            SalaHasTurno salaHasTurnoTarde = new SalaHasTurno(this.id, 2);
            SalaHasTurno salaHasTurnoNoite = new SalaHasTurno(this.id, 3);

            db.SalaHasTurnos.Add(salaHasTurnoManha);
            db.SalaHasTurnos.Add(salaHasTurnoTarde);
            db.SalaHasTurnos.Add(salaHasTurnoNoite);

            db.SaveChanges();
        }


        public static void AlterarSala(int id, int numeroSala, int numeroAndar){
            Database db = new Database();
            Sala sala = db.Salas.Find(id);
            sala.numeroSala = numeroSala;
            sala.numeroAndar = numeroAndar;
            db.Salas.Update(sala);
            db.SaveChanges();
        }

        public static void ExcluirSala(int id){
            Database db = new Database();
            Sala sala = db.Salas.Find(id);
            db.Salas.Remove(sala);
            db.SaveChanges();
        }
        public static Sala GetSalas(int id){
            Database db = new Database();
            return db.Salas.Find(id);
        }
        public static List<Sala> GetAllSalas()
        {
            Database db = new Database();
            List<Sala> salas = db.Salas.ToList();
            return salas;
        }   
    }
}