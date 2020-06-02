using System;

/*
 Leia um valor inteiro. A seguir, calcule o menor número de notas possíveis (cédulas) no qual o valor 
 pode ser decomposto. As notas consideradas são de 100, 50, 20, 10, 5, 2 e 1. A seguir mostre o valor 
 lido e a relação de notas necessárias.
 Exemplo de Entrada	        Exemplo de Saída
576                             576
                                5 nota(s) de R$ 100,00
                                1 nota(s) de R$ 50,00
                                1 nota(s) de R$ 20,00
                                0 nota(s) de R$ 10,00
                                1 nota(s) de R$ 5,00
                                0 nota(s) de R$ 2,00
                                1 nota(s) de R$ 1,00

 */

namespace uri1018
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, calculo, resto,
                     resto50, resto20, resto10, resto5, resto2, resto1, calculo50, calculo20,
                     calculo10, calculo5, calculo2, calculo1;

            Console.Write("Digite o valor: ");
            x = int.Parse(Console.ReadLine());

            calculo = x / 100;
            resto = x % 100;


            calculo50 = resto / 50;
            resto50 = resto % 50;


            calculo20 = resto50 / 20;
            resto20 = resto50 % 20;


            calculo10 = resto20 / 10;
            resto10 = resto20 % 10;



            calculo5 = resto10 / 5;
            resto5 = resto10 % 5;


            calculo2 = resto5 / 2;
            resto2 = resto5 % 2;

            calculo1 = resto2 / 1;
            resto1 = resto2 % 1;

            Console.WriteLine(calculo + " notas (s) de R$ 100,00");
            Console.WriteLine(calculo50 + " notas (s) de R$ 50,00");
            Console.WriteLine(calculo20 + " notas (s) de R$ 20,00");
            Console.WriteLine(calculo10 + " notas (s) de R$ 10,00");
            Console.WriteLine(calculo5 + " notas (s) de R$ 5,00");
            Console.WriteLine(calculo2 + " notas (s) de R$ 2,00");
            Console.WriteLine(calculo1 + " notas (s) de R$ 1,00");
        }
    }
}
