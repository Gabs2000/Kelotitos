using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using MySql.Data.MySqlClient;
using Kelotitos.MySql;
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
    public partial class TicketFinal : Form
    {
        public TicketFinal()
        {
            InitializeComponent();
        }

        private void TicketFinal_Load(object sender, EventArgs e)
        {
            if(Login.siAdmin == 0)
            {
                btnMenu.Visible = false;
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Elegir elegir = new Elegir();
            this.Hide();
            elegir.Show();
        }

        private void btnNuevaVenta_Click(object sender, EventArgs e)
        {
            Comida comida = new Comida();
            this.Hide();
            comida.Show();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void Lbhora_Click(object sender, EventArgs e)
        {
            lbhora.Text = DateTime.Now.ToString("hh:mm:ss dddd MMMM yyy ");
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lbhora.Text = DateTime.Now.ToString("hh:mm:ss dddd MMMM yyy ");
        }
    }
}
