using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaEntidades;
using CapaDatos;

namespace CapaNegocio
{
    public class NpersonaProyecto
    {
        public static int Sentencia(EpersonaProyecto c)
        {
            DpersonaProyecto ca = new DpersonaProyecto();
            return ca.Sentencia(c);
        }

        public static DataTable Buscar(string b = "")
        {
            DpersonaProyecto ca = new DpersonaProyecto();
            return ca.Buscar(b);
        }
    }
}
