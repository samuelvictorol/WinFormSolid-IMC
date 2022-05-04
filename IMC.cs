using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaQuadrado
{
    public class IMC
    {
        Form1 f1;
        public IMC(Form1 f)
        {
            this.f1 = f ;
        }
        public void calcularIMC()
        {
            double resultado = Double.Parse(f1.txt_peso.Text) / (Double.Parse(f1.txt_altura.Text) * Double.Parse(f1.txt_altura.Text));
            
            if(resultado < 18.5)
            {
                this.f1.Text = "Seu IMC: " + resultado.ToString();
                MessageBox.Show("ABAIXO DO PESO NORMAL!");
            }else if(resultado > 18.5 && resultado < 24.9)
            {
                this.f1.Text = "Seu IMC: " + resultado.ToString();
                MessageBox.Show("PESO NORMAL");
            }else if (resultado >= 25 && resultado <= 29.9)
            {
                this.f1.Text = "Seu IMC: " + resultado.ToString();
                MessageBox.Show("Excesso de Peso");
            }else if( resultado > 30)
            {
                this.f1.Text = "Seu IMC: " + resultado.ToString();
                MessageBox.Show("MUITO ACIMA DO PESO");
            }
            this.f1.lb_res.Text = "Seu IMC: " + resultado.ToString();


        }
    }
}
