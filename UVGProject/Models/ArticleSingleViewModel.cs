using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UVGProject.Models
{
    public class ArticleSingleViewModel
    {
        public virtual Articulo ArticuloActual { get; set; }
        public virtual ICollection<Curso> Cursos { get; set; }
        public int? SelectedID { get; set; }
    }
}