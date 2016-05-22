using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
namespace CapaDatos
{
    public class Conexion
    {
        // CADENA DE CONEXION 
        private MySqlConnection c = new MySqlConnection("Server=10.129.10.202;Database=dbpucmm;Uid=root;Pwd=1234;");
        public MySqlConnection con { get { return c; } }
        //ABRIR CONEXION ALA BASE DE DATOS
        public void Conectar()
        {
            if (this.con.State == ConnectionState.Closed)
                con.Open();
        }
        //CERRAR LA CONEXION BASE DE DATOS
        public void Desconectar()
        {
            if (this.con.State == ConnectionState.Open)
                con.Close();
        }


    }
}
