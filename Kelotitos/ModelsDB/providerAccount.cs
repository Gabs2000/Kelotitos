using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Kelotitos.ModelsDB
{
    class providerAccount
    {
        public int id_prov { get; set; }
        public string name_prov { get; set; }
        public string email_prov { get; set; }
        public string cant_prov { get; set; }
        public string cat_prov { get; set; }

        public providerAccount() { }
        public providerAccount(int id, string name)
        {
            this.id_prov = id;
            this.name_prov = name;
        }
        public providerAccount(int id, string name, string email, string tel, string location)
        {
            this.id_prov = id;
            this.name_prov = name;
            this.email_prov = email;
            this.cant_prov = tel;
            this.cat_prov = location;
        }
    }
}
