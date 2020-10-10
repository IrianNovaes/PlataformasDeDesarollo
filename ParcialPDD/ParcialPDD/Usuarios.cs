using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ParcialPDD { 

    [Table ("Usuarios")]
public class Usuarios
    {
        public Usuarios() { }
        public Usuarios(string u, string c) 
        {
            Usuario = u;
            Clave = c;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UsuarioPK { get; set; }

        [MaxLength(20)]
        public string Usuario { get; set; }
        
        [Required]
        [Column(TypeName = "char(20)")]
        public string Clave { get; set; }
    }

}
