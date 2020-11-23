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
    public partial class ReporteVentas : Form
    {
        MySqlConnection conexion;
        public ReporteVentas()
        {
            InitializeComponent();
        }

        private void pcRegresar_Click(object sender, EventArgs e)
        {
            MenuReportes reportes = new MenuReportes();
            this.Hide();
            reportes.Show();
        }

        private void ReporteVentas_Load(object sender, EventArgs e)
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

            cbVendedor.ValueMember = "nombre";
            cbVendedor.DisplayMember = "nombre";
            cbVendedor.DataSource = dt;
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            string fecha = dtpFechaVenta.Value.ToString("yyyy-MM-dd");

            conexion = Connection.GetConnection();
            MySqlCommand cm = new MySqlCommand("SELECT " +
                                                    "V.folio AS Folio, " +
                                                    "U.nombre AS Vendedor, " +
                                                    "DATE_FORMAT(V.fecha_venta,'%d/%m/%Y') AS 'Fecha Venta', " +
                                                    "V.total AS Total " +
                                                "FROM ventas V " +
                                                "INNER JOIN usuarios U " +
                                                    "ON V.id_usuario = U.id_usuario " +
                                                "WHERE V.estatus = 1 " +
                                                "AND U.nombre = IFNULL(@usuario,U.nombre) " +
                                                "AND DATE(V.fecha_venta) = IFNULL(@fecha,V.fecha_venta);", conexion);
            cm.Parameters.AddWithValue("@usuario", cbVendedor.SelectedValue);
            cm.Parameters.AddWithValue("@fecha", fecha);

            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = cm;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvRepVentas.DataSource = tabla;

            dgvRepVentas.AutoResizeColumns();
            dgvRepVentas.ClearSelection();
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            conexion = Connection.GetConnection();
            MySqlCommand cm = new MySqlCommand("SELECT " +
                                                    "V.folio AS Folio, " +
                                                    "U.nombre AS Vendedor, " +
                                                    "DATE_FORMAT(V.fecha_venta,'%d/%m/%Y') AS 'Fecha Venta', " +
                                                    "V.total AS Total " +
                                                "FROM ventas V " +
                                                "INNER JOIN usuarios U " +
                                                    "ON V.id_usuario = U.id_usuario " +
                                                "WHERE V.estatus = 1;", conexion);

            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = cm;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvRepVentas.DataSource = tabla;

            dgvRepVentas.AutoResizeColumns();
            dgvRepVentas.ClearSelection();
        }
    }
}
