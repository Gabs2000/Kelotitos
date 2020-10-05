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
    public partial class RegistroInventario : Form
    {
        MySqlConnection conexion;
        public RegistroInventario()
        {
            InitializeComponent();
        }

        private void RegistroInventario_Load(object sender, EventArgs e)
        {
            this.cargarProveedores();
        }

        private void cargarProveedores()
        {
            conexion = Connection.GetConnection();
            MySqlCommand cm = new MySqlCommand("SELECT " +
                                                    "id_proveedor, " +
                                                    "proveedor " +
                                                "FROM proveedores " +
                                                "WHERE estatus = 1", conexion);
            MySqlDataReader reader;

            reader = cm.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("id_proveedor", typeof(int));
            dt.Columns.Add("proveedor", typeof(string));
            dt.Load(reader);

            cbProveedor.ValueMember = "id_proveedor";
            cbProveedor.DisplayMember = "proveedor";
            cbProveedor.DataSource = dt;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion = Connection.GetConnection();
                MySqlCommand con = new MySqlCommand("INSERT INTO inventario " +
                                                    "(nombre, descripcion, id_proveedor, cantidad, " +
                                                    "unidad_medida, precio_compra, estatus, fecha_creacion) " +
                                                    "VALUES " +
                                                    "(@nombre, @descripcion, @idProveedor, @cantidad, " +
                                                    "@unidadMedida, @precioCompra, 1, NOW())", conexion);
                con.Parameters.AddWithValue("@nombre", txtNombre.Text);
                con.Parameters.AddWithValue("@descripcion", txtDescripcion.Text);
                con.Parameters.AddWithValue("@idProveedor", cbProveedor.SelectedValue);
                con.Parameters.AddWithValue("@cantidad", numCantidad.Value);
                con.Parameters.AddWithValue("@unidadMedida", txtUnidad.Text);
                con.Parameters.AddWithValue("@precioCompra", Convert.ToInt32(txtPrecio.Text));
                con.ExecuteNonQuery();

                MessageBox.Show("Registrado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtNombre.Text = "";
                txtDescripcion.Text = "";
                cbProveedor.SelectedValue = 0;
                numCantidad.Value = 0;
                txtUnidad.Text = "";
                txtPrecio.Text = "";

            }
            catch (Exception err)
            {
                MessageBox.Show("Hubo un error al momento de insertar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Console.WriteLine(err);
            }
            
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Elegir elegir = new Elegir();
            this.Hide();
            elegir.Show();
        }
    }
}
