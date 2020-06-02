using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace oo5
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            double area = Largura * Altura;
            return 2 * (Largura + Altura);
        }
        
        public double Diagonal()
        {
            return Math.Sqrt(Largura*Largura + Altura * Altura);
        }
    }
}
