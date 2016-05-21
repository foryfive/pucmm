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
    public class Dcategoria
    {
        Conexion con = new Conexion();
        public int Sentencia(Ecategoria cat)
        {
            int id = 0;
            MySqlCommand cmd = new MySqlCommand("SentenciaCategoria", con.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("id", MySqlDbType.Int32).Value = cat.idcategoria;
            cmd.Parameters.Add("descripcion", MySqlDbType.Text).Value = cat.descripcion;
            cmd.Parameters.Add("accion", MySqlDbType.Text).Value = cat.accion;

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
            MySqlCommand cmd = new MySqlCommand("SelectCategoria", con.con);
            cmd.Parameters.Add("buscar", MySqlDbType.Text).Value = b;
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }



    }
}
