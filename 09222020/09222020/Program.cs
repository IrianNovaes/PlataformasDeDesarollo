using System;

namespace _09222020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Vehiculo autoUm = new Auto();
            Auto autoDos = new Auto();
            Vehiculo camion = new Camion();


            autoUm.Marca = "Honda";
            autoUm.Modelo = "Civic";
            autoUm.Motor = new Motor();
            ((Auto)autoUm).Puertas = 4;

            if(camion is Auto) {((Auto)camion).Puertas = 2; }
            

            autoDos.Marca = "Honda";
            autoDos.Modelo = "Civic";
            autoDos.Puertas = 4;
        }
    }
}
