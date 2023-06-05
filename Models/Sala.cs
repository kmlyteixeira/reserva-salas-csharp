using reserva_salas_csharp.Repository;

namespace Models 
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
        }


        public static void AlterarSala(int id, int numeroSala, int numeroAndar){
            Database db = new Database();
            Sala sala = db.Salas.Find(id);
            sala.numeroSala = numeroSala;
            sala.numeroAndar = numeroAndar;
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