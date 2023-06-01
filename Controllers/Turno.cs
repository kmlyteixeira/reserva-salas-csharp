using System;
using Models;

namespace Controllers
{

    public class Turno
    {
        // FAZER AS VALIDAÇÕES, PODE SER ANTES OU DEPOIS VER A MELHOR FORMA
        public static Models.Turno CadastrarTurno(string descricao)
        {
            if(String.IsNullOrEmpty(descricao))
                throw new Exception("A descrição do turno é obrigatório");
            Models.Turno turno = new Models.Turno(descricao);
            return turno;
        }

        // FAZER AS VALIDAÇÕES, PODE SER ANTES OU DEPOIS VER A MELHOR FORMA
        public static void Alterarturno(int id, string descricao)
        {   
            Models.Turno turno = Controllers.Turno.GetTurnos(id);
           {
                if(String.IsNullOrEmpty(descricao))
                    throw new Exception("A descrição do turno é obrigatório");
           }
            Models.Turno.AlterarTurno(id, descricao);
        }

        // FAZER AS VALIDAÇÕES, PODE SER ANTES OU DEPOIS VER A MELHOR FORMA
        public static void ExcluirTurno(string id){
            Models.Turno.ExcluirTurno(int.Parse(id));
        }

        public static  Models.Turno GetTurnos(int id){
            return Models.Turno.GetTurnos(id);
        }

        public static List<Models.Turno> GetAllTurnos(){
            return Models.Turno.GetAllTurnos();
        }
    }

}