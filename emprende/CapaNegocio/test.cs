﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
namespace CapaNegocio
{
    public static class test
    {
        public static void con()
        {
            Conexion con = new Conexion();
            con.Conectar();
        }

    }
}
