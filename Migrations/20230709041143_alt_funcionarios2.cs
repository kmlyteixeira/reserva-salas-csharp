using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace reservasalascsharp.Migrations
{
    /// <inheritdoc />
    public partial class altfuncionarios2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Higienizacao_Salas_salaid",
                table: "Higienizacao");

            migrationBuilder.DropForeignKey(
                name: "FK_Higienizacao_Turnos_turnoid",
                table: "Higienizacao");

            migrationBuilder.DropForeignKey(
                name: "FK_Higienizacao_Usuarios_usuarioId",
                table: "Higienizacao");

            migrationBuilder.DropIndex(
                name: "IX_Higienizacao_salaid",
                table: "Higienizacao");

            migrationBuilder.DropIndex(
                name: "IX_Higienizacao_turnoid",
                table: "Higienizacao");

            migrationBuilder.DropIndex(
                name: "IX_Higienizacao_usuarioId",
                table: "Higienizacao");

            migrationBuilder.DropColumn(
                name: "idUsuario",
                table: "Higienizacao");

            migrationBuilder.DropColumn(
                name: "salaid",
                table: "Higienizacao");

            migrationBuilder.DropColumn(
                name: "turnoid",
                table: "Higienizacao");

            migrationBuilder.DropColumn(
                name: "usuarioId",
                table: "Higienizacao");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "idUsuario",
                table: "Higienizacao",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "salaid",
                table: "Higienizacao",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "turnoid",
                table: "Higienizacao",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "usuarioId",
                table: "Higienizacao",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Higienizacao_salaid",
                table: "Higienizacao",
                column: "salaid");

            migrationBuilder.CreateIndex(
                name: "IX_Higienizacao_turnoid",
                table: "Higienizacao",
                column: "turnoid");

            migrationBuilder.CreateIndex(
                name: "IX_Higienizacao_usuarioId",
                table: "Higienizacao",
                column: "usuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Higienizacao_Salas_salaid",
                table: "Higienizacao",
                column: "salaid",
                principalTable: "Salas",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Higienizacao_Turnos_turnoid",
                table: "Higienizacao",
                column: "turnoid",
                principalTable: "Turnos",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Higienizacao_Usuarios_usuarioId",
                table: "Higienizacao",
                column: "usuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
