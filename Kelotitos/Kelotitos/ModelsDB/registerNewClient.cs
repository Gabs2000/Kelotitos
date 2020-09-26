using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Proyecto_OASIS.MySql
{
    class registerNewClient
    {
        public static long agregar(clientAccount add)
        {
            int devolver = 0;
            MySqlCommand comand = new MySqlCommand(String.Format("INSERT INTO client(name_client, email_client, tel_client) values('{0}', '{1}', '{2}')",
                add.name_client, add.email_client, add.tel_client), Connection.GetConnection());
            devolver = comand.ExecuteNonQuery();
            return comand.LastInsertedId;
        }
    }
}
