using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Dominio.Entidades;

namespace Persistencia.AppRepositorios
{
    public class RepositorioNuevo:IRepositorioNuevo
    {
        
        private readonly AppContexto _appContexto;

        public RepositorioNuevo(AppContexto appContexto)
        {
            _appContexto = appContexto;
        }

        Carro IRepositorioNuevo.AddNuevo(Nuevo nuevo)
        {   
            var nuevoAdicionado =_appContexto.Carros.Add(nuevo);
            _appContexto.SaveChanges();
            return nuevoAdicionado.Entity;
        }

        IEnumerable<Nuevo> IRepositorioNuevo.GetAllNuevos()
        {
            return _appContexto.Carros.OfType<Nuevo>().ToList();
        }


        void IRepositorioNuevo.DeleteNuevo(int idNuevo)
        {
            var nuevoEncontrado = _appContexto.Carros.FirstOrDefault(m => m.Id==idNuevo);
            if(nuevoEncontrado==null)
                return;
            _appContexto.Carros.Remove(nuevoEncontrado);
            _appContexto.SaveChanges();
        }


        Nuevo IRepositorioNuevo.GetNuevo(int idNuevo)
        {
            return _appContexto.Carros.OfType<Nuevo>().FirstOrDefault(m => m.Id==idNuevo);
        }

        /*
        Nuevo IRepositorioNuevo.UpdateNuevo(Nuevo nuevo)
        {
            var nuevoEncontrado =_appContexto.Carros.OfType<Nuevo>().FirstOrDefault(m => m.Id==nuevo.Id);
            if(nuevoEncontrado!=null)
            {
                nuevoEncontrado.Modelo = nuevo.Modelo;
                nuevoEncontrado.Marca = nuevo.Marca;
                nuevoEncontrado.PrecioVenta = nuevo.PrecioVenta;
                nuevoEncontrado.PrecioCompra = nuevo.PrecioCompra;
                nuevoEncontrado.Tipo = "Nuevo";
                nuevoEncontrado.Stock = nuevo.Stock;
                nuevoEncontrado.Proveedor = nuevo.Proveedor;
                nuevoEncontrado.Estado = nuevo.Estado;
                _appContexto.SaveChanges();
            }
            return nuevoEncontrado;
        }
        */
        
    }
}