namespace reserva_salas_csharp.Models
{
    public class SalaDataSeed
    {
        public static readonly Sala[] Salas =
        {
            new Sala( numeroSala: 101, numeroAndar: 1),
            new Sala( numeroSala: 106, numeroAndar: 1),
            new Sala( numeroSala: 206, numeroAndar: 2),
            new Sala( numeroSala: 207, numeroAndar: 2),
            new Sala( numeroSala: 304, numeroAndar: 3),
            new Sala( numeroSala: 305, numeroAndar: 3)
        };
    }
}