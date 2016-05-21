using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class Ncomentario
    {
        public static int Sentencia(Ecomentario c)
        {
            Dcomentario ca = new Dcomentario();
            return ca.Sentencia(c);
        }

        public static DataTable Buscar(string b = "")
        {
            Dcomentario ca = new Dcomentario();
            return ca.Buscar(b);
        }
    }
}
