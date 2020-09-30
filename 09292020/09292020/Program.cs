using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _09292020
{
    class Program
    {
        static void Main(string[] args)
        {   //Filter by type
            ArrayList arrayList = new ArrayList();
            arrayList.Add("test");
            arrayList.Add("other test");
            arrayList.Add("another test");
            arrayList.Add(2);
            arrayList.Add(5);
            arrayList.Add(20);


            var numeros = arrayList.OfType<int>();

            List<IActividad> e = new List<IActividad>();
            e.Add(new Actividad());
            e.Add(new Tarea());

            var act = e.OfType<Actividad>();

            //// Filter by Characteres 
            string[] nombres = { "Lola", "Fofa", "Coca", "Boba", "Fola", "Lola", "Lalo" };
            IEnumerable<string> startsWithF = from nombre in nombres where nombre.StartsWith("F") select nombre;
            IEnumerable<string> startsWithL = nombres.Where(i => i.StartsWith("L"));
            IEnumerable<string> unicos = nombres.Distinct();

            foreach (var item in startsWithF) { Console.WriteLine(item); }

            ////funny name Arrow functions

            List<Actividad> eventos = new List<Actividad>();
            eventos.Add(new Actividad { Place = "Da Vinci", Name = "Birthday Party", Date = new DateTime(2020, 03, 03) });
            eventos.Add(new Actividad { Place = "My home", Name = "Birthday Party", Date = new DateTime(2021, 03, 03) });
            eventos.Add(new Actividad { Place = "Someother place", Name = "Birthday Party", Date = new DateTime(2022, 03, 03) });

            List<string> pasados = eventos.Where(i => i.Date < DateTime.Now).Select(i => i.Name).ToList();

            Func<int, bool> validarEdad = (edad) => edad > 18;

            Action<int, int> imprimir = (valor1, valor2) => Console.WriteLine(valor1 + valor2);
            validarEdad(28);
            imprimir(2, 2);


            //// Group by n Ordernate 
            //// Proyeccion 

            List<Actividad> b = new List<Actividad>();
            b.Add(new Actividad { Place = "Da Vinci", Name = "Birthday Party", Date = new DateTime(2020, 03, 03) });
            b.Add(new Actividad { Place = "My home", Name = "Birthday Party", Date = new DateTime(2021, 03, 03) });
            b.Add(new Actividad { Place = "Someother place", Name = "Birthday Party", Date = new DateTime(2022, 03, 03) });

            var n = b.Select(i => i.Name);
            var n2 = b.Select(i => new { i.Name, i.Place });

            //// Aggregate 

            List<int> num = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine(num.Average());
            Console.WriteLine(num.Count());
            Console.WriteLine(num.Sum());
            Console.WriteLine(num.Min());
            Console.WriteLine(num.Max());
            Console.WriteLine(num.First());
            Console.WriteLine(num.Last());

            // Task - armar un programa que dado una lista de numeros
            // filtre los pares y los ordene de mayor a menor

            List<int> myNumbers = new List<int> { 32, 62, 43, 24, 55, 6, 27, 85, 69, 130, 2 , 7 };

            var orderedEvenNumbers  = myNumbers.Where(i => i % 2 == 0).OrderByDescending(i => i);

            Console.WriteLine(orderedEvenNumbers);
        }
    }
}
