using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistencia.Migrations
{
    public partial class HerenciasV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Vendedores");

            migrationBuilder.DropColumn(
                name: "NumVentas",
                table: "Vendedores");

            migrationBuilder.DropColumn(
                name: "Sueldo",
                table: "Vendedores");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Carros");

            migrationBuilder.DropColumn(
                name: "Matricula",
                table: "Carros");

            migrationBuilder.DropColumn(
                name: "Reparaciones",
                table: "Carros");

            migrationBuilder.DropColumn(
                name: "Stock",
                table: "Carros");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Vendedores",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "NumVentas",
                table: "Vendedores",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Sueldo",
                table: "Vendedores",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Carros",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Matricula",
                table: "Carros",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Reparaciones",
                table: "Carros",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Stock",
                table: "Carros",
                type: "int",
                nullable: true);
        }
    }
}
