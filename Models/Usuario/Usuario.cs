using reserva_salas_csharp.Repository;

namespace reserva_salas_csharp.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string CPF { get; set; }
        public string DataNascimento { get; set; }
        public int TipoUsuarioId { get; set; }
        public TipoUsuario TipoUsuario { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Senha { get; set; }

        public Usuario() { }

        public Usuario(string nome, string sobrenome, string cpf, string dataNascimento, int tipoUsuarioId, string Email, string userName, string senha)
        {
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.CPF = cpf;
            this.DataNascimento = dataNascimento;
            this.TipoUsuarioId = tipoUsuarioId;
            this.Email = Email;
            this.UserName = userName;
            this.Senha = senha;

            Database db = new Database();
            db.Usuarios.Add(this);
            db.SaveChanges();
        }

        public static Usuario GetUsuarioById(int id)
        {
            Database db = new Database();
            return (from u in db.Usuarios where u.Id == id select u).FirstOrDefault();
        }

        public static Usuario GetUsuarioByUserName(string userName)
        {
            Database db = new Database();
            return (from u in db.Usuarios where u.UserName == userName select u).First();
        }

        public static IEnumerable<Usuario> GetUsuarios()
        {
            Database db = new Database();
            return from user in db.Usuarios select user;
        }

        public static void DeleteUsuario(int id)
        {
            Database db = new Database();
            db.Usuarios.Remove(GetUsuarioById(id));
            db.SaveChanges();
        }

        public static Usuario UpdateUsuario(int id, string nome, string sobrenome, string cpf, string dataNascimento, TipoUsuario tipoUsuario)
        {
            Database db = new Database();
            Usuario usuario = GetUsuarioById(id);
            usuario.Nome = nome;
            usuario.Sobrenome = sobrenome;
            usuario.CPF = cpf;
            usuario.DataNascimento = dataNascimento;
            usuario.TipoUsuario = tipoUsuario;
            db.Usuarios.Update(usuario);
            db.SaveChanges();

            return usuario;
        }

        public static Usuario UpdateSenha(Usuario usuario, string senha)
        {
            Database db = new Database();
            usuario.Senha = senha;
            db.Usuarios.Update(usuario);
            db.SaveChanges();

            return usuario;
        }
        
    }
}