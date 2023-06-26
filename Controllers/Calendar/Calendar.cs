using Newtonsoft.Json;

namespace reserva_salas_csharp.Controllers
{
    public class Calendar
    {
        public static List<Models.CalendarData> GetCalendarData(int mes)
        {
            string json = File.ReadAllText("Controllers/Calendar/calendar.json");

            List<Models.CalendarData> calendarDataList = JsonConvert.DeserializeObject<List<Models.CalendarData>>(json);

            List<Models.CalendarData> filteredData = calendarDataList.Where(d => d.Mes == mes).ToList();

            return filteredData;
        }

    }
}