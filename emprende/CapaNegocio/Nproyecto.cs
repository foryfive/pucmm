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
    public class Nproyecto
    {
        public static int Sentencia(Eproyecto c)
        {
            Dproyecto ca = new Dproyecto();
            return ca.Sentencia(c);
        }

        public static DataTable Buscar(string b = "")
        {
            Dproyecto ca = new Dproyecto();
            return ca.Buscar(b);
        }
    }
}
