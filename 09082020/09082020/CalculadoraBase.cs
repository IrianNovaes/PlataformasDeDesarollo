using System;
using System.Collections.Generic;
using System.Text;

namespace _09082020
{
    public abstract class CalculadoraBase
    {
        public virtual int Resta(int numero1, int numero2)
        {
            return numero1 - numero2;
        }
        public abstract int Multiplica(int numero1, int numero2);
    }
}
