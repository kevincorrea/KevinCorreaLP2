using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Aula_2209
{
    class Program
    {
        static void Main(string[] args)
        {
            string strConn = "Server=localhost;Database=test;Uid=root;Pwd=";
            string nome = Console.ReadLine();
            string query = "INSERT INTO PESSOA (Nome) VALUES ('" + nome + "')";
        MySqlConnection conn = new MySqlConnection(strConn);
        MySqlCommand command = new MySqlCommand();
        command.Connection = conn;
        command.CommandText = query;
        conn.Open();
        command.ExecuteNonQuery();
        conn.Close();
        }
    }
}
