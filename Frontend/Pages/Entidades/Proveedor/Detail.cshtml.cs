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
    public class ProveedorDetailModel : PageModel
    {
        private readonly IRepositorioProveedor repositorioProveedor;
        public Proveedor Proveedor {get; set;}

        public ProveedorDetailModel(IRepositorioProveedor repositorioProveedor)
        {
            this.repositorioProveedor = repositorioProveedor;
        }

        public IActionResult OnGet(int proveedorId)
        {
            Proveedor = repositorioProveedor.GetProveedor(proveedorId);
            if(Proveedor==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            return Page();
        }

    }
}
