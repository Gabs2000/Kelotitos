namespace Kelotitos
{
    partial class RegistrarCatalogos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNomTam = new System.Windows.Forms.TextBox();
            this.btnAgrTamanio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAgrTipo = new System.Windows.Forms.Button();
            this.chbDifTamanio = new System.Windows.Forms.CheckBox();
            this.txtNomTipo = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.Controls.Add(this.txtNomTam);
            this.groupBox1.Controls.Add(this.btnAgrTamanio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(105, 358);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 227);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Tamaños";
            // 
            // txtNomTam
            // 
            this.txtNomTam.Location = new System.Drawing.Point(50, 90);
            this.txtNomTam.Name = "txtNomTam";
            this.txtNomTam.Size = new System.Drawing.Size(227, 29);
            this.txtNomTam.TabIndex = 1;
            // 
            // btnAgrTamanio
            // 
            this.btnAgrTamanio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgrTamanio.Location = new System.Drawing.Point(68, 136);
            this.btnAgrTamanio.Name = "btnAgrTamanio";
            this.btnAgrTamanio.Size = new System.Drawing.Size(187, 38);
            this.btnAgrTamanio.TabIndex = 3;
            this.btnAgrTamanio.Text = "Agregar Tamaño";
            this.btnAgrTamanio.UseVisualStyleBackColor = true;
            this.btnAgrTamanio.Click += new System.EventHandler(this.btnAgrTamanio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Tamaño";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox2.Controls.Add(this.btnAgrTipo);
            this.groupBox2.Controls.Add(this.chbDifTamanio);
            this.groupBox2.Controls.Add(this.txtNomTipo);
            this.groupBox2.Controls.Add(this.lblTipo);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(519, 358);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 227);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agregar Tipos Productos";
            // 
            // btnAgrTipo
            // 
            this.btnAgrTipo.Location = new System.Drawing.Point(69, 150);
            this.btnAgrTipo.Name = "btnAgrTipo";
            this.btnAgrTipo.Size = new System.Drawing.Size(187, 38);
            this.btnAgrTipo.TabIndex = 4;
            this.btnAgrTipo.Text = "Agregar Tipo Producto";
            this.btnAgrTipo.UseVisualStyleBackColor = true;
            this.btnAgrTipo.Click += new System.EventHandler(this.btnAgrTipo_Click);
            // 
            // chbDifTamanio
            // 
            this.chbDifTamanio.AutoSize = true;
            this.chbDifTamanio.Location = new System.Drawing.Point(35, 116);
            this.chbDifTamanio.Name = "chbDifTamanio";
            this.chbDifTamanio.Size = new System.Drawing.Size(261, 28);
            this.chbDifTamanio.TabIndex = 3;
            this.chbDifTamanio.Text = "¿Tiene diferentes tamaños?";
            this.chbDifTamanio.UseVisualStyleBackColor = true;
            // 
            // txtNomTipo
            // 
            this.txtNomTipo.Location = new System.Drawing.Point(48, 81);
            this.txtNomTipo.Name = "txtNomTipo";
            this.txtNomTipo.Size = new System.Drawing.Size(237, 29);
            this.txtNomTipo.TabIndex = 1;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(65, 53);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(203, 24);
            this.lblTipo.TabIndex = 0;
            this.lblTipo.Text = "Nombre Tipo Producto";
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegresar.Image = global::Kelotitos.Properties.Resources.flecha_pequeña;
            this.btnRegresar.Location = new System.Drawing.Point(24, 12);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(42, 39);
            this.btnRegresar.TabIndex = 2;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Kelotitos.Properties.Resources.kelotitos6;
            this.pictureBox1.Location = new System.Drawing.Point(77, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(536, 144);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(67, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(487, 56);
            this.label2.TabIndex = 4;
            this.label2.Text = "Registrar Catálogo";
            // 
            // RegistrarCatalogos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kelotitos.Properties.Resources.elotes_verdes;
            this.ClientSize = new System.Drawing.Size(953, 749);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "RegistrarCatalogos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrarCatalogos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnAgrTamanio;
        private System.Windows.Forms.Button btnAgrTipo;
        private System.Windows.Forms.TextBox txtNomTam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.CheckBox chbDifTamanio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}