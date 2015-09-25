using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_12
{
    class Gerente : Trabalhador
    {
        public string AreaGerencia { get; set; }
        public double ValorAdc { get; set; }


        public double SalarioTotal()
        {
            return Salario + ValorAdc;
        }

       public override double ValeAlimentacao()
        {
            if ((Salario * 0.065) > 750)
            {
                double vale = 750;
                return vale;
            }
            else
            {

                double vale = Salario * 0.065;
                return vale;
            }
        }
    }
}
