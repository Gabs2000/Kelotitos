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
    public partial class ReporteCompras : Form
    {
        MySqlConnection conexion;
        public ReporteCompras()
        {
            InitializeComponent();
        }

        private void pcRegresar_Click(object sender, EventArgs e)
        {
            MenuReportes reportes = new MenuReportes();
            this.Hide();
            reportes.Show();
        }

        private void ReporteCompras_Load(object sender, EventArgs e)
        {
            this.cargarProveedores();
            this.cargarInventario();
        }

        private void cargarProveedores()
        {
            conexion = Connection.GetConnection();
            MySqlCommand cm = new MySqlCommand("SELECT " +
                                                    "id_proveedor, " +
                                                    "proveedor " +
                                                "FROM proveedores " +
                                                "WHERE estatus = 1;", conexion);
            MySqlDataReader reader;

            reader = cm.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("id_proveedor", typeof(int));
            dt.Columns.Add("proveedor", typeof(string));
            dt.Load(reader);

            cbProveedor.ValueMember = "id_proveedor";
            cbProveedor.DisplayMember = "proveedor";
            cbProveedor.DataSource = dt;

            cbProveedor.SelectedIndex = -1;
        }

        private void cargarInventario()
        {
            conexion = Connection.GetConnection();
            MySqlCommand cm = new MySqlCommand("SELECT " +
                                                    "id_inventario, " +
                                                    "nombre " +
                                                "FROM inventario " +
                                                "WHERE estatus = 1; ", conexion);
            MySqlDataReader reader;

            reader = cm.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("id_inventario", typeof(int));
            dt.Columns.Add("nombre", typeof(string));
            dt.Load(reader);

            cbInventario.ValueMember = "id_inventario";
            cbInventario.DisplayMember = "nombre";
            cbInventario.DataSource = dt;

            cbInventario.SelectedIndex = -1;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cbProveedor.SelectedIndex = -1;
            cbInventario.SelectedIndex = -1;
            dtpFecha.CustomFormat = " ";
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            dtpFecha.CustomFormat = "dd/MM/yyyy";
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string fecha = dtpFecha.Value.ToString("yyyy-MM-dd");
            Console.WriteLine(fecha);

            conexion = Connection.GetConnection();

            MySqlCommand cm = new MySqlCommand();

            if((cbProveedor.SelectedIndex == -1) && (cbInventario.SelectedIndex == -1) && (dtpFecha.CustomFormat == " "))
            {
                cm = new MySqlCommand("SELECT " +
                                        "i.nombre AS Producto, " +
                                        "p.proveedor AS Proveedor, " +
                                        "cp.cantidad AS Cantidad, " +
                                        "(i.precio_compra * cp.cantidad) AS Total, " +
                                        "cp.fecha_creacion AS 'Fecha Compra' " +
                                    "FROM compras_proveedor cp " +
                                    "INNER JOIN inventario i " +
                                        "ON cp.id_inventario = i.id_inventario " +
                                    "INNER JOIN proveedores p " +
                                        "ON cp.id_proveedor = p.id_proveedor " +
                                    "WHERE cp.estatus = 1;", conexion);
            }

            if ((cbProveedor.SelectedIndex != -1) && (cbInventario.SelectedIndex == -1) && (dtpFecha.CustomFormat == " "))
            {
                cm = new MySqlCommand("SELECT " +
                                        "i.nombre AS Producto, " +
                                        "p.proveedor AS Proveedor, " +
                                        "cp.cantidad AS Cantidad, " +
                                        "(i.precio_compra * cp.cantidad) AS Total, " +
                                        "cp.fecha_creacion AS 'Fecha Compra' " +
                                    "FROM compras_proveedor cp " +
                                    "INNER JOIN inventario i " +
                                        "ON cp.id_inventario = i.id_inventario " +
                                    "INNER JOIN proveedores p " +
                                        "ON cp.id_proveedor = p.id_proveedor " +
                                    "WHERE cp.estatus = 1 " +
                                    "AND p.id_proveedor = IFNULL(@idProveedor,p.id_proveedor);", conexion);
                cm.Parameters.AddWithValue("@idProveedor", cbProveedor.SelectedValue);
            }

            if ((cbProveedor.SelectedIndex != -1) && (cbInventario.SelectedIndex != -1) && (dtpFecha.CustomFormat == " "))
            {
                cm = new MySqlCommand("SELECT " +
                                        "i.nombre AS Producto, " +
                                        "p.proveedor AS Proveedor, " +
                                        "cp.cantidad AS Cantidad, " +
                                        "(i.precio_compra * cp.cantidad) AS Total, " +
                                        "cp.fecha_creacion AS 'Fecha Compra' " +
                                    "FROM compras_proveedor cp " +
                                    "INNER JOIN inventario i " +
                                        "ON cp.id_inventario = i.id_inventario " +
                                    "INNER JOIN proveedores p " +
                                        "ON cp.id_proveedor = p.id_proveedor " +
                                    "WHERE cp.estatus = 1 " +
                                    "AND p.id_proveedor = IFNULL(@idProveedor,p.id_proveedor) " +
                                    "AND i.id_inventario = IFNULL(@idInventario,i.id_inventario);", conexion);
                cm.Parameters.AddWithValue("@idProveedor", cbProveedor.SelectedValue);
                cm.Parameters.AddWithValue("@idInventario", cbInventario.SelectedValue);
            }

            if ((cbProveedor.SelectedIndex != -1) && (cbInventario.SelectedIndex == -1) && (dtpFecha.CustomFormat != " "))
            {
                cm = new MySqlCommand("SELECT " +
                                        "i.nombre AS Producto, " +
                                        "p.proveedor AS Proveedor, " +
                                        "cp.cantidad AS Cantidad, " +
                                        "(i.precio_compra * cp.cantidad) AS Total, " +
                                        "cp.fecha_creacion AS 'Fecha Compra' " +
                                    "FROM compras_proveedor cp " +
                                    "INNER JOIN inventario i " +
                                        "ON cp.id_inventario = i.id_inventario " +
                                    "INNER JOIN proveedores p " +
                                        "ON cp.id_proveedor = p.id_proveedor " +
                                    "WHERE cp.estatus = 1 " +
                                    "AND p.id_proveedor = IFNULL(@idProveedor,p.id_proveedor) " +
                                    "AND cp.fecha_creacion LIKE @fecha;", conexion);
                cm.Parameters.AddWithValue("@idProveedor", cbProveedor.SelectedValue);
                cm.Parameters.AddWithValue("@fecha", fecha);
            }

            if ((cbProveedor.SelectedIndex == -1) && (cbInventario.SelectedIndex != -1) && (dtpFecha.CustomFormat == " "))
            {
                cm = new MySqlCommand("SELECT " +
                                        "i.nombre AS Producto, " +
                                        "p.proveedor AS Proveedor, " +
                                        "cp.cantidad AS Cantidad, " +
                                        "(i.precio_compra * cp.cantidad) AS Total, " +
                                        "cp.fecha_creacion AS 'Fecha Compra' " +
                                    "FROM compras_proveedor cp " +
                                    "INNER JOIN inventario i " +
                                        "ON cp.id_inventario = i.id_inventario " +
                                    "INNER JOIN proveedores p " +
                                        "ON cp.id_proveedor = p.id_proveedor " +
                                    "WHERE cp.estatus = 1 " +
                                    "AND i.id_inventario = IFNULL(@idInventario,i.id_inventario);", conexion);
                cm.Parameters.AddWithValue("@idInventario", cbInventario.SelectedValue);
            }

            if ((cbProveedor.SelectedIndex == -1) && (cbInventario.SelectedIndex != -1) && (dtpFecha.CustomFormat != " "))
            {
                cm = new MySqlCommand("SELECT " +
                                        "i.nombre AS Producto, " +
                                        "p.proveedor AS Proveedor, " +
                                        "cp.cantidad AS Cantidad, " +
                                        "(i.precio_compra * cp.cantidad) AS Total, " +
                                        "cp.fecha_creacion AS 'Fecha Compra' " +
                                    "FROM compras_proveedor cp " +
                                    "INNER JOIN inventario i " +
                                        "ON cp.id_inventario = i.id_inventario " +
                                    "INNER JOIN proveedores p " +
                                        "ON cp.id_proveedor = p.id_proveedor " +
                                    "WHERE cp.estatus = 1 " +
                                    "AND i.id_inventario = IFNULL(@idInventario,i.id_inventario) " +
                                    "AND cp.fecha_creacion LIKE @fecha;", conexion);
                cm.Parameters.AddWithValue("@idInventario", cbInventario.SelectedValue);
                cm.Parameters.AddWithValue("@fecha", fecha);
            }

            if ((cbProveedor.SelectedIndex == -1) && (cbInventario.SelectedIndex == -1) && (dtpFecha.CustomFormat != " "))
            {
                cm = new MySqlCommand("SELECT " +
                                        "i.nombre AS Producto, " +
                                        "p.proveedor AS Proveedor, " +
                                        "cp.cantidad AS Cantidad, " +
                                        "(i.precio_compra * cp.cantidad) AS Total, " +
                                        "cp.fecha_creacion AS 'Fecha Compra' " +
                                    "FROM compras_proveedor cp " +
                                    "INNER JOIN inventario i " +
                                        "ON cp.id_inventario = i.id_inventario " +
                                    "INNER JOIN proveedores p " +
                                        "ON cp.id_proveedor = p.id_proveedor " +
                                    "WHERE cp.estatus = 1 " +
                                    "AND cp.fecha_creacion LIKE @fecha;", conexion);
                cm.Parameters.AddWithValue("@fecha", fecha);
            }

            if ((cbProveedor.SelectedIndex != -1) && (cbInventario.SelectedIndex != -1) && (dtpFecha.CustomFormat != " "))
            {
                cm = new MySqlCommand("SELECT " +
                                        "i.nombre AS Producto, " +
                                        "p.proveedor AS Proveedor, " +
                                        "cp.cantidad AS Cantidad, " +
                                        "(i.precio_compra * cp.cantidad) AS Total, " +
                                        "cp.fecha_creacion AS 'Fecha Compra' " +
                                    "FROM compras_proveedor cp " +
                                    "INNER JOIN inventario i " +
                                        "ON cp.id_inventario = i.id_inventario " +
                                    "INNER JOIN proveedores p " +
                                        "ON cp.id_proveedor = p.id_proveedor " +
                                    "WHERE cp.estatus = 1 " +
                                    "AND p.id_proveedor = IFNULL(@idProveedor,p.id_proveedor) " +
                                    "AND i.id_inventario = IFNULL(@idInventario,i.id_inventario) " +
                                    "AND cp.fecha_creacion LIKE @fecha;", conexion);
                cm.Parameters.AddWithValue("@idProveedor", cbProveedor.SelectedValue);
                cm.Parameters.AddWithValue("@idInventario", cbInventario.SelectedValue);
                cm.Parameters.AddWithValue("@fecha", fecha);
            }

            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = cm;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvCompras.DataSource = tabla;

            dgvCompras.AutoResizeColumns();
            dgvCompras.ClearSelection();

        }

        ReportDataSource rs = new ReportDataSource();

        private void btnPDF_Click(object sender, EventArgs e)
        {
            List<RepComprasObject> lista = new List<RepComprasObject>();
            lista.Clear();

            for (int i = 0; i < dgvCompras.Rows.Count - 1; i++)
            {

                RepComprasObject rep = new RepComprasObject
                {
                    producto = dgvCompras.Rows[i].Cells[0].Value.ToString(),
                    proveedor = dgvCompras.Rows[i].Cells[1].Value.ToString(),
                    cantidad = int.Parse(dgvCompras.Rows[i].Cells[2].Value.ToString()),
                    total = int.Parse(dgvCompras.Rows[i].Cells[3].Value.ToString()),
                    fecha_compra = DateTime.Parse(dgvCompras.Rows[i].Cells[4].Value.ToString()),
                };

                lista.Add(rep);

            }

            rs.Name = "DataSetReporte";
            rs.Value = lista;
            reporte repInv = new reporte();
            repInv.reporteView.LocalReport.DataSources.Clear();
            repInv.reporteView.LocalReport.DataSources.Add(rs);
            repInv.reporteView.LocalReport.ReportEmbeddedResource = "Kelotitos.Reportes.repComp.rdlc";
            repInv.ShowDialog();
        }
    }

    //Objeto para el reporte
    public class RepComprasObject
    {
        public string producto { get; set; }
        public string proveedor { get; set; }
        public int cantidad { get; set; }
        public int total { get; set; }
        public DateTime fecha_compra { get; set; }
    }
}
