namespace reserva_salas_csharp.test
{
    public class UsuarioFaker
    {
        public static Models.Usuario GenerateFakeUsuario()
        {
            var faker = new Bogus.Faker();

            string nome = faker.Name.FirstName();
            string sobrenome = faker.Name.LastName();
            string cpf = faker.Random.Replace("###.###.###-##");
            string dataNascimento = faker.Date.Past(30).ToString("dd/MM/yyyy");
            Models.TipoUsuario tipoUsuario = Models.TipoUsuario.GetTipoUsuarioById(1);
            string email = faker.Internet.Email(nome, sobrenome);
            string userName = nome + "22" + sobrenome;
            string senha = faker.Random.Replace("AAAAA###");

            return new Models.Usuario(nome, sobrenome, cpf, dataNascimento, tipoUsuario.Id, email, userName, senha);
        }
    }
}


