using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio30032015
{
    class Program
    {
        static void Main(string[] args)
        {


            int n = 1;
            int x = 0;
            int soma = 0;
            int media = 0;

            Console.WriteLine("Escreva seus números, digite 0 para parar e obter a média dos números: ");

            while (n != 0)
            {

                n = int.Parse(Console.ReadLine());
                soma = n + soma;
                x++;

            }

            if (n == 0)
            {
                media = soma / x;
                Console.WriteLine("A média é igual a {0}", media);
            }
           
        }
    }
}
