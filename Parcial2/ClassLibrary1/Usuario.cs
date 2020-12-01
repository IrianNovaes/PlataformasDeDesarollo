using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entidades
{
    [Table("Usuarios")]
    public class Usuario
    {
        public Usuario() { }
        //public Usuario(string u, string c)
        //{
        //    Nombre = u;
        //    Clave = c;
        //}

        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(20)]
        public string Nombre { get; set; }

        public string Apodo { get; set; }

        [Required]
        [Column(TypeName = "char(20)")]
        public string Clave { get; set; }

        public int RolId { get; set; }

        public Rol Rol { get; set; }


        [NotMapped]
        public string ClaveInput { get; set; }
    }
}
