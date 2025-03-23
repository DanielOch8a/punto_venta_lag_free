namespace Presentacion
{
    partial class frm_ventana_principal
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
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarios_menu_item = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_logo = new System.Windows.Forms.Panel();
            this.lbl_no_factura = new System.Windows.Forms.Label();
            this.lbl_cliente = new System.Windows.Forms.Label();
            this.lbl_codigo_cliente = new System.Windows.Forms.Label();
            this.lbl_imp_venta = new System.Windows.Forms.Label();
            this.lbl_descuento = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_codigo_producto = new System.Windows.Forms.Label();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.txt_codigo_cliente = new System.Windows.Forms.TextBox();
            this.txt_no_factura = new System.Windows.Forms.TextBox();
            this.txt_cliente = new System.Windows.Forms.TextBox();
            this.txt_imp_venta = new System.Windows.Forms.TextBox();
            this.txt_descuento = new System.Windows.Forms.TextBox();
            this.txt_codigo_producto = new System.Windows.Forms.TextBox();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.btn_buscar_cliente = new System.Windows.Forms.Button();
            this.btn_agregar_producto = new System.Windows.Forms.Button();
            this.btn_generar_factura = new System.Windows.Forms.Button();
            this.lbl_simbolo_porcentaje1 = new System.Windows.Forms.Label();
            this.lbl_simbolo_porcentaje2 = new System.Windows.Forms.Label();
            this.lbl_subtotal_numerico = new System.Windows.Forms.Label();
            this.gbx_subtotal = new System.Windows.Forms.GroupBox();
            this.lbl_total_numerico = new System.Windows.Forms.Label();
            this.dgv_productos = new System.Windows.Forms.DataGridView();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.gbx_subtotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(778, 479);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(118, 45);
            this.btn_cerrar.TabIndex = 0;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.usuarios_menu_item,
            this.inventarioToolStripMenuItem,
            this.clientesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(916, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(73, 26);
            this.toolStripMenuItem1.Text = "Archivo";
            // 
            // usuarios_menu_item
            // 
            this.usuarios_menu_item.Name = "usuarios_menu_item";
            this.usuarios_menu_item.Size = new System.Drawing.Size(79, 26);
            this.usuarios_menu_item.Text = "Usuarios";
            this.usuarios_menu_item.Click += new System.EventHandler(this.usuarios_menu_item_Click);
            // 
            // pnl_logo
            // 
            this.pnl_logo.BackgroundImage = global::Presentacion.Properties.Resources.logo_protosoft;
            this.pnl_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_logo.Location = new System.Drawing.Point(12, 31);
            this.pnl_logo.Name = "pnl_logo";
            this.pnl_logo.Size = new System.Drawing.Size(144, 118);
            this.pnl_logo.TabIndex = 2;
            // 
            // lbl_no_factura
            // 
            this.lbl_no_factura.AutoSize = true;
            this.lbl_no_factura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_no_factura.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_no_factura.Location = new System.Drawing.Point(175, 37);
            this.lbl_no_factura.Name = "lbl_no_factura";
            this.lbl_no_factura.Size = new System.Drawing.Size(119, 25);
            this.lbl_no_factura.TabIndex = 3;
            this.lbl_no_factura.Text = "No. Factura:";
            // 
            // lbl_cliente
            // 
            this.lbl_cliente.AutoSize = true;
            this.lbl_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_cliente.Location = new System.Drawing.Point(400, 37);
            this.lbl_cliente.Name = "lbl_cliente";
            this.lbl_cliente.Size = new System.Drawing.Size(79, 25);
            this.lbl_cliente.TabIndex = 4;
            this.lbl_cliente.Text = "Cliente:";
            // 
            // lbl_codigo_cliente
            // 
            this.lbl_codigo_cliente.AutoSize = true;
            this.lbl_codigo_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo_cliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_codigo_cliente.Location = new System.Drawing.Point(15, 165);
            this.lbl_codigo_cliente.Name = "lbl_codigo_cliente";
            this.lbl_codigo_cliente.Size = new System.Drawing.Size(141, 25);
            this.lbl_codigo_cliente.TabIndex = 5;
            this.lbl_codigo_cliente.Text = "Codigo Cliente";
            // 
            // lbl_imp_venta
            // 
            this.lbl_imp_venta.AutoSize = true;
            this.lbl_imp_venta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_imp_venta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_imp_venta.Location = new System.Drawing.Point(131, 41);
            this.lbl_imp_venta.Name = "lbl_imp_venta";
            this.lbl_imp_venta.Size = new System.Drawing.Size(95, 22);
            this.lbl_imp_venta.TabIndex = 6;
            this.lbl_imp_venta.Text = "Imp. Venta";
            // 
            // lbl_descuento
            // 
            this.lbl_descuento.AutoSize = true;
            this.lbl_descuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descuento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_descuento.Location = new System.Drawing.Point(131, 78);
            this.lbl_descuento.Name = "lbl_descuento";
            this.lbl_descuento.Size = new System.Drawing.Size(96, 22);
            this.lbl_descuento.TabIndex = 7;
            this.lbl_descuento.Text = "Descuento";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_total.Location = new System.Drawing.Point(210, 451);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(102, 39);
            this.lbl_total.TabIndex = 8;
            this.lbl_total.Text = "Total:";
            // 
            // lbl_codigo_producto
            // 
            this.lbl_codigo_producto.AutoSize = true;
            this.lbl_codigo_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo_producto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_codigo_producto.Location = new System.Drawing.Point(558, 305);
            this.lbl_codigo_producto.Name = "lbl_codigo_producto";
            this.lbl_codigo_producto.Size = new System.Drawing.Size(183, 25);
            this.lbl_codigo_producto.TabIndex = 9;
            this.lbl_codigo_producto.Text = "Codigo de producto";
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_cantidad.Location = new System.Drawing.Point(558, 382);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(91, 25);
            this.lbl_cantidad.TabIndex = 10;
            this.lbl_cantidad.Text = "Cantidad";
            // 
            // txt_codigo_cliente
            // 
            this.txt_codigo_cliente.Location = new System.Drawing.Point(13, 193);
            this.txt_codigo_cliente.Name = "txt_codigo_cliente";
            this.txt_codigo_cliente.Size = new System.Drawing.Size(143, 38);
            this.txt_codigo_cliente.TabIndex = 11;
            // 
            // txt_no_factura
            // 
            this.txt_no_factura.Location = new System.Drawing.Point(294, 31);
            this.txt_no_factura.Name = "txt_no_factura";
            this.txt_no_factura.Size = new System.Drawing.Size(82, 38);
            this.txt_no_factura.TabIndex = 12;
            // 
            // txt_cliente
            // 
            this.txt_cliente.Location = new System.Drawing.Point(479, 31);
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.Size = new System.Drawing.Size(413, 38);
            this.txt_cliente.TabIndex = 13;
            // 
            // txt_imp_venta
            // 
            this.txt_imp_venta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_imp_venta.Location = new System.Drawing.Point(229, 41);
            this.txt_imp_venta.Name = "txt_imp_venta";
            this.txt_imp_venta.Size = new System.Drawing.Size(58, 28);
            this.txt_imp_venta.TabIndex = 14;
            // 
            // txt_descuento
            // 
            this.txt_descuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descuento.Location = new System.Drawing.Point(229, 75);
            this.txt_descuento.Name = "txt_descuento";
            this.txt_descuento.Size = new System.Drawing.Size(58, 28);
            this.txt_descuento.TabIndex = 15;
            // 
            // txt_codigo_producto
            // 
            this.txt_codigo_producto.Location = new System.Drawing.Point(563, 333);
            this.txt_codigo_producto.Name = "txt_codigo_producto";
            this.txt_codigo_producto.Size = new System.Drawing.Size(178, 38);
            this.txt_codigo_producto.TabIndex = 16;
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(563, 410);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(86, 38);
            this.txt_cantidad.TabIndex = 17;
            // 
            // btn_buscar_cliente
            // 
            this.btn_buscar_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar_cliente.Location = new System.Drawing.Point(31, 237);
            this.btn_buscar_cliente.Name = "btn_buscar_cliente";
            this.btn_buscar_cliente.Size = new System.Drawing.Size(112, 45);
            this.btn_buscar_cliente.TabIndex = 18;
            this.btn_buscar_cliente.Text = "Buscar";
            this.btn_buscar_cliente.UseVisualStyleBackColor = true;
            // 
            // btn_agregar_producto
            // 
            this.btn_agregar_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar_producto.Location = new System.Drawing.Point(563, 451);
            this.btn_agregar_producto.Name = "btn_agregar_producto";
            this.btn_agregar_producto.Size = new System.Drawing.Size(175, 73);
            this.btn_agregar_producto.TabIndex = 19;
            this.btn_agregar_producto.Text = "Agregar Producto";
            this.btn_agregar_producto.UseVisualStyleBackColor = true;
            // 
            // btn_generar_factura
            // 
            this.btn_generar_factura.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generar_factura.Location = new System.Drawing.Point(778, 348);
            this.btn_generar_factura.Name = "btn_generar_factura";
            this.btn_generar_factura.Size = new System.Drawing.Size(114, 90);
            this.btn_generar_factura.TabIndex = 20;
            this.btn_generar_factura.Text = "Generar Factura";
            this.btn_generar_factura.UseVisualStyleBackColor = true;
            // 
            // lbl_simbolo_porcentaje1
            // 
            this.lbl_simbolo_porcentaje1.AutoSize = true;
            this.lbl_simbolo_porcentaje1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_simbolo_porcentaje1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_simbolo_porcentaje1.Location = new System.Drawing.Point(293, 44);
            this.lbl_simbolo_porcentaje1.Name = "lbl_simbolo_porcentaje1";
            this.lbl_simbolo_porcentaje1.Size = new System.Drawing.Size(26, 22);
            this.lbl_simbolo_porcentaje1.TabIndex = 21;
            this.lbl_simbolo_porcentaje1.Text = "%";
            // 
            // lbl_simbolo_porcentaje2
            // 
            this.lbl_simbolo_porcentaje2.AutoSize = true;
            this.lbl_simbolo_porcentaje2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_simbolo_porcentaje2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_simbolo_porcentaje2.Location = new System.Drawing.Point(293, 78);
            this.lbl_simbolo_porcentaje2.Name = "lbl_simbolo_porcentaje2";
            this.lbl_simbolo_porcentaje2.Size = new System.Drawing.Size(26, 22);
            this.lbl_simbolo_porcentaje2.TabIndex = 22;
            this.lbl_simbolo_porcentaje2.Text = "%";
            // 
            // lbl_subtotal_numerico
            // 
            this.lbl_subtotal_numerico.AutoSize = true;
            this.lbl_subtotal_numerico.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subtotal_numerico.Location = new System.Drawing.Point(11, 44);
            this.lbl_subtotal_numerico.Name = "lbl_subtotal_numerico";
            this.lbl_subtotal_numerico.Size = new System.Drawing.Size(114, 54);
            this.lbl_subtotal_numerico.TabIndex = 23;
            this.lbl_subtotal_numerico.Text = "0.00";
            // 
            // gbx_subtotal
            // 
            this.gbx_subtotal.Controls.Add(this.lbl_subtotal_numerico);
            this.gbx_subtotal.Controls.Add(this.lbl_simbolo_porcentaje2);
            this.gbx_subtotal.Controls.Add(this.txt_descuento);
            this.gbx_subtotal.Controls.Add(this.lbl_simbolo_porcentaje1);
            this.gbx_subtotal.Controls.Add(this.lbl_imp_venta);
            this.gbx_subtotal.Controls.Add(this.lbl_descuento);
            this.gbx_subtotal.Controls.Add(this.txt_imp_venta);
            this.gbx_subtotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbx_subtotal.Location = new System.Drawing.Point(180, 309);
            this.gbx_subtotal.Name = "gbx_subtotal";
            this.gbx_subtotal.Size = new System.Drawing.Size(341, 126);
            this.gbx_subtotal.TabIndex = 24;
            this.gbx_subtotal.TabStop = false;
            this.gbx_subtotal.Text = "Subtotal";
            // 
            // lbl_total_numerico
            // 
            this.lbl_total_numerico.AutoSize = true;
            this.lbl_total_numerico.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_numerico.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_total_numerico.Location = new System.Drawing.Point(302, 438);
            this.lbl_total_numerico.Name = "lbl_total_numerico";
            this.lbl_total_numerico.Size = new System.Drawing.Size(193, 91);
            this.lbl_total_numerico.TabIndex = 24;
            this.lbl_total_numerico.Text = "0.00";
            // 
            // dgv_productos
            // 
            this.dgv_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_productos.Location = new System.Drawing.Point(180, 77);
            this.dgv_productos.Name = "dgv_productos";
            this.dgv_productos.RowHeadersWidth = 51;
            this.dgv_productos.RowTemplate.Height = 24;
            this.dgv_productos.Size = new System.Drawing.Size(712, 214);
            this.dgv_productos.TabIndex = 25;
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(89, 26);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(75, 26);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // frm_ventana_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(916, 536);
            this.Controls.Add(this.dgv_productos);
            this.Controls.Add(this.lbl_total_numerico);
            this.Controls.Add(this.gbx_subtotal);
            this.Controls.Add(this.btn_generar_factura);
            this.Controls.Add(this.btn_agregar_producto);
            this.Controls.Add(this.btn_buscar_cliente);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.txt_codigo_producto);
            this.Controls.Add(this.txt_cliente);
            this.Controls.Add(this.txt_no_factura);
            this.Controls.Add(this.txt_codigo_cliente);
            this.Controls.Add(this.lbl_cantidad);
            this.Controls.Add(this.lbl_codigo_producto);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lbl_codigo_cliente);
            this.Controls.Add(this.lbl_cliente);
            this.Controls.Add(this.lbl_no_factura);
            this.Controls.Add(this.pnl_logo);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "frm_ventana_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventana Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbx_subtotal.ResumeLayout(false);
            this.gbx_subtotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem usuarios_menu_item;
        private System.Windows.Forms.Panel pnl_logo;
        private System.Windows.Forms.Label lbl_no_factura;
        private System.Windows.Forms.Label lbl_cliente;
        private System.Windows.Forms.Label lbl_codigo_cliente;
        private System.Windows.Forms.Label lbl_imp_venta;
        private System.Windows.Forms.Label lbl_descuento;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_codigo_producto;
        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.TextBox txt_codigo_cliente;
        private System.Windows.Forms.TextBox txt_no_factura;
        private System.Windows.Forms.TextBox txt_cliente;
        private System.Windows.Forms.TextBox txt_imp_venta;
        private System.Windows.Forms.TextBox txt_descuento;
        private System.Windows.Forms.TextBox txt_codigo_producto;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Button btn_buscar_cliente;
        private System.Windows.Forms.Button btn_agregar_producto;
        private System.Windows.Forms.Button btn_generar_factura;
        private System.Windows.Forms.Label lbl_simbolo_porcentaje1;
        private System.Windows.Forms.Label lbl_simbolo_porcentaje2;
        private System.Windows.Forms.Label lbl_subtotal_numerico;
        private System.Windows.Forms.GroupBox gbx_subtotal;
        private System.Windows.Forms.Label lbl_total_numerico;
        private System.Windows.Forms.DataGridView dgv_productos;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
    }
}