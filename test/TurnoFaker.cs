namespace reserva_salas_csharp.test
{
    public class TurnoFaker
    {
        public static Models.Turno GenerateFakeTurno()
        {
            var faker = new Bogus.Faker();

            string descricao = faker.Name.FirstName();

            return new Models.Turno(descricao);
        }
    }
}