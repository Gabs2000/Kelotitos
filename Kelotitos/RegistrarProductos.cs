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
using Kelotitos.MySql;
using MySql.Data.MySqlClient;

namespace Kelotitos
{
    public partial class RegistrarProductos : Form
    {
        //List<providerAccount> listaProveedores;
        public RegistrarProductos()
        {
            InitializeComponent();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

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

        private void RegistrarProductos_Load(object sender, EventArgs e)
        {
            //MySqlConnection conexion = Connection.GetConnection();

            //MySqlCommand cm = new MySqlCommand("SELECT id_prov, name_prov FROM provider", conexion);
            //MySqlDataReader consultar = cm.ExecuteReader();

            //listaProveedores = new List<providerAccount>();

            //while (consultar.Read())
            //{
            //    providerAccount proveedor = new providerAccount();
            //    proveedor.id_prov = consultar.GetInt32(0);
            //    proveedor.name_prov = consultar.GetString(1);
            //    listaProveedores.Add(proveedor);
            //    ComboBoxItem item = new ComboBoxItem();
            //    item.Text = $"{proveedor.id_prov} - {proveedor.name_prov}";
            //    item.Value = proveedor.id_prov;

            //    comboBox1.Items.Add(item);
            //    comboBox1.SelectedIndex = 0;
            //}

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductAccount newProductAccount = new ProductAccount();
            
            //int providerSelected = listaProveedores[comboBox1.SelectedIndex].id_prov;

            if (string.IsNullOrEmpty(name_textbox.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Los campos no pueden quedar vacíos", "Registro Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {              
                //Para convertir string a int se puede usar; int.TryParse, int.Parse, Convert.ToInt32
                newProductAccount.nombre = name_textbox.Text.Trim();
                newProductAccount.id_tipo_producto = int.Parse(textBox2.Text.Trim());
                newProductAccount.id_tamanio = int.Parse(textBox1.Text.Trim());
                newProductAccount.precio = int.Parse(textBox3.Text.Trim());
                newProductAccount.estatus = 1;
                newProductAccount.fecha_creacion = DateTime.Now;

                try
                {
                    MySqlConnection conexion = Connection.GetConnection();
                    MySqlCommand comm = conexion.CreateCommand();
                    comm.CommandText = "INSERT INTO `cat_productos` (nombre, id_tipo_producto, id_tamanio, precio, estatus, fecha_creación) VALUES(@name, @tipo_producto, @tamaño, @precio, @estatus, @fecha_creacion)";
                    comm.Parameters.AddWithValue("@name", name_textbox.Text);
                    comm.Parameters.AddWithValue("@tipo_producto", textBox2.Text);
                    comm.Parameters.AddWithValue("@tamaño", textBox1.Text);
                    comm.Parameters.AddWithValue("@precio", textBox3.Text);
                    comm.Parameters.AddWithValue("@estatus", 0);
                    comm.Parameters.AddWithValue("@fecha_creacion", /*providerSelected*/ DateTime.Now);
                    comm.ExecuteNonQuery();
                    conexion.Close();
                }
                catch (Exception err)
                {
                    Console.WriteLine(err);
                }
                name_textbox.Text = "";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                comboBox1.SelectedIndex = 0;
            }

            //if (Single.TryParse(textBox1.Text, out float result))
            //{
            //    MessageBox.Show("El campo solo acepta números flotantes", "Registro Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else
            //{

            //}
            //newProductAccount.price_prod = Convert.ToSingle(textBox1.Text.Trim());

            //if (Single.TryParse(textBox3.Text, out float result2))
            //{
            //    MessageBox.Show("El campo solo acepta números flotantes", "Registro Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else
            //{

            //}
            //newProductAccount.purchasePrice_prod = Convert.ToSingle(textBox3.Text.Trim());

            //float val = 0;
            //if (Single.TryParse(textBox1.Text, out val))
            //{

            //}
            //else
            //{
            //    textBox1.Text = val.ToString();
            //}

            //newProductAccount.stock_prod = 0;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
            }
            MessageBox.Show("Los campos no pueden quedar vacíos", "Registro Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void name_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
