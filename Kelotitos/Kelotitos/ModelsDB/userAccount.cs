using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_OASIS.MySql
{
    class userAccount
    {
        public int id_user { get; set; }
        public string name_user { get; set; }
        public string account_user { get; set; }
        public string password_user { get; set; }
        public int type_user { get; set; }

        public userAccount() { }
        public userAccount(int id, string name, string account, string password, int type)
        {
            this.id_user = id;
            this.name_user = name;
            this.account_user = account;
            this.password_user = password;
            this.type_user = type;
        }
    }
}
