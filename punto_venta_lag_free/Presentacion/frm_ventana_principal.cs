using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frm_ventana_principal : Form
    {
        public frm_ventana_principal()
        {
            InitializeComponent();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usuarios_menu_item_Click(object sender, EventArgs e)
        {
            frm_usuarios frmUsuarios = new frm_usuarios();
            this.Hide();
            frmUsuarios.ShowDialog();
            this.Show();
        }
    }
}
