using System;

/* Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os 
 * ímpares de 1 até X, um valor por linha, inclusive o
X, se for o caso.
Exemplo:
Entrada:        Saída:
8                   1
                    3
                    5
                    7 */

namespace for1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um valor: ");
            int X = int.Parse(Console.ReadLine());

            for(int i = 0; i <= X; i++)
            {
                if(i%2 == 1)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
