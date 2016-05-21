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
    public class Ncategoria
    {
        public static int Sentencia(Ecategoria c)
        {
            Dcategoria ca = new Dcategoria();
            return ca.Sentencia(c);
        }

        public static DataTable Buscar(string b = "")
        {
            Dcategoria ca = new Dcategoria();
            return ca.Buscar(b);
        }
    }
}
