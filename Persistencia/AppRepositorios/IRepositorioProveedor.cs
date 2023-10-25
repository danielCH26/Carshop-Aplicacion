using System;
using System.Collections.Generic;
using Dominio.Entidades;

namespace Persistencia.AppRepositorios
{
    public interface IRepositorioProveedor
    {
        IEnumerable<Proveedor> GetAllProveedores();
        Proveedor AddProveedor(Proveedor proveedor);
        Proveedor UpdateProveedor(Proveedor proveedor);
        void DeleteProveedor(int idProveedor);
        Proveedor GetProveedor(int idProveedor); 
    }
    
}