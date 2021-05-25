using System;
using MySql.Data.MySqlClient;

namespace Kelotitos.MySql
{
    class Connection
    {
        private static string Server = "bayjfbagagjr10j6uxy6-mysql.services.clever-cloud.com"; //"127.0.0.1"
        private static string Database = "bayjfbagagjr10j6uxy6"; //"snack_db"
        private static string User = "un5v81dhnzgts8zh"; //"root"
        private static string Password = "SQi5xP8vUNtn6z5BZU0w"; //"root"

        private static string StrConnection = $"server={Server}; database={Database}; Uid={User}; pwd={Password}";

        public static MySqlConnection GetConnection()
        {
            MySqlConnection conn;
            try
            {
                conn = new MySqlConnection(StrConnection);
                conn.Open();
                Console.WriteLine("Conectado con Éxito");
            } catch(Exception e)
            {
                conn = null;
                Console.WriteLine(e);
            }

            return conn;
        }

        public static void Close(MySqlConnection conn)
        {
            try
            {
                conn.Close();
            } catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }        

    }
}
