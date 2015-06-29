using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_2306__Class_e_DataTime_
{
    class Funcionario
    {
        public string nome;
        public string cpf;
        public DateTime admi;
        public DateTime nasc;
        public double salario;
        double aum;

        public double CalculaAumento()
        {
            if (admi.Year <= 2014)
            {
                aum = 423.45;
            }

            if (admi.Year >= 2010 && admi.Year <= 2013)
            {
                aum = (salario / 100) * 9.84;
            }

            if (admi.Year >= 2000 && admi.Year <= 2009)
            {
                aum = (salario / 100) * 16.4;
            }

            if (admi.Year <= 1999)
            {
                aum = (salario / 100) * 22.6;
            }

            return aum;
        }

    }
}
