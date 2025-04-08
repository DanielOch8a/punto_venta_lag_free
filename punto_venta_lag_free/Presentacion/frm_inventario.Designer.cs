namespace Presentacion
{
    partial class frm_inventario
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
            this.dtgrid_inventario = new System.Windows.Forms.DataGridView();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.btn_eliminar_producto = new System.Windows.Forms.Button();
            this.txt_categoria = new System.Windows.Forms.TextBox();
            this.lbl_categoria = new System.Windows.Forms.Label();
            this.btn_modificar_producto = new System.Windows.Forms.Button();
            this.txt_nombre_producto = new System.Windows.Forms.TextBox();
            this.lbl_nombre_producto = new System.Windows.Forms.Label();
            this.btn_agregar_producto = new System.Windows.Forms.Button();
            this.txt_codigo_producto = new System.Windows.Forms.TextBox();
            this.lbl_codigo_producto = new System.Windows.Forms.Label();
            this.lbl_precio_unidad = new System.Windows.Forms.Label();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.txt_precio_unitario = new System.Windows.Forms.TextBox();
            this.pnl_img_inventario = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_inventario)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgrid_inventario
            // 
            this.dtgrid_inventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrid_inventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrid_inventario.Location = new System.Drawing.Point(25, 40);
            this.dtgrid_inventario.Name = "dtgrid_inventario";
            this.dtgrid_inventario.RowHeadersWidth = 51;
            this.dtgrid_inventario.RowTemplate.Height = 24;
            this.dtgrid_inventario.Size = new System.Drawing.Size(731, 285);
            this.dtgrid_inventario.TabIndex = 27;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar.Location = new System.Drawing.Point(778, 463);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(175, 76);
            this.btn_cerrar.TabIndex = 26;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            // 
            // btn_eliminar_producto
            // 
            this.btn_eliminar_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar_producto.Location = new System.Drawing.Point(425, 463);
            this.btn_eliminar_producto.Name = "btn_eliminar_producto";
            this.btn_eliminar_producto.Size = new System.Drawing.Size(175, 76);
            this.btn_eliminar_producto.TabIndex = 24;
            this.btn_eliminar_producto.Text = "Eliminar Producto";
            this.btn_eliminar_producto.UseVisualStyleBackColor = true;
            // 
            // txt_categoria
            // 
            this.txt_categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_categoria.Location = new System.Drawing.Point(450, 408);
            this.txt_categoria.Name = "txt_categoria";
            this.txt_categoria.Size = new System.Drawing.Size(175, 34);
            this.txt_categoria.TabIndex = 23;
            // 
            // lbl_categoria
            // 
            this.lbl_categoria.AutoSize = true;
            this.lbl_categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_categoria.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_categoria.Location = new System.Drawing.Point(445, 373);
            this.lbl_categoria.Name = "lbl_categoria";
            this.lbl_categoria.Size = new System.Drawing.Size(118, 29);
            this.lbl_categoria.TabIndex = 22;
            this.lbl_categoria.Text = "Categoria";
            // 
            // btn_modificar_producto
            // 
            this.btn_modificar_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar_producto.Location = new System.Drawing.Point(219, 463);
            this.btn_modificar_producto.Name = "btn_modificar_producto";
            this.btn_modificar_producto.Size = new System.Drawing.Size(175, 76);
            this.btn_modificar_producto.TabIndex = 21;
            this.btn_modificar_producto.Text = "Modificar Producto";
            this.btn_modificar_producto.UseVisualStyleBackColor = true;
            // 
            // txt_nombre_producto
            // 
            this.txt_nombre_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_producto.Location = new System.Drawing.Point(254, 408);
            this.txt_nombre_producto.Name = "txt_nombre_producto";
            this.txt_nombre_producto.Size = new System.Drawing.Size(175, 34);
            this.txt_nombre_producto.TabIndex = 20;
            // 
            // lbl_nombre_producto
            // 
            this.lbl_nombre_producto.AutoSize = true;
            this.lbl_nombre_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre_producto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_nombre_producto.Location = new System.Drawing.Point(253, 373);
            this.lbl_nombre_producto.Name = "lbl_nombre_producto";
            this.lbl_nombre_producto.Size = new System.Drawing.Size(101, 29);
            this.lbl_nombre_producto.TabIndex = 19;
            this.lbl_nombre_producto.Text = "Nombre";
            // 
            // btn_agregar_producto
            // 
            this.btn_agregar_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar_producto.Location = new System.Drawing.Point(17, 463);
            this.btn_agregar_producto.Name = "btn_agregar_producto";
            this.btn_agregar_producto.Size = new System.Drawing.Size(175, 76);
            this.btn_agregar_producto.TabIndex = 18;
            this.btn_agregar_producto.Text = "Agregar Producto";
            this.btn_agregar_producto.UseVisualStyleBackColor = true;
            // 
            // txt_codigo_producto
            // 
            this.txt_codigo_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo_producto.Location = new System.Drawing.Point(17, 408);
            this.txt_codigo_producto.Name = "txt_codigo_producto";
            this.txt_codigo_producto.Size = new System.Drawing.Size(222, 34);
            this.txt_codigo_producto.TabIndex = 17;
            // 
            // lbl_codigo_producto
            // 
            this.lbl_codigo_producto.AutoSize = true;
            this.lbl_codigo_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo_producto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_codigo_producto.Location = new System.Drawing.Point(12, 373);
            this.lbl_codigo_producto.Name = "lbl_codigo_producto";
            this.lbl_codigo_producto.Size = new System.Drawing.Size(227, 29);
            this.lbl_codigo_producto.TabIndex = 16;
            this.lbl_codigo_producto.Text = "Codigo de producto";
            // 
            // lbl_precio_unidad
            // 
            this.lbl_precio_unidad.AutoSize = true;
            this.lbl_precio_unidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precio_unidad.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_precio_unidad.Location = new System.Drawing.Point(641, 370);
            this.lbl_precio_unidad.Name = "lbl_precio_unidad";
            this.lbl_precio_unidad.Size = new System.Drawing.Size(168, 29);
            this.lbl_precio_unidad.TabIndex = 9;
            this.lbl_precio_unidad.Text = "Precio unitario";
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidad.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_cantidad.Location = new System.Drawing.Point(844, 370);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(109, 29);
            this.lbl_cantidad.TabIndex = 11;
            this.lbl_cantidad.Text = "Cantidad";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(850, 405);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(103, 38);
            this.txt_cantidad.TabIndex = 12;
            // 
            // txt_precio_unitario
            // 
            this.txt_precio_unitario.Location = new System.Drawing.Point(647, 405);
            this.txt_precio_unitario.Name = "txt_precio_unitario";
            this.txt_precio_unitario.Size = new System.Drawing.Size(162, 38);
            this.txt_precio_unitario.TabIndex = 10;
            // 
            // pnl_img_inventario
            // 
            this.pnl_img_inventario.BackgroundImage = global::Presentacion.Properties.Resources.inventario_img;
            this.pnl_img_inventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_img_inventario.Location = new System.Drawing.Point(771, 90);
            this.pnl_img_inventario.Name = "pnl_img_inventario";
            this.pnl_img_inventario.Size = new System.Drawing.Size(200, 186);
            this.pnl_img_inventario.TabIndex = 28;
            // 
            // frm_inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(983, 581);
            this.Controls.Add(this.pnl_img_inventario);
            this.Controls.Add(this.txt_precio_unitario);
            this.Controls.Add(this.dtgrid_inventario);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.lbl_cantidad);
            this.Controls.Add(this.lbl_precio_unidad);
            this.Controls.Add(this.btn_eliminar_producto);
            this.Controls.Add(this.txt_categoria);
            this.Controls.Add(this.lbl_categoria);
            this.Controls.Add(this.btn_modificar_producto);
            this.Controls.Add(this.txt_nombre_producto);
            this.Controls.Add(this.lbl_nombre_producto);
            this.Controls.Add(this.btn_agregar_producto);
            this.Controls.Add(this.txt_codigo_producto);
            this.Controls.Add(this.lbl_codigo_producto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frm_inventario";
            this.Text = "Inventario";
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_inventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrid_inventario;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Button btn_eliminar_producto;
        private System.Windows.Forms.TextBox txt_categoria;
        private System.Windows.Forms.Label lbl_categoria;
        private System.Windows.Forms.Button btn_modificar_producto;
        private System.Windows.Forms.TextBox txt_nombre_producto;
        private System.Windows.Forms.Label lbl_nombre_producto;
        private System.Windows.Forms.Button btn_agregar_producto;
        private System.Windows.Forms.TextBox txt_codigo_producto;
        private System.Windows.Forms.Label lbl_codigo_producto;
        private System.Windows.Forms.Label lbl_precio_unidad;
        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.TextBox txt_precio_unitario;
        private System.Windows.Forms.Panel pnl_img_inventario;
    }
}