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
    class Npersonas
    {
        public static int Sentencia(Epersona c)
        {
            Dpersona ca = new Dpersona();
            return ca.Sentencia(c);
        }

        public static DataTable Buscar(string b = "")
        {
            Dpersona ca = new Dpersona();
            return ca.Buscar(b);
        }
    }
}
