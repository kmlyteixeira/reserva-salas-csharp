using System.Security.Cryptography;
using System.Text;

namespace reserva_salas_csharp.Controllers
{
    public class Usuario
    {
        public static Models.Usuario CadastrarUsuario(string nome, string sobrenome, string cpf, string dataNascimento, Models.TipoUsuario tipoUsuario, string email, string userName, string senha)
        {
            UsuarioValidations.ValidaAtributos(cpf, dataNascimento, nome, sobrenome);
            string hashSenha = GenerateHashCode(senha.GetHashCode()).ToString();
            Models.Usuario usuario = new Models.Usuario(nome, sobrenome, cpf, dataNascimento, tipoUsuario, email, userName, hashSenha);
            return usuario;
        }

        public static Models.Usuario AlterarUsuario(string id, string nome, string sobrenome, string cpf, string dataNascimento, Models.TipoUsuario tipoUsuario)
        {
            UsuarioValidations.ValidaAtributos(cpf, dataNascimento, nome, sobrenome);
            Models.Usuario usuario = Models.Usuario.UpdateUsuario(int.Parse(id), nome, sobrenome, cpf, dataNascimento, tipoUsuario);
            return usuario;
        }

        public static Models.Usuario AlterarSenha(string id, string senha)
        {
            string hashSenha = GenerateHashCode(senha.GetHashCode()).ToString();
            return Models.Usuario.UpdateSenha(int.Parse(id), hashSenha);;
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

        public static int GenerateHashCode(int hashValue)
        {
            unchecked // desabilita checagem de overflow de inteiros
            {
                int hash = (int)2166136261; // numero primo arbitrario para iniciar o hash
                hash = (hash * 16777619) ^ hashValue; // heuristica de Bob Jenskins para gerar hash
                return hash;
            }
        }

        public static byte[] Encrypt(string data, byte[] key) // AES Algorithm
        {
            byte[] dataBytes = Encoding.UTF8.GetBytes(data);

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(data);
                        }
                        return msEncrypt.ToArray();
                    }
                }
            }
        }

        public static void Login (string userName, string senha)
        {
            string hashSenha = GenerateHashCode(senha.GetHashCode()).ToString();
            
            Models.Usuario usuario = Models.Usuario.GetUsuarioByUserName(userName);
            if (usuario == null)
                throw new Exception("Usuário não encontrado");
            
            if (usuario.Senha != hashSenha)
                throw new Exception("Senha incorreta");
        }

        public static void ResetSenha (string userName)
        {
            Models.Usuario usuario = Models.Usuario.GetUsuarioByUserName(userName);
            if (usuario == null)
                throw new Exception("Usuário não encontrado");
            
            Random random = new Random();
            string novaSenha = GenerateHashCode(random.Next(10000000, 1000000000)).ToString();
            string hashSenha = GenerateHashCode(novaSenha.GetHashCode()).ToString();
            Models.Usuario.UpdateSenha(usuario.Id, hashSenha);
            Email.EnviarEmail(usuario.Email, "Reset de senha", $"Sua nova senha é: {novaSenha}");
        }
    }
}