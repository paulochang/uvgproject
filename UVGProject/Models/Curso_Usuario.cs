using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UVGProject.Models
{
    public class Curso_Usuario
    {
        public int ID { get; set; }
        public virtual Curso Curso { get; set; }
        public virtual ApplicationUser Usuario { get; set; }
    }
}