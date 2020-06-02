using System;
/* Ler um interio N e uma matriz quadrada de ordem N. Mostrar a soma dos elementos acima da diagonal principal 
 EXEMPLO:
    ENTRADA      SAÍDA
        3          12
    10 3 2
    5 15 7
    8  6 4

     */

namespace exercicioMatriz4
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
            int soma = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                { 
                    soma = soma + matriz[i, j];
                }
            }
            Console.WriteLine(soma);
        }
    }
}
