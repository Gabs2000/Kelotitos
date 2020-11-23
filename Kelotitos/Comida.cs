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
        int indice;

        public Comida()
        {
            InitializeComponent();
        }

        private void Comida_Load(object sender, EventArgs e)
        {
            this.cargarProductos();
        }

        private void cargarProductos()
        {
            conexion = Connection.GetConnection();
            MySqlCommand cm = new MySqlCommand("SELECT " +
                                                    "nombre " +
                                                "FROM cat_productos " +
                                                "WHERE estatus = 1 " +
                                                "GROUP BY nombre", conexion);
            MySqlDataReader reader;

            reader = cm.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("nombre", typeof(string));
            dt.Load(reader);

            cbProducto.DisplayMember = "nombre";
            cbProducto.DataSource = dt;
        }

        private void cbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Cada que se cambie el producto se va a ejecutar este método
            this.cargarTiposProductos();
        }

        private void cargarTiposProductos()
        {
            conexion = Connection.GetConnection();

            //Retorna todos los tipos de productos que tiene asignado el producto elegido
            MySqlCommand cm = new MySqlCommand("SELECT " +
                                                    "TP.id_tipo_producto, " +
                                                    "TP.tipo_producto " +
                                                "FROM cat_productos P " +
                                                "INNER JOIN snack_db.cat_tipos_productos TP " +
                                                    "ON P.id_tipo_producto = TP.id_tipo_producto " +
                                                "WHERE P.nombre = @nombre " +
                                                "AND P.estatus = 1 " +
                                                "GROUP BY TP.id_tipo_producto, TP.tipo_producto", conexion);
            cm.Parameters.AddWithValue("@nombre", cbProducto.Text);
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

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Cada que se cambie el tipo de producto se va a ejecutar este método
            this.cargarTamanios();
        }

        private void cargarTamanios()
        {
            conexion = Connection.GetConnection();
            //Se retorna los diferentes tamaños que tiene asignado el producto y tipo de producto seleccionado
            MySqlCommand cm = new MySqlCommand("SELECT " +
                                                    "P.id_tamanio, " +
                                                    "T.tamanio " +
                                                "FROM cat_productos P " +
                                                "LEFT OUTER JOIN cat_tamanios T " +
                                                    "ON P.id_tamanio = T.id_tamanio " +
                                                "LEFT OUTER JOIN cat_tipos_productos TP " +
                                                    "ON P.id_tipo_producto = TP.id_tipo_producto " +
                                                "WHERE P.nombre = @nombre " +
                                                "AND P.id_tipo_producto = @idTipoProducto " +
                                                "AND P.estatus = 1", conexion);
            cm.Parameters.AddWithValue("@nombre", cbProducto.Text);
            cm.Parameters.AddWithValue("@idTipoProducto", cbTipo.SelectedValue);
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
            if ((cbProducto.SelectedItem != null) && (cbTipo != null))
            {
                try
                {
                    if (numCantidad.Value > 0)
                    {
                        lblError.Text = "Error";
                        lblError.Visible = false;

                        //Agregamos al carrito
                        double subtotal;
                        conexion = Connection.GetConnection();

                        //Obtenemos el id del producto
                        MySqlCommand cmId = new MySqlCommand("SELECT " +
                                                                "P.id_producto, " +
                                                                "P.nombre, " +
                                                                "TP.tipo_producto, " +
                                                                "T.tamanio, " +
                                                                "P.precio " +
                                                            "FROM cat_productos P " +
                                                            "LEFT OUTER JOIN cat_tamanios T " +
                                                               "ON P.id_tamanio = T.id_tamanio " +
                                                            "LEFT OUTER JOIN cat_tipos_productos TP " +
                                                                "ON P.id_tipo_producto = TP.id_tipo_producto " +
                                                            "WHERE P.nombre = @nombre " +
                                                            "AND P.id_tipo_producto = @idTipoProducto " +
                                                            "AND IF(TP.si_tamanio = 1, P.id_tamanio = @idTamanio, P.id_tamanio IS NULL) " +
                                                            "AND P.estatus = 1 ", conexion);
                        cmId.Parameters.AddWithValue("@nombre", cbProducto.Text);
                        cmId.Parameters.AddWithValue("@idTipoProducto", cbTipo.SelectedValue);
                        cmId.Parameters.AddWithValue("@idTamanio", cbTamanio.SelectedValue);

                        var resultado = cmId.ExecuteReader();

                        if (resultado.HasRows)
                        {
                            resultado.Read();// Get first record.

                            // Se guardan los valores en el datagridview1
                            int n = dgwCarrito.Rows.Add();
                            dgwCarrito.Rows[n].Cells[0].Value = resultado.GetInt32(0);
                            dgwCarrito.Rows[n].Cells[1].Value = resultado.GetString(1);
                            dgwCarrito.Rows[n].Cells[2].Value = resultado.GetString(2);
                            if (resultado[3] != DBNull.Value)
                            {
                                dgwCarrito.Rows[n].Cells[3].Value = resultado.GetString(3);
                            }
                            dgwCarrito.Rows[n].Cells[4].Value = resultado.GetInt32(4);
                            dgwCarrito.Rows[n].Cells[5].Value = numCantidad.Value;

                            subtotal = Convert.ToDouble(resultado.GetInt32(4) * numCantidad.Value);
                            dgwCarrito.Rows[n].Cells[6].Value = subtotal;

                            //Una vez que se agrega el producto, se resetean los campos
                            cbProducto.SelectedIndex = 0;
                            cbTamanio.SelectedIndex = 0;
                            cbTipo.SelectedIndex = 0;
                            numCantidad.Value = 0;

                            //Le sumamos al total el subtotal
                            this.sumarTotal(subtotal);
                        }

                        // Evita que se seleccione automáticamente una fila
                        dgwCarrito.ClearSelection();

                    }
                    else
                    {
                        lblError.Text = "Error: Debes de poner una cantidad de producto!";
                        lblError.Visible = true;
                    }
                }
                catch (Exception err)
                {
                    Console.WriteLine(err);
                }

            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgwCarrito.Rows.Count > 1)
                {

                    int idVenta, cantidad;

                    string folio;
                    string queryContador = "SELECT COUNT(*) FROM snack_db.ventas";

                    string queryInsertVenta = "INSERT INTO snack_db.ventas " +
                                                    "(folio, id_usuario, fecha_venta, total, estatus, fecha_creacion) " +
                                                "VALUES " +
                                                    "(@folio,@idUsuario,NOW(),@total,1,NOW())";

                    string queryMaximo = "SELECT MAX(folio) FROM snack_db.ventas";

                    string queryDetalleVenta = "INSERT INTO snack_db.detalles_ventas " +
                                                "(id_venta, id_producto, cantidad, estatus, fecha_creacion) " +
                                                "VALUES " +
                                                "(@idVenta,@idProducto,@cantidad,1,NOW())";

                    conexion = Connection.GetConnection();

                    //Obtenemos el valor de registros que hay en la tabla ventas y guardamos el valor en la
                    //variable cantidad
                    using (MySqlCommand cm = new MySqlCommand(queryContador, conexion))
                    {
                        using (var resultado = cm.ExecuteReader())
                        {
                            resultado.Read();

                            cantidad = resultado.GetInt32(0);

                            resultado.Close();
                        }
                    }

                    if (cantidad > 0)
                    {
                        //Si existen registros en la tabla ventas, entonces generamos el siguiente número de folio
                        using (MySqlCommand cmFa = new MySqlCommand(queryMaximo, conexion))
                        {

                            var folioAnterior = cmFa.ExecuteReader();

                            folioAnterior.Read();

                            folio = (Convert.ToInt32(folioAnterior.GetString(0)) + 1).ToString();

                            //Agrega los ceros necesarios para que quede el folio con el formato 0000
                            if (folio.Length == 1)
                            {
                                folio = "000" + folio;
                            }
                            else if (folio.Length == 2)
                            {
                                folio = "00" + folio;
                            }
                            else if (folio.Length == 3)
                            {
                                folio = "0" + folio;
                            }

                            folioAnterior.Close();
                        }

                    }
                    else
                    {
                        //Si no hay registros en la tabla ventas, entonces ponemos el folio como 0001
                        folio = "0001";
                    }

                    // Insertamos en la tabla ventas
                    using (MySqlCommand venta = new MySqlCommand(queryInsertVenta, conexion))
                    {
                        string total = lblTotal.Text.Replace("$", "");
                        total = total.Replace(",", ".");

                        venta.Parameters.AddWithValue("@folio", folio);
                        venta.Parameters.AddWithValue("@idUsuario", Login.idUsuario);
                        venta.Parameters.AddWithValue("@total", total);
                        venta.ExecuteNonQuery();
                        idVenta = Convert.ToInt32(venta.LastInsertedId);

                        Console.WriteLine(idVenta);
                    }

                    //Insertamos los detalles de la venta
                    foreach (DataGridViewRow row in dgwCarrito.Rows)
                    {
                        if (row.IsNewRow == false)
                        {
                            using (MySqlCommand detalle = new MySqlCommand(queryDetalleVenta, conexion))
                            {
                                detalle.Parameters.AddWithValue("@idVenta", idVenta);
                                detalle.Parameters.AddWithValue("@idProducto", row.Cells[0].Value);
                                detalle.Parameters.AddWithValue("@cantidad", row.Cells[5].Value);
                                detalle.ExecuteNonQuery();
                            }
                        }
                    }

                    //MessageBox.Show("Compra registrada con exito", "Compra realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.reset();

                    Confirmacion_de_pedido ToMenu = new Confirmacion_de_pedido();
                    this.Hide();
                    ToMenu.Show();

                }
                else
                {
                    MessageBox.Show("Agregue algunos articulos al carrito antes de confirmar", "Carrito vacio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Hubo un error en la transaccion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(err);
            }
        }

        private void sumarTotal(double subtotal)
        {
            double nuevoTotal = Double.Parse(lblTotal.Text.Replace("$", "")) + subtotal;
            string total = string.Format("{0:0.00}", nuevoTotal);
            lblTotal.Text = $"${total}";
        }

        private void restarTotal(double valor)
        {
            double nuevoTotal = Double.Parse(lblTotal.Text.Replace("$", "")) - valor;
            string total = string.Format("{0:0.00}", nuevoTotal);
            lblTotal.Text = $"${total}";
        }

        private void dgwCarrito_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Con este se obtiene el indice de la fila seleccionada
            indice = e.RowIndex;
            Console.WriteLine(indice);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (indice != -1)
            {
                try
                {
                    var valorSubtotal = Convert.ToDouble(dgwCarrito.Rows[indice].Cells[6].Value);

                    this.restarTotal(valorSubtotal);

                    dgwCarrito.Rows.RemoveAt(indice);
                    //Console.WriteLine("Eliminar: " + n);

                    // Evita que se seleccione automáticamente una fila
                    dgwCarrito.ClearSelection();
                }
                catch (System.InvalidOperationException err)
                {
                    MessageBox.Show("Debe seleccionar primero el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void btnRestarCant_Click(object sender, EventArgs e)
        {

            try
            {
                var valorPrecioUnitario = Convert.ToDouble(dgwCarrito.Rows[indice].Cells[4].Value);

                this.restarTotal(valorPrecioUnitario);

                dgwCarrito.Rows[indice].Cells[5].Value = (Convert.ToInt32(dgwCarrito.Rows[indice].Cells[5].Value) - 1).ToString();

                if (Convert.ToInt32(dgwCarrito.Rows[indice].Cells[5].Value) == 0)
                {
                    dgwCarrito.Rows.RemoveAt(indice);
                    // Evita que se seleccione automáticamente una fila
                    dgwCarrito.ClearSelection();
                }

                dgwCarrito.Rows[indice].Cells[6].Value = Convert.ToInt32(dgwCarrito.Rows[indice].Cells[4].Value) * Convert.ToInt32(dgwCarrito.Rows[indice].Cells[5].Value);

            }
            catch (System.InvalidOperationException err)
            {
                MessageBox.Show("Debe seleccionar primero el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSumarCant_Click(object sender, EventArgs e)
        {
            try
            {
                var valorPrecioUnitario = Convert.ToDouble(dgwCarrito.Rows[indice].Cells[4].Value);

                dgwCarrito.Rows[indice].Cells[5].Value = (Convert.ToInt32(dgwCarrito.Rows[indice].Cells[5].Value) + 1).ToString();

                this.sumarTotal(valorPrecioUnitario);

                dgwCarrito.Rows[indice].Cells[6].Value = Convert.ToInt32(dgwCarrito.Rows[indice].Cells[4].Value) * Convert.ToInt32(dgwCarrito.Rows[indice].Cells[5].Value);


            }
            catch (System.InvalidOperationException err)
            {
                MessageBox.Show("Debe seleccionar primero el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            if (Login.siAdmin == 0)
            {
                Login login = new Login();
                this.Hide();
                login.Show();
            }
            else
            {
                Elegir ToElegir = new Elegir();
                this.Hide();
                ToElegir.Show();
            }
            
        }

        private void Lbhora_Click(object sender, EventArgs e)
        {
            lbhora.Text = DateTime.Now.ToString("hh:mm:ss dddd MMMM yyy ");
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lbhora.Text = DateTime.Now.ToString("hh:mm:ss dddd MMMM yyy ");
        }

        private void reset()
        {
            dgwCarrito.Rows.Clear();
            lblTotal.Text = "$0.00";
        }

    }
}
