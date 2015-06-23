using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Aula_2306
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidade = int.Parse(Console.ReadLine());
            string[] nome = new string[quantidade];
            int[] cpf= new int[quantidade];
            int[] nasc= new int[quantidade];
            double[] salario= new double[quantidade];
            int[] admi= new int[quantidade];
            double[] nsalario = new double[quantidade];

            for (int i = 0; i < quantidade; i++)
            {
                cpf[i] = int.Parse(Console.ReadLine());
                nome[i] = (Console.ReadLine());
                nasc[i] = int.Parse(Console.ReadLine());
                admi[i] = int.Parse(Console.ReadLine());
                salario[i] = double.Parse(Console.ReadLine());
            }
            for (int j = 0; j < quantidade; j++)
            {
                if (admi[j] >= 2014)
                {
                    nsalario[j] = salario[j] + 423.45;
                }
                if (admi[j] >= 2010 && admi[j] < 2014)
                {
                    nsalario[j] = salario[j] * 9.84 / 100;
                }
                if (admi[j] >= 2000 && admi[j] <= 2009)
                {
                    nsalario[j] = salario[j] + salario[j] * 16.04 / 100;
                }
                if (admi[j] <= 1999)
                {
                    nsalario[j] = salario[j] * 22.06 / 100; 
                }
            }
            for (int k = 0; k < quantidade; k++)
            {
                Console.WriteLine(cpf[k]);
                Console.WriteLine(nome[k]);
                Console.WriteLine(nasc[k]);
                Console.WriteLine(admi[k]);
                Console.WriteLine(salario[k]);
                Console.WriteLine(nsalario[k]);
            }
        }
        
    }
}
