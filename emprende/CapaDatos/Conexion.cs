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

        private MySqlConnection c = new MySqlConnection("Server=10.129.10.202;Database=dbpucmm;Uid=root;Pwd=1234;");
        public MySqlConnection con { get { return c; } }
        public void Conectar()
        {
            if (this.con.State == ConnectionState.Closed)
                con.Open();
        }
        public void Desconectar()
        {
            if (this.con.State == ConnectionState.Open)
                con.Close();
        }


    }
}
