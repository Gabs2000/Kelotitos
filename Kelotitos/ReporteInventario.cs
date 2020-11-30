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
using Kelotitos.ModelsDB;
using Kelotitos.ModelsDB.Reportes;

namespace Kelotitos
{

    public partial class ReporteInventario : Form
    {
        MySqlConnection conexion;
        public ReporteInventario()
        {
            InitializeComponent();
        }

        private void pcRegresar_Click(object sender, EventArgs e)
        {
            MenuReportes reportes = new MenuReportes();
            this.Hide();
            reportes.Show();
        }

        private void ReporteInventario_Load(object sender, EventArgs e)
        {
            this.cargarInventario();
        }

        private void cargarInventario()
        {
            conexion = Connection.GetConnection();
            MySqlCommand cm = new MySqlCommand("SELECT " +
                                                    "I.nombre AS Producto, " +
                                                    "P.proveedor AS Proveedor, " +
                                                    "I.cantidad AS Cantidad, " +
                                                    "I.unidad_medida AS 'Unidad Medida', " +
                                                    "I.precio_compra AS 'Precio Unitario' " +
                                                "FROM inventario I " +
                                                "INNER JOIN proveedores P " +
                                                    "ON I.id_proveedor = P.id_proveedor " +
                                                "WHERE I.estatus = 1; ", conexion);

            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = cm;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgwRepInv.DataSource = tabla;

            dgwRepInv.AutoResizeColumns();
            dgwRepInv.ClearSelection();
                
        }

        ReportDataSource rs = new ReportDataSource();

        private void btnPDF_Click(object sender, EventArgs e)
        {
            List<RepInventarioObject> lista = new List<RepInventarioObject>();
            lista.Clear();

            for(int i=0; i < dgwRepInv.Rows.Count - 1;i++)
            {

                RepInventarioObject rep = new RepInventarioObject
                {
                    producto = dgwRepInv.Rows[i].Cells[0].Value.ToString(),
                    proveedor = dgwRepInv.Rows[i].Cells[1].Value.ToString(),
                    cantidad = int.Parse(dgwRepInv.Rows[i].Cells[2].Value.ToString()),
                    unidad = dgwRepInv.Rows[i].Cells[3].Value.ToString(),
                    precioUnitario = int.Parse(dgwRepInv.Rows[i].Cells[4].Value.ToString())
                };
                
                lista.Add(rep);

            }

            rs.Name = "DataSetReporte";
            rs.Value = lista;
            repInv repInv = new repInv();
            repInv.reporte.LocalReport.DataSources.Clear();
            repInv.reporte.LocalReport.DataSources.Add(rs);
            repInv.reporte.LocalReport.ReportEmbeddedResource = "Kelotitos.Reportes.repInv.rdlc";
            repInv.ShowDialog();
        }
    }

    //Objeto para el reporte
    public class RepInventarioObject
    {
        public string producto { get; set; }
        public string proveedor { get; set; }
        public int cantidad { get; set; }
        public string unidad { get; set; }
        public int precioUnitario { get; set; }
    }
}
