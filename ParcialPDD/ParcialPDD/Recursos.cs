using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ParcialPDD
{
    [Table("Recursos")]
    public class Recursos
    {
        public Recursos() { }
        public Recursos(string n, Usuarios u) {
            Nombre = n;
            Usuario = u;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RecursoPK { get; set; }

        [MaxLength(50)]
        public string Nombre { get; set; }
        public Usuarios Usuario { get; set; }

    }
}
