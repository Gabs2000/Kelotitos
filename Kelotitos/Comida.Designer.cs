namespace Kelotitos
{
    partial class Comida
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
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lbhora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnRegresar = new System.Windows.Forms.Button();
            this.dgwCarrito = new System.Windows.Forms.DataGridView();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tamanio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.cbProducto = new System.Windows.Forms.ComboBox();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.cbTamanio = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblTamanio = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSumarCant = new System.Windows.Forms.Button();
            this.btnRestarCant = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCarrito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnConfirmar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(109)))));
            this.btnConfirmar.Location = new System.Drawing.Point(761, 540);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(126, 31);
            this.btnConfirmar.TabIndex = 12;
            this.btnConfirmar.Text = "Confirmar ";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lbhora
            // 
            this.lbhora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbhora.AutoSize = true;
            this.lbhora.BackColor = System.Drawing.Color.Transparent;
            this.lbhora.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbhora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(194)))), ((int)(((byte)(149)))));
            this.lbhora.Location = new System.Drawing.Point(-13, 9);
            this.lbhora.Name = "lbhora";
            this.lbhora.Size = new System.Drawing.Size(93, 31);
            this.lbhora.TabIndex = 30;
            this.lbhora.Text = "HORA";
            this.lbhora.Click += new System.EventHandler(this.Lbhora_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnRegresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(109)))));
            this.btnRegresar.Location = new System.Drawing.Point(12, 496);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(126, 31);
            this.btnRegresar.TabIndex = 31;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // dgwCarrito
            // 
            this.dgwCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCarrito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProducto,
            this.producto,
            this.descripcionProducto,
            this.Tamanio,
            this.precioProducto,
            this.cantidad,
            this.subtotal});
            this.dgwCarrito.Location = new System.Drawing.Point(14, 171);
            this.dgwCarrito.MultiSelect = false;
            this.dgwCarrito.Name = "dgwCarrito";
            this.dgwCarrito.RowHeadersWidth = 51;
            this.dgwCarrito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwCarrito.Size = new System.Drawing.Size(873, 319);
            this.dgwCarrito.TabIndex = 33;
            this.dgwCarrito.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgwCarrito_RowHeaderMouseClick);
            // 
            // idProducto
            // 
            this.idProducto.Frozen = true;
            this.idProducto.HeaderText = "ID";
            this.idProducto.MinimumWidth = 6;
            this.idProducto.Name = "idProducto";
            this.idProducto.ReadOnly = true;
            this.idProducto.Width = 50;
            // 
            // producto
            // 
            this.producto.Frozen = true;
            this.producto.HeaderText = "Producto";
            this.producto.MinimumWidth = 6;
            this.producto.Name = "producto";
            this.producto.ReadOnly = true;
            this.producto.Width = 250;
            // 
            // descripcionProducto
            // 
            this.descripcionProducto.Frozen = true;
            this.descripcionProducto.HeaderText = "Tipo";
            this.descripcionProducto.MinimumWidth = 6;
            this.descripcionProducto.Name = "descripcionProducto";
            this.descripcionProducto.ReadOnly = true;
            this.descripcionProducto.Width = 150;
            // 
            // Tamanio
            // 
            this.Tamanio.Frozen = true;
            this.Tamanio.HeaderText = "Tamaño";
            this.Tamanio.Name = "Tamanio";
            this.Tamanio.ReadOnly = true;
            // 
            // precioProducto
            // 
            this.precioProducto.Frozen = true;
            this.precioProducto.HeaderText = "Precio";
            this.precioProducto.MinimumWidth = 6;
            this.precioProducto.Name = "precioProducto";
            this.precioProducto.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.Frozen = true;
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.MinimumWidth = 6;
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.Width = 70;
            // 
            // subtotal
            // 
            this.subtotal.Frozen = true;
            this.subtotal.HeaderText = "Subtotal";
            this.subtotal.MinimumWidth = 6;
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(109)))));
            this.lblTotal.Location = new System.Drawing.Point(808, 500);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(82, 31);
            this.lblTotal.TabIndex = 51;
            this.lblTotal.Text = "$0.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(109)))));
            this.label6.Location = new System.Drawing.Point(692, 500);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 31);
            this.label6.TabIndex = 50;
            this.label6.Text = "TOTAL:";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(35, 54);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(50, 13);
            this.lblProducto.TabIndex = 53;
            this.lblProducto.Text = "Producto";
            // 
            // cbProducto
            // 
            this.cbProducto.FormattingEnabled = true;
            this.cbProducto.Location = new System.Drawing.Point(38, 71);
            this.cbProducto.Name = "cbProducto";
            this.cbProducto.Size = new System.Drawing.Size(205, 21);
            this.cbProducto.TabIndex = 54;
            this.cbProducto.SelectedIndexChanged += new System.EventHandler(this.cbProducto_SelectedIndexChanged);
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Location = new System.Drawing.Point(249, 71);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(221, 21);
            this.cbTipo.TabIndex = 55;
            this.cbTipo.SelectedIndexChanged += new System.EventHandler(this.cbTipo_SelectedIndexChanged);
            // 
            // cbTamanio
            // 
            this.cbTamanio.FormattingEnabled = true;
            this.cbTamanio.Location = new System.Drawing.Point(476, 71);
            this.cbTamanio.Name = "cbTamanio";
            this.cbTamanio.Size = new System.Drawing.Size(196, 21);
            this.cbTamanio.TabIndex = 56;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(249, 53);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 57;
            this.lblTipo.Text = "Tipo";
            // 
            // lblTamanio
            // 
            this.lblTamanio.AutoSize = true;
            this.lblTamanio.Location = new System.Drawing.Point(476, 53);
            this.lblTamanio.Name = "lblTamanio";
            this.lblTamanio.Size = new System.Drawing.Size(46, 13);
            this.lblTamanio.TabIndex = 58;
            this.lblTamanio.Text = "Tamaño";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(109)))));
            this.btnAgregar.Location = new System.Drawing.Point(775, 69);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 59;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // numCantidad
            // 
            this.numCantidad.Location = new System.Drawing.Point(679, 71);
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(80, 20);
            this.numCantidad.TabIndex = 60;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(679, 53);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 61;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(594, 9);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(40, 17);
            this.lblError.TabIndex = 62;
            this.lblError.Text = "Error";
            this.lblError.Visible = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(109)))));
            this.btnEliminar.Location = new System.Drawing.Point(761, 134);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(126, 31);
            this.btnEliminar.TabIndex = 63;
            this.btnEliminar.Text = "Eliminar Producto";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSumarCant
            // 
            this.btnSumarCant.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSumarCant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(109)))));
            this.btnSumarCant.Location = new System.Drawing.Point(497, 134);
            this.btnSumarCant.Name = "btnSumarCant";
            this.btnSumarCant.Size = new System.Drawing.Size(126, 31);
            this.btnSumarCant.TabIndex = 64;
            this.btnSumarCant.Text = "Sumar Cantidad";
            this.btnSumarCant.UseVisualStyleBackColor = false;
            this.btnSumarCant.Click += new System.EventHandler(this.btnSumarCant_Click);
            // 
            // btnRestarCant
            // 
            this.btnRestarCant.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRestarCant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(109)))));
            this.btnRestarCant.Location = new System.Drawing.Point(629, 134);
            this.btnRestarCant.Name = "btnRestarCant";
            this.btnRestarCant.Size = new System.Drawing.Size(126, 31);
            this.btnRestarCant.TabIndex = 65;
            this.btnRestarCant.Text = "Restar Cantidad";
            this.btnRestarCant.UseVisualStyleBackColor = false;
            this.btnRestarCant.Click += new System.EventHandler(this.btnRestarCant_Click);
            // 
            // Comida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(915, 592);
            this.Controls.Add(this.btnRestarCant);
            this.Controls.Add(this.btnSumarCant);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.numCantidad);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblTamanio);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.cbTamanio);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.cbProducto);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgwCarrito);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.lbhora);
            this.Controls.Add(this.btnConfirmar);
            this.Name = "Comida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comida";
            this.Load += new System.EventHandler(this.Comida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCarrito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lbhora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.DataGridView dgwCarrito;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.ComboBox cbProducto;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.ComboBox cbTamanio;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblTamanio;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tamanio;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSumarCant;
        private System.Windows.Forms.Button btnRestarCant;
    }
}