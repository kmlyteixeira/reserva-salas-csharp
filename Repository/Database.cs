using Microsoft.EntityFrameworkCore;
using reserva_salas_csharp.Models;

namespace reserva_salas_csharp.Repository
{
    public class Database : DbContext
    {
        public Database(){}
        public Database(DbContextOptions<Database> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<TipoUsuario> TiposUsuario { get; set; }
        public DbSet<Models.Funcionario> funcionario { get; set; }
        public DbSet<Models.Sala> Salas { get; set; }
        public DbSet<Models.Turno> Turnos { get; set; }
        
        private IConfiguration Configuration { get; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=localhost;Database=dbReservaSalas;Uid=root;";
            ServerVersion version = ServerVersion.AutoDetect(connectionString);

            optionsBuilder.UseMySql(connectionString, version);
        }
    }
}