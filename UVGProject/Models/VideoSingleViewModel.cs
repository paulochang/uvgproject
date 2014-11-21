using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UVGProject.Models
{
    public class VideoSingleViewModel
    {
        public virtual Video VideoActual { get; set; }
        public virtual ICollection<Curso> Cursos { get; set; }
        public int? SelectedID { get; set; }

    }
}