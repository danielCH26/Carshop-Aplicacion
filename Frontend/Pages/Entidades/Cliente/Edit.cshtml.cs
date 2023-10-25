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
    public class ClienteEditModel : PageModel
    {
        private readonly IRepositorioCliente repositorioCliente;

        [BindProperty]
        public Cliente Cliente {get; set;}

        public ClienteEditModel(IRepositorioCliente repositorioCliente)
        {
            this.repositorioCliente = repositorioCliente;
        }

        public IActionResult OnGet(int? clienteId)
        {
            if(clienteId.HasValue)
            {
                Cliente = repositorioCliente.GetCliente(clienteId.Value);
            }
            else
            {
                Cliente = new Cliente();
            }
            
            if(Cliente==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            return Page();
        }

        public IActionResult OnPost()
        {
            
            if(!ModelState.IsValid)
            {
                return Page();
            }

            if(Cliente.Id > 0)
            {
                Cliente = repositorioCliente.UpdateCliente(Cliente);
            }
            else
            {
                Cliente = repositorioCliente.AddCliente(Cliente);
            }
            return RedirectToPage("./List");
        }

    }
}
