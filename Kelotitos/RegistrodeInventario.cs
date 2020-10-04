using Kelotitos.ModelsDB;
using Kelotitos.MySql;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kelotitos
{
    public partial class Form1 : Form
    {
        private int resultado;
        private object name_textbox;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ResetText();
            MessageBox.Show("Se eliminará la información de los campos llenados", "¿Está segur@ de eliminar la información?", MessageBoxButtons.OK);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            providerAccount newProviderAccount = NewMethod();
            newProviderAccount.name_prov = name_textbox.Text.Trim();
            newProviderAccount.name_prov = textBox2.Text.Trim();
            newProviderAccount.cant_prov = numericUpDown1.Value.ToString();
            newProviderAccount.cat_prov = cmb.Items.AddRange();
            if (string.IsNullOrEmpty(name_textbox.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(numericUpDown1) || string.IsNullOrEmpty(cmb))
            {
                MessageBox.Show("Los campos requieren de una respuesta", "RegistroInventario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MySqlConnection conexion = Connection.GetConnection();
                MySqlCommand newProvider = new MySqlCommand();
                newProvider.CommandText = "SELECT * FROM provider WHERE name_prov";
                newProvider.Parameters.AddWithValue("@newProviderAccount.name_prov", newProviderAccount.name_prov);
                newProvider.Parameters.AddWithValue("@newProviderAccount.name_prov", newProviderAccount.name_prov);
                newProvider.Parameters.AddWithValue("@newProvideraAccount.cant_prov", newProviderAccount.cant_prov);
                newProvider.Parameters.AddWithValue("@newProviderAccount.cat_prov", newProviderAccount.cat_prov);
                newProvider.Connection = conexion;
                MySqlDataReader leer = newProvider.ExecuteReader();
                if (leer.Read())
                {
                    MessageBox.Show("El producto ya existe", "RegistroInventario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conexion.Close();
                }
                else
                {
                    int v = RegisterNewProvider.agregar(newProviderAccount);
                    int resultado = v;
                }

                if (resultado > 0)
                {
                    MessageBox.Show("Producto Registrado con Éxito!", "RegistroInventario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Elegir ToElegir = new Elegir();
                    this.Hide();
                    ToElegir.Show();
                }
                else
                {
                    MessageBox.Show("No se puede guardar el Producto", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private static providerAccount NewMethod()
        {
            return newProviderAccount();
        }

        private static providerAccount newProviderAccount()
        {
            throw new NotImplementedException();
        }
    }
}