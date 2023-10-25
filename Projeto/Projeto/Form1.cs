using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txbIdade_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbAltura_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbPeso_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIMC_Click(object sender, EventArgs e)
        {
            float peso = float.Parse(txbPeso.Text);
            float altura = float.Parse(txbAltura.Text);

            float imc;

            imc = peso / (altura * altura);

            lbResultado.Text = "O seu IMC É: " + imc;

            if ( imc < 18.5 ) 
            {

                lbResultado.Text = "O seu IMC É: " + imc + ", você está abixo do peso ideal";

            }

            else if ( imc < 25 )
            {

                lbResultado.Text = "O seu IMC É: " + imc + ", você está no peso ideal";

            }

            else if ( imc < 30 )
            {

                lbResultado.Text = "O seu IMC É: " + imc + ", você está levemente acima do peso ideal";

            }

            else if ( imc < 35 )
            {

                lbResultado.Text = "O seu IMC É: " + imc + ", você está com obesidade de 1º grau";

            }

            else if ( imc < 40 )
            {

                lbResultado.Text = "O seu IMC É: " + imc + ", você está com obesidade de 2º grau";

            }

            else 
            {

                lbResultado.Text = "O seu IMC É: " + imc + ", você está enorme de gordo";//ideia do professor essa frase

            }

        }

        private void btnDirigir_Click(object sender, EventArgs e)
        {
            int idade = int.Parse(txbIdade.Text);

            if (idade >= 18)
            {
                lbResultado.Text = "Você PODE dirigir!";
            }
            else
            {
                lbResultado.Text = "Você NÃO PODE dirigir!";
            }

        }

        private void lbResultado_Click(object sender, EventArgs e)
        {



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            double valorDivida = double.Parse(txbValorDivida.Text);
            int quantidadeParcelas = int.Parse(txbQtdParcelas.Text);

            double valorParcela;
            double valorJuros;
            double valorTotal;
         

            if (valorDivida < 50000)
            {
                valorJuros = valorDivida * 0.5;

                // teve que mudar a variável para double
               
                valorTotal = valorDivida + valorJuros;
                lbResultado.Text = "O juros que será acrescentado equivale a: R$" + valorJuros + "\nResultando em um total de: R$" + valorTotal;
                
                valorParcela = valorTotal / quantidadeParcelas;
                lbParcelado.Text = "Valor parcelado: R$" + valorParcela;
            }  

            else
            {
                valorJuros = valorDivida * 0.25;

                
                valorTotal = valorDivida + valorJuros;

                lbResultado.Text = "O juros que será acrescentado equivale a: R$" + valorJuros + "\nResultando em um total de: R$" + valorTotal;

                valorParcela = valorTotal / quantidadeParcelas;
                lbParcelado.Text = "Valor parcelado: R$" + valorParcela;

            }
            
         
        }
    }
}
