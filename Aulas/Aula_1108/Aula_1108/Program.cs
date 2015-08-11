using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_1108
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime dtNasc = new DateTime();
            //MinhaString m = new MinhaString("Olá Mundo");

            //Console.WriteLine(m.Substring(1));
            //Console.WriteLine(m.Substring(3, 5));

            var bananas = "bruno,diogo,kevin".Split(',');

            foreach (var banana in bananas)
            {
                Console.WriteLine(banana);
            }
        }
    }
}
