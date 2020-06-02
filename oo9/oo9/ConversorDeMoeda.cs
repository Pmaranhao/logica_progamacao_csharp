using System;
using System.Collections.Generic;
using System.Text;

namespace oo9
{
    class ConversorDeMoeda
    {
        public static double Iof = 6.0;

        public static double calculo(double quantia, double cotacao)
        {
            double total = quantia * cotacao;
            return total + total * Iof / 100.0;
        }
    }
}
