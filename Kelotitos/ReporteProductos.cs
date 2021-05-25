using Kelotitos.MySql;
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
using Kelotitos.Reportes;

namespace Kelotitos
{
    public partial class ReporteProductos : Form
    {
        MySqlConnection conexion;
        public ReporteProductos()
        {
            InitializeComponent();
        }

        private void pcRegresar_Click(object sender, EventArgs e)
        {
            MenuReportes reportes = new MenuReportes();
            this.Hide();
            reportes.Show();
        }

        private void ReporteProductos_Load(object sender, EventArgs e)
        {
            this.cargarProductos();
        }

        private void cargarProductos()
        {
            conexion = Connection.GetConnection();
            MySqlCommand cm = new MySqlCommand("SELECT " +
                                                    "P.nombre AS Producto, " +
                                                    "TP.tipo_producto AS 'Tipo Producto', " +
                                                    "T.tamanio AS 'Tamaño', " +
                                                    "P.precio AS Precio " +
                                                "FROM cat_productos P " +
                                                "INNER JOIN cat_tipos_productos TP " +
                                                "ON P.id_tipo_producto = TP.id_tipo_producto " +
                                                "LEFT JOIN cat_tamanios T " +
                                                    "ON P.id_tamanio = T.id_tamanio " +
                                                "WHERE P.estatus = 1; ", conexion);

            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = cm;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgwRepProd.DataSource = tabla;

            dgwRepProd.AutoResizeColumns();
            dgwRepProd.ClearSelection();
        }

        ReportDataSource rs = new ReportDataSource();

        private void btnPDF_Click(object sender, EventArgs e)
        {
            List<RepProductoObject> lista = new List<RepProductoObject>();
            lista.Clear();

            for (int i = 0; i < dgwRepProd.Rows.Count - 1; i++)
            {

                RepProductoObject rep = new RepProductoObject
                {
                    producto = dgwRepProd.Rows[i].Cells[0].Value.ToString(),
                    tipo_producto = dgwRepProd.Rows[i].Cells[1].Value.ToString(),
                    tamanio = dgwRepProd.Rows[i].Cells[2].Value.ToString(),
                    precio = int.Parse(dgwRepProd.Rows[i].Cells[3].Value.ToString())
                };

                lista.Add(rep);

            }

            rs.Name = "DataSetReporte";
            rs.Value = lista;
            reporte repInv = new reporte();
            repInv.reporteView.LocalReport.DataSources.Clear();
            repInv.reporteView.LocalReport.DataSources.Add(rs);
            repInv.reporteView.LocalReport.ReportEmbeddedResource = "Kelotitos.Reportes.repProd.rdlc";
            repInv.ShowDialog();
        }
    }

    //Objeto para el reporte
    public class RepProductoObject
    {
        public string producto { get; set; }
        public string tipo_producto { get; set; }
        public string tamanio { get; set; }
        public int precio { get; set; }
    }
}
