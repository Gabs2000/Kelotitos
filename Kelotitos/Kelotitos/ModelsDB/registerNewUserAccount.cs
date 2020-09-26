using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Proyecto_OASIS.MySql
{
    class registerNewUserAccount
    {
        public static int agregar(userAccount add)
        {
            int devolver = 0;
            MySqlCommand comand = new MySqlCommand(String.Format("INSERT INTO user(name_user, account_user, password_user, type_user) values('{0}', '{1}', '{2}', '{3}')",
                add.name_user, add.account_user, add.password_user, add.type_user), Connection.GetConnection());
            devolver = comand.ExecuteNonQuery();
            return devolver;
        }
    }
}
