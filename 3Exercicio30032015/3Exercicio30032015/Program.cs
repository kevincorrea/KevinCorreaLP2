using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Exercicio30032015
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int x = 0;
            int soma = 0;
            int menor = 0;
            int maior = 0;


            Console.WriteLine("Digite a quantidade de números desejada.");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite {0} números.", n);


            for (int i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                soma = x + soma;

                if (x < menor || i == 0)
                {
                    menor = x;
                }
                if (x > maior || i == 0)
                {
                    maior = x;
                }
            }

            Console.WriteLine("A soma é: {0}", soma);
            Console.WriteLine("O menor número é: {0}", menor);
            Console.WriteLine("O maior número é: {0}", maior);
                
        }
    }
}
