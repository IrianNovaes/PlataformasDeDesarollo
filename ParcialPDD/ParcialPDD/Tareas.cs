using System;
using System.Collections.Generic;
using System.Text;

namespace ParcialPDD
{
    class Tareas
    {
        public string Titulo { get; set; }
        public DateTime Vencimiento { get; set; }
        public int Estimacion { get; set; }
        public Recursos Responsable { get; set; }
        public bool Estado { get; set; }

    }
}
