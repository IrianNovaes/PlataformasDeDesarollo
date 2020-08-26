using System;

namespace _08182020
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0, numero = 0, contador = 11;
            
            var random = new Random();

            Console.WriteLine("Enter your name:");
            string nombre = Console.ReadLine();

            Console.WriteLine($"Hello {nombre}, Lets Play a game");
            Console.ReadLine();
            
            Console.WriteLine("Please enter 10 different numbers untill you reach the mistery number.");

            for (int i = 0; i < contador; i++)
            {
                if (i >= 10)
                {
                    Console.WriteLine("that was your 10th number, You have no more options, byeee");
                }
                else if (suma < 50 )
                {
                    Console.WriteLine("Enter you number");
                    numero = int.Parse(Console.ReadLine());

                    if (numero <= 50)
                    {
                        suma += numero;
                    }
                    else if (suma > 50 || numero > 50)
                    {
                        contador = 1;
                        Console.WriteLine("You have exploded.");
                    }
                } else if (numero == 50 || suma == 50)
                    {
                        contador = 1;
                        Console.WriteLine("Congratulations the mistery number was 50");
                    }

                
            }
        }
    }
}
