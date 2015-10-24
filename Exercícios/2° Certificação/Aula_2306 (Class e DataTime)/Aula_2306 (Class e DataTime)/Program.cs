using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_2306__Class_e_DataTime_
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidade = int.Parse(Console.ReadLine());
            Funcionario f = new Funcionario();

            for (int i = 0; i < quantidade; i++)
            {
                f.nome = Console.ReadLine();
                f.cpf = Console.ReadLine();
                f.nasc = DateTime.Parse(Console.ReadLine());
                f.admi = DateTime.Parse(Console.ReadLine());
                f.salario = double.Parse(Console.ReadLine());
            }

            for (int j = 0; j < quantidade; j++)
            {
                Console.WriteLine(f.nome);
                Console.WriteLine(f.cpf);
                Console.WriteLine(f.nasc);
                Console.WriteLine(f.admi);
                Console.WriteLine(f.salario);
                Console.WriteLine(f.CalculaAumento());
            }
        }
    }
}
