using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Proyecto_OASIS.MySql;

namespace Proyecto_OASIS.ModelsDB
{
    class RegisterNewProduct
    {
        public static int agregar(ProductAccount add)
        {
            int devolver = 0;
            MySqlCommand comand = new MySqlCommand(String.Format("INSERT INTO product(name_prod, des_prod, price_prod, purchasePrice_prod, stock_prod) values('{0}', '{1}', '{2}', '{3}', '{4}')",
                add.name_prod, add.des_prod, add.price_prod, add.purchasePrice_prod, add.stock_prod), Connection.GetConnection());
            devolver = comand.ExecuteNonQuery();
            return devolver;
        }
    }
}
