﻿using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Microsoft.VisualBasic;
using Kelotitos.MySql;

namespace Kelotitos
{
    public partial class Login : Form
    {
        public static int idUsuario;
        public static string nombreUsuario;
        public static int siAdmin;
        public Login()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            string user = user_textbox.Text;
            string password = password_textbox.Text;

            MySqlConnection conexion = Connection.GetConnection();

            MySqlCommand login = new MySqlCommand();
            login.CommandText = "SELECT * FROM usuarios WHERE usuario = @user AND contrasena = @password";
            login.Parameters.AddWithValue("@user", user);
            login.Parameters.AddWithValue("@password", password);
            login.Connection = conexion;

            if (string.IsNullOrEmpty(user_textbox.Text) || string.IsNullOrEmpty(password_textbox.Text))
            {
                MessageBox.Show("Los campos no pueden quedar vacíos.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MySqlDataReader leer = login.ExecuteReader();
                if (leer.Read())
                {
                    Login.idUsuario = leer.GetInt32(0);
                    Login.nombreUsuario = leer.GetString(1);
                    Login.siAdmin = leer.GetInt32(4);
                    Console.WriteLine(Login.idUsuario);
                    MessageBox.Show("Bienvenido", "Log In", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if(leer.GetInt32(4) == 1)
                    {
                        Elegir ToMenu = new Elegir();
                        ToMenu.Show();
                    }
                    else
                    {
                        Comida comida = new Comida();
                        comida.Show();
                    }

                    this.Hide();
                    conexion.Close();
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña Incorrectos", "Log In", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conexion.Close();
                }
            }
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Introduzca la contraseña de ADMINISTRADOR para crear un nuevo usuario", "Aviso", "", -1, -1);


            if (input == "admin")
            {
                Registro ToRegistro = new Registro();
                this.Hide();
                ToRegistro.Show();
            }
            else
            {
                MessageBox.Show("Contraseña de Administrador Incorrecta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Hora_Tick(object sender, EventArgs e)
        {
            lbhora.Text = DateTime.Now.ToString("hh:mm:ss dddd MMMM yyy ");
        }

    }
}
