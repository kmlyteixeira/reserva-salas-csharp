using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace reservasalascsharp.Migrations
{
    /// <inheritdoc />
    public partial class altadicionandoativo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "Higienizacao",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            /*migrationBuilder.AddColumn<int>(
                name: "funcionarioId",
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
                defaultValue: 0);*/

            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "Agendamentos",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            /*migrationBuilder.CreateIndex(
                name: "IX_Higienizacao_funcionarioId",
                table: "Higienizacao",
                column: "funcionarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Higienizacao_salaid",
                table: "Higienizacao",
                column: "salaid");

            migrationBuilder.CreateIndex(
                name: "IX_Higienizacao_turnoid",
                table: "Higienizacao",
                column: "turnoid");

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
                name: "FK_Higienizacao_funcionario_funcionarioId",
                table: "Higienizacao",
                column: "funcionarioId",
                principalTable: "funcionario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);*/
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Higienizacao_Salas_salaid",
                table: "Higienizacao");

            migrationBuilder.DropForeignKey(
                name: "FK_Higienizacao_Turnos_turnoid",
                table: "Higienizacao");

            migrationBuilder.DropForeignKey(
                name: "FK_Higienizacao_funcionario_funcionarioId",
                table: "Higienizacao");

            migrationBuilder.DropIndex(
                name: "IX_Higienizacao_funcionarioId",
                table: "Higienizacao");

            migrationBuilder.DropIndex(
                name: "IX_Higienizacao_salaid",
                table: "Higienizacao");

            migrationBuilder.DropIndex(
                name: "IX_Higienizacao_turnoid",
                table: "Higienizacao");

            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "Higienizacao");

            migrationBuilder.DropColumn(
                name: "funcionarioId",
                table: "Higienizacao");

            migrationBuilder.DropColumn(
                name: "salaid",
                table: "Higienizacao");

            migrationBuilder.DropColumn(
                name: "turnoid",
                table: "Higienizacao");

            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "Agendamentos");
        }
    }
}
