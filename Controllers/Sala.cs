using System;
using Models;




namespace Controllers
{

    public class Sala {

         // FAZER AS VALIDAÇÕES, PODE SER ANTES OU DEPOIS VER A MELHOR FORMA
        public static Models.Sala CadastrarSala(string numeroSala, string numeroAndar){
            Models.Sala sala = new Models.Sala(int.Parse(numeroSala), int.Parse(numeroAndar));
            return sala;

        }

         // FAZER AS VALIDAÇÕES, PODE SER ANTES OU DEPOIS VER A MELHOR FORMA

        public static void AlterarSala(string id, string numeroSala, string numeroAndar){
            Models.Sala.AlterarSala(int.Parse(id), int.Parse(numeroSala), int.Parse(numeroAndar));
        }

         // FAZER AS VALIDAÇÕES, PODE SER ANTES OU DEPOIS VER A MELHOR FORMA
        public static void ExcluirSala(string id){
            Models.Sala.ExcluirSala(int.Parse(id));
        }

        public static List<Models.Sala> GetSalas(string id){
            return Models.Sala.GetSalas(int.Parse(id));
        }

        public static List<Models.Sala> GetAllSalas(){
            return Models.Sala.GetAllSalas();
        }
    }
}