using System;
using ClassLibrary1;
using Mysql = ClassLibrary1.DAL.Mysql;

namespace _09082020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Calculadora calculadora = new Calculadora();
            Console.WriteLine(calculadora.Suma(2, 2));
            //Console.WriteLine(calculadora.Resta(2, 2));
            Console.WriteLine(calculadora.Divide(2, 2));
            Console.WriteLine(calculadora.Divide(0, 2));
            //Console.WriteLine(calculadora.Multiplica(2, 2));
            //Calculadora calculadora1 = new Calculadora(2,2);
            //Calculadora calculadora2 = new Calculadora(2,2);
            //Class1 clase = new Class1();
            //Mysql.db db = new Mysql.db();
            //calculadora.Metodo(1);
            //calculadora.Metodo(1,1);

            //calculadora.SetNumero3(10);
            //Console.WriteLine(calculadora.GetNumero3());

            //calculadora.Numero1 = 11;
            //Console.WriteLine(calculadora.Numero1);

            //elemina el puntero en memoria, avisando al garbage collector 
            //calculadora2 = null;




        }
    }
}
