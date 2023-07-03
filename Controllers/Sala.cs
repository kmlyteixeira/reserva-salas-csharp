using System;
using reserva_salas_csharp.Models;

namespace reserva_salas_csharp.Controllers
{
    public class Sala {

        public static Models.Sala CadastrarSala(
            string numeroSala, 
            string numeroAndar
        )
        {
            if(String.IsNullOrEmpty(numeroSala))
                throw new Exception("O número da sala é obrigatório");

            if(String.IsNullOrEmpty(numeroAndar))
                throw new Exception("O número do andar é obrigatório");

            Models.Sala sala = new Models.Sala(int.Parse(numeroSala), int.Parse(numeroAndar));
            return sala;

        }

         // FAZER AS VALIDAÇÕES, PODE SER ANTES OU DEPOIS VER A MELHOR FORMA

        public static void AlterarSala(int id, string numeroSala, string numeroAndar)
        {
            Models.Sala.GetSalas(id);
            {
                if(String.IsNullOrEmpty(numeroSala))
                    throw new Exception("O número da sala é obrigatório");

                if(String.IsNullOrEmpty(numeroAndar))
                    throw new Exception("Para editar o número do andar é obrigatório");
            }
            Models.Sala.AlterarSala(id, int.Parse(numeroSala), int.Parse(numeroAndar));
        }

         // FAZER AS VALIDAÇÕES, PODE SER ANTES OU DEPOIS VER A MELHOR FORMA
        public static void ExcluirSala(string id)
        {
            
            Models.Sala.ExcluirSala(int.Parse(id));
        }

        public static Models.Sala GetSalas(int id){
            return Models.Sala.GetSalas(id);
        }

        public static List<Models.Sala> GetAllSalas(){
            return Models.Sala.GetAllSalas();
        }
    }
}