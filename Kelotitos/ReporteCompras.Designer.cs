
namespace Kelotitos
{
    partial class ReporteCompras
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
            ((System.ComponentModel.ISupportInitialize)(this.pcRegresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pcRegresar
            // 
            this.pcRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcRegresar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcRegresar.Image = global::Kelotitos.Properties.Resources.flecha_pequeña;
            this.pcRegresar.Location = new System.Drawing.Point(12, 12);
            this.pcRegresar.Name = "pcRegresar";
            this.pcRegresar.Size = new System.Drawing.Size(56, 47);
            this.pcRegresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcRegresar.TabIndex = 0;
            this.pcRegresar.TabStop = false;
            this.pcRegresar.Click += new System.EventHandler(this.pcRegresar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = global::Kelotitos.Properties.Resources.kelotitos6;
            this.pictureBox2.Location = new System.Drawing.Point(161, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(299, 79);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 30F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(113, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 47);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reportes Compras";
            // 
            // ReporteCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kelotitos.Properties.Resources.elotes_verdes;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(629, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pcRegresar);
            this.DoubleBuffered = true;
            this.Name = "ReporteCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Compras";
            ((System.ComponentModel.ISupportInitialize)(this.pcRegresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcRegresar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}