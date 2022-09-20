using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiInventarioDeFiguras.Migrations
{
    public partial class advanced : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Waves",
                table: "Waves");

            migrationBuilder.DropColumn(
                name: "Numero_de_Serie",
                table: "Waves");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Waves",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Waves",
                table: "Waves",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Waves",
                table: "Waves");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Waves");

            migrationBuilder.AddColumn<long>(
                name: "Numero_de_Serie",
                table: "Waves",
                type: "bigint",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Waves",
                table: "Waves",
                column: "Numero_de_Serie");
        }
    }
}
