namespace reserva_salas_csharp.Models
{
    public class TurnoDataSeed
    {
        public static readonly Turno[] Turnos =
        {
            new Turno( descricao: "Manhã"),
            new Turno( descricao: "Tarde"),
            new Turno( descricao: "Noite")
        };
    }
}