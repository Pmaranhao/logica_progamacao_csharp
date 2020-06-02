using System;

/* O sargento Silva organiza seu pelotão em M filas numeradas a partir de 1, sendo cada
 fila com a mesma quantidade de soldados.
   Um dos exercícios que o sargento Silva realiza com o pelotão é o exercício "girar fila",
   que consiste em dizer o número de uma fila, de modo que os soldados desta fila devem se mover 
   para a direita, e o último soldado da direita vai para posição mais à esquerda. Você
   deve fazer um programa para ler a formação do pelotão e executar o exercício "girar fila".
   
     EXEMPLO:
     
     ENTRADA                                        SAÍDA
     3                                              1034 2271 9013 9281 1138
     5                                              7201 2837 1827 1074 9271    
     1034 2271 9013 9281 1138                       1822 1977 1821 2278 1821    
     2837 1827 1074 9271 7201
     1822 1977 1821 2278 1821
     2*/

namespace exercicioMatriz7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o números de linhas: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Digite o números de colunas: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[m, n];

            Console.WriteLine("Digite sua matriz: ");
            for (int i = 0; i < m; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(valores[j]);
                }
            }

            Console.Write("Qual fila girar: ");
            int fila = int.Parse(Console.ReadLine());

            fila = fila - 1;

            int ultimoDaFila = matriz[fila, n - 1];

            for (int j = n - 1; j > 0; j--)
            {
                matriz[fila, j] = matriz[fila, j - 1];
            }

            matriz[fila, 0] = ultimoDaFila;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
