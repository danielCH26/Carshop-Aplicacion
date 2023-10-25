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
    public class NuevoListModel : PageModel
    {
        private readonly IRepositorioNuevo repositorioNuevo;
        public IEnumerable<Nuevo> Nuevos{get; set;}
        public NuevoListModel(IRepositorioNuevo repositorioNuevo)
        {
            this.repositorioNuevo = repositorioNuevo;
        }

        public void OnGet(int? nuevoId)
        {
            if(nuevoId>0)
            {
                repositorioNuevo.DeleteNuevo(nuevoId.Value);
            }
            Nuevos = repositorioNuevo.GetAllNuevos();
        }
    }
}
