using System;

    /* Fazer uma programa para ler duas matrizes de números inteiros A e B, contendo de M linhas 
      e N colunas cada. Depois gerar uma terceira matriz C onde cada elemento desta é a soma dos 
      elementos correspondentes das matrizes originais
      
      EXEMPLO:
      
      ENTRADA                  SAÍDA   
       2  3                    5 9 7  
       3 5 2                   5 13 9 
       4 5 1
       2 4 5 
       1 8 8
       .*/

namespace exercicioMatriz5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite as dimensões de sua matriz (LXC): ");
            string[] vet = Console.ReadLine().Split(' ');
            int m = int.Parse(vet[0]);
            int n = int.Parse(vet[1]);

            int[,] matrizA = new int[m, n];
            int[,] matrizB = new int[m, n];
            int[,] matrizC = new int[m, n];

            Console.WriteLine("Digite a matriz A: ");
            for (int i = 0; i < m; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    matrizA[i, j] = int.Parse(valores[j]);

                }
            }

            Console.WriteLine("Digite a matriz B: ");
            for (int i = 0; i < m; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    matrizB[i, j] = int.Parse(valores[j]);

                }
            }


            Console.WriteLine("SAÍDA: ");
            for (int i = 0; i < m; i++)
            {

                for (int j = 0; j < n; j++)
                {
                    matrizC[i, j] = matrizA[i, j] + matrizB[i, j];
                    Console.Write(matrizC[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
