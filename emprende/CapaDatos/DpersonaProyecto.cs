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
    public class DpersonaProyecto
    {
        Conexion con = new Conexion();
        public int Sentencia(EpersonaProyecto per)
        {
            int id = 0;
            MySqlCommand cmd = new MySqlCommand("SentenciaPer_pro", con.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("id", MySqlDbType.Int32).Value = per.idpersona;
            cmd.Parameters.Add("idpersona", MySqlDbType.Int32).Value = per.idpersona;
            cmd.Parameters.Add("idproyecto", MySqlDbType.Int32).Value = per.idproyecto;
            cmd.Parameters.Add("accion", MySqlDbType.Text).Value = per.accion;

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
            MySqlCommand cmd = new MySqlCommand("SelectPer_pro", con.con);
            cmd.Parameters.Add("buscar", MySqlDbType.Text).Value = b;
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }



    }
}
