﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UVGProject.Models
{
    public class Entrada_Respuesta
    {
        public virtual Entrada Entrada { get; set; }
        public virtual Respuesta Respuesta { get; set; }
    }
}