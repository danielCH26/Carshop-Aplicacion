using System;
using System.Collections.Generic;
using Dominio.Entidades;

namespace Persistencia.AppRepositorios
{
    public interface IRepositorioNuevo
    {
        IEnumerable<Nuevo> GetAllNuevos();
        Carro AddNuevo(Nuevo nuevo);
        //Nuevo UpdateNuevo(Nuevo nuevo);
        void DeleteNuevo(int idNuevo);
        Nuevo GetNuevo(int idNuevo); 
    }
}