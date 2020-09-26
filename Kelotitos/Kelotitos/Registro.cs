﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_OASIS.MySql;
using MySql.Data.MySqlClient;

namespace Proyecto_OASIS
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }
        //comentario
        private void back_button_Click(object sender, EventArgs e)
        {
            Login ToLogin = new Login();
            this.Hide();
            ToLogin.Show();
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            userAccount newAccount = new userAccount();
            newAccount.name_user = name_textbox.Text.Trim();
            newAccount.account_user = registeruser_textbox.Text.Trim();
            newAccount.password_user = registerpassword_textbox.Text.Trim();
            newAccount.type_user = 1;
            confirmpassword_textbox.Text.Trim();

            if (string.IsNullOrEmpty(name_textbox.Text) || string.IsNullOrEmpty(registeruser_textbox.Text) || string.IsNullOrEmpty(registerpassword_textbox.Text) || string.IsNullOrEmpty(confirmpassword_textbox.Text))
            {
                MessageBox.Show("Los campos no pueden quedar vacios", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (registerpassword_textbox.Text != confirmpassword_textbox.Text)
                {
                    MessageBox.Show("Las contraseñas no coinciden, porfavor coloque la misma contraseña en ambos campos", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    //newAccount.name_user == name_textbox.Text || newAccount.account_user == registeruser_textbox.Text
                    MySqlConnection conexion = Connection.GetConnection();

                    MySqlCommand compareUser = new MySqlCommand();
                    compareUser.CommandText = "SELECT * FROM user WHERE account_user = @newAccount.account_user AND password_user = @newAccount.password_user";
                    compareUser.Parameters.AddWithValue("@newAccount.account_user", newAccount.account_user);
                    compareUser.Parameters.AddWithValue("@newAccount.password_user", newAccount.password_user);
                    compareUser.Connection = conexion;

                    MySqlDataReader leer = compareUser.ExecuteReader();
                    if (leer.Read())
                    {
                        MessageBox.Show("El usuario ya existe", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        conexion.Close();
                    }
                    else
                    {
                    int resultado = registerNewUserAccount.agregar(newAccount);
                        if (resultado > 0)
                        {
                            MessageBox.Show("Usuario Registrado con Exito!", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //Menu ToMenu = new Menu();
                            //this.Hide();
                            //ToMenu.Show();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo guardar el Usuario", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void Lbhora_Click(object sender, EventArgs e)
        {
            lbhora.Text = DateTime.Now.ToString("hh:mm:ss dddd MMMM yyy ");
        }

        private void HoraFecha_Tick(object sender, EventArgs e)
        {
            lbhora.Text = DateTime.Now.ToString("hh:mm:ss dddd MMMM yyy ");
        }

        private void Name_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Registeruser_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }
    }
}
