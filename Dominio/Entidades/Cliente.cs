using System;
using System.Collections.Generic;

namespace Dominio.Entidades
{
    public class Cliente
    {
        public int Id {get; set;}

        public string Cedula {get; set;}
        public string Nombre {get; set;}
        public string Apellido {get; set;}
        public string Interes {get; set;}
    }
}