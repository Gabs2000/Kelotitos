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

            cbEmpleados.SelectedIndex = -1;
        }

        private void btnResetFecha_Click(object sender, EventArgs e)
        {
            dtpFecha.CustomFormat = " ";
            cbEmpleados.SelectedIndex = -1;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string fecha = dtpFecha.Value.ToString("yyyy-MM-dd");

            conexion = Connection.GetConnection();

            MySqlCommand cm = new MySqlCommand();

            if ((cbEmpleados.SelectedIndex == -1) && (dtpFecha.CustomFormat == " "))
            {

                cm = new MySqlCommand("SELECT " +
                                            "nombre AS Nombre, " +
                                            "salarioXdia AS 'Salario Diario', " +
                                            "diasSemanas AS 'Días Trabajo'," +
                                            "DATE_FORMAT(fecha_creacion,'%d/%m/%Y') AS 'Fecha Inicio' " +
                                        "FROM usuarios " +
                                        "WHERE estatus = 1;", conexion);

            }
            
            if ((cbEmpleados.SelectedIndex != -1) && (dtpFecha.CustomFormat == " "))
            {

                cm = new MySqlCommand("SELECT " +
                                            "nombre AS Nombre, " +
                                            "salarioXdia AS 'Salario Diario', " +
                                            "diasSemanas AS 'Días Trabajo'," +
                                            "DATE_FORMAT(fecha_creacion,'%d/%m/%Y') AS 'Fecha Inicio' " +
                                        "FROM usuarios " +
                                        "WHERE estatus = 1 " +
                                        "AND nombre = IFNULL(@usuario, nombre);", conexion);

                cm.Parameters.AddWithValue("@usuario", cbEmpleados.SelectedValue);

            }
            
            if ((cbEmpleados.SelectedIndex == -1) && (dtpFecha.CustomFormat != " "))
            {

                cm = new MySqlCommand("SELECT " +
                                            "nombre AS Nombre, " +
                                            "salarioXdia AS 'Salario Diario', " +
                                            "diasSemanas AS 'Días Trabajo'," +
                                            "DATE_FORMAT(fecha_creacion,'%d/%m/%Y') AS 'Fecha Inicio' " +
                                        "FROM usuarios " +
                                        "WHERE estatus = 1 " +
                                        "AND DATE(fecha_creacion) = IFNULL(@fecha,DATE(fecha_creacion));", conexion);

                cm.Parameters.AddWithValue("@fecha", fecha);

            }
            
            if ((cbEmpleados.SelectedIndex != -1) && (dtpFecha.CustomFormat != " "))
            {

                cm = new MySqlCommand("SELECT " +
                                            "nombre AS Nombre, " +
                                            "salarioXdia AS 'Salario Diario', " +
                                            "diasSemanas AS 'Días Trabajo'," +
                                            "DATE_FORMAT(fecha_creacion,'%d/%m/%Y') AS 'Fecha Inicio' " +
                                        "FROM usuarios " +
                                        "WHERE estatus = 1 " +
                                        "AND nombre = IFNULL(@usuario, nombre) " +
                                        "AND DATE(fecha_creacion) = IFNULL(@fecha,DATE(fecha_creacion));", conexion);

                cm.Parameters.AddWithValue("@usuario", cbEmpleados.SelectedValue);
                cm.Parameters.AddWithValue("@fecha", fecha);

            }

            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = cm;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvEmpleados.DataSource = tabla;

            dgvEmpleados.AutoResizeColumns();
            dgvEmpleados.ClearSelection();
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            dtpFecha.CustomFormat = "dd/MM/yyyy";
        }

        ReportDataSource rs = new ReportDataSource();

        private void btnPDF_Click(object sender, EventArgs e)
        {
            List<RepEmpleadosObject> lista = new List<RepEmpleadosObject>();
            lista.Clear();

            for (int i = 0; i < dgvEmpleados.Rows.Count - 1; i++)
            {

                RepEmpleadosObject rep = new RepEmpleadosObject
                {
                    nombre = dgvEmpleados.Rows[i].Cells[0].Value.ToString(),
                    salarioDiario = int.Parse(dgvEmpleados.Rows[i].Cells[1].Value.ToString()),
                    diasTrabajo = int.Parse(dgvEmpleados.Rows[i].Cells[2].Value.ToString()),
                    fecha_inicio = DateTime.Parse(dgvEmpleados.Rows[i].Cells[3].Value.ToString())
                };

                lista.Add(rep);

            }

            rs.Name = "DataSetReporte";
            rs.Value = lista;
            reporte repInv = new reporte();
            repInv.reporteView.LocalReport.DataSources.Clear();
            repInv.reporteView.LocalReport.DataSources.Add(rs);
            repInv.reporteView.LocalReport.ReportEmbeddedResource = "Kelotitos.Reportes.repEmp.rdlc";
            repInv.ShowDialog();
        }
    }

    //Objeto para el reporte
    public class RepEmpleadosObject
    {
        public string nombre { get; set; }
        public int salarioDiario { get; set; }
        public int diasTrabajo { get; set; }
        public DateTime fecha_inicio { get; set; }
    }
}
