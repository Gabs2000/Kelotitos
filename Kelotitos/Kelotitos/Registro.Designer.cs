﻿namespace Proyecto_OASIS
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
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.registeruser_textbox = new System.Windows.Forms.TextBox();
            this.registerpassword_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.register_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.confirmpassword_textbox = new System.Windows.Forms.TextBox();
            this.lbhora = new System.Windows.Forms.Label();
            this.horaFecha = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name_textbox
            // 
            this.name_textbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.name_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(171)))), ((int)(((byte)(0)))));
            this.name_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name_textbox.Font = new System.Drawing.Font("BigNoodleTitling", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(109)))));
            this.name_textbox.Location = new System.Drawing.Point(629, 167);
            this.name_textbox.Multiline = true;
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(811, 68);
            this.name_textbox.TabIndex = 17;
            this.name_textbox.TextChanged += new System.EventHandler(this.Name_textbox_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("BigNoodleTitling", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(109)))));
            this.label3.Location = new System.Drawing.Point(191, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(385, 70);
            this.label3.TabIndex = 16;
            this.label3.Text = "NOMBRE COMPLET0:";
            // 
            // registeruser_textbox
            // 
            this.registeruser_textbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.registeruser_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(171)))), ((int)(((byte)(0)))));
            this.registeruser_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.registeruser_textbox.Font = new System.Drawing.Font("BigNoodleTitling", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registeruser_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(109)))));
            this.registeruser_textbox.Location = new System.Drawing.Point(629, 266);
            this.registeruser_textbox.Multiline = true;
            this.registeruser_textbox.Name = "registeruser_textbox";
            this.registeruser_textbox.Size = new System.Drawing.Size(811, 68);
            this.registeruser_textbox.TabIndex = 18;
            this.registeruser_textbox.TextChanged += new System.EventHandler(this.Registeruser_textbox_TextChanged);
            // 
            // registerpassword_textbox
            // 
            this.registerpassword_textbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.registerpassword_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(171)))), ((int)(((byte)(0)))));
            this.registerpassword_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.registerpassword_textbox.Font = new System.Drawing.Font("BigNoodleTitling", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerpassword_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(109)))));
            this.registerpassword_textbox.Location = new System.Drawing.Point(629, 383);
            this.registerpassword_textbox.Multiline = true;
            this.registerpassword_textbox.Name = "registerpassword_textbox";
            this.registerpassword_textbox.PasswordChar = '*';
            this.registerpassword_textbox.Size = new System.Drawing.Size(811, 68);
            this.registerpassword_textbox.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("BigNoodleTitling", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(109)))));
            this.label1.Location = new System.Drawing.Point(389, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 70);
            this.label1.TabIndex = 20;
            this.label1.Text = "USUARIO:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("BigNoodleTitling", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(109)))));
            this.label2.Location = new System.Drawing.Point(302, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 70);
            this.label2.TabIndex = 21;
            this.label2.Text = "CONTRASEÑA:";
            // 
            // register_button
            // 
            this.register_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.register_button.BackColor = System.Drawing.Color.Yellow;
            this.register_button.Font = new System.Drawing.Font("BigNoodleTitling", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(109)))));
            this.register_button.Location = new System.Drawing.Point(876, 694);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(224, 54);
            this.register_button.TabIndex = 23;
            this.register_button.Text = "Registrar";
            this.register_button.UseVisualStyleBackColor = false;
            this.register_button.Click += new System.EventHandler(this.register_button_Click);
            // 
            // back_button
            // 
            this.back_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.back_button.BackColor = System.Drawing.Color.Yellow;
            this.back_button.Font = new System.Drawing.Font("BigNoodleTitling", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(109)))));
            this.back_button.Location = new System.Drawing.Point(465, 694);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(224, 54);
            this.back_button.TabIndex = 22;
            this.back_button.Text = "REGRESAR";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("BigNoodleTitling", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(109)))));
            this.label4.Location = new System.Drawing.Point(89, 490);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(492, 70);
            this.label4.TabIndex = 24;
            this.label4.Text = "CONFIRMAR CONTRASEÑA:";
            // 
            // confirmpassword_textbox
            // 
            this.confirmpassword_textbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.confirmpassword_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(171)))), ((int)(((byte)(0)))));
            this.confirmpassword_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.confirmpassword_textbox.Font = new System.Drawing.Font("BigNoodleTitling", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmpassword_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(109)))));
            this.confirmpassword_textbox.Location = new System.Drawing.Point(629, 488);
            this.confirmpassword_textbox.Multiline = true;
            this.confirmpassword_textbox.Name = "confirmpassword_textbox";
            this.confirmpassword_textbox.PasswordChar = '*';
            this.confirmpassword_textbox.Size = new System.Drawing.Size(811, 68);
            this.confirmpassword_textbox.TabIndex = 25;
            // 
            // lbhora
            // 
            this.lbhora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbhora.AutoSize = true;
            this.lbhora.BackColor = System.Drawing.Color.Transparent;
            this.lbhora.Font = new System.Drawing.Font("BigNoodleTitling", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbhora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(194)))), ((int)(((byte)(149)))));
            this.lbhora.Location = new System.Drawing.Point(944, 9);
            this.lbhora.Name = "lbhora";
            this.lbhora.Size = new System.Drawing.Size(130, 70);
            this.lbhora.TabIndex = 26;
            this.lbhora.Text = "HORA";
            this.lbhora.Click += new System.EventHandler(this.Lbhora_Click);
            // 
            // horaFecha
            // 
            this.horaFecha.Enabled = true;
            this.horaFecha.Tick += new System.EventHandler(this.HoraFecha_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("BigNoodleTitling", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(194)))), ((int)(((byte)(149)))));
            this.label5.Location = new System.Drawing.Point(-2, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(267, 70);
            this.label5.TabIndex = 27;
            this.label5.Text = "SNACK OASIS";
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_OASIS.Properties.Resources.Fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbhora);
            this.Controls.Add(this.confirmpassword_textbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.register_button);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registerpassword_textbox);
            this.Controls.Add(this.registeruser_textbox);
            this.Controls.Add(this.name_textbox);
            this.Controls.Add(this.label3);
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox registeruser_textbox;
        private System.Windows.Forms.TextBox registerpassword_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button register_button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox confirmpassword_textbox;
        private System.Windows.Forms.Label lbhora;
        private System.Windows.Forms.Timer horaFecha;
        private System.Windows.Forms.Label label5;
    }
}