using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Dominio.Entidades;

namespace Persistencia.AppRepositorios
{
    public class RepositorioProveedor:IRepositorioProveedor
    {
        private readonly AppContexto _appContexto;

        public RepositorioProveedor(AppContexto appContexto)
        {
            _appContexto = appContexto;
        }

        Proveedor IRepositorioProveedor.AddProveedor(Proveedor proveedor)
        {   
            var proveedorAdicionado =_appContexto.Proveedores.Add(proveedor);
            _appContexto.SaveChanges();
            return proveedorAdicionado.Entity;
        }
        
        void IRepositorioProveedor.DeleteProveedor(int idProveedor)
        {
            var proveedorEncontrado = _appContexto.Proveedores.FirstOrDefault(m => m.Id==idProveedor);
            if(proveedorEncontrado==null)
                return;
            _appContexto.Proveedores.Remove(proveedorEncontrado);
            _appContexto.SaveChanges();
        }

        IEnumerable<Proveedor> IRepositorioProveedor.GetAllProveedores()
        {
            return _appContexto.Proveedores;
        }

        Proveedor IRepositorioProveedor.GetProveedor(int idProveedor)
        {
            return _appContexto.Proveedores.FirstOrDefault(m => m.Id==idProveedor);
        }

        Proveedor IRepositorioProveedor.UpdateProveedor(Proveedor proveedor)
        {
            var proveedorEncontrado =_appContexto.Proveedores.FirstOrDefault(m => m.Id==proveedor.Id);
            if(proveedorEncontrado!=null)
            {
                proveedorEncontrado.Nombre = proveedor.Nombre;
                proveedorEncontrado.Apellido = proveedor.Apellido;
                proveedorEncontrado.Cedula = proveedor.Cedula;
                _appContexto.SaveChanges();
            }
            return proveedorEncontrado;
        }

    }
}