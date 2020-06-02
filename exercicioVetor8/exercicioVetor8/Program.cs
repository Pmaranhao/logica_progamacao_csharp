using System;
using System.Globalization;

/*Tem-se um conjunto de dados contendoa altura e o sexo (M,F) de N pessoas.
  Fazer um programa que calcule e escreva:
  - a maior e a menor altura do grupo;
  - a média de altura das mulheres;
  - o número de homens.
    EXEMPLO:
    ENTRADA                                 SAÍDA
       5                                    Menor altura = 1.54
       1.70 F                               Maior altura = 1.83
       1.83 M                               Média das alturas das mulheres = 1.69
       1.54 M                               Número de homens = 2
       1.61 F
       1.75 F
 */

namespace exercicioVetor8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o tamanho do vetor: ");
            int n = int.Parse(Console.ReadLine());
            double[] altura = new double[n];
            char[] sexo = new char[n];

            Console.WriteLine("Digite seu vetor:");
            for (int i = 0; i < n; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                altura[i] = double.Parse(valores[0], CultureInfo.InvariantCulture);
                sexo[i] = char.Parse(valores[1]);
            }

            double menorAltura = altura[0];

            for (int i = 0; i < n; i++)
            {
                if (altura[i] < menorAltura)
                {
                    menorAltura = altura[i];
                }
            }

            Console.WriteLine("Menor altura = " + menorAltura.ToString("F2", CultureInfo.InvariantCulture));

            double maiorAltura = altura[0];

            for (int i = 0; i < n; i++)
            {
                if (altura[i] > maiorAltura)
                {
                    maiorAltura = altura[i];
                }
            }

            Console.WriteLine("Maior altura = " + maiorAltura.ToString("F2", CultureInfo.InvariantCulture));

            double media = 0.0;
            double soma = 0.0;
            int cont = 0;

            for (int i = 0; i < n; i++)
            {
                if (sexo[i] == 'f')
                {
                    soma = altura[i] + soma;
                    cont++;
                }

            }

            media = soma / cont;

            Console.WriteLine("Media da alturas das mulheres = " + media.ToString("F2", CultureInfo.InvariantCulture));

            cont = 0;

            for (int i = 0; i < n; i++)
            {
                if (sexo[i] == 'm')
                {
                    cont++;
                }

            }

            Console.WriteLine("Numeros de homens = " + cont);
        }
    }
}
