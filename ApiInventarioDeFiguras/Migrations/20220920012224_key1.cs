using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiInventarioDeFiguras.Migrations
{
    public partial class key1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Waves",
                columns: table => new
                {
                    Numero_de_Serie = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ola = table.Column<int>(type: "int", nullable: false),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FiguraId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Waves", x => x.Numero_de_Serie);
                    table.ForeignKey(
                        name: "FK_Waves_Figuras_FiguraId",
                        column: x => x.FiguraId,
                        principalTable: "Figuras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Waves_FiguraId",
                table: "Waves",
                column: "FiguraId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Waves");
        }
    }
}
