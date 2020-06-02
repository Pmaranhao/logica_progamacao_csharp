using System;

/*Ler um número N e depois uma matriz quadrada NxN com números inteiros. Depois, mostrar na tela a soma dos elementos de cada linha da matriz.
 EXEMPLO:

    ENTRADA            SAÍDA
      3                  11
      5  2 4             19   
      10 3 6             29
      9  8 12
     */

namespace exercicioMatriz2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um valor inteiro: ");
                int n = int.Parse(Console.ReadLine());
                int[,] matriz = new int[n, n];

            Console.WriteLine("Digite sua matriz: ");
                    for (int i = 0; i < n; i++)
                    {
                        string[] valores = Console.ReadLine().Split(' ');
                        for (int j = 0; j < n; j++)
                        {
                            matriz[i, j] = int.Parse(valores[j]);
                        }
                    }


            Console.WriteLine("SAÍDA: ");
                    for (int i = 0; i < n; i++)
                    {
                        int soma = 0;
                        for (int j = 0; j < n; j++)
                        {
                            soma = matriz[i, j] + soma;

                        }
                        Console.WriteLine(soma);
                    }
            }
    }
}
