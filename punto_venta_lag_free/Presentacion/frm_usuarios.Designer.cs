namespace Presentacion
{
    partial class frm_usuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.btn_agregar_usuario = new System.Windows.Forms.Button();
            this.btn_modificar_usuario = new System.Windows.Forms.Button();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.btn_eliminar_usuario = new System.Windows.Forms.Button();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.txt_contrasena = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.gbx_info_acceso = new System.Windows.Forms.GroupBox();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.dtgrid_usuarios = new System.Windows.Forms.DataGridView();
            this.gbx_info_acceso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(24, 363);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(114, 32);
            this.lbl_nombre.TabIndex = 0;
            this.lbl_nombre.Text = "Nombre";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(30, 398);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(175, 38);
            this.txt_nombre.TabIndex = 1;
            // 
            // btn_agregar_usuario
            // 
            this.btn_agregar_usuario.Location = new System.Drawing.Point(30, 453);
            this.btn_agregar_usuario.Name = "btn_agregar_usuario";
            this.btn_agregar_usuario.Size = new System.Drawing.Size(175, 76);
            this.btn_agregar_usuario.TabIndex = 2;
            this.btn_agregar_usuario.Text = "Agregar Usuario";
            this.btn_agregar_usuario.UseVisualStyleBackColor = true;
            this.btn_agregar_usuario.Click += new System.EventHandler(this.btn_agregar_usuario_Click);
            // 
            // btn_modificar_usuario
            // 
            this.btn_modificar_usuario.Location = new System.Drawing.Point(233, 453);
            this.btn_modificar_usuario.Name = "btn_modificar_usuario";
            this.btn_modificar_usuario.Size = new System.Drawing.Size(175, 76);
            this.btn_modificar_usuario.TabIndex = 5;
            this.btn_modificar_usuario.Text = "Modificar Usuario";
            this.btn_modificar_usuario.UseVisualStyleBackColor = true;
            this.btn_modificar_usuario.Click += new System.EventHandler(this.btn_modificar_usuario_Click);
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(233, 398);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(175, 38);
            this.txt_apellido.TabIndex = 4;
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Location = new System.Drawing.Point(227, 363);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(118, 32);
            this.lbl_apellido.TabIndex = 3;
            this.lbl_apellido.Text = "Apellido";
            // 
            // btn_eliminar_usuario
            // 
            this.btn_eliminar_usuario.Location = new System.Drawing.Point(440, 453);
            this.btn_eliminar_usuario.Name = "btn_eliminar_usuario";
            this.btn_eliminar_usuario.Size = new System.Drawing.Size(175, 76);
            this.btn_eliminar_usuario.TabIndex = 8;
            this.btn_eliminar_usuario.Text = "Eliminar Usuario";
            this.btn_eliminar_usuario.UseVisualStyleBackColor = true;
            this.btn_eliminar_usuario.Click += new System.EventHandler(this.btn_eliminar_usuario_Click);
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(440, 398);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(175, 38);
            this.txt_telefono.TabIndex = 7;
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Location = new System.Drawing.Point(434, 363);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(126, 32);
            this.lbl_telefono.TabIndex = 6;
            this.lbl_telefono.Text = "Telefono";
            // 
            // txt_contrasena
            // 
            this.txt_contrasena.Location = new System.Drawing.Point(192, 73);
            this.txt_contrasena.Name = "txt_contrasena";
            this.txt_contrasena.Size = new System.Drawing.Size(166, 38);
            this.txt_contrasena.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "Contraseña";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(20, 73);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(150, 38);
            this.txt_usuario.TabIndex = 10;
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Location = new System.Drawing.Point(14, 38);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(112, 32);
            this.lbl_usuario.TabIndex = 9;
            this.lbl_usuario.Text = "Usuario";
            // 
            // gbx_info_acceso
            // 
            this.gbx_info_acceso.Controls.Add(this.txt_usuario);
            this.gbx_info_acceso.Controls.Add(this.txt_contrasena);
            this.gbx_info_acceso.Controls.Add(this.label1);
            this.gbx_info_acceso.Controls.Add(this.lbl_usuario);
            this.gbx_info_acceso.Location = new System.Drawing.Point(650, 331);
            this.gbx_info_acceso.Name = "gbx_info_acceso";
            this.gbx_info_acceso.Size = new System.Drawing.Size(377, 117);
            this.gbx_info_acceso.TabIndex = 13;
            this.gbx_info_acceso.TabStop = false;
            this.gbx_info_acceso.Text = "Información de acceso";
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(833, 454);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(175, 76);
            this.btn_cerrar.TabIndex = 14;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // dtgrid_usuarios
            // 
            this.dtgrid_usuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrid_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrid_usuarios.Location = new System.Drawing.Point(30, 30);
            this.dtgrid_usuarios.Name = "dtgrid_usuarios";
            this.dtgrid_usuarios.RowHeadersWidth = 51;
            this.dtgrid_usuarios.RowTemplate.Height = 24;
            this.dtgrid_usuarios.Size = new System.Drawing.Size(997, 285);
            this.dtgrid_usuarios.TabIndex = 15;
            // 
            // frm_usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 541);
            this.Controls.Add(this.dtgrid_usuarios);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.gbx_info_acceso);
            this.Controls.Add(this.btn_eliminar_usuario);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.lbl_telefono);
            this.Controls.Add(this.btn_modificar_usuario);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.lbl_apellido);
            this.Controls.Add(this.btn_agregar_usuario);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_nombre);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frm_usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.gbx_info_acceso.ResumeLayout(false);
            this.gbx_info_acceso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_usuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Button btn_agregar_usuario;
        private System.Windows.Forms.Button btn_modificar_usuario;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.Button btn_eliminar_usuario;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.TextBox txt_contrasena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.GroupBox gbx_info_acceso;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.DataGridView dtgrid_usuarios;
    }
}