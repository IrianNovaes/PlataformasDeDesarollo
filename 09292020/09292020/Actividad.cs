using System;
using System.Collections.Generic;
using System.Text;

namespace _09292020
{   
    public interface IActividad
    {

    }

    public class Tarea : IActividad
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
    public class Actividad : IActividad
    {
        public string Place { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
    }
}
