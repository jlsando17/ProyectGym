using Microsoft.EntityFrameworkCore.Migrations;

namespace GimnasioFacil.App.Persistencia.Migrations
{
    public partial class Segunda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Contraseña",
                table: "Clientes",
                newName: "Contrasena");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Contrasena",
                table: "Clientes",
                newName: "Contraseña");
        }
    }
}
