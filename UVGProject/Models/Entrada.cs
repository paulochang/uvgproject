using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UVGProject.Models
{
    public class Entrada
    {
        public int ID { get; set; }
        public string Titulo { get; set; }
        public int Visitas { get; set; }
        public virtual ApplicationUser Autor { get; set; }
        public virtual Curso Curso { get; set; }
    }
}