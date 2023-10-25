using System;
using System.Collections.Generic;
using Dominio.Entidades;

namespace Persistencia.AppRepositorios
{
    public interface IRepositorioCarro
    {
         IEnumerable<Carro> GetAllCarros();
    }
}