using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entidades
{
    [Table("Detalles")]
    public class Detalle
    {
        public Detalle() { }

        //public Detalle(DateTime f, int t, int r, Tarea tarea, int tareaId)
        //{
        //    Fecha = f;
        //    Tiempo = t;
        //    RecursoId = r;
        //    Tarea = tarea;
        //    TareaId = tareaId;
        //}
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int Tiempo { get; set; }
        public int RecursoId { get; set; }
        public int TareaId { get; set; }
        public Tarea Tarea { get; set; }
    }
}
