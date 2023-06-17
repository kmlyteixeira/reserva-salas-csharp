using reserva_salas_csharp.Repository;

namespace reserva_salas_csharp.Models
{
    public enum UserType
    {
        Admin,
        User
    }

    public class TipoUsuario
    {
        public int Id { get; set; }
        public UserType Tipo { get; set; }
        public string Descricao { get; set; }

        public TipoUsuario() { }

        public TipoUsuario(UserType tipo, string descricao)
        {
            this.Tipo = tipo;
            this.Descricao = descricao;

            Database db = new Database();
            db.TiposUsuario.Add(this);
            db.SaveChanges();
        }

        public static TipoUsuario GetTipoUsuarioById(int id)
        {
            Database db = new Database();
            return db.TiposUsuario.Find(id);
        }

        public static IEnumerable<TipoUsuario> GetTiposUsuario()
        {
            Database db = new Database();
            return db.TiposUsuario.ToList();
        }
    }
}