using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using iText.Layout.Element;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kelotitos.ModelsDB;
using Kelotitos.MySql;
using MySql.Data.MySqlClient;

namespace Kelotitos
{
    public partial class RegistrarProductos : Form
    {
        MySqlConnection conexion;
        public RegistrarProductos()
        {
            InitializeComponent();
        }

        private void RegistrarProductos_Load(object sender, EventArgs e)
        {
            this.cargarTiposProductos();
            this.cargarTamanios();
        }

        private void cargarTiposProductos()
        {
            conexion = Connection.GetConnection();

            //Retorna todos los tipos de productos que están registrados en la tabla cat_tipos_productos
            MySqlCommand cm = new MySqlCommand("SELECT " +
                                                    "tipo_producto, " +
                                                    "id_tipo_producto " +
                                                "FROM cat_tipos_productos " +
                                                "WHERE estatus = 1", conexion);
            MySqlDataReader reader;
            reader = cm.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("id_tipo_producto", typeof(int));
            dt.Columns.Add("tipo_producto", typeof(string));
            dt.Load(reader);

            cbTipo.ValueMember = "id_tipo_producto";
            cbTipo.DisplayMember = "tipo_producto";
            cbTipo.DataSource = dt;

        }

        private void cargarTamanios()
        {
            conexion = Connection.GetConnection();
            //Se retorna los diferentes tamaños que están registrados en la tabla cat_tamanios
            MySqlCommand cm = new MySqlCommand("SELECT " +
                                                    "tamanio, " +
                                                    "id_tamanio " +
                                                "FROM cat_tamanios " +
                                                "WHERE estatus = 1", conexion);
            MySqlDataReader reader;

            reader = cm.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("id_tamanio", typeof(int));
            dt.Columns.Add("tamanio", typeof(string));
            dt.Load(reader);

            cbTamanio.ValueMember = "id_tamanio";
            cbTamanio.DisplayMember = "tamanio";
            cbTamanio.DataSource = dt;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Elegir ToMenu = new Elegir();
            this.Hide();
            ToMenu.Show();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion = Connection.GetConnection();
                MySqlCommand con = new MySqlCommand("INSERT INTO cat_productos " +
                                                    "(nombre, id_tipo_producto, id_tamanio, precio, " +
                                                    "estatus, fecha_creacion) " +
                                                    "VALUES " +
                                                    "(@nombre, @idTipoProducto, @idTamanio, @precio, 1, NOW())", conexion);
                con.Parameters.AddWithValue("@nombre", txtNombre.Text);
                con.Parameters.AddWithValue("@idTipoProducto", cbTipo.SelectedValue);
                con.Parameters.AddWithValue("@idTamanio", cbTamanio.SelectedValue);
                con.Parameters.AddWithValue("@precio", Convert.ToInt32(txtPrecio.Text));
                con.ExecuteNonQuery();

                MessageBox.Show("Registrado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtNombre.Text = "";
                cbTipo.SelectedValue = 0;
                cbTamanio.SelectedValue = 0;
                txtPrecio.Text = "";

            }
            catch (Exception err)
            {
                MessageBox.Show("Hubo un error al momento de registrar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Console.WriteLine(err);
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lbhora.Text = DateTime.Now.ToString("hh:mm:ss dddd MMMM yyy ");
        }

        private void Lbhora_Click(object sender, EventArgs e)
        {
            lbhora.Text = DateTime.Now.ToString("hh:mm:ss dddd MMMM yyy ");
        }
    }
}
