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
    public class ProveedorEditModel : PageModel
    {
        private readonly IRepositorioProveedor repositorioProveedor;

        [BindProperty]
        public Proveedor Proveedor {get; set;}

        public ProveedorEditModel(IRepositorioProveedor repositorioProveedor)
        {
            this.repositorioProveedor = repositorioProveedor;
        }

        public IActionResult OnGet(int? proveedorId)
        {
            if(proveedorId.HasValue)
            {
                Proveedor = repositorioProveedor.GetProveedor(proveedorId.Value);
            }
            else
            {
                Proveedor = new Proveedor();
            }
            
            if(Proveedor==null)
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

            if(Proveedor.Id > 0)
            {
                Proveedor = repositorioProveedor.UpdateProveedor(Proveedor);
            }
            else
            {
                Proveedor = repositorioProveedor.AddProveedor(Proveedor);
            }
            return RedirectToPage("./List");
        }
    }
}
