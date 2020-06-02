using System;
using System.Globalization;

/* Ler uma matriz quadrada de ordem N, contendo números reais. Em seguida, fazer as seguintes ações:
   a) calcular e imprimir a soma de todos os elemntos positivos da matriz;
   b) fazer a leitura do índice de uma linha da matriz e, daí, imprimir todos os elementos desta linha;
   c) fazer a leitura do índice de uma coluna da matriz e,daí, imprimir todos os elementos desta coluna;
   d)imprimir os elementos da diagonal principal da matriz;
   e)alterar a matriz elevandoao quadrado todos os números negativos da mesma. Em seguida imprimir a matriz alterada.
   EXEMPLO:
   
     ENTRADA                                SAÍDA
        3                                   SOMA DOS POSITIVOS: 40.0    
      7.0  -8.0  10.0                       LINHA ESCOLHIDA: -2.0 3.0 5.0
     -2.0  3.0   5.0                        COLUNA ESCOLHIDA: 10.0 5.0 4.0
      11.0 -15.0 4.0                        DIAGONAL PRINCIPAL: 7.0 3.0 4.0
        1                                   MATRIZ ALTERADA:
        2                                   7.0  64.0  10.0
                                            4.0  3.0   5.0
                                            11.0 225.0 4.0
 */

namespace exercicioMatriz6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite o valor para sua matriz quadrada: ");
            int n = int.Parse(Console.ReadLine());

            double[,] matriz = new double[n, n];

            Console.WriteLine("Digite sua matriz: ");
            for (int i = 0; i < n; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = double.Parse(valores[j], CultureInfo.InvariantCulture);

                }
            }

            Console.Write("Qual linha quer imprimir: ");
            int nlinha = int.Parse(Console.ReadLine());
            Console.Write("Qual coluna quer imprimir: ");
            int clinha = int.Parse(Console.ReadLine());
            double soma = 0;

            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] > 0)
                    {
                        soma = matriz[i, j] + soma;
                    }

                }
            }

            Console.WriteLine();

            Console.WriteLine("SOMA DOS POSITIVOS: " + soma.ToString("F1"), CultureInfo.InvariantCulture);

            Console.Write("LINHA ESCOLHIDA: ");
            for (int i = 0; i < n; i++)
            {

                Console.Write(matriz[nlinha, i].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }

            Console.WriteLine();


            Console.Write("LINHA ESCOLHIDA: ");
            for (int i = 0; i < n; i++)
            {

                Console.Write(matriz[i, clinha].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }

            Console.WriteLine();

            Console.Write("DIAGONAL PRINCIPAL: ");
            for (int i = 0; i < n; i++)
            {

                Console.Write(matriz[i, i].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }

            Console.WriteLine();


            Console.WriteLine("MATRIZ ALTERADA: ");
            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < n; j++)
                {

                    if (matriz[i, j] < 0)
                    {
                        matriz[i, j] = matriz[i, j] * matriz[i, j];
                    }

                    Console.Write(matriz[i, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
