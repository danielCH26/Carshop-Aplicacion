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
    public class CarroListModel : PageModel
    {
        private readonly IRepositorioCarro repositorioCarro;
        public IEnumerable<Carro> Carros{get; set;}
        public CarroListModel(IRepositorioCarro repositorioCarro)
        {
            this.repositorioCarro = repositorioCarro;
        }


        public void OnGet(int? carroId)
        {
            Carros = repositorioCarro.GetAllCarros();
        }
    }
}
