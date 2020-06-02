using System;
using System.Globalization;

/* Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste
de 3 valores reais, cada um deles com uma casa decimal. Apresente a média ponderada para cada um destes
conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem
peso 5.
Exemplo:
Entrada:                       Saída:
3                               5.7
6.5 4.3 6.2                     6.3
5.1 4.2 8.1                     9.3
8.0 9.0 10.0

 */

namespace for3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite quantos testes deseja fazer: ");
            int n = int.Parse(Console.ReadLine());

           for (int i = 0; i < n; i++)
           {
                    Console.WriteLine("Digite as notas: ");
                    string[] valores = Console.ReadLine().Split(' ');
                    double a = double.Parse(valores[0], CultureInfo.InvariantCulture);
                    double b = double.Parse(valores[1], CultureInfo.InvariantCulture);
                    double c = double.Parse(valores[2], CultureInfo.InvariantCulture);

                    double media = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;

                    Console.WriteLine("Média: " + media.ToString("F1", CultureInfo.InvariantCulture));
           }

        }
    }
}
