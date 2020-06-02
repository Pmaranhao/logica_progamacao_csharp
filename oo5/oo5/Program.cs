using System;
using System.Globalization;

/* Fazer um programa para ler os valores da largura e altura
de um retângulo. Em seguida, mostrar na tela o valor de
sua área, perímetro e diagonal. Usar uma classe como
mostrado no projeto ao lado.

    EXEMPLO
Entre a largura e altura do retângulo:
3.00
4.00
SAÍDA
AREA = 12.00
PERÍMETRO = 14.00
DIAGONAL = 5.00 */

namespace oo5
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo r = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo:");
            Console.Write("Digite a altura:");
            r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite a largura:");
            r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            
            Console.WriteLine(r.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(r.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(r.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
