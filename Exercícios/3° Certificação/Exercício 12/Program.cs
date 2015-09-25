using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a quantidade de funcionários");
            int quantfunc = int.Parse(Console.ReadLine());

            List<Trabalhador> Trabalhador = new List<Trabalhador>();
            List<Gerente> Gerente = new List<Gerente>();
            List<Terceirizado> Terceirizado = new List<Terceirizado>();


            for (int i = 0; i <= quantfunc; i++)
       {

           Console.WriteLine("Informe o tipo de funcionário, trabalhador, gerente ou terceirizado");
           string funcTip = Console.ReadLine();

           if (funcTip == "trabalhador")
           {

                Trabalhador trab = new Trabalhador();
                Console.Write("Nome: ");
                trab.Nome = Console.ReadLine();
                Console.Write("CPF: ");
                trab.Cpf = Console.ReadLine();
                Console.Write("Data de nascimento: ");
                trab.DataNascimento = DateTime.Parse(Console.ReadLine());
                Console.Write("Matricula: ");
                trab.Matricula = Console.ReadLine();
                Console.Write("Salário: ");
                trab.Salario = double.Parse(Console.ReadLine());

              
               Trabalhador.Add(trab);
            }

           else if (funcTip == "gerente")
           {
               Gerente ger = new Gerente();
               Console.Write("Nome: ");
               ger.Nome = Console.ReadLine();
               Console.Write("CPF: ");
               ger.Cpf = Console.ReadLine();
               Console.Write("Data de nascimento: ");
               ger.DataNascimento = DateTime.Parse(Console.ReadLine());
               Console.Write("Matricula: ");
               ger.Matricula = Console.ReadLine();
               Console.Write("Salário: ");
               ger.Salario = double.Parse(Console.ReadLine());
               Console.Write("Área: ");
               ger.AreaGerencia = Console.ReadLine();
               Console.Write("Valor adicional pela área: ");
               ger.ValorAdc = double.Parse(Console.ReadLine());

               Gerente.Add(ger);

           }

           if (funcTip == "terceirizado")
           {
               Terceirizado terc = new Terceirizado();
               Console.Write("Nome: ");
               terc.Nome = Console.ReadLine();
               Console.Write("CPF: ");
               terc.Cpf = Console.ReadLine();
               Console.Write("Data de nascimento: ");
               terc.DataNascimento = DateTime.Parse(Console.ReadLine());
               Console.Write("Matricula: ");
               terc.Matricula = Console.ReadLine();
               Console.Write("CNPJ: ");
               terc.Cnpj = Console.ReadLine();

               Terceirizado.Add(terc);
     
           }

       }
            double folhaDePagamento = 0;

            foreach (Trabalhador trab in Trabalhador)
            {
                folhaDePagamento += trab.Salario;
                folhaDePagamento += trab.ValeAlimentacao();
            }

            foreach (Gerente ger in Gerente)
            {
                folhaDePagamento += ger.SalarioTotal();
                folhaDePagamento += ger.ValeAlimentacao();
            }
            Console.WriteLine("A folha de pagamento total da empresa é de R${0}", folhaDePagamento);

        }
    }
}
