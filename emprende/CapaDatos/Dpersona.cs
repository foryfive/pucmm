using MySql.Data.MySqlClient;
using System.Data;
using CapaEntidades;

namespace CapaDatos
{
    public class Dpersona

    {
        
        Conexion con = new Conexion();
        public int Sentencia(Epersona per)
        {
            int id = 0;
            MySqlCommand cmd = new MySqlCommand("SentenciaPersona", con.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("id", MySqlDbType.Int32).Value = per.idpersona;
            cmd.Parameters.Add("cedula", MySqlDbType.Text).Value = per.cedula;
            cmd.Parameters.Add("nombre", MySqlDbType.Text).Value = per.nombre;
            cmd.Parameters.Add("usuario", MySqlDbType.Text).Value = per.usuario;
            cmd.Parameters.Add("clave", MySqlDbType.Text).Value = per.clave;
            cmd.Parameters.Add("estado", MySqlDbType.Text).Value = per.estado;
            cmd.Parameters.Add("rol", MySqlDbType.Text).Value = per.rol;
            cmd.Parameters.Add("idcarrera", MySqlDbType.Int32).Value = per.idcarrera;
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
            MySqlCommand cmd = new MySqlCommand("SelectPersona", con.con);
            cmd.Parameters.Add("buscar", MySqlDbType.Text).Value = b;
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }


    
}
}
