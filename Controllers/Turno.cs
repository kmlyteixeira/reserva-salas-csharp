using System;
using Models;

namespace Controllers
{

    public class Turno
    {
        // FAZER AS VALIDAÇÕES, PODE SER ANTES OU DEPOIS VER A MELHOR FORMA
        public static Models.Turno CadastrarTurno(string descricao)
        {
            Models.Turno turno = new Models.Turno(descricao);
            return turno;
        }

        // FAZER AS VALIDAÇÕES, PODE SER ANTES OU DEPOIS VER A MELHOR FORMA
        public static void Alterarturno(string id, string descricao){
            Models.Turno.AlterarTurno(int.Parse(id), descricao);
        }

        // FAZER AS VALIDAÇÕES, PODE SER ANTES OU DEPOIS VER A MELHOR FORMA
        public static void ExcluirTurno(string id){
            Models.Turno.ExcluirTurno(int.Parse(id));
        }

        public static List<Models.Turno> GetTurnos(string id){
            return Models.Turno.GetTurnos(int.Parse(id));
        }

        public static List<Models.Turno> GetAllTurnos(){
            return Models.Turno.GetAllTurnos();
        }
    }

}