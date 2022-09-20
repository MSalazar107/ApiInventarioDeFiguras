using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiInventarioDeFiguras.Migrations
{
    public partial class corr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Waves_Figuras_FiguraId",
                table: "Waves");

            migrationBuilder.AlterColumn<int>(
                name: "FiguraId",
                table: "Waves",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Waves_Figuras_FiguraId",
                table: "Waves",
                column: "FiguraId",
                principalTable: "Figuras",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Waves_Figuras_FiguraId",
                table: "Waves");

            migrationBuilder.AlterColumn<int>(
                name: "FiguraId",
                table: "Waves",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Waves_Figuras_FiguraId",
                table: "Waves",
                column: "FiguraId",
                principalTable: "Figuras",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
