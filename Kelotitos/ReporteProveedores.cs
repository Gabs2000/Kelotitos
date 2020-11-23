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
                                                    "calle AS Calle, " +
                                                    "colonia AS Colonia, " +
                                                    "municipio AS Municipio, " +
                                                    "estado AS Estado, " +
                                                    "codigo_postal AS 'Código Postal', " +
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
    }
}
