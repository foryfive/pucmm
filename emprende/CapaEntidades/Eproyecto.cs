﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Eproyecto
    {
        public int idproyecto { get; set; }
        public DateTime fechaPublicacion { get; set; }
        public int puntos { get; set; }
        public string descripcion { get; set; }
        public int idpersona { get; set; }
        public string estado { get; set; }
        public string accion { get; set; }
        public string titulo { get; set; }

    }
}
