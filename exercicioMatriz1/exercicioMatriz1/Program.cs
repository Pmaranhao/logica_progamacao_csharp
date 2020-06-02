using System;

/*Ler dois números M e N, e depois ler uma matriz MxN de números inteiros. Em seguida, mostrar na tela somente os números negativos da matriz.
 * EXEMPLO:
 
    ENTRADA         SAÍDA       
      2  3          -8
     12 -8 5        -13
    -13 10 -6       -6  
 */

namespace exercicioMatriz1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite dois numeros inteiros para sua matriz(ex: 2 3): ");
            string[] vet = Console.ReadLine().Split(' ');
            int m = int.Parse(vet[0]);
            int n = int.Parse(vet[1]);

            int[,] matriz = new int[m, n];
            
            Console.WriteLine("Digite os valores da matriz: ");
            
            for (int i = 0; i < m; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(valores[j]);
                }
            }

            Console.WriteLine("VALORES NEGATIVOS: ");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] < 0)
                    {
                        Console.WriteLine(matriz[i, j]);
                    }
                }
            }
        }
    }
}
