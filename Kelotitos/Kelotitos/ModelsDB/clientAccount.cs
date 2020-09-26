using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_OASIS.MySql
{
    public class clientAccount
    {
        public int id_client { get; set; }
        public string name_client { get; set; }
        public string email_client { get; set; }
        public string tel_client { get; set; }

        public clientAccount() { }
        public clientAccount(int id, string name, string email, string tel)
        {
            this.id_client = id;
            this.name_client = name;
            this.email_client = email;
            this.tel_client = tel;
        }
    }
}
