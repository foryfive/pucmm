using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaEntidades;
using MySql.Data.MySqlClient;
namespace CapaDatos
{
    public class DiniciarSesion
    {
        Conexion con = new Conexion();

        public DataTable IniciarSesion(string usuario,string clave)
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand("iniciarsesion", con.con);
            cmd.Parameters.Add("user", MySqlDbType.Text).Value = usuario;
            cmd.Parameters.Add("pass", MySqlDbType.Text).Value = clave;
            cmd.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;

        }

    }
}
