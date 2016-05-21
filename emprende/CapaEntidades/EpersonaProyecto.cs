using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class EpersonaProyecto
    {
        public int idper_pro { get; set; }
        public int idpersona { get; set; }
        public int idproyecto { get; set; }
        public char accion { get; set; }
    }
}
