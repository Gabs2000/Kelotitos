using System;
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
                MessageBox.Show("Los campos no pueden quedar vacios", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MySqlDataReader leer = login.ExecuteReader();
                if (leer.Read())
                {
                    Login.idUsuario = leer.GetInt32(0);
                    Login.nombreUsuario = leer.GetString(1);
                    Console.WriteLine(Login.idUsuario);
                    MessageBox.Show("Bienvenido", "Log In", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Elegir ToMenu = new Elegir();

                    this.Hide();
                    ToMenu.Show();
                    conexion.Close();
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña incorrectos", "Log In", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conexion.Close();
                }
            }
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Introduzca la contraseña de administrador para crear un usuario", "Aviso", "", -1, -1);


            if (input == "admin")
            {
                Registro ToRegistro = new Registro();
                this.Hide();
                ToRegistro.Show();
            }
            else
            {
                MessageBox.Show("Contraseña de administrador incorrecta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Hora_Tick(object sender, EventArgs e)
        {
            lbhora.Text = DateTime.Now.ToString("hh:mm:ss dddd MMMM yyy ");
        }
    }
}
