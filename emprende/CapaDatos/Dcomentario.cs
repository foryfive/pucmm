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
    public class Dcomentario
    {
        Conexion con = new Conexion();
        public int Sentencia(Ecomentario com)
        {
            int id = 0;
            MySqlCommand cmd = new MySqlCommand("SentenciaComentario", con.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("id", MySqlDbType.Int32).Value = com.idcomentario;
            cmd.Parameters.Add("estado", MySqlDbType.Text).Value = com.estado;
            cmd.Parameters.Add("descripcion", MySqlDbType.Text).Value = com.descripcion;
            cmd.Parameters.Add("idproyecto", MySqlDbType.Int32).Value = com.idproyecto;
            cmd.Parameters.Add("idpersona", MySqlDbType.Int32).Value = com.idpersona;
            cmd.Parameters.Add("accion", MySqlDbType.Text).Value = com.accion;

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
            MySqlCommand cmd = new MySqlCommand("SelectComentario", con.con);
            cmd.Parameters.Add("buscar", MySqlDbType.Text).Value = b;
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }



    }
}
