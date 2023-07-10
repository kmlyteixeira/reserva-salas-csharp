using reserva_salas_csharp.Models;
using reserva_salas_csharp.Repository;

namespace reserva_salas_csharp.Controllers
{
    public class Higienizacao
    {
        public static void CriarHigienizazao(string salaId, string turnoId, string funcionarioId, string observacao, string data)
        {
            var sala = Models.Sala.GetSalas(int.Parse(salaId));
            var turno = Models.Turno.GetTurnos(int.Parse(turnoId));
            var funcionario = Models.Funcionario.GetByIdfunc(int.Parse(funcionarioId));

            new Models.Higienizacao(sala, turno, funcionario, observacao, DateTime.Parse(data));
        }

        public static void alterarHigienizacao(int id, string observacao, string idhorario, string idSala, string idUsusario, string idFunc)
        {
            var camposParaAtualizar = new Dictionary<string, string>
            {
                { "Observacao", observacao },
                { "Idhorario", idhorario },
                { "IdSala", idSala },
                { "IdUsusario", idUsusario },
                { "IdFunc", idFunc }
            };

            Models.Higienizacao.alterarHigienizacao(id, camposParaAtualizar);
        }

        public static void excluirHigienizacao(int id)
        {
            Models.Higienizacao.excluirHigienizacao(id);
        }

        public static void mostrarHigien(int id)
        {
            Models.Higienizacao.GetByIdHigi(id);
        }

        public static void mostrarAllHigien()
        {
            Models.Higienizacao.GetAllHigienizacoes();
        }

        public static Models.Higienizacao GetHigienizacoesBySalaTurnoData(string salaId, string turnoId, DateTime data)
        {
            return Models.Higienizacao.GetAllHigienizacoes()
                .Where(a => a.idSala == int.Parse(salaId) && a.idTurno == int.Parse(turnoId) && a.Data.Date == data.Date && a.Ativo == true)
                .FirstOrDefault();
        }

        public static void InativarHigienizacao(int salaId, int turnoId, DateTime data)
        {
            var higienizacao = Models.Higienizacao.GetAllHigienizacoes()
                .Where(a => a.idSala == salaId && a.idTurno == turnoId && a.Data.Date == data.Date && a.Ativo == true)
                .FirstOrDefault();

            Models.Higienizacao.InativarHigienizacao(higienizacao.Id);
        }
    }
}