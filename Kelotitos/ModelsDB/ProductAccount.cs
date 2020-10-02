using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Kelotitos.ModelsDB

{
    public class ProductAccount
    {

        public ProductAccount() { }

        public int id_producto { get; set; }
        public string nombre { get; set; }
        public int id_tipo_producto { get; set; }
        public int id_tamanio { get; set; }
        public int precio { get; set; }
        public int estatus { get; set; }
        public DateTime fecha_creacion { get; set; }



        // Anterior
        public int id_prod { get; set; }
        public string name_prod { get; set; }
        public string des_prod { get; set; }
        public double price_prod { get; set; }
        public double purchasePrice_prod { get; set; }
        public int stock_prod { get; set; }
        public int items { get; set; }


        public ProductAccount(int idProducto, string nombre, int idTipoProducto, int idTamanio, int precio, int estatus, DateTime fechaCreacion,
                              int id, string name, string des, float price, float purchase, int stock)
        {
            this.id_producto = idProducto;
            this.nombre = nombre;
            this.id_tipo_producto = idTipoProducto;
            this.id_tamanio = idTamanio;
            this.precio = precio;
            this.estatus = estatus;
            this.fecha_creacion = fechaCreacion;


            //Anterior
            this.id_prod = id;
            this.name_prod = name;
            this.des_prod = des;
            this.price_prod = price;
            this.purchasePrice_prod = purchase;
            this.stock_prod = stock;
        }
    }
}
