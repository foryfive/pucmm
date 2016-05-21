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
    public class NproyectoCategoria
    {
        public static int Sentencia(EproyectoCategoria c)
        {
            DproyectoCategoria ca = new DproyectoCategoria();
            return ca.Sentencia(c);
        }

        public static DataTable Buscar(string b = "")
        {
            DproyectoCategoria ca = new DproyectoCategoria();
            return ca.Buscar(b);
        }
    }
}
