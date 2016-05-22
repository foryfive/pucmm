using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public static class Ninisiarsesion
    {
        public static DataTable InisiaSesion(string usuario,string clave)
        {
            DiniciarSesion i = new DiniciarSesion();
            return i.IniciarSesion(usuario,clave);
        }


    }
}
