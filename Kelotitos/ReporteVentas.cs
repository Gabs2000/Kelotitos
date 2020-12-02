using Kelotitos.MySql;
using Kelotitos.Reportes;
using Microsoft.Reporting.WinForms;
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

            cbVendedor.SelectedIndex = -1;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            string fecha = dtpFechaVenta.Value.ToString("yyyy-MM-dd");

            conexion = Connection.GetConnection();

            MySqlCommand cm = new MySqlCommand();

            if ((dtpFechaVenta.CustomFormat == " ") && (cbVendedor.SelectedItem == null))
            {
                cm = new MySqlCommand("SELECT " +
                                            "V.folio AS Folio, " +
                                            "U.nombre AS Vendedor, " +
                                            "DATE_FORMAT(V.fecha_venta,'%d/%m/%Y') AS 'Fecha Venta', " +
                                            "V.total AS Total " +
                                        "FROM ventas V " +
                                        "INNER JOIN usuarios U " +
                                            "ON V.id_usuario = U.id_usuario " +
                                        "WHERE V.estatus = 1;", conexion);
            }
            
            if((dtpFechaVenta.CustomFormat == " ") && (cbVendedor.SelectedItem != null))
            {
                cm = new MySqlCommand("SELECT " +
                                            "V.folio AS Folio, " +
                                            "U.nombre AS Vendedor, " +
                                            "DATE_FORMAT(V.fecha_venta,'%d/%m/%Y') AS 'Fecha Venta', " +
                                            "V.total AS Total " +
                                        "FROM ventas V " +
                                        "INNER JOIN usuarios U " +
                                            "ON V.id_usuario = U.id_usuario " +
                                        "WHERE V.estatus = 1 " +
                                        "AND U.nombre = IFNULL(@usuario,U.nombre);", conexion);
                cm.Parameters.AddWithValue("@usuario", cbVendedor.SelectedValue);
            }
            
            if((dtpFechaVenta.CustomFormat != " ") && (cbVendedor.SelectedItem == null))
            {
                cm = new MySqlCommand("SELECT " +
                                            "V.folio AS Folio, " +
                                            "U.nombre AS Vendedor, " +
                                            "DATE_FORMAT(V.fecha_venta,'%d/%m/%Y') AS 'Fecha Venta', " +
                                            "V.total AS Total " +
                                        "FROM ventas V " +
                                        "INNER JOIN usuarios U " +
                                            "ON V.id_usuario = U.id_usuario " +
                                        "WHERE V.estatus = 1 " +
                                        "AND DATE(V.fecha_venta) = IFNULL(@fecha,V.fecha_venta);", conexion);
                cm.Parameters.AddWithValue("@fecha", fecha);
            }
            
            if((dtpFechaVenta.CustomFormat != " ") && (cbVendedor.SelectedItem != null))
            {
                cm = new MySqlCommand("SELECT " +
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
            }

            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = cm;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvRepVentas.DataSource = tabla;

            dgvRepVentas.AutoResizeColumns();
            dgvRepVentas.ClearSelection();
        }

        ReportDataSource rs = new ReportDataSource();

        private void btnPDF_Click(object sender, EventArgs e)
        {

            List<RepVentasObject> lista = new List<RepVentasObject>();
            lista.Clear();

            for (int i = 0; i < dgvRepVentas.Rows.Count - 1; i++)
            {

                RepVentasObject rep = new RepVentasObject
                {
                    folio = dgvRepVentas.Rows[i].Cells[0].Value.ToString(),
                    vendedor = dgvRepVentas.Rows[i].Cells[1].Value.ToString(),
                    fecha_venta = DateTime.Parse(dgvRepVentas.Rows[i].Cells[2].Value.ToString()),
                    total = int.Parse(dgvRepVentas.Rows[i].Cells[3].Value.ToString())
                };

                lista.Add(rep);

            }

            rs.Name = "DataSetReporte";
            rs.Value = lista;
            reporte repInv = new reporte();
            repInv.reporteView.LocalReport.DataSources.Clear();
            repInv.reporteView.LocalReport.DataSources.Add(rs);
            repInv.reporteView.LocalReport.ReportEmbeddedResource = "Kelotitos.Reportes.repVent.rdlc";
            repInv.ShowDialog();

        }

        private void dtpFechaVenta_ValueChanged(object sender, EventArgs e)
        {
            dtpFechaVenta.CustomFormat = "dd/MM/yyyy";
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            dtpFechaVenta.CustomFormat = " ";
            cbVendedor.SelectedIndex = -1;
        }
    }

    //Objeto para el reporte
    public class RepVentasObject
    {
        public string folio { get; set; }
        public string vendedor { get; set; }
        public DateTime fecha_venta { get; set; }
        public int total { get; set; }
    }
}
