using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Dominio.Entidades;

namespace Persistencia.AppRepositorios
{
    public class RepositorioCarro:IRepositorioCarro
    {
        private readonly AppContexto _appContexto;

        public RepositorioCarro(AppContexto appContexto)
        {
            _appContexto = appContexto;
        }

        IEnumerable<Carro> IRepositorioCarro.GetAllCarros()
        {
            return _appContexto.Carros;
        }

    }
}