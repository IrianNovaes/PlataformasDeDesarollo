using System;
using System.Collections.Generic;
using System.Text;

namespace ParcialPDD
{
    class Detalles
    {
        public DateTime Fecha { get; set; }
        public int Tiempo { get; set; }
        public Recursos Recurso { get; set; }
        public Tareas Tarea { get; set; }
    }
}
