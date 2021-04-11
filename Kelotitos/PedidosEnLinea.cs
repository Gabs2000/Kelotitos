using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Kelotitos.MySql;

namespace Kelotitos
{
    public partial class PedidosEnLinea : Form
    {
        MySqlConnection conexion;

        public PedidosEnLinea()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Elegir ToElegir = new Elegir();
            this.Hide();
            ToElegir.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbhora.Text = DateTime.Now.ToString("hh:mm:ss dddd MMMM yyy ");
        }

        private void lbhora_Click(object sender, EventArgs e)
        {
            lbhora.Text = DateTime.Now.ToString("hh:mm:ss dddd MMMM yyy ");
        }

        private void PedidosEnLinea_Load(object sender, EventArgs e)
        {
            this.cargarPedidos();
        }

        private void cargarPedidos()
        {
            conexion = Connection.GetConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            string query = "SELECT id_venta AS 'ID Venta', " +
                "fecha_venta 'Fecha', total 'Total', estatus 'Estatus', comentarios 'Comentarios', nombre_corto 'Nombre Corto', " +
                "colonia 'Colonia', calle 'Calle', num_externo 'Número Externo', num_interno 'Número Interno', " +
                "telefono 'Teléfono' FROM ventas WHERE tipo = 2";
            adapter.SelectCommand = new MySqlCommand(query, conexion);

            DataTable table = new DataTable();
            adapter.Fill(table);

            BindingSource binding = new BindingSource();
            binding.DataSource = table;

            dgvPedidos.DataSource = binding;
            dgvPedidos.MultiSelect = false;
            dgvPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //conexion = Connection.GetConnection();
            //MySqlCommand cm = new MySqlCommand("SELECT id_venta, " +
            //    "fecha_venta, total, estatus, comentarios, nombre_corto, " +
            //    "colonia, calle, num_externo, num_interno, " +
            //    "telefono FROM ventas WHERE tipo = 2", conexion);

            //MySqlDataReader reader;
            //reader = cm.ExecuteReader();
            //DataTable dt = new DataTable();
            //dt.Columns.Add("ID Venta", typeof(string));
            //dt.Columns.Add("Fecha de Venta", typeof(string));
            //dt.Columns.Add("Total", typeof(int));
            //dt.Columns.Add("Estatus", typeof(int));
            //dt.Columns.Add("Comentarios", typeof(string));
            //dt.Columns.Add("Nombre corto", typeof(string));
            //dt.Columns.Add("Colonia", typeof(string));
            //dt.Columns.Add("Calle", typeof(string));
            //dt.Columns.Add("Número externo", typeof(string));
            //dt.Columns.Add("Número interno", typeof(string));
            //dt.Columns.Add("Teléfono", typeof(string));

            //int n = dgvPedidos.Rows.Add();
            //dgvPedidos.Rows[n].Cells[0].Value = reader.GetString();


            //dt.Load(reader);
        }

        private void btnRealizado_Click(object sender, EventArgs e)
        {
            // Actualizar el estatus a 0 (Realizado)
            try
            {
                foreach (DataGridViewRow r in dgvPedidos.SelectedRows)
                {
                    //r.Cells["Estatus"].Value = 1;
                    int idventa = (int)dgvPedidos.CurrentRow.Cells[0].Value;
                    conexion = Connection.GetConnection();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    string query = "UPDATE ventas SET estatus = 0 WHERE estatus = 1 AND id_venta = " + idventa;
                    adapter.SelectCommand = new MySqlCommand(query, conexion);

                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    BindingSource binding = new BindingSource();
                    binding.DataSource = table;
                }

                //DataTable changes = ((DataTable)dgvPedidos.DataSource).GetChanges();
                //if(changes != null)
                //{
                //    conexion = Connection.GetConnection();
                //    MySqlDataAdapter adapter = new MySqlDataAdapter();
                //    MySqlCommandBuilder mcb = new MySqlCommandBuilder(adapter);
                //    adapter.UpdateCommand = mcb.GetUpdateCommand();
                //    adapter.Update(changes);
                //    ((DataTable)dgvPedidos.DataSource).AcceptChanges();
                //}

                MessageBox.Show("El Pedido ya fue Actualizado a Realizado");
                this.cargarPedidos();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }


            //this.cargarPedidos();
            //try
            //{

            //    conexion = Connection.GetConnection();
            //    MySqlDataAdapter adapter = new MySqlDataAdapter();
            //    string query = "UPDATE ventas SET estatus = 0 WHERE estatus = 1";
            //    adapter.SelectCommand = new MySqlCommand(query, conexion);

            //    DataTable table = new DataTable();
            //    adapter.Fill(table);

            //    BindingSource binding = new BindingSource();
            //    binding.DataSource = table;

            //    this.cargarPedidos();
            //}
            //catch (Exception err)
            //{
            //    MessageBox.Show(err.Message);
            //    MessageBox.Show("El pedido ya se encuentra realizado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }

        private void btnPendiente_Click(object sender, EventArgs e)
        {
            // Actualizar el estatus a 1 (Pendiente)
            try
            {
                foreach (DataGridViewRow r in dgvPedidos.SelectedRows)
                {
                    //r.Cells["Estatus"].Value = 1;
                    int idventa = (int)dgvPedidos.CurrentRow.Cells[0].Value;
                    conexion = Connection.GetConnection();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    string query = "UPDATE ventas SET estatus = 1 WHERE estatus = 0 AND id_venta = " + idventa;
                    adapter.SelectCommand = new MySqlCommand(query, conexion);

                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    BindingSource binding = new BindingSource();
                    binding.DataSource = table;
                }

                //DataTable changes = ((DataTable)dgvPedidos.DataSource).GetChanges();
                //if(changes != null)
                //{
                //    conexion = Connection.GetConnection();
                //    MySqlDataAdapter adapter = new MySqlDataAdapter();
                //    MySqlCommandBuilder mcb = new MySqlCommandBuilder(adapter);
                //    adapter.UpdateCommand = mcb.GetUpdateCommand();
                //    adapter.Update(changes);
                //    ((DataTable)dgvPedidos.DataSource).AcceptChanges();
                //}

                MessageBox.Show("El Pedido ya fue Actualizado a Pendiente");
                this.cargarPedidos();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }

            //try
            //{
            //conexion = Connection.GetConnection();
            //MySqlCommand cmd = new MySqlCommand("UPDATE ventas SET estatus = 1 WHERE estatus = 0 AND id_venta = @id_venta", conexion);

            //var resultado = cmd.ExecuteReader();
            //foreach (DataGridViewRow r in dgvPedidos.SelectedRows)
            //{
            //    r.Cells["Estatus"].Value = 1;
            //}
            //this.BindingContext[dgvPedidos.DataSource].EndCurrentEdit();
            //}
            //catch
            //{
            //    MessageBox.Show("++++++", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}


            //try
            //{
            //    this.cargarPedidos();
            //    conexion = Connection.GetConnection();
            //    MySqlDataAdapter adapter = new MySqlDataAdapter();
            //    string query = "UPDATE ventas SET estatus = 1 WHERE estatus = 0";
            //    adapter.SelectCommand = new MySqlCommand(query, conexion);
            //    DataTable table = new DataTable();
            //    adapter.Fill(table);
            //    BindingSource binding = new BindingSource();
            //    binding.DataSource = table;
            //    this.cargarPedidos();
            //}
            //catch (Exception err)
            //{
            //    MessageBox.Show("El pedido ya se encuentra pendiente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }
    }
}