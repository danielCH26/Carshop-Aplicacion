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
    public class ProveedorListModel : PageModel
    {
        private readonly IRepositorioProveedor repositorioProveedor;
        public IEnumerable<Proveedor> Proveedores{get; set;}
        public ProveedorListModel(IRepositorioProveedor repositorioProveedor)
        {
            this.repositorioProveedor = repositorioProveedor;
        }


        public void OnGet(int? proveedorId)
        {
            if(proveedorId>0)
            {
                repositorioProveedor.DeleteProveedor(proveedorId.Value);
            }
            Proveedores = repositorioProveedor.GetAllProveedores();
        }
    }
}
