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
    public partial class ReporteProveedores : Form
    {
        MySqlConnection conexion;
        public ReporteProveedores()
        {
            InitializeComponent();
        }

        private void pcRegresar_Click(object sender, EventArgs e)
        {
            MenuReportes reportes = new MenuReportes();
            this.Hide();
            reportes.Show();
        }

        private void ReporteProveedores_Load(object sender, EventArgs e)
        {
            this.cargarProveedores();
        }

        private void cargarProveedores()
        {
            conexion = Connection.GetConnection();
            MySqlCommand cm = new MySqlCommand("SELECT " +
                                                    "proveedor AS Proveedor, " +
                                                    "encargado AS Encargado, " +
                                                    "municipio AS Municipio, " +
                                                    "telefono AS Teléfono, " +
                                                    "correo AS Correo " +
                                                "FROM proveedores " +
                                                "WHERE estatus = 1;", conexion);

            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = cm;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgwProveedores.DataSource = tabla;

            dgwProveedores.AutoResizeColumns();
            dgwProveedores.ClearSelection();
        }

        ReportDataSource rs = new ReportDataSource();

        private void btnPDF_Click(object sender, EventArgs e)
        {
            List<RepProveedorObject> lista = new List<RepProveedorObject>();
            lista.Clear();

            for (int i = 0; i < dgwProveedores.Rows.Count - 1; i++)
            {

                RepProveedorObject rep = new RepProveedorObject
                {
                    proveedor = dgwProveedores.Rows[i].Cells[0].Value.ToString(),
                    encargado = dgwProveedores.Rows[i].Cells[1].Value.ToString(),
                    municipio = dgwProveedores.Rows[i].Cells[2].Value.ToString(),
                    telefono = dgwProveedores.Rows[i].Cells[3].Value.ToString(),
                    correo = dgwProveedores.Rows[i].Cells[4].Value.ToString(),
                };

                lista.Add(rep);

            }

            rs.Name = "DataSetReporte";
            rs.Value = lista;
            reporte repInv = new reporte();
            repInv.reporteView.LocalReport.DataSources.Clear();
            repInv.reporteView.LocalReport.DataSources.Add(rs);
            repInv.reporteView.LocalReport.ReportEmbeddedResource = "Kelotitos.Reportes.repProv.rdlc";
            repInv.ShowDialog();
        }
    }

    //Objeto para el reporte
    public class RepProveedorObject
    {
        public string proveedor { get; set; }
        public string encargado { get; set; }
        public string municipio { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
    }
}
