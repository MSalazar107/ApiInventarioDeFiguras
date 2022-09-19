using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiInventarioDeFiguras.Migrations
{
    public partial class Franquicia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Marca",
                table: "Figuras",
                newName: "Franquicia");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Franquicia",
                table: "Figuras",
                newName: "Marca");
        }
    }
}
