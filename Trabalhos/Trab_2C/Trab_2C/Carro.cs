using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trab_2C
{
    class Carro
    {
        private int _idCarro;
        private string _modelo;
        private string _marca;
        private string _placa;
        private int _capCarro;
        private int _qtdPassa;

        public void Set_idCarro(int idCarro)
        {
            _idCarro = idCarro;
        }

        public int Get_idCarro()
        {
            return _idCarro;
        }

        public void Set_modelo(string modelo)
        {
            _modelo = modelo;
        }

        public string Get_modelo()
        {
            return _modelo;
        }

        public void Set_marca(string marca)
        {
            _marca = marca;
        }

        public string Get_marca()
        {
            return _marca;
        }

        public void Set_placa(string placa)
        {
            _placa = placa;
        }

        public string Get_placa()
        {
            return _placa;
        }

        public void Set_capCarro(int capCarro)
        {
            _capCarro = capCarro;
        }

        public int Get_capCarro()
        {
            return _capCarro;
        }

        public void Set_qtdPassa(int qtdPassa)
        {
            _qtdPassa = qtdPassa;
        }

        public int Get_qtdPassa()
        {
            return _qtdPassa;
        }
    }
}
