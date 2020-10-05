namespace Kelotitos
{
    partial class TicketFinal
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.lbhora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnNuevaVenta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(109)))));
            this.label1.Location = new System.Drawing.Point(172, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 46);
            this.label1.TabIndex = 19;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(109)))));
            this.btnMenu.Location = new System.Drawing.Point(112, 188);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(126, 31);
            this.btnMenu.TabIndex = 21;
            this.btnMenu.Text = "Menú Principal";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // lbhora
            // 
            this.lbhora.AutoSize = true;
            this.lbhora.BackColor = System.Drawing.Color.Transparent;
            this.lbhora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbhora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(194)))), ((int)(((byte)(149)))));
            this.lbhora.Location = new System.Drawing.Point(12, 9);
            this.lbhora.Name = "lbhora";
            this.lbhora.Size = new System.Drawing.Size(69, 25);
            this.lbhora.TabIndex = 22;
            this.lbhora.Text = "HORA";
            this.lbhora.Click += new System.EventHandler(this.Lbhora_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnImprimir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(109)))));
            this.btnImprimir.Location = new System.Drawing.Point(112, 80);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(2);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(126, 31);
            this.btnImprimir.TabIndex = 23;
            this.btnImprimir.Text = "Imprimir Ticket";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnNuevaVenta
            // 
            this.btnNuevaVenta.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevaVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnNuevaVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(109)))));
            this.btnNuevaVenta.Location = new System.Drawing.Point(112, 130);
            this.btnNuevaVenta.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevaVenta.Name = "btnNuevaVenta";
            this.btnNuevaVenta.Size = new System.Drawing.Size(126, 31);
            this.btnNuevaVenta.TabIndex = 24;
            this.btnNuevaVenta.Text = "Nueva Venta ";
            this.btnNuevaVenta.UseVisualStyleBackColor = false;
            this.btnNuevaVenta.Click += new System.EventHandler(this.btnNuevaVenta_Click);
            // 
            // TicketFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(365, 276);
            this.Controls.Add(this.btnNuevaVenta);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.lbhora);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.label1);
            this.Name = "TicketFinal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicketFinal";
            this.Load += new System.EventHandler(this.TicketFinal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label lbhora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnNuevaVenta;
    }
}