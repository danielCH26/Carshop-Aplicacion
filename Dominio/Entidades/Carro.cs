using System;
using System.Collections.Generic;

namespace Dominio.Entidades
{
    public class Carro
    {
        public int Id {get; set;}
        public string Marca {get; set;}
        public string Modelo {get; set;}
        public string PrecioCompra {get; set;}
        public string PrecioVenta {get; set;}
        public Proveedor Proveedor {get; set;}

        public string Estado {get; set;}

        public string Tipo {get; set;}

    }
}