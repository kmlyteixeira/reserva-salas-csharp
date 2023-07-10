using Microsoft.EntityFrameworkCore.Migrations;
using reserva_salas_csharp.Models;

#nullable disable

namespace reservasalascsharp.Migrations
{
    /// <inheritdoc />
    public partial class adddataseed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            foreach (var turno in TurnoDataSeed.Turnos)
            {
                migrationBuilder.InsertData(
                    table: "Turnos",
                    columns: new[] { "descricao" },
                    values: new object[] { turno.descricao });
            }
            
            foreach (var sala in SalaDataSeed.Salas)
            {
                migrationBuilder.InsertData(
                    table: "Salas",
                    columns: new[] { "numeroSala", "numeroAndar" },
                    values: new object[] { sala.numeroSala, sala.numeroAndar });
            }

            foreach (var tipo in TipoUsuarioDataSeed.TiposUsuario)
            {
                migrationBuilder.InsertData(
                    table: "TiposUsuario",
                    columns: new[] { "Tipo", "Descricao" },
                    values: new object[] { tipo.Tipo, tipo.Descricao });
            }

            foreach (var user in UsuarioDataSeed.Usuarios)
            {
                migrationBuilder.InsertData(
                    table: "Usuarios",
                    columns: new[] { "Nome", "Sobrenome", "CPF", "DataNascimento", "TipoUsuarioId", "Email", "UserName", "Senha" },
                    values: new object[] { 
                        user.Nome, 
                        user.Sobrenome, 
                        user.CPF, 
                        user.DataNascimento, 
                        user.TipoUsuarioId, 
                        user.Email, 
                        user.UserName, 
                        user.Senha 
                    });
            }
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
