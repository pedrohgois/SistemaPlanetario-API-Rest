using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaSolarAPI.Migrations
{
    public partial class D1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SistemaSolares",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(70)", maxLength: 70, nullable: false),
                    MassaEstrela = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SistemaSolares", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Planetas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(70)", maxLength: 70, nullable: false),
                    Massa = table.Column<int>(type: "int", nullable: false),
                    Distancia = table.Column<int>(type: "int", nullable: false),
                    SistemaSolarId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planetas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Planetas_SistemaSolares_SistemaSolarId",
                        column: x => x.SistemaSolarId,
                        principalTable: "SistemaSolares",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Planetas_SistemaSolarId",
                table: "Planetas",
                column: "SistemaSolarId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Planetas");

            migrationBuilder.DropTable(
                name: "SistemaSolares");
        }
    }
}
