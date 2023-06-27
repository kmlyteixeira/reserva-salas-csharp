using Newtonsoft.Json;

namespace reserva_salas_csharp.Models 
{
    public class CalendarData
    {
        public int Id { get; set; }
        public int Mes { get; set; }
        public int Domingo { get; set; }
        public int Segunda { get; set; }
        public int Terca { get; set; }
        public int Quarta { get; set; }
        public int Quinta { get; set; }
        public int Sexta { get; set; }
        public int Sabado { get; set; }
    }
}