using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UVGProject.Models
{
    public class Categoria
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public ICollection<Recurso> Recursos { get; set; }
    }
}