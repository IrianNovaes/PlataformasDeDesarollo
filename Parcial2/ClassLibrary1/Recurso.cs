using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entidades
{
    [Table("Recursos")]
    public class Recurso
    {
        public Recurso() { }
        //public Recurso(string n, Usuario u)
        //{
        //    Nombre = n;
        //    Usuario = u;
        //}

        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Nombre { get; set; }
        public Usuario Usuario { get; set; }

    }
}
