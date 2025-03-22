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
    public partial class Form1 : Form
    {
        ConexionSQLN cn = new ConexionSQLN();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            if (cn.conSQL(txt_usuario.Text, txt_contrasena.Text) == 1)
            {
                MessageBox.Show("Bienvenido "+txt_usuario.Text+".");
                this.Hide();

                frm_ventana_principal vnt_principal = new frm_ventana_principal();
                vnt_principal.Show();
            }
            else
            {
                MessageBox.Show("El usuario no ha sido encontrado.");
            }

        }
    }
}
