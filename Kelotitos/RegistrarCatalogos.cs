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
    public partial class RegistrarCatalogos : Form
    {
        MySqlConnection conexion;
        public RegistrarCatalogos()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Elegir elegir = new Elegir();
            this.Hide();
            elegir.Show();
        }

        private void btnAgrTamanio_Click(object sender, EventArgs e)
        {
            try
            {
                conexion = Connection.GetConnection();
                MySqlCommand con = new MySqlCommand("INSERT INTO cat_tamanios " +
                                                    "(tamanio, estatus, fecha_creacion) " +
                                                    "VALUES " +
                                                    "(@tamanio, 1, NOW())", conexion);
                con.Parameters.AddWithValue("@tamanio", txtNomTam.Text);
                con.ExecuteNonQuery();

                MessageBox.Show("Tamaño registrado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtNomTam.Text = "";

            }
            catch (Exception err)
            {
                MessageBox.Show("Hubo un error al momento de insertar el tamaño", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Console.WriteLine(err);
            }
        }

        private void btnAgrTipo_Click(object sender, EventArgs e)
        {
            try
            {
                int siTamanio;

                if(chbDifTamanio.Checked == true)
                {
                    siTamanio = 1;
                }
                else
                {
                    siTamanio = 0;
                }

                conexion = Connection.GetConnection();
                MySqlCommand con = new MySqlCommand("INSERT INTO cat_tipos_productos " +
                                                    "(tipo_producto, si_tamanio, estatus, fecha_creacion) " +
                                                    "VALUES " +
                                                    "(@tipoProducto, @siTamanio, 1, NOW())", conexion);
                con.Parameters.AddWithValue("@tipoProducto", txtNomTipo.Text);
                con.Parameters.AddWithValue("@siTamanio", siTamanio);
                con.ExecuteNonQuery();

                MessageBox.Show("Tipo de producto registrado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtNomTipo.Text = "";
                chbDifTamanio.Checked = false;

            }
            catch (Exception err)
            {
                MessageBox.Show("Hubo un error al momento de insertar el tipo de producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Console.WriteLine(err);
            }
        }
    }
}
