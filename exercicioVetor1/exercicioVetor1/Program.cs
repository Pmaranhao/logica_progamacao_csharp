using System;
using System.Globalization;

/* Faça um programa que leia N números reais e armazene-os em um vetor.
 Em seguida, mostrar na tela o maior número do vetor (supor não haver empates). 
 Mostrar também a posição do maior elemento.
 EXEMPLO:

    ENTRADA:                                        SAÍDA
    6                                                14.0
    8.0 4.0 10.0 14.0 13.0 7.0                         3 
     */

namespace exercicioVetor1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.Write("Digite o tamanho do vetor: ");
            n = int.Parse(Console.ReadLine());

            double[] vetor = new double[n];
            
            Console.WriteLine("Digite os valores do vetor: ");
            string[] valores = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {

                vetor[i] = double.Parse(valores[i], CultureInfo.InvariantCulture);
            }

            double maior = vetor[0];
            int posicaoMaior = 0;

            for (int i = 0; i < n; i++)
            {
                if (vetor[i] > maior)
                {
                    maior = vetor[i];
                    posicaoMaior = i;
                }
            }
            Console.WriteLine(maior.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine(posicaoMaior);
        }
    }
}
