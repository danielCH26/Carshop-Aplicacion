using System;
using System.Collections.Generic;

namespace Dominio.Entidades
{
    public class Venta
    {
        public int Id {get; set;}

        public Carro Carro{get; set;}
        public int Cantidad{get; set;}
        public Cliente Cliente{get; set;}
        public Vendedor Vendedor{get; set;}
    }
}