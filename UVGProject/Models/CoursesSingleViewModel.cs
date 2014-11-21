using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UVGProject.Models
{
    public class CoursesSingleViewModel
    {
        public virtual Curso CursoActual { get; set; }
        public virtual ICollection<Curso> Cursos { get; set; }
        public int? SelectedID { get; set; }
    }
}