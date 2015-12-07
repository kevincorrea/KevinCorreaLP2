using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace Exercício_Final
{
    class Program
    {
        static void Main(string[] args)
        {

            int loop = 1;
            Console.WriteLine("Digite seu login:");
            string login = Console.ReadLine();
            Console.WriteLine("Digite sua senha:");
            string senha = Console.ReadLine();

            while (loop == 1)
            {
                MySqlConnection conn = new MySqlConnection("Server=localhost;Database=test;Uid=root;Pwd=kev");
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                conn.Open();

                cmd.CommandText = "SELECT login, senha FROM usuario WHERE login = @login AND senha = @senha";
                cmd.Parameters.AddWithValue("@login", login);
                cmd.Parameters.AddWithValue("@senha", senha); 

                MySqlDataReader reader = cmd.ExecuteReader();

                User user = new User();


                if (reader.HasRows)
                {
                    Console.WriteLine("Logado com sucesso!");
                    DateTime lastacess = DateTime.Now;
                    cmd.CommandText = "UPDATE User SET DataUltAces = '@lastacess'";
                    cmd.Parameters.AddWithValue("@lastacess", lastacess);
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Digite 0 para deslogar!");
                    loop = int.Parse(Console.ReadLine());
                    conn.Close();

                }

                else
                {
                    Console.WriteLine("Usuário não encotrado!");
                }
            }
    
       
        }
    }
}
