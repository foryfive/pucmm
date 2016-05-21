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
    public static class Ncarrera
    {
        public static int Sentencia(Ecarrera c)
        {
            Dcarrera ca = new Dcarrera();
            return ca.Sentencia(c); 
        }
        public static DataTable Buscar(string b = "")
        {
            Dcarrera ca = new Dcarrera();
            return ca.Buscar(b);
        }
    }
}
