namespace Kelotitos
{
    partial class PedidosEnLinea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PedidosEnLinea));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbhora = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnPendiente = new System.Windows.Forms.Button();
            this.btnRealizado = new System.Windows.Forms.Button();
            this.lblTamanio = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::Kelotitos.Properties.Resources.kelotitos6;
            this.pictureBox1.Location = new System.Drawing.Point(263, 46);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(544, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbhora
            // 
            this.lbhora.AutoSize = true;
            this.lbhora.BackColor = System.Drawing.Color.Transparent;
            this.lbhora.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbhora.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbhora.Location = new System.Drawing.Point(527, 11);
            this.lbhora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbhora.Name = "lbhora";
            this.lbhora.Size = new System.Drawing.Size(96, 32);
            this.lbhora.TabIndex = 28;
            this.lbhora.Text = "HORA";
            this.lbhora.Click += new System.EventHandler(this.lbhora_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(298, 197);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(465, 59);
            this.label1.TabIndex = 38;
            this.label1.Text = "Pedidos en Línea";
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegresar.Image = global::Kelotitos.Properties.Resources.flecha_pequeña;
            this.btnRegresar.Location = new System.Drawing.Point(32, 15);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(56, 48);
            this.btnRegresar.TabIndex = 39;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Location = new System.Drawing.Point(21, 259);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.RowHeadersWidth = 51;
            this.dgvPedidos.RowTemplate.Height = 24;
            this.dgvPedidos.Size = new System.Drawing.Size(1028, 271);
            this.dgvPedidos.TabIndex = 40;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnPendiente
            // 
            this.btnPendiente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPendiente.ForeColor = System.Drawing.Color.Black;
            this.btnPendiente.Location = new System.Drawing.Point(463, 537);
            this.btnPendiente.Margin = new System.Windows.Forms.Padding(4);
            this.btnPendiente.Name = "btnPendiente";
            this.btnPendiente.Size = new System.Drawing.Size(284, 38);
            this.btnPendiente.TabIndex = 66;
            this.btnPendiente.Text = "Marcar Estatus Como Pendiente";
            this.btnPendiente.UseVisualStyleBackColor = false;
            this.btnPendiente.Click += new System.EventHandler(this.btnPendiente_Click);
            // 
            // btnRealizado
            // 
            this.btnRealizado.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRealizado.ForeColor = System.Drawing.Color.Black;
            this.btnRealizado.Location = new System.Drawing.Point(765, 537);
            this.btnRealizado.Margin = new System.Windows.Forms.Padding(4);
            this.btnRealizado.Name = "btnRealizado";
            this.btnRealizado.Size = new System.Drawing.Size(284, 38);
            this.btnRealizado.TabIndex = 67;
            this.btnRealizado.Text = "Marcar Estatus Como Realizado";
            this.btnRealizado.UseVisualStyleBackColor = false;
            this.btnRealizado.Click += new System.EventHandler(this.btnRealizado_Click);
            // 
            // lblTamanio
            // 
            this.lblTamanio.AutoSize = true;
            this.lblTamanio.Location = new System.Drawing.Point(839, 231);
            this.lblTamanio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTamanio.Name = "lblTamanio";
            this.lblTamanio.Size = new System.Drawing.Size(96, 17);
            this.lblTamanio.TabIndex = 68;
            this.lblTamanio.Text = "Pendiente = 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(954, 231);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 69;
            this.label2.Text = "Realizado = 0";
            // 
            // PedidosEnLinea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kelotitos.Properties.Resources.elotes_verdes;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1077, 599);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTamanio);
            this.Controls.Add(this.btnRealizado);
            this.Controls.Add(this.btnPendiente);
            this.Controls.Add(this.dgvPedidos);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbhora);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PedidosEnLinea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PedidosEnLinea";
            this.Load += new System.EventHandler(this.PedidosEnLinea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbhora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnPendiente;
        private System.Windows.Forms.Button btnRealizado;
        private System.Windows.Forms.Label lblTamanio;
        private System.Windows.Forms.Label label2;
    }
}