namespace Kelotitos
{
    partial class Elegir
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
            this.components = new System.ComponentModel.Container();
            this.lblRegProducto = new System.Windows.Forms.Label();
            this.lbhora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.lblRegCompra = new System.Windows.Forms.Label();
            this.lblRegProveedor = new System.Windows.Forms.Label();
            this.lblRegistrarVenta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRegInventario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRegProducto
            // 
            this.lblRegProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRegProducto.AutoSize = true;
            this.lblRegProducto.BackColor = System.Drawing.Color.Transparent;
            this.lblRegProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(109)))));
            this.lblRegProducto.Location = new System.Drawing.Point(68, 69);
            this.lblRegProducto.Name = "lblRegProducto";
            this.lblRegProducto.Size = new System.Drawing.Size(365, 46);
            this.lblRegProducto.TabIndex = 17;
            this.lblRegProducto.Text = "Registrar Producto ";
            this.lblRegProducto.Click += new System.EventHandler(this.lblRegProducto_Click);
            // 
            // lbhora
            // 
            this.lbhora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbhora.AutoSize = true;
            this.lbhora.BackColor = System.Drawing.Color.Transparent;
            this.lbhora.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbhora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(194)))), ((int)(((byte)(149)))));
            this.lbhora.Location = new System.Drawing.Point(12, 9);
            this.lbhora.Name = "lbhora";
            this.lbhora.Size = new System.Drawing.Size(93, 31);
            this.lbhora.TabIndex = 27;
            this.lbhora.Text = "HORA";
            this.lbhora.Click += new System.EventHandler(this.Lbhora_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCerrarSesion.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(109)))));
            this.btnCerrarSesion.Location = new System.Drawing.Point(198, 398);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(217, 52);
            this.btnCerrarSesion.TabIndex = 29;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // lblRegCompra
            // 
            this.lblRegCompra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRegCompra.AutoSize = true;
            this.lblRegCompra.BackColor = System.Drawing.Color.Transparent;
            this.lblRegCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegCompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(109)))));
            this.lblRegCompra.Location = new System.Drawing.Point(68, 185);
            this.lblRegCompra.Name = "lblRegCompra";
            this.lblRegCompra.Size = new System.Drawing.Size(345, 46);
            this.lblRegCompra.TabIndex = 30;
            this.lblRegCompra.Text = "Registrar Compra ";
            this.lblRegCompra.Click += new System.EventHandler(this.lblRegCompra_Click);
            // 
            // lblRegProveedor
            // 
            this.lblRegProveedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRegProveedor.AutoSize = true;
            this.lblRegProveedor.BackColor = System.Drawing.Color.Transparent;
            this.lblRegProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(109)))));
            this.lblRegProveedor.Location = new System.Drawing.Point(68, 248);
            this.lblRegProveedor.Name = "lblRegProveedor";
            this.lblRegProveedor.Size = new System.Drawing.Size(387, 46);
            this.lblRegProveedor.TabIndex = 31;
            this.lblRegProveedor.Text = "Registrar Proveedor ";
            this.lblRegProveedor.Click += new System.EventHandler(this.lblRegProveedor_Click);
            // 
            // lblRegistrarVenta
            // 
            this.lblRegistrarVenta.AutoSize = true;
            this.lblRegistrarVenta.BackColor = System.Drawing.Color.Transparent;
            this.lblRegistrarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblRegistrarVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(109)))));
            this.lblRegistrarVenta.Location = new System.Drawing.Point(68, 305);
            this.lblRegistrarVenta.Name = "lblRegistrarVenta";
            this.lblRegistrarVenta.Size = new System.Drawing.Size(307, 46);
            this.lblRegistrarVenta.TabIndex = 32;
            this.lblRegistrarVenta.Text = "Registrar Venta ";
            this.lblRegistrarVenta.Click += new System.EventHandler(this.lblRegistrarVenta_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 33;
            // 
            // lblRegInventario
            // 
            this.lblRegInventario.AutoSize = true;
            this.lblRegInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblRegInventario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(109)))));
            this.lblRegInventario.Location = new System.Drawing.Point(68, 129);
            this.lblRegInventario.Name = "lblRegInventario";
            this.lblRegInventario.Size = new System.Drawing.Size(365, 46);
            this.lblRegInventario.TabIndex = 34;
            this.lblRegInventario.Text = "Registrar Inventario";
            this.lblRegInventario.Click += new System.EventHandler(this.lblRegInventario_Click);
            // 
            // Elegir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(649, 495);
            this.Controls.Add(this.lblRegInventario);
            this.Controls.Add(this.lblRegistrarVenta);
            this.Controls.Add(this.lblRegProveedor);
            this.Controls.Add(this.lblRegCompra);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.lbhora);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRegProducto);
            this.Name = "Elegir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elegir";
            this.Load += new System.EventHandler(this.Elegir_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegProducto;
        private System.Windows.Forms.Label lbhora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Label lblRegCompra;
        private System.Windows.Forms.Label lblRegProveedor;
        private System.Windows.Forms.Label lblRegistrarVenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRegInventario;
    }
}