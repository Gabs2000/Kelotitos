
namespace Kelotitos
{
    partial class MenuReportes
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbRegresar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVentas = new System.Windows.Forms.Label();
            this.lblCompras = new System.Windows.Forms.Label();
            this.lblProductos = new System.Windows.Forms.Label();
            this.lblInventario = new System.Windows.Forms.Label();
            this.lblProveedores = new System.Windows.Forms.Label();
            this.lblEmpleados = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegresar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Kelotitos.Properties.Resources.kelotitos6;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(108, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(366, 85);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pbRegresar
            // 
            this.pbRegresar.BackgroundImage = global::Kelotitos.Properties.Resources.flecha_pequeña;
            this.pbRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbRegresar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbRegresar.Location = new System.Drawing.Point(12, 12);
            this.pbRegresar.Name = "pbRegresar";
            this.pbRegresar.Size = new System.Drawing.Size(46, 42);
            this.pbRegresar.TabIndex = 1;
            this.pbRegresar.TabStop = false;
            this.pbRegresar.Click += new System.EventHandler(this.pbRegresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 30F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(191, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 47);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reportes";
            // 
            // lblVentas
            // 
            this.lblVentas.AutoSize = true;
            this.lblVentas.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblVentas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVentas.Font = new System.Drawing.Font("Bookman Old Style", 18F);
            this.lblVentas.Location = new System.Drawing.Point(32, 194);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(194, 29);
            this.lblVentas.TabIndex = 3;
            this.lblVentas.Text = "Reporte Ventas";
            this.lblVentas.Click += new System.EventHandler(this.lblVentas_Click);
            // 
            // lblCompras
            // 
            this.lblCompras.AutoSize = true;
            this.lblCompras.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblCompras.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCompras.Font = new System.Drawing.Font("Bookman Old Style", 18F);
            this.lblCompras.Location = new System.Drawing.Point(308, 194);
            this.lblCompras.Name = "lblCompras";
            this.lblCompras.Size = new System.Drawing.Size(219, 29);
            this.lblCompras.TabIndex = 4;
            this.lblCompras.Text = "Reporte Compras";
            this.lblCompras.Click += new System.EventHandler(this.lblCompras_Click);
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblProductos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblProductos.Font = new System.Drawing.Font("Bookman Old Style", 18F);
            this.lblProductos.Location = new System.Drawing.Point(32, 241);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(229, 29);
            this.lblProductos.TabIndex = 5;
            this.lblProductos.Text = "Reporte Productos";
            this.lblProductos.Click += new System.EventHandler(this.lblProductos_Click);
            // 
            // lblInventario
            // 
            this.lblInventario.AutoSize = true;
            this.lblInventario.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblInventario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInventario.Font = new System.Drawing.Font("Bookman Old Style", 18F);
            this.lblInventario.Location = new System.Drawing.Point(308, 241);
            this.lblInventario.Name = "lblInventario";
            this.lblInventario.Size = new System.Drawing.Size(233, 29);
            this.lblInventario.TabIndex = 6;
            this.lblInventario.Text = "Reporte Inventario";
            this.lblInventario.Click += new System.EventHandler(this.lblInventario_Click);
            // 
            // lblProveedores
            // 
            this.lblProveedores.AutoSize = true;
            this.lblProveedores.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblProveedores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblProveedores.Font = new System.Drawing.Font("Bookman Old Style", 18F);
            this.lblProveedores.Location = new System.Drawing.Point(32, 290);
            this.lblProveedores.Name = "lblProveedores";
            this.lblProveedores.Size = new System.Drawing.Size(254, 29);
            this.lblProveedores.TabIndex = 7;
            this.lblProveedores.Text = "Reporte Proveedores";
            this.lblProveedores.Click += new System.EventHandler(this.lblProveedores_Click);
            // 
            // lblEmpleados
            // 
            this.lblEmpleados.AutoSize = true;
            this.lblEmpleados.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEmpleados.Font = new System.Drawing.Font("Bookman Old Style", 18F);
            this.lblEmpleados.Location = new System.Drawing.Point(308, 290);
            this.lblEmpleados.Name = "lblEmpleados";
            this.lblEmpleados.Size = new System.Drawing.Size(241, 29);
            this.lblEmpleados.TabIndex = 8;
            this.lblEmpleados.Text = "Reporte Empleados";
            this.lblEmpleados.Click += new System.EventHandler(this.lblEmpleados_Click);
            // 
            // MenuReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kelotitos.Properties.Resources.elotes_verdes;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(590, 378);
            this.Controls.Add(this.lblEmpleados);
            this.Controls.Add(this.lblProveedores);
            this.Controls.Add(this.lblInventario);
            this.Controls.Add(this.lblProductos);
            this.Controls.Add(this.lblCompras);
            this.Controls.Add(this.lblVentas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbRegresar);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "MenuReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Reportes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegresar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbRegresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVentas;
        private System.Windows.Forms.Label lblCompras;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.Label lblInventario;
        private System.Windows.Forms.Label lblProveedores;
        private System.Windows.Forms.Label lblEmpleados;
    }
}