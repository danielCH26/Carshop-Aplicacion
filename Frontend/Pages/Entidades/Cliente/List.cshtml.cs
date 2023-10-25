using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Persistencia.AppRepositorios;
using Dominio.Entidades;

namespace Frontend.Pages
{
    public class ClienteListModel : PageModel
    {
        private readonly IRepositorioCliente repositorioCliente;
        public IEnumerable<Cliente> Clientes{get; set;}
        public ClienteListModel(IRepositorioCliente repositorioCliente)
        {
            this.repositorioCliente = repositorioCliente;
        }


        public void OnGet(int? clienteId)
        {
            if(clienteId>0)
            {
                repositorioCliente.DeleteCliente(clienteId.Value);
            }
            Clientes = repositorioCliente.GetAllClientes();
        }
    }
}
