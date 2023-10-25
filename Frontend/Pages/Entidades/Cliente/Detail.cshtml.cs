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
    public class ClienteDetailModel : PageModel
    {
        private readonly IRepositorioCliente repositorioCliente;
        public Cliente Cliente {get; set;}

        public ClienteDetailModel(IRepositorioCliente repositorioCliente)
        {
            this.repositorioCliente = repositorioCliente;
        }

        public IActionResult OnGet(int clienteId)
        {
            Cliente = repositorioCliente.GetCliente(clienteId);
            if(Cliente==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            return Page();
        }
    }
}
