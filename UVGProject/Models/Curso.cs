using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UVGProject.Models
{
    public class Curso
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Semestre { get; set; }

        public ICollection<Curso_Usuario> Curso_Usuarios { get; set; }
        public ICollection<Entrada> Entradas { get; set; }
        public ICollection<Recurso> Recursos { get; set; }

    }
}