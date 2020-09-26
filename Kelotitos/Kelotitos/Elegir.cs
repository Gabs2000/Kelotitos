using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_OASIS
{
    public partial class Elegir : Form
    {
        public Elegir()
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

        private void Elegir_Load(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {
            RegistrarProductos ToRegistrarProductos = new RegistrarProductos();
            this.Hide();
            ToRegistrarProductos.Show();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            Registrar_Cliente ToRegistrar_Cliente = new Registrar_Cliente();
            this.Hide();
            ToRegistrar_Cliente.Show();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            Comida ToRegistro = new Comida();
            this.Hide();
            ToRegistro.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Login ToLogin = new Login();
            this.Hide();
            ToLogin.Show();
        }

        private void Label4_Click(object sender, EventArgs e)
        {
            RegistrarCompra ToLogin = new RegistrarCompra();
            this.Hide();
            ToLogin.Show();
        }

        private void Labelx_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {
            RegistrarProovedor ToLogin = new RegistrarProovedor();
            this.Hide();
            ToLogin.Show();
        }
    }
}
