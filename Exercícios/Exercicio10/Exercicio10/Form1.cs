using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Exercicio10
{
    public partial class Form1 : Form
    {
       
        

        public Form1()
        {
            InitializeComponent();
        }

        List<Carro> armazenamento = new List<Carro>();

        private void Cadst_Click(object sender, EventArgs e)
        {
            Carro ck = new Carro();
            try
            {
                ck.placa = txtplaca.Text;
                ck.modelo = txtmodelo.Text;
                ck.marca = txtmarca.Text;
                ck.ano = double.Parse(txtano.Text);
                ck.kilometragem = double.Parse(txtkilometragem.Text);
                ck.captanque = double.Parse(txtcaptanque.Text);
                ck.potencia = double.Parse(txtpotencia.Text);

               
                
                ck.SetPlaca(placa);
                ck.SetModelo(modelo);
                ck.SetMarca(marca);
                ck.SetaAno(ano);
                ck.SetKilometragem(kilometragem);
                ck.SetCaptanque(captanque);
                ck.SetPotencia(potencia);

                
                
                
                
                armazenamento.Add(ck);



                txtplaca.Clear();
                txtmodelo.Clear();
                txtmarca.Clear();
                txtano.Clear();
                txtkilometragem.Clear();
                txtcaptanque.Clear();
                txtpotencia.Clear();

            }

            catch
            {
                MessageBox.Show("Erro!");
            }



        }
        
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            

           
              
        }
    }

}
