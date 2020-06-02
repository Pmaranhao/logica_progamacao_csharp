using System;

/* Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando
essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).
Exemplo:
Entrada:        Saída:
5               2 in
14              3 out
123
10
-25
32
 */

namespace for2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira quantos números que digitar: ");
            int N = int.Parse(Console.ReadLine());
            int[] vet = new int[N];

            int countIn = 0;
            int countOut = 0;

            for(int i = 0; i < N; i++)
            {
                Console.Write("Digite o valor: ");
                vet[i] = int.Parse(Console.ReadLine());
                if(vet[i] >= 10 && vet[i] <= 20)
                {
                    countIn++;
                }
                else
                {
                    countOut++;
                }

            }

            Console.WriteLine(countIn + " in");
            Console.WriteLine(countOut + " out");
        }
    }
}
