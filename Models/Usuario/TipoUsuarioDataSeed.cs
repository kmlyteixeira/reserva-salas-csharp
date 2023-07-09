namespace reserva_salas_csharp.Models
{
    public class TipoUsuarioDataSeed
    {
        public static readonly TipoUsuario[] TiposUsuario =
        { 
            new TipoUsuario { Tipo = 1, Descricao = "Administrador"},
            new TipoUsuario { Tipo = 2, Descricao = "Comum"}
        };
    }
}