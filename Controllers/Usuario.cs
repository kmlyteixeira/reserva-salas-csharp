using System.Collections.Generic;

namespace reserva_salas_csharp.Controllers
{
    public class Usuario
    {
        public static Models.Usuario CadastrarUsuario(string nome, string sobrenome, string cpf, string dataNascimento, Models.TipoUsuario tipoUsuario, string userName, string senha)
        {
            UsuarioValidations.ValidaAtributos(cpf, dataNascimento, nome, sobrenome);
            Models.Usuario usuario = new Models.Usuario(nome, sobrenome, cpf, dataNascimento, tipoUsuario, userName, senha);
            return usuario;
        }

        public static Models.Usuario AlterarUsuario(string id, string nome, string sobrenome, string cpf, string dataNascimento, Models.TipoUsuario tipoUsuario)
        {
            UsuarioValidations.ValidaAtributos(cpf, dataNascimento, nome, sobrenome);
            Models.Usuario usuario = Models.Usuario.UpdateUsuario(int.Parse(id), nome, sobrenome, cpf, dataNascimento, tipoUsuario);
            return usuario;
        }

        public static void DeletarUsuario(string id)
        {
            Models.Usuario.DeleteUsuario(int.Parse(id));
        }

        public static Models.Usuario GetUsuario(string id)
        {
            return Models.Usuario.GetUsuarioById(int.Parse(id));
        }

        public static IEnumerable<Models.Usuario> GetAllUsuarios()
        {
            return Models.Usuario.GetUsuarios();
        }
    }
}