using Microsoft.EntityFrameworkCore.Migrations;

namespace GimnasioFacil.App.Persistencia.Migrations
{
    public partial class Cuarta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Entrenamientos_Valoraciones_ValoracionId",
                table: "Entrenamientos");

            migrationBuilder.DropTable(
                name: "Valoraciones");

            migrationBuilder.DropIndex(
                name: "IX_Entrenamientos_ValoracionId",
                table: "Entrenamientos");

            migrationBuilder.DropColumn(
                name: "ValoracionId",
                table: "Entrenamientos");

            migrationBuilder.AddColumn<string>(
                name: "Altura",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Edad",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Peso",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Altura",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "Edad",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "Peso",
                table: "Clientes");

            migrationBuilder.AddColumn<int>(
                name: "ValoracionId",
                table: "Entrenamientos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Valoraciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Altura = table.Column<float>(type: "real", nullable: false),
                    Edad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Peso = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Valoraciones", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Entrenamientos_ValoracionId",
                table: "Entrenamientos",
                column: "ValoracionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Entrenamientos_Valoraciones_ValoracionId",
                table: "Entrenamientos",
                column: "ValoracionId",
                principalTable: "Valoraciones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
