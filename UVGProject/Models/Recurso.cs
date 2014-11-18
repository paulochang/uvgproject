using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UVGProject.Models
{
    public class Recurso
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Ruta { get; set; }
        public virtual Curso Curso { get; set; }
        public virtual Categoria Categoria { get; set; }
        public virtual ApplicationUser Autor { get; set; }
    }
}