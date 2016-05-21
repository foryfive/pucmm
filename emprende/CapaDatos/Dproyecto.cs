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
    public class Dproyecto
    {
        Conexion con = new Conexion();
        public int Sentencia(Eproyecto pro)
        {
            int id = 0;
            MySqlCommand cmd = new MySqlCommand("SentenciaProyecto", con.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("id", MySqlDbType.Int32).Value = pro.idproyecto;
            cmd.Parameters.Add("fechaPublicacion", MySqlDbType.Date).Value = pro.fechaPublicacion;
            cmd.Parameters.Add("puntos", MySqlDbType.Int32).Value = pro.puntos;
            cmd.Parameters.Add("descripcion", MySqlDbType.Text).Value = pro.descripcion;
            cmd.Parameters.Add("idpersona", MySqlDbType.Int32).Value = pro.idpersona;
            cmd.Parameters.Add("estado", MySqlDbType.Text).Value = pro.estado;
            cmd.Parameters.Add("accion", MySqlDbType.Text).Value = pro.accion;

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
            MySqlCommand cmd = new MySqlCommand("SelectProyecto", con.con);
            cmd.Parameters.Add("buscar", MySqlDbType.Text).Value = b;
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }



    }
}
