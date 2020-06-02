using System;
using System.Globalization;

/* Fazer um programa para ler um vetor de N números inteiros. 
 * Em seguida, mostrar na tela a média aritmética somente
   dos números pares lidos
    EXEMPLO:
    ENTRADA             SAÍDA
     6                   11.0
   8 2 11 14 13 20 
     */

namespace exercicioVetor5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite o tamanho do seu vetor: ");
            int n = int.Parse(Console.ReadLine());
            int[] vetor = new int[n];

            Console.WriteLine("Digite os valores do vetor: ");
            string[] valores = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {
                vetor[i] = int.Parse(valores[i]);
            }

            int soma = 0;
            int qtnumero = 0;

            for (int i = 0; i < n; i++)
            {
                if (vetor[i] % 2 == 0)
                {
                    soma = vetor[i] + soma;
                    qtnumero++;
                }
            }

            double media = 0.0;
            media = soma / qtnumero;

            Console.WriteLine("Saída");
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
