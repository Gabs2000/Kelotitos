
namespace Kelotitos
{
    partial class ReporteVentas
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
            this.pcRegresar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvRepVentas = new System.Windows.Forms.DataGridView();
            this.btnPDF = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbVendedor = new System.Windows.Forms.ComboBox();
            this.dtpFechaVenta = new System.Windows.Forms.DateTimePicker();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcRegresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Kelotitos.Properties.Resources.kelotitos6;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(132, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(335, 82);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pcRegresar
            // 
            this.pcRegresar.BackgroundImage = global::Kelotitos.Properties.Resources.flecha_pequeña;
            this.pcRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcRegresar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcRegresar.Location = new System.Drawing.Point(13, 13);
            this.pcRegresar.Name = "pcRegresar";
            this.pcRegresar.Size = new System.Drawing.Size(50, 44);
            this.pcRegresar.TabIndex = 1;
            this.pcRegresar.TabStop = false;
            this.pcRegresar.Click += new System.EventHandler(this.pcRegresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 30F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(129, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 47);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reporte Ventas";
            // 
            // dgvRepVentas
            // 
            this.dgvRepVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRepVentas.Location = new System.Drawing.Point(244, 163);
            this.dgvRepVentas.Name = "dgvRepVentas";
            this.dgvRepVentas.Size = new System.Drawing.Size(352, 230);
            this.dgvRepVentas.TabIndex = 3;
            // 
            // btnPDF
            // 
            this.btnPDF.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPDF.Location = new System.Drawing.Point(352, 411);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(159, 26);
            this.btnPDF.TabIndex = 4;
            this.btnPDF.Text = "Crear PDF";
            this.btnPDF.UseVisualStyleBackColor = false;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Vendedor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha Venta:";
            // 
            // cbVendedor
            // 
            this.cbVendedor.FormattingEnabled = true;
            this.cbVendedor.Location = new System.Drawing.Point(23, 244);
            this.cbVendedor.Name = "cbVendedor";
            this.cbVendedor.Size = new System.Drawing.Size(206, 21);
            this.cbVendedor.TabIndex = 7;
            // 
            // dtpFechaVenta
            // 
            this.dtpFechaVenta.CustomFormat = " ";
            this.dtpFechaVenta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaVenta.Location = new System.Drawing.Point(52, 311);
            this.dtpFechaVenta.Name = "dtpFechaVenta";
            this.dtpFechaVenta.Size = new System.Drawing.Size(144, 20);
            this.dtpFechaVenta.TabIndex = 8;
            this.dtpFechaVenta.ValueChanged += new System.EventHandler(this.dtpFechaVenta_ValueChanged);
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(73, 349);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(94, 27);
            this.btnGenerar.TabIndex = 9;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(32, 394);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(181, 27);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reestablecer Campos";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // ReporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kelotitos.Properties.Resources.elotes_verdes;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(608, 450);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.dtpFechaVenta);
            this.Controls.Add(this.cbVendedor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.dgvRepVentas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcRegresar);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "ReporteVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Ventas";
            this.Load += new System.EventHandler(this.ReporteVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcRegresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pcRegresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvRepVentas;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbVendedor;
        private System.Windows.Forms.DateTimePicker dtpFechaVenta;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnReset;
    }
}