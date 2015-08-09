using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trab_2C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       List<Carro> Cars = new List<Carro>();

       int qtdCarros;
 
        qtdCarros = int.Parse(txtQtdCarro.Text);

        private void btnCdstro_Click(object sender, EventArgs e)
        {
           
            
                Carro ck = new Carro();
                ck.Set_idCarro(qtdCarros);
                ck.Set_modelo(txtModelo.Text);
                ck.Set_marca(txtMarca.Text);
                ck.Set_placa(txtPlaca.Text);
                ck.Set_capCarro(int.Parse(txtCapCarro.Text));
                Cars.Add(ck);

                txtModelo.Clear();
                txtMarca.Clear();
                txtPlaca.Clear();
                txtCapCarro.Clear();
                txtModelo.Focus();

        }

       int Carros;

        private void btnStart_Click(object sender, EventArgs e)
        {
            Carros = int.Parse(txtQtdCarros.Text);
           
        }


        private void btnsolicite_Click(object sender, EventArgs e)
        {


                int idEscolha = int.Parse(txtId.Text);

                 while (idEscolha >= 0)
                 {
                    
                  for (int j = 0; j < Cars.Count; j++)
                
                  {
                   
                      Carro aloca = new Carro();
                      aloca = (Carro)Cars[j];                   
                   
                                       
                    if (aloca.GetId() == idEscolha)
                    {
                     
                       
                        if (aloca.Get_qtdPassa() = aloca.GetcapCarro())
                        {
                            MessageBox.Show("{0} Lotado: ", _idCarro));
                        }
                        
                        else
                        {
                           aloca.Set_qtdPassa(aloca.Get_qtdPassa() + 1);
                           Cars[j] = aloca;
                        }
                                          

                
            
            for (int  k = 0; k < qtdCars; k++)
                {
                    MessageBox.Show("Carro: " + " Id- " + (k + 1) + " Marca- " + Cars[k].GetMarca() + " Modelo- " + Cars[k].GetModelo() + " Placa- " + Cars[k].GetPlaca());
                    MessageBox.Show("Vagas Restantes: " + Cars[k].GetCapCarro());
   
                }


            

          

        private void button1_Click_1(object sender, EventArgs e)
        {
        
        }  

      
     
       
    
    
    
    
    }
}
