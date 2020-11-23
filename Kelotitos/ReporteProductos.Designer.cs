
namespace Kelotitos
{
    partial class ReporteProductos
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
            this.pcRegresar = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgwRepProd = new System.Windows.Forms.DataGridView();
            this.btnPDF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcRegresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRepProd)).BeginInit();
            this.SuspendLayout();
            // 
            // pcRegresar
            // 
            this.pcRegresar.BackgroundImage = global::Kelotitos.Properties.Resources.flecha_pequeña;
            this.pcRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcRegresar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcRegresar.Location = new System.Drawing.Point(12, 12);
            this.pcRegresar.Name = "pcRegresar";
            this.pcRegresar.Size = new System.Drawing.Size(54, 46);
            this.pcRegresar.TabIndex = 0;
            this.pcRegresar.TabStop = false;
            this.pcRegresar.Click += new System.EventHandler(this.pcRegresar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::Kelotitos.Properties.Resources.kelotitos6;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(98, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(312, 81);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 30F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(54, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 47);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reporte Productos";
            // 
            // dgwRepProd
            // 
            this.dgwRepProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwRepProd.Location = new System.Drawing.Point(76, 171);
            this.dgwRepProd.Name = "dgwRepProd";
            this.dgwRepProd.Size = new System.Drawing.Size(370, 237);
            this.dgwRepProd.TabIndex = 3;
            // 
            // btnPDF
            // 
            this.btnPDF.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPDF.Location = new System.Drawing.Point(206, 431);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(110, 32);
            this.btnPDF.TabIndex = 4;
            this.btnPDF.Text = "Crear PDF";
            this.btnPDF.UseVisualStyleBackColor = false;
            // 
            // ReporteProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kelotitos.Properties.Resources.elotes_verdes;
            this.ClientSize = new System.Drawing.Size(512, 475);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.dgwRepProd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pcRegresar);
            this.Name = "ReporteProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Productos";
            this.Load += new System.EventHandler(this.ReporteProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcRegresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRepProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcRegresar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgwRepProd;
        private System.Windows.Forms.Button btnPDF;
    }
}