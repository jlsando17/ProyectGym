using Microsoft.EntityFrameworkCore.Migrations;

namespace GimnasioFacil.App.Persistencia.Migrations
{
    public partial class Tercera : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Nutriciones_Entrenamientos_EntrenamientoId",
                table: "Nutriciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Rutinas_Entrenamientos_EntrenamientoId",
                table: "Rutinas");

            migrationBuilder.DropIndex(
                name: "IX_Rutinas_EntrenamientoId",
                table: "Rutinas");

            migrationBuilder.DropIndex(
                name: "IX_Nutriciones_EntrenamientoId",
                table: "Nutriciones");

            migrationBuilder.DropColumn(
                name: "EntrenamientoId",
                table: "Rutinas");

            migrationBuilder.DropColumn(
                name: "EntrenamientoId",
                table: "Nutriciones");

            migrationBuilder.AddColumn<int>(
                name: "NutricionId",
                table: "Entrenamientos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RutinaId",
                table: "Entrenamientos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Entrenamientos_NutricionId",
                table: "Entrenamientos",
                column: "NutricionId");

            migrationBuilder.CreateIndex(
                name: "IX_Entrenamientos_RutinaId",
                table: "Entrenamientos",
                column: "RutinaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Entrenamientos_Nutriciones_NutricionId",
                table: "Entrenamientos",
                column: "NutricionId",
                principalTable: "Nutriciones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Entrenamientos_Rutinas_RutinaId",
                table: "Entrenamientos",
                column: "RutinaId",
                principalTable: "Rutinas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Entrenamientos_Nutriciones_NutricionId",
                table: "Entrenamientos");

            migrationBuilder.DropForeignKey(
                name: "FK_Entrenamientos_Rutinas_RutinaId",
                table: "Entrenamientos");

            migrationBuilder.DropIndex(
                name: "IX_Entrenamientos_NutricionId",
                table: "Entrenamientos");

            migrationBuilder.DropIndex(
                name: "IX_Entrenamientos_RutinaId",
                table: "Entrenamientos");

            migrationBuilder.DropColumn(
                name: "NutricionId",
                table: "Entrenamientos");

            migrationBuilder.DropColumn(
                name: "RutinaId",
                table: "Entrenamientos");

            migrationBuilder.AddColumn<int>(
                name: "EntrenamientoId",
                table: "Rutinas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EntrenamientoId",
                table: "Nutriciones",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rutinas_EntrenamientoId",
                table: "Rutinas",
                column: "EntrenamientoId");

            migrationBuilder.CreateIndex(
                name: "IX_Nutriciones_EntrenamientoId",
                table: "Nutriciones",
                column: "EntrenamientoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Nutriciones_Entrenamientos_EntrenamientoId",
                table: "Nutriciones",
                column: "EntrenamientoId",
                principalTable: "Entrenamientos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rutinas_Entrenamientos_EntrenamientoId",
                table: "Rutinas",
                column: "EntrenamientoId",
                principalTable: "Entrenamientos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
