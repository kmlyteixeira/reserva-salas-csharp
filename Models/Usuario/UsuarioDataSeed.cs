namespace reserva_salas_csharp.Models
{
    public class UsuarioDataSeed
    {
        private static readonly string senha = "senha";
        private static readonly string hashSenha = Controllers.Usuario.GenerateHashCode(Controllers.Usuario.StringToInt(senha)).ToString();

        public static readonly Usuario[] Usuarios =
        {
            new Usuario{ 
                Nome = "admin", 
                Sobrenome = "admin", 
                CPF = "123.123.123-99", 
                DataNascimento = "17/09/2000",
                TipoUsuarioId = 1, 
                Email = "admin@admin", 
                UserName = "admin", 
                Senha = hashSenha
            },
            new Usuario{ 
                Nome = "user", 
                Sobrenome = "user", 
                CPF = "123.123.123-99", 
                DataNascimento = "17/09/2000",
                TipoUsuarioId = 2, 
                Email = "user@user", 
                UserName = "user", 
                Senha = hashSenha
            }
        };
    }
}