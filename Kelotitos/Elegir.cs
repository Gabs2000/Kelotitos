using Prueba;
using System;
using System.Windows.Forms;

namespace Kelotitos
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

        private void lblRegProducto_Click(object sender, EventArgs e)
        {
            RegistrarProductos ToRegistrarProductos = new RegistrarProductos();
            this.Hide();
            ToRegistrarProductos.Show();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Login ToLogin = new Login();
            this.Hide();
            ToLogin.Show();
        }

        private void lblRegCompra_Click(object sender, EventArgs e)
        {
            RegistrarCompra ToLogin = new RegistrarCompra();
            this.Hide();
            ToLogin.Show();
        }

        private void lblRegProveedor_Click(object sender, EventArgs e)
        {
            RegistrarProveedor ToLogin = new RegistrarProveedor();
            this.Hide();
            ToLogin.Show();
        }

        private void lblRegistrarVenta_Click(object sender, EventArgs e)
        {
            Comida ToRegistro = new Comida();
            this.Hide();
            ToRegistro.Show();
        }

        private void lblRegInventario_Click(object sender, EventArgs e)
        {
            RegistroInventario inv = new RegistroInventario();
            this.Hide();
            inv.Show();
        }
    }
}
