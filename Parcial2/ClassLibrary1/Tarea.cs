using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{
    [Table("Tareas")]
    public class Tarea
    {
        public Tarea() { }
        //public Tarea(string t, DateTime v, int e, Recurso r, bool estado)
        //{
        //    Titulo = t;
        //    Vencimiento = v;
        //    Estimacion = e;
        //    Responsable = r;
        //    Estado = estado;
        //}

        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(100)]
        public string Titulo { get; set; }
        public DateTime Vencimiento { get; set; }
        public int Estimacion { get; set; }
        public Recurso Responsable { get; set; }
        public bool Estado { get; set; }
        public int TipoId { get; set; }
        public TipoTarea Tipo { get; set; }
        public List<Detalle> Detalles { get; set; }
    }
}
