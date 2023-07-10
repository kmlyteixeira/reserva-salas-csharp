using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace reservasalascsharp.Migrations
{
    /// <inheritdoc />
    public partial class altfuncionarios : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Higienizacao_funcionario_funcionarioId",
                table: "Higienizacao");

            migrationBuilder.DropIndex(
                name: "IX_Higienizacao_funcionarioId",
                table: "Higienizacao");

            migrationBuilder.DropColumn(
                name: "funcionarioId",
                table: "Higienizacao");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "funcionarioId",
                table: "Higienizacao",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Higienizacao_funcionarioId",
                table: "Higienizacao",
                column: "funcionarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Higienizacao_funcionario_funcionarioId",
                table: "Higienizacao",
                column: "funcionarioId",
                principalTable: "funcionario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
