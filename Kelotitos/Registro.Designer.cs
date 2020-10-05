namespace Kelotitos
{
    partial class Registro
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.register_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConfContra = new System.Windows.Forms.TextBox();
            this.lbhora = new System.Windows.Forms.Label();
            this.horaFecha = new System.Windows.Forms.Timer(this.components);
            this.chbAdmin = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(109)))));
            this.txtNombre.Location = new System.Drawing.Point(341, 90);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(433, 31);
            this.txtNombre.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(109)))));
            this.label3.Location = new System.Drawing.Point(217, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 31);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nombre:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(109)))));
            this.txtUsuario.Location = new System.Drawing.Point(341, 155);
            this.txtUsuario.Multiline = true;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(433, 31);
            this.txtUsuario.TabIndex = 2;
            // 
            // txtContrasena
            // 
            this.txtContrasena.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(109)))));
            this.txtContrasena.Location = new System.Drawing.Point(341, 222);
            this.txtContrasena.Multiline = true;
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '*';
            this.txtContrasena.Size = new System.Drawing.Size(433, 31);
            this.txtContrasena.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(109)))));
            this.label1.Location = new System.Drawing.Point(217, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 31);
            this.label1.TabIndex = 20;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(109)))));
            this.label2.Location = new System.Drawing.Point(170, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 31);
            this.label2.TabIndex = 21;
            this.label2.Text = "Contraseña:";
            // 
            // register_button
            // 
            this.register_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.register_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(109)))));
            this.register_button.Location = new System.Drawing.Point(364, 444);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(210, 54);
            this.register_button.TabIndex = 6;
            this.register_button.Text = "Registrar";
            this.register_button.UseVisualStyleBackColor = false;
            this.register_button.Click += new System.EventHandler(this.register_button_Click);
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(109)))));
            this.back_button.Location = new System.Drawing.Point(134, 444);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(202, 54);
            this.back_button.TabIndex = 7;
            this.back_button.Text = "Regresar ";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(109)))));
            this.label4.Location = new System.Drawing.Point(44, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(289, 31);
            this.label4.TabIndex = 24;
            this.label4.Text = "Confirmar Contraseña:";
            // 
            // txtConfContra
            // 
            this.txtConfContra.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtConfContra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfContra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(109)))));
            this.txtConfContra.Location = new System.Drawing.Point(341, 291);
            this.txtConfContra.Multiline = true;
            this.txtConfContra.Name = "txtConfContra";
            this.txtConfContra.PasswordChar = '*';
            this.txtConfContra.Size = new System.Drawing.Size(433, 31);
            this.txtConfContra.TabIndex = 4;
            // 
            // lbhora
            // 
            this.lbhora.AutoSize = true;
            this.lbhora.BackColor = System.Drawing.Color.Transparent;
            this.lbhora.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbhora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(194)))), ((int)(((byte)(149)))));
            this.lbhora.Location = new System.Drawing.Point(31, 21);
            this.lbhora.Name = "lbhora";
            this.lbhora.Size = new System.Drawing.Size(93, 31);
            this.lbhora.TabIndex = 26;
            this.lbhora.Text = "HORA";
            this.lbhora.Click += new System.EventHandler(this.Lbhora_Click);
            // 
            // horaFecha
            // 
            this.horaFecha.Enabled = true;
            this.horaFecha.Tick += new System.EventHandler(this.HoraFecha_Tick);
            // 
            // chbAdmin
            // 
            this.chbAdmin.AutoSize = true;
            this.chbAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.chbAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(109)))));
            this.chbAdmin.Location = new System.Drawing.Point(341, 351);
            this.chbAdmin.Name = "chbAdmin";
            this.chbAdmin.Size = new System.Drawing.Size(266, 35);
            this.chbAdmin.TabIndex = 5;
            this.chbAdmin.Text = "¿Es administrador?";
            this.chbAdmin.UseVisualStyleBackColor = true;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(817, 547);
            this.Controls.Add(this.chbAdmin);
            this.Controls.Add(this.lbhora);
            this.Controls.Add(this.txtConfContra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.register_button);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button register_button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtConfContra;
        private System.Windows.Forms.Label lbhora;
        private System.Windows.Forms.Timer horaFecha;
        private System.Windows.Forms.CheckBox chbAdmin;
    }
}