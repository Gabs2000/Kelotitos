using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kelotitos.ModelsDB.Reportes
{
    public class rInventario
    {
        public string producto { get; set; }
        public string proveedor { get; set; }
        public int cantidad { get; set; }
        public string unidad { get; set; }
        public int precioUnitario { get; set; }

        //public rInventario() { }
        //public rInventario(string producto, string proveedor, int cantidad, string unidad, int precioUnitario)
        //{
        //    this.producto = producto;
        //    this.proveedor = proveedor;
        //    this.cantidad = cantidad;
        //    this.unidad = unidad;
        //    this.precioUnitario = precioUnitario;
        //}
    }
}
