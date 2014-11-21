using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UVGProject.Models
{
    public class Articulo
    {
        public int ID { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(100)]
        public string Título { get; set; }
        [Required]
        public string Contenido { get; set; }
        public virtual Curso Curso { get; set; }
        public virtual ApplicationUser Autor { get; set; }
    }
}