using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Datos
{
    public class ConexionSQL
    {
        static string conexion_string = "SERVER=postDem;DATABASE=puntodeventa;INTEGRATEDSECURITY";
        NpgsqlConnection con = new NpgsqlConnection(conexion_string);

        public int ConsultaLogin (string usuario, string contrasena)
        {
            int count;
            con.Open();
            string query = "Select count(*) from usuario where usuario ='" + usuario + "' and contrasena = '" + contrasena + "'";
            NpgsqlCommand cmd = new NpgsqlCommand(query,con);

            count = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return count;
        }
    }
}
