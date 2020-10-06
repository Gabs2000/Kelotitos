using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kelotitos.MySql;
using MySql.Data.MySqlClient;

namespace Kelotitos
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

            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtContrasena.Text) || string.IsNullOrEmpty(txtConfContra.Text))
            {
                MessageBox.Show("Los campos no pueden quedar vacíos", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtContrasena.Text != txtConfContra.Text)
                {
                    MessageBox.Show("Las contraseñas no coinciden, por favor coloque la misma contraseña en ambos campos", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    MySqlConnection conexion = Connection.GetConnection();

                    string querySelect = "SELECT * FROM usuarios WHERE usuario = @usuario AND contrasena = @contrasena";
                    string queryInsert = "INSERT INTO usuarios " +
                                        "(nombre, usuario, contrasena, administrador, estatus, fecha_creacion) " +
                                        "VALUES " +
                                        "(@nombre, @usuario, @contrasena, @administrador, 1, NOW())";

                    using (MySqlCommand usuario = new MySqlCommand(querySelect, conexion))
                    {
                        usuario.Parameters.AddWithValue("@usuario", txtNombre.Text);
                        usuario.Parameters.AddWithValue("@contrasena", txtContrasena.Text);
                        usuario.Connection = conexion;

                        MySqlDataReader leer = usuario.ExecuteReader();

                        if (leer.Read())
                        {
                            MessageBox.Show("El usuario ya existe", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            conexion.Close();
                        }
                        else
                        {
                            leer.Close();
                            try
                            {
                                using (MySqlCommand con = new MySqlCommand(queryInsert, conexion))
                                {
                                    int siAdmin = 0;

                                    if(chbAdmin.Checked == true)
                                    {
                                        siAdmin = 1;
                                    }

                                    con.Parameters.AddWithValue("@nombre", txtNombre.Text);
                                    con.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                                    con.Parameters.AddWithValue("@contrasena", txtContrasena.Text);
                                    con.Parameters.AddWithValue("@administrador", siAdmin);
                                    con.ExecuteNonQuery();
                                }
                                    

                                MessageBox.Show("Usuario Registrado con Exito!", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                txtNombre.Text = "";
                                txtUsuario.Text = "";
                                txtContrasena.Text = "";
                                txtConfContra.Text = "";
                                chbAdmin.Checked = false;

                            }
                            catch (Exception err)
                            {
                                MessageBox.Show("No se pudo guardar el Usuario", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Console.WriteLine(err);
                            }
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
