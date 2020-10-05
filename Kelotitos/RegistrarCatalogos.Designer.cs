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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnAgrTamanio = new System.Windows.Forms.Button();
            this.btnAgrTipo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomTam = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtNomTipo = new System.Windows.Forms.TextBox();
            this.chbDifTamanio = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNomTam);
            this.groupBox1.Controls.Add(this.btnAgrTamanio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(48, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 174);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Tamaños";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAgrTipo);
            this.groupBox2.Controls.Add(this.chbDifTamanio);
            this.groupBox2.Controls.Add(this.txtNomTipo);
            this.groupBox2.Controls.Add(this.lblTipo);
            this.groupBox2.Location = new System.Drawing.Point(365, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 174);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agregar Tipos Productos";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(12, 12);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 2;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnAgrTamanio
            // 
            this.btnAgrTamanio.Location = new System.Drawing.Point(62, 133);
            this.btnAgrTamanio.Name = "btnAgrTamanio";
            this.btnAgrTamanio.Size = new System.Drawing.Size(139, 23);
            this.btnAgrTamanio.TabIndex = 3;
            this.btnAgrTamanio.Text = "Agregar Tamaño";
            this.btnAgrTamanio.UseVisualStyleBackColor = true;
            this.btnAgrTamanio.Click += new System.EventHandler(this.btnAgrTamanio_Click);
            // 
            // btnAgrTipo
            // 
            this.btnAgrTipo.Location = new System.Drawing.Point(57, 133);
            this.btnAgrTipo.Name = "btnAgrTipo";
            this.btnAgrTipo.Size = new System.Drawing.Size(157, 23);
            this.btnAgrTipo.TabIndex = 4;
            this.btnAgrTipo.Text = "Agregar Tipo Producto";
            this.btnAgrTipo.UseVisualStyleBackColor = true;
            this.btnAgrTipo.Click += new System.EventHandler(this.btnAgrTipo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Tamaño";
            // 
            // txtNomTam
            // 
            this.txtNomTam.Location = new System.Drawing.Point(18, 58);
            this.txtNomTam.Name = "txtNomTam";
            this.txtNomTam.Size = new System.Drawing.Size(227, 20);
            this.txtNomTam.TabIndex = 1;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(31, 32);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(114, 13);
            this.lblTipo.TabIndex = 0;
            this.lblTipo.Text = "Nombre Tipo Producto";
            // 
            // txtNomTipo
            // 
            this.txtNomTipo.Location = new System.Drawing.Point(19, 58);
            this.txtNomTipo.Name = "txtNomTipo";
            this.txtNomTipo.Size = new System.Drawing.Size(237, 20);
            this.txtNomTipo.TabIndex = 1;
            // 
            // chbDifTamanio
            // 
            this.chbDifTamanio.AutoSize = true;
            this.chbDifTamanio.Location = new System.Drawing.Point(34, 97);
            this.chbDifTamanio.Name = "chbDifTamanio";
            this.chbDifTamanio.Size = new System.Drawing.Size(157, 17);
            this.chbDifTamanio.TabIndex = 3;
            this.chbDifTamanio.Text = "¿Tiene diferentes tamaños?";
            this.chbDifTamanio.UseVisualStyleBackColor = true;
            // 
            // RegistrarCatalogos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 291);
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
            this.ResumeLayout(false);

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
    }
}