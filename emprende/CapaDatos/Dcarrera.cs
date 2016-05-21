using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using CapaEntidades;
using System.Data;
namespace CapaDatos
{
    public class Dcarrera
    {
        Conexion con = new Conexion();
        public int Sentencia(Ecarrera c)
        {
            int id = 0;
            MySqlCommand cmd = new MySqlCommand("SentenciaCarrera",con.con);
            cmd.Parameters.Add("id", MySqlDbType.Int32).Value         = c.idcarrera;
            cmd.Parameters.Add("descripcion", MySqlDbType.Text).Value = c.descripcion;
            cmd.Parameters.Add("accion", MySqlDbType.Text).Value      = c.accion;

            try
            {
                con.Conectar();
                  id = int.Parse(cmd.ExecuteScalar().ToString());
                con.Desconectar();
            }
            finally
            {
                con.Desconectar();
            }

           
            return id ;
        }
        public DataTable Buscar(string b = "")
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand("selectcarrera",con.con);
            cmd.Parameters.Add("buscar", MySqlDbType.Text).Value = b;
            cmd.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }


    }
}
