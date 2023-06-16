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
    }
}