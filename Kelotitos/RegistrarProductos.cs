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
            //this.cargarProductos();
            this.cargarTiposProductos();
            this.cargarTamanios();
        }

        //private void cargarProductos()
        //{
        //    conexion = Connection.GetConnection();
        //    MySqlCommand cm = new MySqlCommand("SELECT " +
        //                                            "nombre " +
        //                                        "FROM cat_productos " +
        //                                        "WHERE estatus = 1 " +
        //                                        "GROUP BY nombre", conexion);
        //    MySqlDataReader reader;

        //    reader = cm.ExecuteReader();
        //    DataTable dt = new DataTable();
        //    dt.Columns.Add("nombre", typeof(string));
        //    dt.Load(reader);

        //    comboBox1.DisplayMember = "nombre";
        //    comboBox1.DataSource = dt;
        //}

        private void cargarTiposProductos()
        {
            conexion = Connection.GetConnection();

            //Retorna todos los tipos de productos que tiene asignado el producto elegido
            MySqlCommand cm = new MySqlCommand("SELECT tipo_producto, id_tipo_producto FROM cat_tipos_productos", conexion);
            //cm.Parameters.AddWithValue("@nombre", comboBox1.Text);
            MySqlDataReader reader;
            reader = cm.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("id_tipo_producto", typeof(int));
            dt.Columns.Add("tipo_producto", typeof(string));
            dt.Load(reader);

            comboBox1.ValueMember = "id_tipo_producto";
            comboBox1.DisplayMember = "tipo_producto";
            comboBox1.DataSource = dt;

            //while (reader.read())
            //{
            //    cattiposprod select = new cattiposprod();
            //    select.id_tipo_producto = reader.getint32(0);
            //    select.tipo_producto =

            //    combobox2.items.add(reader.getint32(0));
            //    combobox2.items.add(reader.getstring(1));

            //    combobox2.selectedindex = 0;

            //    datatable dt = new datatable();
            //    dt.columns.add("tipo_producto", typeof(string));
            //    dt.load(reader);

            //    combobox2.valuemember = "";
            //    combobox2.displaymember = "tipo_producto";
            //    combobox2.datasource = dt;
            //}
        }

        private void cargarTamanios()
        {
            conexion = Connection.GetConnection();
            //Se retorna los diferentes tamaños que tiene asignado el producto y tipo de producto seleccionado
            MySqlCommand cm = new MySqlCommand("SELECT tamanio, id_tamanio FROM cat_tamanios", conexion);
            MySqlDataReader reader;

            reader = cm.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("id_tamanio", typeof(int));
            dt.Columns.Add("tamanio", typeof(string));
            dt.Load(reader);

            comboBox2.ValueMember = "id_tamanio";
            comboBox2.DisplayMember = "tamanio";
            comboBox2.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ProductAccount newProductAccount = new ProductAccount();

            ////int providerSelected = listaProveedores[comboBox1.SelectedIndex].id_prov;

            ////Para convertir string a int se puede usar; int.TryParse, int.Parse, Convert.ToInt32
            //newProductAccount.nombre = name_textbox.Text.Trim();
            //newProductAccount.id_tipo_producto = int.Parse(textBox2.Text.Trim());
            //newProductAccount.id_tamanio = int.Parse(textBox1.Text.Trim());
            //newProductAccount.precio = int.Parse(textBox3.Text.Trim());
            //newProductAccount.estatus = 1;
            //newProductAccount.fecha_creacion = DateTime.Now;

            //if (string.IsNullOrEmpty(name_textbox.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox3.Text))
            //{
            //    MessageBox.Show("Los campos no pueden quedar vacíos", "Registro Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else
            //{
            //    try
            //    {
            //        MySqlConnection conexion = Connection.GetConnection();
            //        MySqlCommand comm = conexion.CreateCommand();
            //        comm.CommandText = "INSERT INTO `cat_productos` (nombre, id_tipo_producto, id_tamanio, precio, estatus, fecha_creación) VALUES(@name, @tipo_producto, @tamaño, @precio, @estatus, @fecha_creacion)";
            //        comm.Parameters.AddWithValue("@name", name_textbox.Text);
            //        comm.Parameters.AddWithValue("@tipo_producto", textBox2.Text);
            //        comm.Parameters.AddWithValue("@tamaño", textBox1.Text);
            //        comm.Parameters.AddWithValue("@precio", textBox3.Text);
            //        comm.Parameters.AddWithValue("@estatus", 0);
            //        comm.Parameters.AddWithValue("@fecha_creacion", /*providerSelected*/ DateTime.Now);
            //        comm.ExecuteNonQuery();
            //        conexion.Close();
            //    }
            //    catch (Exception err)
            //    {
            //        Console.WriteLine(err);
            //    }
            //    name_textbox.Text = "";
            //    textBox1.Text = "";
            //    textBox2.Text = "";
            //    textBox3.Text = "";
            //    comboBox1.SelectedIndex = 0;
            //}




            //if ((cbProducto.SelectedItem != null) && (cbTipo != null))
            //{
            //    try
            //    {
            //        if (numCantidad.Value > 0)
            //        {
            //            lblError.Text = "Error";
            //            lblError.Visible = false;

            //            //Agregamos al carrito
            //            double subtotal;
            //            conexion = Connection.GetConnection();

            //            //Obtenemos el id del producto
            //            MySqlCommand cmId = new MySqlCommand("SELECT " +
            //                                                    "P.id_producto, " +
            //                                                    "P.nombre, " +
            //                                                    "TP.tipo_producto, " +
            //                                                    "T.tamanio, " +
            //                                                    "P.precio " +
            //                                                "FROM cat_productos P " +
            //                                                "LEFT OUTER JOIN cat_tamanios T " +
            //                                                   "ON P.id_tamanio = T.id_tamanio " +
            //                                                "LEFT OUTER JOIN cat_tipos_productos TP " +
            //                                                    "ON P.id_tipo_producto = TP.id_tipo_producto " +
            //                                                "WHERE P.nombre = @nombre " +
            //                                                "AND P.id_tipo_producto = @idTipoProducto " +
            //                                                "AND IF(TP.si_tamanio = 1, P.id_tamanio = @idTamanio, P.id_tamanio IS NULL) " +
            //                                                "AND P.estatus = 1 ", conexion);
            //            cmId.Parameters.AddWithValue("@nombre", cbProducto.Text);
            //            cmId.Parameters.AddWithValue("@idTipoProducto", cbTipo.SelectedValue);
            //            cmId.Parameters.AddWithValue("@idTamanio", cbTamanio.SelectedValue);

            //            var resultado = cmId.ExecuteReader();

            //            //Una vez que se agrega el producto, se resetean los campos
            //            cbProducto.SelectedIndex = 0;
            //            cbTamanio.SelectedIndex = 0;
            //            cbTipo.SelectedIndex = 0;
            //            numCantidad.Value = 0;

            //            // Evita que se seleccione automáticamente una fila
            //            dgwCarrito.ClearSelection();
            //        }
            //        else
            //        {
            //            lblError.Text = "Error: Debes de poner una cantidad de producto!";
            //            lblError.Visible = true;
            //        }
            //    }
            //    catch (Exception err)
            //    {
            //        Console.WriteLine(err);
            //    }

            //}
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            lbhora.Text = DateTime.Now.ToString("hh:mm:ss dddd MMMM yyy ");
        }

        private void Lbhora_Click(object sender, EventArgs e)
        {
            lbhora.Text = DateTime.Now.ToString("hh:mm:ss dddd MMMM yyy ");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Elegir ToMenu = new Elegir();
            this.Hide();
            ToMenu.Show();
        }
    }
}
