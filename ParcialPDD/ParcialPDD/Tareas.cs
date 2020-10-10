using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ParcialPDD
{
    [Table("Tareas")]
    public class Tareas
    {   

        public Tareas() { }
        public Tareas(string t, DateTime v, int e, Recursos r, bool estado) {
            Titulo = t;
            Vencimiento = v;
            Estimacion = e;
            Responsable = r;
            Estado = estado;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TareaPK { get; set; }
        
        [MaxLength(100)]
        public string Titulo { get; set; }
        public DateTime Vencimiento { get; set; }
        public int Estimacion { get; set; }
        public Recursos Responsable { get; set; }
        
        public bool Estado { get; set; }


    }
}
