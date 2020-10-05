using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kelotitos.ModelsDB;

using MySql.Data.MySqlClient;
using Kelotitos.MySql;

namespace Kelotitos
{
    public partial class RegistrarCompra : Form
    {
        MySqlConnection conexion;
        int indice;

        public RegistrarCompra()
        {
            InitializeComponent();
        }

        private void dgwCompras_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            indice = e.RowIndex;
            Console.WriteLine(indice);
        }

        private void RegistrarCompra_Load(object sender, EventArgs e)
        {
            this.cargarInventario();
        }

        public void cargarInventario()
        {
            conexion = Connection.GetConnection();
            MySqlCommand cm = new MySqlCommand("SELECT " +
                                                    "id_inventario, " +
                                                    "nombre " +
                                                "FROM inventario " +
                                                "WHERE estatus = 1", conexion);
            MySqlDataReader reader;

            reader = cm.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("id_inventario", typeof(int));
            dt.Columns.Add("nombre", typeof(string));
            dt.Load(reader);

            cbInventario.ValueMember = "id_inventario";
            cbInventario.DisplayMember = "nombre";
            cbInventario.DataSource = dt;
        }

        private void cbInventario_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cargarProveedor();
        }

        public void cargarProveedor()
        {
            conexion = Connection.GetConnection();
            MySqlCommand cm = new MySqlCommand("SELECT " +
                                                    "P.id_proveedor, " +
                                                    "P.proveedor " +
                                                "FROM proveedores P " +
                                                "INNER JOIN inventario I " +
                                                    "ON P.id_proveedor = I.id_proveedor " +
                                                "WHERE P.estatus = 1 " +
                                                "AND I.nombre = @nombreInv", conexion);
            cm.Parameters.AddWithValue("@nombreInv", cbInventario.Text);
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if ((cbInventario != null) && (cbProveedor != null))
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
                                                                "I.id_inventario, " +
                                                                "I.nombre, " +
                                                                "P.proveedor, " +
                                                                "I.precio_compra " +
                                                            "FROM inventario I " +
                                                            "INNER JOIN proveedores P " +
                                                                "ON I.id_proveedor = P.id_proveedor " +
                                                            "WHERE P.estatus = 1 " +
                                                            "AND I.id_inventario = @idInventario " +
                                                            "AND P.id_proveedor = @idProveedor", conexion);
                        cmId.Parameters.AddWithValue("@idInventario", cbInventario.SelectedValue);
                        cmId.Parameters.AddWithValue("@idProveedor", cbProveedor.SelectedValue);

                        var resultado = cmId.ExecuteReader();

                        if (resultado.HasRows)
                        {
                            resultado.Read();// Get first record.

                            // Se guardan los valores en el datagridview1
                            int n = dgwCompras.Rows.Add();
                            dgwCompras.Rows[n].Cells[0].Value = resultado.GetInt32(0);
                            dgwCompras.Rows[n].Cells[1].Value = resultado.GetString(1);
                            dgwCompras.Rows[n].Cells[2].Value = resultado.GetString(2);
                            dgwCompras.Rows[n].Cells[3].Value = resultado.GetInt32(3);
                            dgwCompras.Rows[n].Cells[4].Value = numCantidad.Value;

                            subtotal = Convert.ToDouble(resultado.GetInt32(3) * numCantidad.Value);
                            dgwCompras.Rows[n].Cells[5].Value = subtotal;

                            //Una vez que se agrega el producto, se resetean los campos
                            cbInventario.SelectedIndex = 0;
                            cbProveedor.SelectedIndex = 0;
                            numCantidad.Value = 0;

                            //Le sumamos al total el subtotal
                            this.sumarTotal(subtotal);
                        }

                        // Evita que se seleccione automáticamente una fila
                        dgwCompras.ClearSelection();

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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (indice != -1)
            {
                try
                {
                    var valorSubtotal = Convert.ToDouble(dgwCompras.Rows[indice].Cells[5].Value);

                    this.restarTotal(valorSubtotal);

                    dgwCompras.Rows.RemoveAt(indice);
                    //Console.WriteLine("Eliminar: " + n);

                    // Evita que se seleccione automáticamente una fila
                    dgwCompras.ClearSelection();
                }
                catch (System.InvalidOperationException err)
                {
                    MessageBox.Show("Debe seleccionar primero el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

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

        private void btnSumarCant_Click(object sender, EventArgs e)
        {
            try
            {
                var valorPrecioUnitario = Convert.ToDouble(dgwCompras.Rows[indice].Cells[3].Value);

                dgwCompras.Rows[indice].Cells[4].Value = (Convert.ToInt32(dgwCompras.Rows[indice].Cells[4].Value) + 1).ToString();

                this.sumarTotal(valorPrecioUnitario);

                dgwCompras.Rows[indice].Cells[5].Value = Convert.ToInt32(dgwCompras.Rows[indice].Cells[3].Value) * Convert.ToInt32(dgwCompras.Rows[indice].Cells[4].Value);

            }
            catch (System.InvalidOperationException err)
            {
                MessageBox.Show("Debe seleccionar primero el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRestarCant_Click(object sender, EventArgs e)
        {
            try
            {
                var valorPrecioUnitario = Convert.ToDouble(dgwCompras.Rows[indice].Cells[3].Value);

                this.restarTotal(valorPrecioUnitario);

                dgwCompras.Rows[indice].Cells[4].Value = (Convert.ToInt32(dgwCompras.Rows[indice].Cells[4].Value) - 1).ToString();

                if (Convert.ToInt32(dgwCompras.Rows[indice].Cells[4].Value) == 0)
                {
                    dgwCompras.Rows.RemoveAt(indice);
                    // Evita que se seleccione automáticamente una fila
                    dgwCompras.ClearSelection();
                }

                dgwCompras.Rows[indice].Cells[5].Value = Convert.ToInt32(dgwCompras.Rows[indice].Cells[3].Value) * Convert.ToInt32(dgwCompras.Rows[indice].Cells[4].Value);

            }
            catch (System.InvalidOperationException err)
            {
                MessageBox.Show("Debe seleccionar primero el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgwCompras.Rows.Count > 0)
                {

                    string queryCompra = "INSERT INTO compras_proveedor " +
                                        "(id_inventario, cantidad, estatus, fecha_creacion) " +
                                        "VALUES " +
                                        "(@idInventario, @cantidad, 1, NOW())";

                    conexion = Connection.GetConnection();

                    //Insertamos las compras
                    foreach (DataGridViewRow row in dgwCompras.Rows)
                    {
                        if (row.IsNewRow == false)
                        {
                            using (MySqlCommand compra = new MySqlCommand(queryCompra, conexion))
                            {
                                compra.Parameters.AddWithValue("@idInventario", row.Cells[0].Value);
                                compra.Parameters.AddWithValue("@cantidad", row.Cells[4].Value);
                                compra.ExecuteNonQuery();
                            }
                        }
                    }

                    MessageBox.Show("Compra registrada con exito", "Compra realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.reset();

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
            dgwCompras.Rows.Clear();
            lblTotal.Text = "$0.00";
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Elegir ToMenu = new Elegir();
            this.Hide();
            ToMenu.Show();
        }
    }
}
