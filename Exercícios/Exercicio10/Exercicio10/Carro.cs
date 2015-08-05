using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10
{
    class Carro
    {
        public string _placa;
        public string _modelo;
        public string _marca;
        public double _ano;
         public double _kilometragem;
         public double _captanque;
         public double _potencia;
         
      

        
        
        public void SetPlaca(string placa)
        {
           _placa = placa;
        }
        
        public string GetPlaca()
        {
            return _placa;
        }
        
        public void Setmodelo(string modelo)
        {
            _modelo = modelo;
        }
        
        public  string GetModelo()
        {
            return _modelo;
        }
       
        public void SetMarca(string marca)
        {
            _marca = marca;
        }
        public string GetMarca()
        {
            return _marca;
        }


        public void SetAno(double ano)
        {
            _ano = ano;
        }
        public double GetAno()
        {
            return _ano;
        }



        public void SetKilometragem(double kilometragem)
        {
            _kilometragem = kilometragem;
        }
        public double GetKilometragem()
        {
            return _kilometragem;
        }


        public void SetCaptanque(double captanque)
        {
            _captanque = captanque;
        }
        public double GetCaptanque()
        {
            return _captanque;
        }



        public void SetPotencia(double potencia)
        {
            _potencia = potencia;
        }
        public double GetPotencia()
        {
            return _potencia;
        }
    }
}
