using System;

/* Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema
cartesiano. Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo
menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma).
Exemplo:
Entrada:            Saída:
2 2                 primeiro
3 -2                quarto
-8 -1               terceiro
-7 1                segundo
0 2
 */

namespace while2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite as coordenadas: ");
            string[] vet = Console.ReadLine().Split(' ');
            int x = int.Parse(vet[0]);
            int y = int.Parse(vet[1]);

            while(x != 0  && y != 0)
            {

                if (x > 0 && y > 0)
                {
                    Console.WriteLine("Primeiro");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("Segundo");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Terceiro");
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("Quarto");
                }

                Console.Write("Digite as coordenadas: ");
                vet = Console.ReadLine().Split(' ');
                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);
            }

            Console.Write("Encerrado");
        }
    }
}
