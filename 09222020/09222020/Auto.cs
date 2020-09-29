using System;
using System.Collections.Generic;
using System.Text;

namespace _09222020
{
    public class Auto : Vehiculo, ITerrestre
    {
        public int Puertas { get; set; }
        int ITerrestre.Velocidad { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
