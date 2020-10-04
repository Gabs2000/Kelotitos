namespace Prueba
{
    partial class RegistrarProveedor
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabla = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nomprove = new System.Windows.Forms.TextBox();
            this.telprove = new System.Windows.Forms.TextBox();
            this.mailprove = new System.Windows.Forms.TextBox();
            this.dirprove = new System.Windows.Forms.TextBox();
            this.bcancelar = new System.Windows.Forms.Button();
            this.bregistrar = new System.Windows.Forms.Button();
            this.bregresar = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabla
            // 
            this.tabla.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.tabla.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.tabla.GridLines = true;
            this.tabla.HideSelection = false;
            this.tabla.Location = new System.Drawing.Point(49, 294);
            this.tabla.Name = "tabla";
            this.tabla.Size = new System.Drawing.Size(804, 154);
            this.tabla.TabIndex = 1;
            this.tabla.UseCompatibleStateImageBehavior = false;
            this.tabla.View = System.Windows.Forms.View.Details;
            this.tabla.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dirprove);
            this.groupBox1.Controls.Add(this.mailprove);
            this.groupBox1.Controls.Add(this.telprove);
            this.groupBox1.Controls.Add(this.nomprove);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(49, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(804, 204);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar proveedor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del proveedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(466, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dirección";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(466, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-mail";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Teléfono";
            // 
            // nomprove
            // 
            this.nomprove.Location = new System.Drawing.Point(39, 58);
            this.nomprove.Name = "nomprove";
            this.nomprove.Size = new System.Drawing.Size(288, 20);
            this.nomprove.TabIndex = 4;
            this.nomprove.TextChanged += new System.EventHandler(this.nomprove_TextChanged);
            // 
            // telprove
            // 
            this.telprove.Location = new System.Drawing.Point(39, 138);
            this.telprove.Name = "telprove";
            this.telprove.Size = new System.Drawing.Size(288, 20);
            this.telprove.TabIndex = 5;
            this.telprove.TextChanged += new System.EventHandler(this.telprove_TextChanged);
            // 
            // mailprove
            // 
            this.mailprove.Location = new System.Drawing.Point(469, 136);
            this.mailprove.Name = "mailprove";
            this.mailprove.Size = new System.Drawing.Size(288, 20);
            this.mailprove.TabIndex = 6;
            this.mailprove.TextChanged += new System.EventHandler(this.mailprove_TextChanged);
            // 
            // dirprove
            // 
            this.dirprove.Location = new System.Drawing.Point(469, 51);
            this.dirprove.Name = "dirprove";
            this.dirprove.Size = new System.Drawing.Size(288, 20);
            this.dirprove.TabIndex = 7;
            this.dirprove.TextChanged += new System.EventHandler(this.dirprove_TextChanged);
            // 
            // bcancelar
            // 
            this.bcancelar.Location = new System.Drawing.Point(88, 265);
            this.bcancelar.Name = "bcancelar";
            this.bcancelar.Size = new System.Drawing.Size(75, 23);
            this.bcancelar.TabIndex = 3;
            this.bcancelar.Text = "Cancelar";
            this.bcancelar.UseVisualStyleBackColor = true;
            this.bcancelar.Click += new System.EventHandler(this.bcancelar_Click);
            // 
            // bregistrar
            // 
            this.bregistrar.Location = new System.Drawing.Point(731, 265);
            this.bregistrar.Name = "bregistrar";
            this.bregistrar.Size = new System.Drawing.Size(75, 23);
            this.bregistrar.TabIndex = 4;
            this.bregistrar.Text = "Registrar";
            this.bregistrar.UseVisualStyleBackColor = true;
            this.bregistrar.Click += new System.EventHandler(this.bregistrar_Click);
            // 
            // bregresar
            // 
            this.bregresar.Location = new System.Drawing.Point(731, 463);
            this.bregresar.Name = "bregresar";
            this.bregresar.Size = new System.Drawing.Size(75, 23);
            this.bregresar.TabIndex = 5;
            this.bregresar.Text = "Regresar";
            this.bregresar.UseVisualStyleBackColor = true;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nombre del proveedor";
            this.columnHeader1.Width = 152;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Direccion";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 308;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Telefono";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 134;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "E-mail";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 203;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 498);
            this.Controls.Add(this.bregresar);
            this.Controls.Add(this.bregistrar);
            this.Controls.Add(this.bcancelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabla);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView tabla;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox dirprove;
        private System.Windows.Forms.TextBox mailprove;
        private System.Windows.Forms.TextBox telprove;
        private System.Windows.Forms.TextBox nomprove;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bcancelar;
        private System.Windows.Forms.Button bregistrar;
        private System.Windows.Forms.Button bregresar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}

