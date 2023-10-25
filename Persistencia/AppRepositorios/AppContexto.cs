using System;
using Microsoft.EntityFrameworkCore;
using Dominio.Entidades;


namespace Persistencia.AppRepositorios
{
    public class AppContexto:DbContext
    {
        public DbSet<Carro> Carros {get; set;}

        public DbSet<Proveedor> Proveedores {get; set;}
        public DbSet<Cliente> Clientes {get; set;}
        public DbSet<Reserva> Reservas {get; set;}
        public DbSet<Venta> Ventas {get; set;}
        public DbSet<Vendedor> Vendedores {get; set;}

        /*
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Nuevo>().HasBaseType<Carro>();
            modelBuilder.Entity<Usado>().HasBaseType<Carro>();
            modelBuilder.Entity<Asalariado>().HasBaseType<Vendedor>();
            modelBuilder.Entity<Comisionado>().HasBaseType<Vendedor>();
        }
        */

        protected override void OnConfiguring(DbContextOptionsBuilder conn){
            if(!conn.IsConfigured){
                conn.UseSqlServer("Data source = (localdb)\\MSSQLLocalDB; Initial Catalog = CarShop");
            }
        }
        
    }
}