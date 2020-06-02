using System;

/*Ler um número inteiro N e uma matriz quadrada de ordem N. Mostrar qual o maior elemento de cada linha. Suponha não haver empates.
 * EXEMPLO:
    
    ENTRADA                SAÍDA     
      4                      12                           
    10 5 12 3                7
    4  7 0  6                8
    3  3 8  1                15
    15 13 4 7
     */

namespace exercicioMatriz3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite um número inteiro: ");
            int n = int.Parse(Console.ReadLine());
            int[,] matriz = new int[n, n];

            Console.WriteLine("Digite sua matriz:");
            for (int i = 0; i < n; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(valores[j]);
                }
            }


            Console.WriteLine("SAÍDA:");
            for (int i = 0; i < n; i++)
            {
                int maior = 0;
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] > maior)
                    {
                        maior = matriz[i, j];
                    }
                }
                Console.WriteLine(maior);
            }
        }
    }
}
