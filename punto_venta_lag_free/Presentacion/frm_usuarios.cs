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
        }

        private void btn_agregar_usuario_Click(object sender, EventArgs e)
        {
            dtgrid_usuarios.DataSource = cn.ConsultaDT();
        }

        private void btn_modificar_usuario_Click(object sender, EventArgs e)
        {
            dtgrid_usuarios.DataSource = cn.ConsultaDT();
        }

        private void btn_eliminar_usuario_Click(object sender, EventArgs e)
        {
            dtgrid_usuarios.DataSource = cn.ConsultaDT();

        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
