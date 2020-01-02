using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace datos
{
    public class ConexionSQL
    {
        static string conexionstring = "server = localhost; database = Municipio;" +
            "integrated security = true";
        SqlConnection con = new SqlConnection(conexionstring);

        public int consultalogin(string Dni, string Paterno){
            int count;
            con.Open();
            string Query = "select Count(*) From Usuario where nom_usuario = '" +Dni+ "' and contraseña = '"+Paterno+"'";
            SqlCommand cmd = new SqlCommand(Query, con);
            count = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return count;
        }

        public int consultalogin2(string Usuario, string Contrasena)
        {
            int count;
            con.Open();
            string Query = "select Count(*) From Area where usuario = '" + Usuario + "' and contrasena = '" + Contrasena + "'";
            SqlCommand cmd = new SqlCommand(Query, con);
            count = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return count;
        }

    }
}
