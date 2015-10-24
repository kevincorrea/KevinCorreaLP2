using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Globalization;

namespace Exercício_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 1;
            while (opcao != 0)
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Inserir");
                Console.WriteLine("2 - Consultar");
                Console.WriteLine("0 - Sair");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {

                    case 1:
                        Inserir();
                        break;

                    case 2:
                        Consultar();
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }


            }
        }

        public static void Inserir()
        {
            Console.WriteLine("Insira seus Dados");
            Pessoa p = new Pessoa();
            Console.WriteLine("Insira seu Nome:");
            p.Nome = Console.ReadLine();
            Console.WriteLine("Insira seu Sobrenome:");
            p.Sobrenome = Console.ReadLine();
            Console.WriteLine("Insira seu Peso:");
            p.Peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira sua Altura:");
            p.Altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira seu Telefone:");
            p.Telefone = Console.ReadLine();

            MySqlConnection conn = new MySqlConnection("Server=localhost;Database=test;Uid=root;Pwd=kev");
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;

            string q = string.Format(new CultureInfo("en"), "INSERT INTO PESSOA(Nome, Sobrenome, Peso, Altura, Telefone) VALUES('{0}', '{1}', '{2}', '{3}', '{4}')", p.Nome, p.Sobrenome, p.Peso, p.Altura, p.Telefone);

            cmd.CommandText = q;

            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }


        public static void Consultar()
        {
            Console.WriteLine("Escolha uma opção");
            Console.WriteLine("1 - Consultar pelo ID");
            Console.WriteLine("2 - Consultar pelo Nome");
            int opcao = int.Parse(Console.ReadLine());


            if (opcao == 1)
            {

                Console.WriteLine("Digite um ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                MySqlCommand cmd = new MySqlCommand();
                string selectid = string.Format("SELECT * FROM Pessoa WHERE Id = '{0}'", id);
                cmd.CommandText = selectid;

                MySqlDataReader reader = cmd.ExecuteReader();


                if (reader.HasRows)
                {
                    List<Pessoa> pessoas = new List<Pessoa>();
                    while (reader.Read())
                    {
                        Pessoa p = new Pessoa();


                        Console.WriteLine("Id:{0}", reader.GetInt32(0));
                        Console.WriteLine("Nome:{0}", reader.GetString(1));
                        Console.WriteLine("Sobrenome:{0}", reader.GetString(2));
                        Console.WriteLine("Peso:{0}", reader.GetDouble(3));
                        Console.WriteLine("Altura:{0}", reader.GetDouble(4));
                        Console.WriteLine("Id:{0}", reader.GetString(5));

                        pessoas.Add(p);
                        reader.Close();

                    }


                }
            }

            else if (opcao == 2)
            {

                Console.WriteLine("Digite um Nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("");
                MySqlCommand cmd = new MySqlCommand();
                string selectnome = string.Format("SELECT * FROM pessoa WHERE Nome = '{0}'", nome);
                cmd.CommandText = selectnome;

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("Id:{0}", reader.GetInt32(0));
                        Console.WriteLine("Nome:{0}", reader.GetString(1));
                        Console.WriteLine("Sobrenome:{0}", reader.GetString(2));
                    }

                    reader.Close();

                    Console.WriteLine("Volte a primeira lista de opções e consulte pelo ID do Nome para maiores informações do Cadastro");
                }

                else
                {
                    Console.WriteLine("Opção Inválida");
                }
            }
        }
    }
}
