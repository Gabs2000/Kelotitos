using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_OASIS.ModelsDB;

using MySql.Data.MySqlClient;
using Proyecto_OASIS.MySql;

namespace Proyecto_OASIS
{
    public partial class RegistrarCompra : Form
    {
        List<providerAccount> listaProveedores;
        List<ProductAccount> listaProductos;
        List<ProductAccount> carrito;
        private int n = -1;

        public RegistrarCompra()
        {
            InitializeComponent();
        }

        private void Lbhora_Click(object sender, EventArgs e)
        {
            lbhora.Text = DateTime.Now.ToString("hh:mm:ss dddd MMMM yyy ");
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lbhora.Text = DateTime.Now.ToString("hh:mm:ss dddd MMMM yyy ");
        }

        private void RegistrarCompra_Load(object sender, EventArgs e)
        {
            listaProductos = new List<ProductAccount>();
            listaProveedores = new List<providerAccount>();
            carrito = new List<ProductAccount>();

            MySqlConnection conexion = Connection.GetConnection();

            MySqlCommand cm = new MySqlCommand("SELECT id_prov, name_prov FROM provider", conexion);
            MySqlDataReader consultar = cm.ExecuteReader();

            while (consultar.Read())
            {
                providerAccount proveedor = new providerAccount();
                proveedor.id_prov = consultar.GetInt32(0);
                proveedor.name_prov = consultar.GetString(1);
                listaProveedores.Add(proveedor);
                ComboBoxItem item = new ComboBoxItem();
                item.Text = $"{proveedor.id_prov} - {proveedor.name_prov}";
                item.Value = proveedor.id_prov;

                comboBox1.Items.Add(item);
                comboBox1.SelectedIndex = 0;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //TODO: Hacer transacciones
            //Insertar compra
            if (carrito.Count > 0)
            {
                int id;
                MySqlConnection conexion = Connection.GetConnection();
                MySqlCommand comm = conexion.CreateCommand();
                comm.CommandText = "INSERT INTO purchase (datetime_pur, total_pur) VALUES (now(), 0)";
                comm.ExecuteNonQuery();
                id = Convert.ToInt32(comm.LastInsertedId);
                conexion.Close();

                //Insertar detalles de compra 
                int noRows = -1;
                foreach(ProductAccount producto in carrito)
                {
                    try
                    {
                        conexion = Connection.GetConnection();
                        comm = conexion.CreateCommand();
                        comm.CommandText = "INSERT INTO purchase_has_product (purchase_id_pur, product_id_prod, quantity_prod) VALUES (@id_pur, @id_prod, @quantity)";
                        comm.Parameters.AddWithValue("@id_pur", id);
                        comm.Parameters.AddWithValue("@id_prod", producto.id_prod);
                        comm.Parameters.AddWithValue("@quantity", producto.items);
                        noRows = comm.ExecuteNonQuery();
                    }
                    catch(Exception err)
                    {
                        Console.WriteLine(err);
                    }
                    finally
                    {
                        conexion.Close();
                    }
                }

                if(noRows > 0)
                {
                    MessageBox.Show("Compra registrada con exito, su stock ha sido actualizado", "Compra realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reset();
                }
                else
                {
                    MessageBox.Show("Hubo un error en la transaccion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                MessageBox.Show("Agregue algunos articulos antes de confirmar", "Carrito vacio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Elegir ToMenu = new Elegir();
            this.Hide();
            ToMenu.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            numericUpDown1.Value = 0;
            comboBox2.Items.Clear();
            listaProductos.Clear();
            //TODO: Mostrar productos del nuevo proveedor
            int id = listaProveedores[comboBox1.SelectedIndex].id_prov;
            MySqlConnection conexion = Connection.GetConnection();
            MySqlCommand cm = new MySqlCommand("SELECT id_prod, name_prod, purchasePrice_prod FROM product WHERE provider_id_prov = @id", conexion);
            cm.Parameters.AddWithValue("@id", id);
            MySqlDataReader consultar = cm.ExecuteReader();

            while (consultar.Read())
            {
                ProductAccount producto = new ProductAccount();
                producto.id_prod = consultar.GetInt32(0);
                producto.name_prod = consultar.GetString(1);
                producto.purchasePrice_prod = consultar.GetDouble(2);
                listaProductos.Add(producto);
                ComboBoxItem item = new ComboBoxItem();
                item.Text = $"{producto.id_prod} - {producto.name_prod}";
                item.Value = producto.id_prod;

                comboBox2.Items.Add(item);
                comboBox2.SelectedIndex = 0;
            }

            if (comboBox2.Items.Count == 0)
            {
                comboBox2.Text = "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text != "" && numericUpDown1.Value != 0)
            {
                listaProductos[comboBox2.SelectedIndex].items = Convert.ToInt32(numericUpDown1.Value);
                //agregamos al carrito
                carrito.Add(listaProductos[comboBox2.SelectedIndex]);
                ProductAccount producto = listaProductos[comboBox2.SelectedIndex];
                providerAccount proveedor = listaProveedores[comboBox1.SelectedIndex];
                double total = producto.purchasePrice_prod * Convert.ToDouble(numericUpDown1.Value);
                Console.WriteLine(total);
                //mostrar en datagrid
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = producto.id_prod;
                dataGridView1.Rows[n].Cells[1].Value = producto.name_prod;
                dataGridView1.Rows[n].Cells[2].Value = proveedor.name_prov;
                dataGridView1.Rows[n].Cells[3].Value = producto.purchasePrice_prod;
                dataGridView1.Rows[n].Cells[4].Value = total;

                sumarTotal(total);
            }
        }

        private void sumarTotal(double subtotal)
        {
            double nuevoTotal = Double.Parse(label5.Text.Replace("$", "")) + subtotal;
            string total = string.Format("{0:0.00}", nuevoTotal);
            label5.Text = $"${total}";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //numericUpDown1.Value = 0;
            //numericUpDown1.Maximum = listaProductos[comboBox2.SelectedIndex].stock_prod;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(n != -1)
            {
                try
                {
                    dataGridView1.Rows.RemoveAt(n);
                    sumarTotal(carrito[n].purchasePrice_prod * carrito[n].items * -1);
                    carrito.RemoveAt(n);
                    for (int i = 0; i < carrito.Count; i++)
                    {
                        Console.WriteLine(carrito[i].name_prod);
                    }
                } catch (System.InvalidOperationException err)
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

        private void reset()
        {
            carrito.Clear();
            dataGridView1.Rows.Clear();
            label5.Text = "$0.00";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            reset();
            MessageBox.Show("Compra cancelada, los articulos fueron eliminados", "Compra cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }
    }
}
