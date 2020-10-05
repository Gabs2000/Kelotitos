using Kelotitos;
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

namespace Prueba
{
    public partial class RegistrarProveedor : Form
    {
        MySqlConnection conexion;
        public RegistrarProveedor()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                //valida que todos los campos esten llenos
                if (txtNombre.Text == "")
                    MessageBox.Show("Debe de ingresar un nombre");
                else if (txtCorreo.Text == "")
                    MessageBox.Show("Debe de ingresar un correo");
                else if (txtTelefono.Text == "")
                    MessageBox.Show("Debe dar de alta el telefono");
                else if (txtEncargado.Text == "")
                    MessageBox.Show("Debe de ingresar un encargado");
                else if (txtCalle.Text == "")
                    MessageBox.Show("Debe de ingresar la calle");
                else if (txtColonia.Text == "")
                    MessageBox.Show("Debe de ingresar la colonia");
                else if (txtMunicipio.Text == "")
                    MessageBox.Show("Debe de ingresar el municipio");
                else if (txtEstado.Text == "")
                    MessageBox.Show("Debe de ingresar el estado");
                else if (txtCodigoPostal.Text == "")
                    MessageBox.Show("Debe de ingresar el código postal");
                else
                {

                    conexion = Connection.GetConnection();
                    MySqlCommand con = new MySqlCommand("INSERT INTO proveedores " +
                                                        "(proveedor, encargado, calle, colonia, municipio, " +
                                                        "estado, codigo_postal, telefono, correo, estatus, " +
                                                        "fecha_creacion) " +
                                                        "VALUES " +
                                                        "(@proveedor, @encargado, @calle, @colonia, " +
                                                        "@municipio, @estado, @codigoPostal, @telefono, " +
                                                        "@correo, 1, NOW())", conexion);
                    con.Parameters.AddWithValue("@proveedor", txtNombre.Text);
                    con.Parameters.AddWithValue("@encargado", txtEncargado.Text);
                    con.Parameters.AddWithValue("@calle", txtCalle.Text);
                    con.Parameters.AddWithValue("@colonia", txtColonia.Text);
                    con.Parameters.AddWithValue("@municipio", txtMunicipio.Text);
                    con.Parameters.AddWithValue("@estado", txtEstado.Text);
                    con.Parameters.AddWithValue("@codigoPostal", Convert.ToInt32(txtCodigoPostal.Text));
                    con.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                    con.Parameters.AddWithValue("@correo", txtCorreo.Text);
                    con.ExecuteNonQuery();

                    MessageBox.Show("Registrado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnCancelar_Click(sender, e);


                    ////capturar datos
                    //string nombre = txtNombre.Text;
                    //string direccion = txtCalle.Text;
                    //string mail = txtCorreo.Text;
                    //long telefono = Convert.ToInt64(txtTelefono.Text);

                    ////Impresion de resultados
                    //ListViewItem fila = new ListViewItem(nombre);
                    //fila.SubItems.Add(direccion);
                    //fila.SubItems.Add(txtTelefono.ToString());
                    //fila.SubItems.Add(mail);

                    //tabla.Items.Add(fila);
                    //btnCancelar_Click(sender, e);

                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Hubo un error al momento de registrar el proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Console.WriteLine(err);
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtEncargado.Clear();
            txtCalle.Clear();
            txtColonia.Clear();
            txtMunicipio.Clear();
            txtEstado.Clear();
            txtCodigoPostal.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Elegir elegir = new Elegir();
            this.Hide();
            elegir.Show();
        }
    }
}
