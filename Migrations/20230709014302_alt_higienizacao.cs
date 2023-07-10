using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace reservasalascsharp.Migrations
{
    /// <inheritdoc />
    public partial class althigienizacao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "idUsusario",
                table: "Higienizacao",
                newName: "turnoid");

            migrationBuilder.AddColumn<DateTime>(
                name: "Data",
                table: "Higienizacao",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "idTurno",
                table: "Higienizacao",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idUsuario",
                table: "Higienizacao",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Data",
                table: "Agendamentos",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.CreateIndex(
                name: "IX_Higienizacao_turnoid",
                table: "Higienizacao",
                column: "turnoid");

            migrationBuilder.AddForeignKey(
                name: "FK_Higienizacao_Turnos_turnoid",
                table: "Higienizacao",
                column: "turnoid",
                principalTable: "Turnos",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Higienizacao_Turnos_turnoid",
                table: "Higienizacao");

            migrationBuilder.DropIndex(
                name: "IX_Higienizacao_turnoid",
                table: "Higienizacao");

            migrationBuilder.DropColumn(
                name: "Data",
                table: "Higienizacao");

            migrationBuilder.DropColumn(
                name: "idTurno",
                table: "Higienizacao");

            migrationBuilder.DropColumn(
                name: "idUsuario",
                table: "Higienizacao");

            migrationBuilder.RenameColumn(
                name: "turnoid",
                table: "Higienizacao",
                newName: "idUsusario");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Data",
                table: "Agendamentos",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");
        }
    }
}
