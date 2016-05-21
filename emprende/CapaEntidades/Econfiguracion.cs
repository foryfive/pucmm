using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Econfiguracion
    {
        public int idconfiguracion { get; set; }
        public int diaslimite { get; set; }
        public int puntolimite { get; set; }
        public int diasLimInf { get; set; }
        public int puntosLimSup { get; set; }
        public char accion { get; set; }

    }
}
