using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    public class Equacao
    {
        public Equacao()
        {

        }

        private double a;
        private double b;
        private double c;
        private double delta;

        public void seta(double xa)
        {
            a = xa;
        }

        public void setb(double xb)
        {
            b = xb;
        }

        public void setc(double xc)
        {
            c = xc;
        }

        public void calcularDelta()
        {
            delta = b * b - 4 * a * c;
        }



        public String calcularX1()
        {
            double resultado = 0;
            if (delta >= 0)
            {
                resultado = ((-b) + Math.Sqrt(delta)) / 2 * a;
                return String.Format("X1 : {0,5:0.00}", resultado);
            }
            else
            {
                return "Equação não tem Raízes.Delta é menor 0.";
            }
        }

        public String calcularX2()
        {
            double resultado = 0;
            if (delta >= 0)
            {
                resultado = ( (-b) - Math.Sqrt(delta)) / 2 * a;
                return String.Format("X2 : {0,5:0.00}", resultado);
            }
            else
            {
                return "Equação não tem Raízes.Delta é menor 0.";
            }
        }
    }
}
