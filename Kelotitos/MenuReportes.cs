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
    public partial class MenuReportes : Form
    {
        public MenuReportes()
        {
            InitializeComponent();
        }

        private void pbRegresar_Click(object sender, EventArgs e)
        {
            Elegir elegir = new Elegir();
            this.Hide();
            elegir.Show();
        }

        private void lblVentas_Click(object sender, EventArgs e)
        {
            ReporteVentas ventas = new ReporteVentas();
            this.Hide();
            ventas.Show();
        }

        private void lblProductos_Click(object sender, EventArgs e)
        {
            ReporteProductos productos = new ReporteProductos();
            this.Hide();
            productos.Show();
        }

        private void lblProveedores_Click(object sender, EventArgs e)
        {
            ReporteProveedores proveedores = new ReporteProveedores();
            this.Hide();
            proveedores.Show();
        }

        private void lblCompras_Click(object sender, EventArgs e)
        {
            ReporteCompras compras = new ReporteCompras();
            this.Hide();
            compras.Show();
        }

        private void lblInventario_Click(object sender, EventArgs e)
        {
            ReporteInventario inventario = new ReporteInventario();
            this.Hide();
            inventario.Show();
        }

        private void lblEmpleados_Click(object sender, EventArgs e)
        {
            ReporteEmpleados empleados = new ReporteEmpleados();
            this.Hide();
            empleados.Show();
        }
    }
}
