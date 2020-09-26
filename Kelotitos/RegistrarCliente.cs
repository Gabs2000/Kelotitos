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
    public partial class Registrar_Cliente : Form
    {
        clientAccount cliente;
        public Registrar_Cliente()
        {
            InitializeComponent();
            

        }

        private void Lbhora_Click(object sender, EventArgs e)
        {
            lbhora.Text = DateTime.Now.ToString("hh:mm:ss dddd MMMM yyy ");
        }

        private void Registrar_Cliente_Load(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lbhora.Text = DateTime.Now.ToString("hh:mm:ss dddd MMMM yyy ");
        }

        private void Register_button_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(client_textbox.Text) || string.IsNullOrEmpty(email_textbox.Text) || string.IsNullOrEmpty(tel_textbox.Text))
            {
                MessageBox.Show("Los campos no pueden quedar vacios", "Registro Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cliente = new clientAccount();
                cliente.name_client = client_textbox.Text.Trim();
                cliente.email_client = email_textbox.Text.Trim();
                cliente.tel_client = tel_textbox.Text.Trim();

                int resultado = Convert.ToInt32(registerNewClient.agregar(cliente));
                cliente.id_client = resultado;
                if (resultado > 0)
                {
                    MessageBox.Show("Cliente Registrado con Exito!", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Menu ToMenu = new Menu();
                    //this.Hide();
                    //ToMenu.Show();
                    Comida ToComida = new Comida(cliente);
                    this.Hide();
                    ToComida.Show();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar a el Cliente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
              
            }
        }

        private void tel_textbox_KeyPress(Object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
            }
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            Elegir ToElegir = new Elegir();
            this.Hide();
            ToElegir.Show();
        }

        private void tel_textbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
