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
    public class Dconfiguracion
    {
        Conexion con = new Conexion();
        public int Sentencia(Econfiguracion config)
        {
            int id = 0;
            MySqlCommand cmd = new MySqlCommand("SentenciaConfiguracion", con.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("id", MySqlDbType.Int32).Value = config.idconfiguracion;
            cmd.Parameters.Add("diaslimite", MySqlDbType.Int32).Value = config.diaslimite;
            cmd.Parameters.Add("puntoslimite", MySqlDbType.Int32).Value = config.puntolimite;
            cmd.Parameters.Add("diaslimitesinferior", MySqlDbType.Int32).Value = config.diasLimInf;
            cmd.Parameters.Add("puntoslimitessuperior", MySqlDbType.Int32).Value = config.puntosLimSup;
            cmd.Parameters.Add("accion", MySqlDbType.Text).Value = config.accion;

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
            MySqlCommand cmd = new MySqlCommand("SelectConfiguracion", con.con);
            cmd.Parameters.Add("buscar", MySqlDbType.Text).Value = b;
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }

    }
}
