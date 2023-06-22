namespace reserva_salas_csharp.Controllers
{
    public class Agendamento
    {
        public static Models.Agendamento CadastrarAgendamento(string observacao, string data, string usuarioId, string salaHasTurnoId)
        {
            Models.Agendamento agendamento = new Models.Agendamento(observacao, DateTime.Parse(data), int.Parse(usuarioId), int.Parse(salaHasTurnoId));
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

        public static IEnumerable<Models.Agendamento> GetAgendamentosBySalaData(string salaId, string data)
        {
            return Models.Agendamento.GetAllAgendamentos()
                .Where(a => a.SalaHasTurno.SalaId == int.Parse(salaId) && a.Data == DateTime.Parse(data));
        }
    }
}