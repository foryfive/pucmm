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
    public class Nconfiguracion
    {
        public static int Sentencia(Econfiguracion c)
        {
            Dconfiguracion ca = new Dconfiguracion();
            return ca.Sentencia(c);
        }

        public static DataTable Buscar(string b = "")
        {
            Dconfiguracion ca = new Dconfiguracion();
            return ca.Buscar(b);
        }
    }
}
