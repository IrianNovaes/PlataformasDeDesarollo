using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ParcialPDD
{
    [Table("Detalles")]
    public class Detalles
    {
        public Detalles() { }
        public Detalles(DateTime f, int t, Recursos r, Tareas tarea) {
            Fecha = f;
            Tiempo = t;
            Recurso = r;
            Tarea = tarea;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DetallePK { get; set; }
        public DateTime Fecha { get; set; }
        public int Tiempo { get; set; }
        public Recursos Recurso { get; set; }
        public Tareas Tarea { get; set; }
    }
}
