using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kelotitos.MySql
{
    class userAccount
    {
        public int id_usuario { get; set; }
        public string nombre { get; set; }
        public string usuario { get; set; }
        public string contrasena { get; set; }
        public int administrador { get; set; }

        public userAccount() { }
        public userAccount(int idUsuario, string nombre, string usuario, string contrasena, int admin)
        {
            this.id_usuario = idUsuario;
            this.nombre = nombre;
            this.usuario = usuario;
            this.contrasena = contrasena;
            this.administrador = admin;
        }
    }
}
