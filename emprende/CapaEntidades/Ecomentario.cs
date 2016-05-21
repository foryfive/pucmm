using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Ecomentario
    {
        public int idcomentario { get; set; }
        public char estado { get; set; }
        public string descripcion { get; set; }
        public int idproyecto { get; set; }
        public int idpersona { get; set; }
        public char accion { get; set; }

    }
}
