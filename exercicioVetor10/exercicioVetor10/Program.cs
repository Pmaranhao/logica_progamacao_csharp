using System;
using System.Globalization;
using System.Runtime.Serialization;

/* Fazer um programa para ler um número inteiro N e a altura de N pessoas.
Armazene as N alturas em um vetor. Em seguida, mostrar a altura média dessas
pessoas.
Entrada:      Saída:
3             AVERAGE HEIGHT = 1.69
1.72
1.56
1.80

 */

namespace exercicioVetor10
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Write("Digite um numero inteiro: ");
            int n = int.Parse(Console.ReadLine());

            double[] vet = new double[n];

            Console.WriteLine("Digite as alturas: ");
            for(int i = 0; i < n; i++)
            {
                vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double soma =  0.0;

            for (int i = 0; i < n; i++)
            {
                soma += vet[i];                         
            }

            double media = soma / n;

            Console.WriteLine("AVERAGE HEIGHT = " + media.ToString("F2",CultureInfo.InvariantCulture));
            
        }
    }
}
