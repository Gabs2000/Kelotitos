using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Runtime.InteropServices;


namespace Kelotitos
{
    public partial class Juego : Form
    {
        public Juego()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hwc, IntPtr hWndNewParent);

        private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Button2_Click(object sender, EventArgs e)
        {
         
        }

        private void Button3_Click(object sender, EventArgs e)
        {
           
        }

        private void Button4_Click(object sender, EventArgs e)
        {
           
            }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            
             }

    private void txtUrl_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            if (od.ShowDialog() == DialogResult.OK)
            {
                Process proc = Process.Start(od.FileName);
                proc.WaitForInputIdle();

                while (proc.MainWindowHandle == IntPtr.Zero)
                {
                    Thread.Sleep(100);
                    proc.Refresh();
                }
                SetParent(proc.MainWindowHandle, this.panel1.Handle);
            }
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            Elegir ToElegir = new Elegir();
            this.Hide();
            ToElegir.Show();
        }

        private void Juego_Load(object sender, EventArgs e)
        {

        }
    }
}
