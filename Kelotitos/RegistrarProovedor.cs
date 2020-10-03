using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Kelotitos.ModelsDB;
using Kelotitos.MySql;

namespace Kelotitos
{
    public partial class RegistrarProovedor : Form
    {
        public RegistrarProovedor()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lbhora.Text = DateTime.Now.ToString("hh:mm:ss dddd MMMM yyy ");
        }

        private void Lbhora_Click(object sender, EventArgs e)
        {
            lbhora.Text = DateTime.Now.ToString("hh:mm:ss dddd MMMM yyy ");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            providerAccount newProviderAccount = new providerAccount();
            newProviderAccount.name_prov = name_textbox.Text.Trim();
            newProviderAccount.email_prov = textBox2.Text.Trim();
            newProviderAccount.tel_prov = textBox1.Text.Trim();
            newProviderAccount.location_prov = textBox3.Text.Trim();

            if (string.IsNullOrEmpty(name_textbox.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Los campos no pueden quedar vacíos", "Registro Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MySqlConnection conexion = Connection.GetConnection();

                MySqlCommand newProvider = new MySqlCommand();
                newProvider.CommandText = "SELECT * FROM provider WHERE name_prov   ";
                newProvider.Parameters.AddWithValue("@newProviderAccount.name_prov", newProviderAccount.name_prov);
                newProvider.Parameters.AddWithValue("@newProviderAccount.email_prov", newProviderAccount.email_prov);
                newProvider.Parameters.AddWithValue("@newProvideraAccount.tel_prov", newProviderAccount.tel_prov);
                newProvider.Parameters.AddWithValue("@newProviderAccount.location_prov", newProviderAccount.location_prov);
                newProvider.Connection = conexion;

                MySqlDataReader leer = newProvider.ExecuteReader();
                if (leer.Read())
                {
                    MessageBox.Show("El usuario ya existe", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conexion.Close();
                }
                else
                {
                    int resultado = RegisterNewProvider.agregar(newProviderAccount);
                    if (resultado > 0)
                    {
                        MessageBox.Show("Proveedor Registrado con Éxito!", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Elegir ToElegir = new Elegir();
                        this.Hide();
                        ToElegir.Show();
                    }
                    else
                    {
                        MessageBox.Show("No se puede guardar a el Proveedor", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            Elegir ToRegistro = new Elegir();
            this.Hide();
            ToRegistro.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
            }
        }

        private void RegistrarProovedor_Load(object sender, EventArgs e)
        {

        }

        private void name_textbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
