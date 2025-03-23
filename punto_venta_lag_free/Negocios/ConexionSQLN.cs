using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Npgsql;

namespace Negocios
{
    public class ConexionSQLN
    {
        ConexionSQL cn = new ConexionSQL();

        public int conSQL(string user, string pass)
        {
            return cn.ConsultaLogin(user, pass);
        }

        public DataTable ConsultaDT()
        {
            return cn.ConsultaUsuariosDG();
        }

        public int InsertarUsuario(string nombre, string apellido, string telefono, string usuario, string contrasena)
        {
            return cn.InsertarUsuario(nombre, apellido, telefono, usuario, contrasena);
        }

        public int ModificarUsuario(string nombre, string apellido, string telefono, string usuario, string contrasena)
        {
            return cn.ModificarUsuario(nombre, apellido, telefono, usuario, contrasena);
        }

        public int EliminarUsuario(string usuario)
        {
            return cn.EliminarUsuario(usuario);
        }
    }
}
