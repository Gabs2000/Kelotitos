using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kelotitos.Reportes
{
    public partial class repInv : Form
    {
        public repInv()
        {
            InitializeComponent();
        }

        private void repInv_Load(object sender, EventArgs e)
        {

            this.reporte.RefreshReport();
        }
    }
}
