namespace Proyecto.Intermedios
{
    partial class IMantenimiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IMantenimiento));
            this.label1 = new System.Windows.Forms.Label();
            this.btncerrar = new FontAwesome.Sharp.IconButton();
            this.btnbuscarcompra = new FontAwesome.Sharp.IconButton();
            this.btnlistacompras = new FontAwesome.Sharp.IconButton();
            this.btnnuevacompra = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 364);
            this.label1.TabIndex = 14;
            // 
            // btncerrar
            // 
            this.btncerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrar.ForeColor = System.Drawing.Color.White;
            this.btncerrar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btncerrar.IconColor = System.Drawing.Color.White;
            this.btncerrar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btncerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncerrar.Location = new System.Drawing.Point(55, 274);
            this.btncerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Padding = new System.Windows.Forms.Padding(80, 4, 0, 0);
            this.btncerrar.Size = new System.Drawing.Size(329, 68);
            this.btncerrar.TabIndex = 13;
            this.btncerrar.Text = "Cerrar";
            this.btncerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncerrar.UseVisualStyleBackColor = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // btnbuscarcompra
            // 
            this.btnbuscarcompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnbuscarcompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscarcompra.ForeColor = System.Drawing.Color.White;
            this.btnbuscarcompra.IconChar = FontAwesome.Sharp.IconChar.UserLock;
            this.btnbuscarcompra.IconColor = System.Drawing.Color.White;
            this.btnbuscarcompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbuscarcompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbuscarcompra.Location = new System.Drawing.Point(55, 123);
            this.btnbuscarcompra.Margin = new System.Windows.Forms.Padding(4);
            this.btnbuscarcompra.Name = "btnbuscarcompra";
            this.btnbuscarcompra.Padding = new System.Windows.Forms.Padding(80, 4, 0, 0);
            this.btnbuscarcompra.Size = new System.Drawing.Size(329, 68);
            this.btnbuscarcompra.TabIndex = 12;
            this.btnbuscarcompra.Text = "Permisos";
            this.btnbuscarcompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnbuscarcompra.UseVisualStyleBackColor = false;
            this.btnbuscarcompra.Click += new System.EventHandler(this.btnbuscarcompra_Click);
            // 
            // btnlistacompras
            // 
            this.btnlistacompras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnlistacompras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlistacompras.ForeColor = System.Drawing.Color.White;
            this.btnlistacompras.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.btnlistacompras.IconColor = System.Drawing.Color.White;
            this.btnlistacompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnlistacompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlistacompras.Location = new System.Drawing.Point(55, 198);
            this.btnlistacompras.Margin = new System.Windows.Forms.Padding(4);
            this.btnlistacompras.Name = "btnlistacompras";
            this.btnlistacompras.Padding = new System.Windows.Forms.Padding(80, 4, 0, 0);
            this.btnlistacompras.Size = new System.Drawing.Size(329, 68);
            this.btnlistacompras.TabIndex = 11;
            this.btnlistacompras.Text = "Datos de Negocio";
            this.btnlistacompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnlistacompras.UseVisualStyleBackColor = false;
            this.btnlistacompras.Click += new System.EventHandler(this.btnlistacompras_Click);
            // 
            // btnnuevacompra
            // 
            this.btnnuevacompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnnuevacompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnnuevacompra.ForeColor = System.Drawing.Color.White;
            this.btnnuevacompra.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.btnnuevacompra.IconColor = System.Drawing.Color.White;
            this.btnnuevacompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnnuevacompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnuevacompra.Location = new System.Drawing.Point(55, 48);
            this.btnnuevacompra.Margin = new System.Windows.Forms.Padding(4);
            this.btnnuevacompra.Name = "btnnuevacompra";
            this.btnnuevacompra.Padding = new System.Windows.Forms.Padding(80, 4, 0, 0);
            this.btnnuevacompra.Size = new System.Drawing.Size(329, 68);
            this.btnnuevacompra.TabIndex = 10;
            this.btnnuevacompra.Text = "Usuarios";
            this.btnnuevacompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnnuevacompra.UseVisualStyleBackColor = false;
            this.btnnuevacompra.Click += new System.EventHandler(this.btnnuevacompra_Click);
            // 
            // IMantenimiento
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(429, 386);
            this.ControlBox = false;
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.btnbuscarcompra);
            this.Controls.Add(this.btnlistacompras);
            this.Controls.Add(this.btnnuevacompra);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(429, 386);
            this.MinimumSize = new System.Drawing.Size(429, 386);
            this.Name = "IMantenimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "IMantenimiento";
            this.Load += new System.EventHandler(this.IMantenimiento_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btncerrar;
        private FontAwesome.Sharp.IconButton btnbuscarcompra;
        private FontAwesome.Sharp.IconButton btnlistacompras;
        private FontAwesome.Sharp.IconButton btnnuevacompra;
        private System.Windows.Forms.Label label1;
    }
}