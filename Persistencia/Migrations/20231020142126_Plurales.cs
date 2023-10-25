using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistencia.Migrations
{
    public partial class Plurales : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carros_Proveedors_ProveedorId",
                table: "Carros");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Vendedors_VendedorId",
                table: "Reservas");

            migrationBuilder.DropForeignKey(
                name: "FK_Ventas_Vendedors_VendedorId",
                table: "Ventas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vendedors",
                table: "Vendedors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Proveedors",
                table: "Proveedors");

            migrationBuilder.RenameTable(
                name: "Vendedors",
                newName: "Vendedores");

            migrationBuilder.RenameTable(
                name: "Proveedors",
                newName: "Proveedores");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vendedores",
                table: "Vendedores",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Proveedores",
                table: "Proveedores",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Carros_Proveedores_ProveedorId",
                table: "Carros",
                column: "ProveedorId",
                principalTable: "Proveedores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Vendedores_VendedorId",
                table: "Reservas",
                column: "VendedorId",
                principalTable: "Vendedores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ventas_Vendedores_VendedorId",
                table: "Ventas",
                column: "VendedorId",
                principalTable: "Vendedores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carros_Proveedores_ProveedorId",
                table: "Carros");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Vendedores_VendedorId",
                table: "Reservas");

            migrationBuilder.DropForeignKey(
                name: "FK_Ventas_Vendedores_VendedorId",
                table: "Ventas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vendedores",
                table: "Vendedores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Proveedores",
                table: "Proveedores");

            migrationBuilder.RenameTable(
                name: "Vendedores",
                newName: "Vendedors");

            migrationBuilder.RenameTable(
                name: "Proveedores",
                newName: "Proveedors");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vendedors",
                table: "Vendedors",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Proveedors",
                table: "Proveedors",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Carros_Proveedors_ProveedorId",
                table: "Carros",
                column: "ProveedorId",
                principalTable: "Proveedors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Vendedors_VendedorId",
                table: "Reservas",
                column: "VendedorId",
                principalTable: "Vendedors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ventas_Vendedors_VendedorId",
                table: "Ventas",
                column: "VendedorId",
                principalTable: "Vendedors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
