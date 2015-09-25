using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_12
{
    class Trabalhador : Funcionario
    {
        public double Salario { get; set; }


        public double ValeAlimentacao()
        {
            if ((Salario * 0.08) > 750)
            {
                double vale = 750;
                return vale;
            }
            else
            {

                double vale = Salario * 0.08;
                return vale;
            }
        
        }
    }
}
