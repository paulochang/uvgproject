using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UVGProject.Models
{
    public class Curso
    {
        public int ID { get; set; }
        [Required]
        [MinLength(6)]
        [MaxLength(10)]
        public string Código { get; set; }
        [Required]
        [MinLength(5)]
        [MaxLength(100)]
        public string Descripcion { get; set; }

        public virtual ICollection<ApplicationUser> Usuarios { get; set; }

    }
}