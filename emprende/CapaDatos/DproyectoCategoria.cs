using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using CapaEntidades;

namespace CapaDatos
{
    public class DproyectoCategoria
    {
        Conexion con = new Conexion();
        public int Sentencia(EproyectoCategoria procat)
        {
            int id = 0;
            MySqlCommand cmd = new MySqlCommand("SentenciaPro_cat", con.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("idproyecto", MySqlDbType.Int32).Value = procat.idproyecto;
            cmd.Parameters.Add("idcategoria", MySqlDbType.Text).Value = procat.idcategoria;
            cmd.Parameters.Add("accion", MySqlDbType.Text).Value = procat.accion;

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

            return id;
        }
        public DataTable Buscar(string b = "")
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand("SelectPro_cat", con.con);
            cmd.Parameters.Add("buscar", MySqlDbType.Text).Value = b;
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }



    }
}
