using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaQuadrado
{
    public class Retangulo
    {

        public void calculaArea(Form1 f)
        {
            Form1 f1 = f;
            double resultado;
            resultado = Double.Parse(f1.txt_peso.Text) * Double.Parse(f1.txt_altura.Text);
            f1.lb_res.Text = resultado.ToString();
        }

    }
}
