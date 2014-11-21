using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UVGProject.Models
{
    public class Video
    {
        public int ID { get; set; }
        [Required]
        [MinLength(5)]
        [MaxLength(100)]
        public string Titulo { get; set; }
        [Required]
        [MinLength(5)]
        [MaxLength(15)]
        public string Link { get; set; }
        public virtual Curso Curso { get; set; }
        public virtual ApplicationUser Autor { get; set; }
    }
}