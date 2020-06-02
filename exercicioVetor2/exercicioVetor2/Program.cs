using System;

/* Faça um programa que leia N números inteiros e armazene-os em um vetor.
   Em seguida, mostre na tela:
   - todos os números pares;
   - a quantidade de números.
 EXEMPLO:

    ENTRADA:                                        SAÍDA
    6                                                8 2 14 20
    8 2 11 14 13 20                                    4 
     */

namespace exercicioVetor2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o tamanho do vetor: ");
            int n = int.Parse(Console.ReadLine());
            int[] vetor = new int[n];

            Console.WriteLine("Digie os vaores do vetor: ");
            string[] valores = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {
                vetor[i] = int.Parse(valores[i]);
            }

            for (int i = 0; i < n; i++)
            {
                if (vetor[i] % 2 == 0)
                {
                    Console.Write(vetor[i] + " ");
                }
            }

            int qtnumerospares = 0;

            for (int i = 0; i < n; i++)
            {
                if (vetor[i] % 2 == 0)
                {
                    qtnumerospares++;
                }
            }

            Console.WriteLine();
            Console.WriteLine(qtnumerospares);

        }
    }
}
