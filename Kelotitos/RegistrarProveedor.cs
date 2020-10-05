﻿using Kelotitos;
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
        public RegistrarProveedor()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //valida que todos los campos esten llenos
            if (nomprove.Text == "")
                MessageBox.Show("Debe de ingresar un nombre");
            else if (dirprove.Text == "")
                MessageBox.Show("Debe de rellenar la direccion");
            else if (telprove.Text == "")
                MessageBox.Show("Debe dar de alta el telefono");
            else if (mailprove.Text == "")
                MessageBox.Show("Debe de ingresar un correo");
            else
            {
                //capturar datos
                string nombre = nomprove.Text;
                string direccion = dirprove.Text;
                string mail = mailprove.Text;
                long telefono = Convert.ToInt64(telprove.Text);

                //Impresion de resultados
                ListViewItem fila = new ListViewItem(nombre);
                fila.SubItems.Add(direccion);
                fila.SubItems.Add(telprove.ToString());
                fila.SubItems.Add(mail);

                tabla.Items.Add(fila);
                btnCancelar_Click(sender, e);

            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            nomprove.Clear();
            dirprove.Clear();
            telprove.Clear();
            mailprove.Clear();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Elegir elegir = new Elegir();
            this.Hide();
            elegir.Show();
        }
    }
}
