using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using MySql.Data.MySqlClient;
using Kelotitos.MySql;
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
    public partial class TicketFinal : Form
    {
        public TicketFinal()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            Elegir ToElegir = new Elegir();
            this.Hide();
            ToElegir.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Confirmacion_de_pedido ToElegir = new Confirmacion_de_pedido();
            this.Hide();
            ToElegir.Show();
        }

        private void Lbhora_Click(object sender, EventArgs e)
        {
            lbhora.Text = DateTime.Now.ToString("hh:mm:ss dddd MMMM yyy ");
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lbhora.Text = DateTime.Now.ToString("hh:mm:ss dddd MMMM yyy ");
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TicketFinal_Load(object sender, EventArgs e)
        {
            CrearPdf();
        }
        private void CrearPdf()
        {
            PdfWriter pdfWriter = new PdfWriter("ReporteTicket.pdf");
            PdfDocument pdf = new PdfDocument(pdfWriter);
            Document documento = new Document(pdf, PageSize.LETTER);

            documento.SetMargins(60, 20, 55, 20);

            
            PdfFont fontColumnas = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
            PdfFont fontContenido = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

            string[] columnas = { "IdCliente", "IdUsuarioDelSistema", "NombreProducto", "Descripcion Compra", "PrecioVenta", "TOTAL" };

            float[] tamanios = { 2, 4, 2, 2, 4 };
            Table tabla = new Table(UnitValue.CreatePercentArray(tamanios));
            tabla.SetWidth(UnitValue.CreatePercentValue(100));

            foreach (string columna in columnas)
            {
                tabla.AddHeaderCell(new Cell().Add(new Paragraph(columna).SetFont(fontColumnas)));
            }

            string sql = "SELECT p. FROM product AS p INNER JOIN categorias AS c WHERE";

            MySqlConnection conexion = Connection.GetConnection();

            MySqlCommand cm = new MySqlCommand("SELECT id_prov, name_prov FROM provider", conexion);
            MySqlDataReader consultar = cm.ExecuteReader();

            //while (reader.Read())
            //{
            //    tabla.AddCell(new Cell().Add(new Paragraph(reader[""].ToString()).SetFont(fontContenido)));
            //    tabla.AddCell(new Cell().Add(new Paragraph(reader[""].ToString()).SetFont(fontContenido)));
            //    tabla.AddCell(new Cell().Add(new Paragraph(reader[""].ToString()).SetFont(fontContenido)));
            //    tabla.AddCell(new Cell().Add(new Paragraph(reader[""].ToString()).SetFont(fontContenido)));
            //    tabla.AddCell(new Cell().Add(new Paragraph(reader[""].ToString()).SetFont(fontContenido)));
            //}
            documento.Add(tabla);
            documento.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
