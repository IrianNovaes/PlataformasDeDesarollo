using System;
using System.Collections.Generic;
using System.Text;

namespace _09222020
{
    public abstract class Vehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public Motor Motor { get; set; }
    }
}
