using System;

namespace _08252020
{
    class Program
    {
        static void Main(string[] args)
        {


            //int i = 0;
            //while (i>10)
            //{
            //    Console.WriteLine(++i);
            //}

            //do
            //{
            //    Console.WriteLine(i);

            //} while (i > 10);

            int misteryNumber = 0;
            int trys = 0;

            while(trys < 3 || misteryNumber != 40)
            {
                trys++;
                Console.WriteLine("enter the mistery number: ");
                misteryNumber = int.Parse(Console.ReadLine());
            };

            
        }
    }
}
