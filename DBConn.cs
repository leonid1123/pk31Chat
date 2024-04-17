using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace pk31Chat
{
    public static class DBConn
    {
        static MySqlConnection connection = new MySqlConnection();
        public static MySqlConnection Connect()
        {
            //192.168.1.61
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection = new MySqlConnection("Server=localhost;User ID=pk31;Password=pk31;Database=chat");
                connection.Open();
                Console.WriteLine(connection.State);
                return connection;
            } else
            {
                return null;
            }
        }
        public static void Close()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
