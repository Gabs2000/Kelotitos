﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Proyecto_OASIS.MySql;

namespace Proyecto_OASIS.ModelsDB
{
    class RegisterNewProvider
    {
        public static int agregar(providerAccount add)
        {
            int devolver = 0;
            MySqlCommand command = new MySqlCommand(String.Format("INSERT INTO provider(name_prov, email_prov, tel_prov, location_prov) values('{0}', '{1}', '{2}', '{3}')",
                add.name_prov, add.email_prov, add.tel_prov, add.location_prov), Connection.GetConnection());
            devolver = command.ExecuteNonQuery();
            return devolver;
        }
    }
}
