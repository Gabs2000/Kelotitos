using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Kelotitos.MySql
{
    class registerNewUserAccount
    {
        public static int agregar(userAccount add)
        {
            int devolver = 0;
            MySqlCommand comand = new MySqlCommand(String.Format("INSERT INTO usuarios(nombre, usuario, contrasena, administrador) values('{0}', '{1}', '{2}', '{3}')",
                add.nombre, add.usuario, add.contrasena, add.administrador), Connection.GetConnection());
            devolver = comand.ExecuteNonQuery();
            return devolver;
        }
    }
}
