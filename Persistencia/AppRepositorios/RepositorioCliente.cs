using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Dominio.Entidades;

namespace Persistencia.AppRepositorios
{
    public class RepositorioCliente:IRepositorioCliente
    {
        private readonly AppContexto _appContexto;

        public RepositorioCliente(AppContexto appContexto)
        {
            _appContexto = appContexto;
        }

        Cliente IRepositorioCliente.AddCliente(Cliente cliente)
        {   
            var clienteAdicionado =_appContexto.Clientes.Add(cliente);
            _appContexto.SaveChanges();
            return clienteAdicionado.Entity;
        }

        void IRepositorioCliente.DeleteCliente(int idCliente)
        {
            var clienteEncontrado = _appContexto.Clientes.FirstOrDefault(m => m.Id==idCliente);
            if(clienteEncontrado==null)
                return;
            _appContexto.Clientes.Remove(clienteEncontrado);
            _appContexto.SaveChanges();
        }

        IEnumerable<Cliente> IRepositorioCliente.GetAllClientes()
        {
            return _appContexto.Clientes;
        }

        Cliente IRepositorioCliente.GetCliente(int idCliente)
        {
            return _appContexto.Clientes.FirstOrDefault(m => m.Id==idCliente);
        }
        
        Cliente IRepositorioCliente.UpdateCliente(Cliente cliente)
        {
            var clienteEncontrado =_appContexto.Clientes.FirstOrDefault(m => m.Id==cliente.Id);
            if(clienteEncontrado!=null)
            {
                clienteEncontrado.Nombre = cliente.Nombre;
                clienteEncontrado.Apellido = cliente.Apellido;
                clienteEncontrado.Cedula = cliente.Cedula;
                clienteEncontrado.Interes = cliente.Interes;
                _appContexto.SaveChanges();
            }
            return clienteEncontrado;
        }


    }
}