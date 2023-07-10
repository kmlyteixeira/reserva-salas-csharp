namespace reserva_salas_csharp.Controllers
{
    public class Agendamento
    {
        public static Models.Agendamento CadastrarAgendamento(string observacao, string data, string usuarioId, string salaId, string turnoId)
        {
            var salaHasTurno = Models.SalaHasTurno.GetSalaHasTurnos(int.Parse(salaId)).Where(sht => sht.TurnoId == int.Parse(turnoId)).FirstOrDefault();
            Models.Agendamento agendamento = new Models.Agendamento(observacao, DateTime.Parse(data), int.Parse(usuarioId), salaHasTurno);
            return agendamento;
        }

        public static Models.Agendamento AlterarAgendamento(string id, string observacao, string usuarioId, string salaHasTurnoId)
        {
            Models.Agendamento agendamento = Models.Agendamento.GetAgendamentoById(int.Parse(id));
            Models.Agendamento.AlterarAgendamento(int.Parse(id), observacao, int.Parse(usuarioId), int.Parse(salaHasTurnoId));
            return agendamento;
        }

        public static void DeletarAgendamento(string id)
        {
            Models.Agendamento.DeleteAgendamento(int.Parse(id));
        }

        public static Models.Agendamento GetAgendamento(string id)
        {
            return Models.Agendamento.GetAgendamentoById(int.Parse(id));
        }

        public static IEnumerable<Models.Agendamento> GetAllAgendamentos()
        {
            return Models.Agendamento.GetAllAgendamentos();
        }

        public static IEnumerable<Models.Agendamento> GetAgendamentosByUsuario(string usuarioId)
        {
            return Models.Agendamento.GetAllAgendamentos().Where(a => a.UsuarioId == int.Parse(usuarioId));
        }

        public static IEnumerable<Models.Agendamento> GetAgendamentosBySalaData(string salaId, DateTime data)
        {
            return Models.Agendamento.GetAllAgendamentos()
                .Where(a => a.SalaHasTurno.SalaId == int.Parse(salaId) && a.Data == data);
        }

        public static Models.Agendamento GetAgendamentosBySalaTurnoData(string salaId, string turnoId, DateTime data)
        {
            return Models.Agendamento.GetAllAgendamentos()
                .Where(a => a.SalaHasTurno.SalaId == int.Parse(salaId) && a.SalaHasTurno.TurnoId == int.Parse(turnoId) && a.Data.Date == data.Date && a.Ativo == true)
                .FirstOrDefault();
        }

        public static void InativarAgendamento(int salaId, int turnoId, DateTime data)
        {
            var agendamento = Models.Agendamento.GetAllAgendamentos()
                .Where(a => a.SalaHasTurno.SalaId == salaId && a.SalaHasTurno.TurnoId == turnoId && a.Data.Date == data.Date && a.Ativo == true)
                .FirstOrDefault();

            Models.Agendamento.InativarAgendamento(agendamento.Id);
        }

        public static IEnumerable<Models.Agendamento> GetRelatorioAgendamentos()
        {
            return Models.Agendamento.GetRelatorioAgendamentos();
        }
    }
}