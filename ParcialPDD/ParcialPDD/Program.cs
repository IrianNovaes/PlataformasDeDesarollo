using System;
using System.Collections.Generic;

namespace ParcialPDD
{
    class Program
    {
        static void Main(string[] args)
        {
            Tareas Tarea1 = new Tareas();
            Tarea1.Titulo = "Do App";
            Tarea1.Vencimiento = new DateTime(2020, 10, 06);
            Tarea1.Responsable.Nombre = "Lola";
            Tarea1.Responsable.Usuario.Usuario = "Lola";
            Tarea1.Responsable.Usuario.Clave = "xxxx";
            Tarea1.Estado = true;
            Tarea1.Estimacion = 24;

            Tareas Tarea2 = new Tareas();
            Tarea2.Titulo = "Do NOTHING";
            Tarea2.Vencimiento = new DateTime(2020, 10, 06);
            Tarea2.Responsable.Nombre = "Lola";
            Tarea2.Responsable.Usuario.Usuario = "Lola";
            Tarea2.Responsable.Usuario.Clave = "xxxx";
            Tarea2.Estado = true;
            Tarea2.Estimacion = 24;

            List<Tareas> Tarea = new List<Tareas>();
            Tarea.Add(Tarea1);
            Tarea.Add(Tarea2);
        }

   
    }
}
