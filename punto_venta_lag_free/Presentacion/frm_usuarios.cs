using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;

namespace Presentacion
{
    public partial class frm_usuarios : Form
    {
        ConexionSQLN cn = new ConexionSQLN();
        public frm_usuarios()
        {
            InitializeComponent();
            dtgrid_usuarios.DataSource = cn.ConsultaDT();
        }

        private void btn_agregar_usuario_Click(object sender, EventArgs e)
        {
            cn.InsertarUsuario(txt_nombre.Text,txt_apellido.Text,txt_telefono.Text,txt_usuario.Text,txt_contrasena.Text);
            dtgrid_usuarios.DataSource = cn.ConsultaDT();
        }

        private void btn_modificar_usuario_Click(object sender, EventArgs e)
        {
            cn.ModificarUsuario(txt_nombre.Text, txt_apellido.Text, txt_telefono.Text, txt_usuario.Text, txt_contrasena.Text);
            dtgrid_usuarios.DataSource = cn.ConsultaDT();
        }

        private void btn_eliminar_usuario_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = txt_usuario.Text; // Suponiendo que tienes un TextBox para el nombre de usuario
                if (string.IsNullOrWhiteSpace(usuario))
                {
                    MessageBox.Show("Por favor, ingrese un nombre de usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int filasAfectadas = cn.EliminarUsuario(txt_usuario.Text);
                MessageBox.Show($"Usuario eliminado correctamente. Filas afectadas: {filasAfectadas}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dtgrid_usuarios.DataSource = cn.ConsultaDT();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
