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
    }
}
