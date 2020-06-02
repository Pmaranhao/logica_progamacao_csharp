using System;
using System.Globalization;


/* Fazer um programa para ler um vetor de N números reais. Em seguida, mostrar 
 * na tela a média aritmética de todos elementos. Depois mostrar todos os elementos 
 * do vetor que sejam abaixo da média.
 * EXEMPLO
 
     ENTRADA                SAÍDA
        4                   12.125
10.0 15.5 13.2 9.8           10.0
                             9.8   
     */

namespace exercicioVetor4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o tamanho do vetor: ");
            int n = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double[] vetor = new double[n];

            Console.WriteLine("Digite os valores do vetor: ");
            string[] valores = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {
                vetor[i] = double.Parse(valores[i], CultureInfo.InvariantCulture);
            }

            double soma = 0.0;

            for (int i = 0; i < n; i++)
            {
                soma = vetor[i] + soma;
            }

            double media = soma / n;

            Console.WriteLine("Média: ");
            Console.WriteLine(media.ToString("F3", CultureInfo.InvariantCulture));

            Console.WriteLine("Valores abaixo da média: ");
            for (int i = 0; i < n; i++)
            {
                if (vetor[i] < media)
                {
                    Console.WriteLine(vetor[i].ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
