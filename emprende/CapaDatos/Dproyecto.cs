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
            cmd.Parameters.Add("fecha", MySqlDbType.Date).Value = pro.fechaPublicacion;
            cmd.Parameters.Add("puntuacion", MySqlDbType.Int32).Value = pro.puntos;
            cmd.Parameters.Add("descripcion", MySqlDbType.Text).Value = pro.descripcion;
            cmd.Parameters.Add("idpersona", MySqlDbType.Int32).Value = pro.idpersona;
            cmd.Parameters.Add("estado", MySqlDbType.Text).Value = pro.estado;
            cmd.Parameters.Add("titulo", MySqlDbType.Text).Value = pro.titulo;
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
            cmd.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = cmd;

            da.Fill(dt);
            return dt;
        }
        public DataTable Buscar(int id)
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand("SelectProyectoId", con.con);
            cmd.Parameters.Add("id", MySqlDbType.Int16).Value = id;
            cmd.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }


    }
}
