using System;

/* Faça um programa para ler dois vetores A e B, contendo N elementos cada.
 * Em seguida, gere um terceiro vetor C onde cada elemento de C é a soma
 * dos elementos correspondentes de A e B. Imprimir o vetor C gerado.
 EXEMPLO:

    ENTRADA:                                        SAÍDA
    6                                                13 12 14 15 23 27
    8 2 11 14 13 20
    5 10 3 1  10  7
     */

namespace exercicioVetor3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite o tamanho do vetor: ");
            int n = int.Parse(Console.ReadLine());
            int[] A = new int[n];
            int[] B = new int[n];
            int[] C = new int[n];

            Console.WriteLine("Digite os valores do vetor A: ");
            string[] valoresA = Console.ReadLine().Split(' ');

            Console.WriteLine("Digite os valores do vetor B: ");
            string[] valoresB = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {
                A[i] = int.Parse(valoresA[i]);
                B[i] = int.Parse(valoresB[i]);
            }


            for (int i = 0; i < n; i++)
            {
                C[i] = A[i] + B[i];
                Console.Write(C[i] + " ");
            }
        }
    }
}
