using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer_11_08
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            double delta, baskara;

            Console.WriteLine("Entre com o valor de A:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o valor de B:");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o valor de C:");
            c = double.Parse(Console.ReadLine());



            if (a == 0 && b == 0 && c == 0)
            {
                Console.WriteLine("A, B e C devem ser diferentes de 0!");
            }
            else
            {
                delta = Math.Pow(b, 2) * (-4 * a * c);
                if (delta < 0)
                {
                    Console.WriteLine("Delta não pode ser menor que 0!");
                }
                else if (delta == 0)
                {
                    baskara = -b / (2 * a);
                }
                else
                {
                    baskara = -b + Math.Sqrt(delta) / (2 * a);
                    Console.WriteLine(String.Format("1º Valor da Equação do segundo grau:{0}", baskara));
                    baskara = -b - Math.Sqrt(delta) / (2 * a);
                    Console.WriteLine(String.Format("2º Valor da Equação do segundo grau:{0}", baskara));
                }
            }
        }
    }
}