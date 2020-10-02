using iText.Layout.Element;
using MySql.Data.MySqlClient;
using Kelotitos.ModelsDB;
using Kelotitos.MySql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Kelotitos
{
    public partial class Comida : Form
    {
        MySqlConnection conexion;
        List<ProductAccount> listaProductos;
        List<ProductAccount> carrito;
        int n;

        public Comida()
        {
            InitializeComponent();
        }
        public Comida(clientAccount cliente)
        {
            InitializeComponent();
        }

        private void Comida_Load(object sender, EventArgs e)
        {
            carrito = new List<ProductAccount>();
            listaProductos = new List<ProductAccount>();

            this.cargarProductos();
            this.cargarTiposProductos();
            this.cargarTamanios();


        }

        private void cargarProductos()
        {
            conexion = Connection.GetConnection();
            MySqlCommand cm = new MySqlCommand("SELECT id_producto,nombre FROM cat_productos WHERE estatus = 1", conexion);
            MySqlDataReader reader;

            reader = cm.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("id_producto", typeof(int));
            dt.Columns.Add("nombre", typeof(string));
            dt.Load(reader);

            cbProducto.ValueMember = "id_producto";
            cbProducto.DisplayMember = "nombre";
            cbProducto.DataSource = dt;
        }

        private void cargarTiposProductos()
        {
            conexion = Connection.GetConnection();
            MySqlCommand cm = new MySqlCommand("SELECT id_tipo_producto, tipo_producto FROM cat_tipos_productos WHERE estatus = 1", conexion);
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
            MySqlCommand cm = new MySqlCommand("SELECT id_tamanio, tamanio FROM cat_tamanios WHERE estatus = 1", conexion);
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if((cbProducto.SelectedItem != null) && (cbTipo != null) && (cbTamanio != null))
            {
                //Agregamos al carrito
                string nombre, tipoProducto, tamanio;
                int precio, id;
                conexion = Connection.GetConnection();

                //Obtenemos el id del producto
                MySqlCommand cmId= new MySqlCommand("SELECT " +
                                                            "P.id_producto " +
                                                        "FROM cat_productos P " +
                                                        "INNER JOIN cat_tamanios T " +
                                                            "ON P.id_tamanio = T.id_tamanio " +
                                                        "INNER JOIN cat_tipos_productos TP " +
                                                            "ON P.id_tipo_producto = TP.id_tipo_producto " +
                                                        "WHERE P.id_producto = @idProducto " +
                                                        "AND P.id_tamanio = @idTamanio " +
                                                        "AND P.id_tipo_producto = @idTipoProducto", conexion);
                cmId.Parameters.AddWithValue("@idProducto", cbProducto.SelectedValue);
                cmId.Parameters.AddWithValue("@idTamanio", cbTamanio.SelectedValue);
                cmId.Parameters.AddWithValue("@idTipoProducto", cbTipo.SelectedValue);

                var resultadoId = cmId.ExecuteScalar();

                id = Convert.ToInt32(Convert.ToString(resultadoId));

                //Obtenemos el nombre del producto
                MySqlCommand cmNombre = new MySqlCommand("SELECT " +
                                                            "P.nombre " +
                                                        "FROM cat_productos P " +
                                                        "INNER JOIN cat_tamanios T " +
                                                            "ON P.id_tamanio = T.id_tamanio " +
                                                        "INNER JOIN cat_tipos_productos TP " +
                                                            "ON P.id_tipo_producto = TP.id_tipo_producto " +
                                                        "WHERE P.id_producto = @idProducto " +
                                                        "AND P.id_tamanio = @idTamanio " +
                                                        "AND P.id_tipo_producto = @idTipoProducto", conexion);
                cmNombre.Parameters.AddWithValue("@idProducto", cbProducto.SelectedValue);
                cmNombre.Parameters.AddWithValue("@idTamanio", cbTamanio.SelectedValue);
                cmNombre.Parameters.AddWithValue("@idTipoProducto", cbTipo.SelectedValue);

                var resultadoNombre = cmNombre.ExecuteScalar();

                nombre = Convert.ToString(resultadoNombre);


                // Obtenemos el tipo de producto
                MySqlCommand cmTipo = new MySqlCommand("SELECT " +
                                                            "TP.tipo_producto " +
                                                        "FROM cat_productos P " +
                                                        "INNER JOIN cat_tamanios T " +
                                                            "ON P.id_tamanio = T.id_tamanio " +
                                                        "INNER JOIN cat_tipos_productos TP " +
                                                            "ON P.id_tipo_producto = TP.id_tipo_producto " +
                                                        "WHERE P.id_producto = @idProducto " +
                                                        "AND P.id_tamanio = @idTamanio " +
                                                        "AND P.id_tipo_producto = @idTipoProducto", conexion);
                cmTipo.Parameters.AddWithValue("@idProducto", cbProducto.SelectedValue);
                cmTipo.Parameters.AddWithValue("@idTamanio", cbTamanio.SelectedValue);
                cmTipo.Parameters.AddWithValue("@idTipoProducto", cbTipo.SelectedValue);

                var resultadoTipo = cmTipo.ExecuteScalar();

                tipoProducto = Convert.ToString(resultadoTipo);


                // Obtenemos el tamaño de producto
                MySqlCommand cmTamanio = new MySqlCommand("SELECT " +
                                                            "T.tamanio " +
                                                        "FROM cat_productos P " +
                                                        "INNER JOIN cat_tamanios T " +
                                                            "ON P.id_tamanio = T.id_tamanio " +
                                                        "INNER JOIN cat_tipos_productos TP " +
                                                            "ON P.id_tipo_producto = TP.id_tipo_producto " +
                                                        "WHERE P.id_producto = @idProducto " +
                                                        "AND P.id_tamanio = @idTamanio " +
                                                        "AND P.id_tipo_producto = @idTipoProducto", conexion);
                cmTamanio.Parameters.AddWithValue("@idProducto", cbProducto.SelectedValue);
                cmTamanio.Parameters.AddWithValue("@idTamanio", cbTamanio.SelectedValue);
                cmTamanio.Parameters.AddWithValue("@idTipoProducto", cbTipo.SelectedValue);

                var resultadoTamanio = cmTamanio.ExecuteScalar();

                tamanio = Convert.ToString(resultadoTamanio);


                // Obtenemos el precio de producto
                MySqlCommand cmPrecio = new MySqlCommand("SELECT " +
                                                            "P.precio " +
                                                        "FROM cat_productos P " +
                                                        "INNER JOIN cat_tamanios T " +
                                                            "ON P.id_tamanio = T.id_tamanio " +
                                                        "INNER JOIN cat_tipos_productos TP " +
                                                            "ON P.id_tipo_producto = TP.id_tipo_producto " +
                                                        "WHERE P.id_producto = @idProducto " +
                                                        "AND P.id_tamanio = @idTamanio " +
                                                        "AND P.id_tipo_producto = @idTipoProducto", conexion);
                cmPrecio.Parameters.AddWithValue("@idProducto", cbProducto.SelectedValue);
                cmPrecio.Parameters.AddWithValue("@idTamanio", cbTamanio.SelectedValue);
                cmPrecio.Parameters.AddWithValue("@idTipoProducto", cbTipo.SelectedValue);

                var resultadoPrecio = cmPrecio.ExecuteScalar();

                precio = Convert.ToInt32(Convert.ToString(resultadoPrecio));



                //Console.WriteLine(id + ", " + nombre + ", " + tipoProducto + ", " + tamanio + ", " + precio);

                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = id;
                dataGridView1.Rows[n].Cells[1].Value = nombre;
                dataGridView1.Rows[n].Cells[2].Value = tipoProducto;
                dataGridView1.Rows[n].Cells[3].Value = tamanio;
                dataGridView1.Rows[n].Cells[4].Value = precio;
                dataGridView1.Rows[n].Cells[5].Value = 1;
                dataGridView1.Rows[n].Cells[6].Value = precio;
            }
        }






        //Anterior

        private void cargarAlimentos(string product)
        {
            comboBox2.Items.Clear();
            listaProductos.Clear();
            conexion = Connection.GetConnection();
            MySqlCommand cm = new MySqlCommand("SELECT id_prod, name_prod, des_prod, price_prod, stock_prod FROM product WHERE name_prod = @product && stock_prod > 0", conexion);
            cm.Parameters.AddWithValue("@product", product);
            MySqlDataReader consultar = cm.ExecuteReader();
            while (consultar.Read())
            {
                ProductAccount producto = new ProductAccount();
                producto.id_prod = consultar.GetInt32(0);
                producto.name_prod = consultar.GetString(1);
                producto.des_prod = consultar.GetString(2);
                producto.price_prod = consultar.GetDouble(3);
                producto.stock_prod = consultar.GetInt32(4);
                listaProductos.Add(producto);
                ComboBoxItem item = new ComboBoxItem();
                item.Text = $"{producto.des_prod}";
                item.Value = producto.id_prod;

                comboBox2.Items.Add(item);
                comboBox2.SelectedIndex = 0;
            }

            if (comboBox2.Items.Count == 0)
            {
                comboBox2.Text = "";
            }

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            //TODO: Hacer transacciones
            //Insertar compra
            if (carrito.Count > 0)
            {
                int id;
                MySqlConnection conexion = Connection.GetConnection();
                MySqlCommand comm = conexion.CreateCommand();
                comm.CommandText = "INSERT INTO sale (datetime_sale, total_sale, client_id_client, user_id_user) VALUES (now(), 0, @client, @user)";
                comm.Parameters.AddWithValue("@user", Login.idUsuario);
                comm.ExecuteNonQuery();
                id = Convert.ToInt32(comm.LastInsertedId);
                conexion.Close();

                //Insertar detalles de compra 
                int noRows = -1;
                foreach (ProductAccount producto in carrito)
                {
                    try
                    {
                        conexion = Connection.GetConnection();
                        comm = conexion.CreateCommand();
                        comm.CommandText = "INSERT INTO sale_has_product (sale_id_sale, product_id_prod, quantity_prod) VALUES (@id_sale, @id_prod, 1)";
                        comm.Parameters.AddWithValue("@id_sale", id);
                        comm.Parameters.AddWithValue("@id_prod", producto.id_prod);
                        noRows = comm.ExecuteNonQuery();
                    }
                    catch (Exception err)
                    {
                        Console.WriteLine(err);
                    }
                    finally
                    {
                        conexion.Close();
                    }
                }

                if (noRows > 0)
                {
                    MessageBox.Show("Compra registrada con exito", "Compra realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reset();
                }
                else
                {
                    MessageBox.Show("Hubo un error en la transaccion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Agregue algunos articulos antes de confirmar", "Carrito vacio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Confirmacion_de_pedido ToMenu = new Confirmacion_de_pedido(carrito);
            this.Hide();
            ToMenu.Show();
        }
        private void reset()
        {
            carrito.Clear();
            dataGridView1.Rows.Clear();
            label5.Text = "$0.00";
        }

        private void Lbhora_Click(object sender, EventArgs e)
        {
            lbhora.Text = DateTime.Now.ToString("hh:mm:ss dddd MMMM yyy ");
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lbhora.Text = DateTime.Now.ToString("hh:mm:ss dddd MMMM yyy ");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Elegir ToElegir = new Elegir();
            this.Hide();
            ToElegir.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text != "")
            {
                //agregamos al carrito
                ProductAccount productNew = listaProductos[comboBox2.SelectedIndex];
                productNew.items = 1;

                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = productNew.id_prod;
                dataGridView1.Rows[n].Cells[1].Value = productNew.name_prod;
                dataGridView1.Rows[n].Cells[2].Value = productNew.des_prod;
                dataGridView1.Rows[n].Cells[3].Value = productNew.price_prod;
                dataGridView1.Rows[n].Cells[4].Value = 1;
                dataGridView1.Rows[n].Cells[5].Value = productNew.price_prod;
                carrito.Add(productNew);
                sumarTotal(productNew.price_prod);

                
            }
        }

        private void sumarTotal(double subtotal)
        {
            double nuevoTotal = Double.Parse(label5.Text.Replace("$", "")) + subtotal;
            string total = string.Format("{0:0.00}", nuevoTotal);
            label5.Text = $"${total}";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (n != -1)
            {
                try
                {
                    dataGridView1.Rows.RemoveAt(n);
                    sumarTotal(carrito[n].price_prod * -1);
                    Console.WriteLine(carrito[n].price_prod * -1);
                    carrito.RemoveAt(n);
                    for (int i = 0; i < carrito.Count; i++)
                    {
                        Console.WriteLine(carrito[i].name_prod);
                    }
                }
                catch (System.InvalidOperationException err)
                {
                    MessageBox.Show("La nueva fila sin confirmar no se puede eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            n = e.RowIndex;
            Console.WriteLine(n);
        }
    }
}
