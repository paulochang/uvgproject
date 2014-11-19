using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UVGProject.Models
{
    public class Respuesta
    {
        public int ID { get; set; }
        public string Titulo { get; set; }
        [DataType(DataType.MultilineText)]
        public string Texto { get; set; }
        public virtual ApplicationUser Autor { get; set; }
        public virtual ICollection<Entrada_Respuesta> Entrada_Respuestas { get; set; }
    }
}