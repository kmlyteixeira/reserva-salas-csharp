using System.Text.RegularExpressions;

namespace reserva_salas_csharp.Controllers
{
    public class UsuarioValidations
    {
        public static void ValidaAtributos(string cpf, string dataNascimento, string nome, string sobrenome)
        {
            UsuarioValidations.IsValidRegex(UsuarioAtributosEnum.CPF, cpf);
            UsuarioValidations.IsValidRegex(UsuarioAtributosEnum.DataNascimento, dataNascimento);
            UsuarioValidations.IsValidRegex(UsuarioAtributosEnum.UserName, nome);
            UsuarioValidations.IsValidRegex(UsuarioAtributosEnum.Senha, sobrenome);
        }
        public static void IsValidRegex(UsuarioAtributosEnum usuarioEnum, string value)
        {
            switch (usuarioEnum)
            {
                case UsuarioAtributosEnum.CPF:
                    if (!Regex.IsMatch(value, @"^\d{3}\.\d{3}\.\d{3}\-\d{2}$")) throw new System.Exception("O campo CPF é inválido");
                    break;
                case UsuarioAtributosEnum.DataNascimento:
                    if (!Regex.IsMatch(value, @"^\d{2}\/\d{2}\/\d{4}$")) throw new System.Exception("O campo Data de Nascimento é inválido");
                    break;
                case UsuarioAtributosEnum.UserName:
                    if (!Regex.IsMatch(value, @"^[a-zA-Z0-9]+$")) throw new System.Exception("O campo Username é inválido");
                    break;
                case UsuarioAtributosEnum.Senha:
                    if (!Regex.IsMatch(value, @"^[a-zA-Z0-9]+$")) throw new System.Exception("O campo Senha é inválido");
                    break;
            }
        }
    }
}