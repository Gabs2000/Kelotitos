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
    public partial class ReporteEmpleados : Form
    {
        MySqlConnection conexion;
        public ReporteEmpleados()
        {
            InitializeComponent();
        }

        private void pcRegresar_Click(object sender, EventArgs e)
        {
            MenuReportes reportes = new MenuReportes();
            this.Hide();
            reportes.Show();
        }

        private void ReporteEmpleados_Load(object sender, EventArgs e)
        {
            this.cargarVendedores();
        }

        private void cargarVendedores()
        {
            conexion = Connection.GetConnection();
            MySqlCommand cm = new MySqlCommand("SELECT " +
                                                    "nombre " +
                                                "FROM usuarios " +
                                                "WHERE estatus = 1;", conexion);
            MySqlDataReader reader;

            reader = cm.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("nombre", typeof(string));
            dt.Load(reader);

            cbEmpleados.ValueMember = "nombre";
            cbEmpleados.DisplayMember = "nombre";
            cbEmpleados.DataSource = dt;
        }
    }
}
