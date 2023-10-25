using System;
using System.Collections.Generic;
using Dominio.Entidades;

namespace Persistencia.AppRepositorios
{
    public interface IRepositorioCliente
    {
        IEnumerable<Cliente> GetAllClientes();
        Cliente AddCliente(Cliente cliente);
        Cliente UpdateCliente(Cliente cliente);
        void DeleteCliente(int idCliente);
        Cliente GetCliente(int idCliente); 
    }
}