using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_1509
{
    class Gerente
    {
        public string Nome { get; set; }
        private string Cpf { get; set; }
        private DateTime Date { get; set; }
        private double _salario;

        private string Matricula { get; set; }

        private string Depart { get; set; }

        public double AdcDepart { get; set; }




        public void Set_salario(double salario)
        {
            _salario = _salario + AdcDepart;
         }

        public double Get_salario()
        {
            return _salario;
        }

    
    
    
    
    
    }

}
