using System;

/* Ler um valor N. Calcular e escrever seu respectivo fatorial. 
   Fatorial de N = N * (N-1) * (N-2) * (N-3) * ... * 1.
   Lembrando que, por definição, fatorial de 0 é 1.
Exemplos:
Entrada:        Saída:
4                 24
Entrada:        Saída:
1                 1
Entrada:        Saída:
5                120
Entrada:        Saída:
0                 1
*/

namespace for7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor: ");
            int n = int.Parse(Console.ReadLine());

            int fat = 1;

            for(int i = 1; i <= n; i++)
            {    
                fat = fat * i;
            }


            Console.WriteLine(fat);
        }
    }
}
