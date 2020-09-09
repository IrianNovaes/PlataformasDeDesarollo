using System;
using System.Collections.Generic;
using System.Text;

namespace _09082020
{
    public class Calculadora : CalculadoraBase
    {
        //private int numero1;
        //private int numero3;

        //public int Numero1
        //{
        //    get { return numero1; }
        //    set { numero1 = value; }
        //}

        //public void SetNumero3(int valor)
        //{
        //    numero3 = valor;
        //}

        //public int GetNumero3()
        //{
        //    return numero3;
        //}

        private int total;
        public int Numero2 { private get; set;}
        public int Numero1 { private get; set; }

        public Calculadora() { }
        public Calculadora(int numero1, int numero2) {
            Numero1 = numero1;
            Numero2 = numero2;
        }

        public int GetTotalSuma()
        {
            return total;

        }

        public override int Multiplica(int numero1, int numero2)
        {
            return numero1 * numero2;
        }


        // Sealed bloquea futuros overrides
        public sealed override int Resta(int numero1, int numero2)
        {
            return base.Resta(numero1, numero2);
        }

        public int Suma (int numero1, int numero2)
        {
            total = total + numero1 + numero2;
            return numero1 + numero2;
        }

        public int Divide(int numero1, int numero2)
        {
            if(numero1 == 0 || numero2 == 0)
            {
                Console.WriteLine("No podeis dividir por 0 sweetie");
            return 0;
            } 
            else
            {
            return numero1 / numero2;
            } 

            
        }

        
        /// <summary>
        /// Este metodo es de prueba
        /// </summary>
        /// <param name="q">aca podeis hablar sobre el parametro</param>
        /// <returns>aca sobre el return lol </returns>
        //public int Metodo(string q)
        //{
        //    return 0;
        //}

        //public int Metodo(int q)
        //{
        //    return 0;
        //}

        //public int Metodo(int q, int r)
        //{
        //    return 0;
        //}
        //public int Metodo() 
        //{
        //    return 0;
        //}

       
    }
}
