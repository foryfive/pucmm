﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Epersona
    {
        public int idpersona { get; set; }
        public int cedula { get; set; }
        public string nombre { get; set; }
        public string usuario { get; set; }
        public string clave { get; set; }
        public char estado { get; set;}
        public string rol { get; set; }
        public int idcarrera { get; set; }
        public char accion { get; set; }
        
    }
    
}
