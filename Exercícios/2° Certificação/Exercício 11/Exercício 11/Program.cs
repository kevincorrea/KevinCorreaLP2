using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_11
{
    class Program
    {
        static void Main(string[] args)
        {
            

            List<Carro> Cars = new List<Carro>();
            
           
            int numCars;
            numCars = int.Parse(Console.ReadLine());
          

            for (int i = 0; i < numCars; i++)
            {
                Carro ck = new Carro(); ;


                string modelo = Console.ReadLine();
                string marca = Console.ReadLine();
                string placa = Console.ReadLine();
                int capacidadePessoas = int.Parse(Console.ReadLine());

                ck.SetModelo(modelo);
                ck.SetMarca(marca);
                ck.SetPlaca(placa);
                ck.SetCapacidadePessoas(capacidadePessoas);
                ck.SetId();

                ck.GetModelo();
                ck.GetMarca();
                ck.GetPlaca();
                ck.GetId();
              
                Cars.Add(ck);

                
            }


             
               Console.WriteLine("Digite o ID do Carro desejado para se alocar");
               int idEscolha = int.Parse(Console.ReadLine());

                 while (idEscolha >= 0)
                 {
                    
                  for (int j = 0; j < Cars.Count; j++)
                
                  {
                   
                      Carro aloca = new Carro();
                      aloca = (Carro)Cars[j];                   
                   
                                       
                    if (aloca.GetId() == idEscolha)
                    {
                     
                       
                        if (aloca.Get_qtdPassa() = aloca.GetcapacidadePessoas())
                        {
                            Console.WriteLine("{0} Lotado: ", _idCarro));
                        }
                        
                        else
                        {
                           aloca.Set_qtdPassa(aloca.Get_qtdPassa() + 1);
                           Cars[j] = aloca;
                        }
                                          

                
            
            for (int  k = 0; k < numCars; k++)
                {
                    Console.WriteLine("Carro: " + " Id- " + (k + 1) + " Marca- " + Cars[k].GetMarca() + " Modelo- " + Cars[k].GetModelo() + " Placa- " + Cars[k].GetPlaca());
                    Console.WriteLine("Vagas Restantes: " + Cars[k].GetCapacidadePessoas());
   
                }


            
            
            Console.ReadKey();
            

        }
    }
}
