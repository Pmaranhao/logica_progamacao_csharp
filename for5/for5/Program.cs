using System;

/* Ler um número inteiro N e calcular todos os seus divisores.
Exemplo:
Entrada:        Saída:
6                  1
                   2
                   3
                   6 
*/


namespace for5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um valor: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }   
        }
    }
}
