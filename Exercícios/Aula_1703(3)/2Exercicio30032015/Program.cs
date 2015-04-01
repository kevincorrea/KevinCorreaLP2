using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _2Exercicio30032015
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList digitos = new ArrayList();
            int soma = 0;
            int media = 0;
            int n = 1;
         
            Console.WriteLine("Escreva seus números, digite 0 para parar e obter a média dos números: ");

            while (n != 0)
            {

                n = int.Parse(Console.ReadLine());
                
                digitos.Add(n);
                digitos.Remove(0);

                soma = n + soma;

            }

           
               media = soma / digitos.Count;
               Console.WriteLine("A média é igual a {0}", media);
            


        }
    }
}
