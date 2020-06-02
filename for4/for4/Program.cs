using System;
using System.Globalization;

/* Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo
segundo. Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel".
Exemplo:
Entrada:        Saída:
3                -1.5   
3 -2              divisao impossivel
-8 0              0.0  
0 8


 */

namespace for4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite quantos testes que fazer: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite os valores: ");
                string[] valores = Console.ReadLine().Split(' ');
                int n1 = int.Parse(valores[0]);
                int n2 = int.Parse(valores[1]);

                if (n2 == 0)
                {
                    Console.WriteLine("Divisao impossivel");
                }
                else
                {
                    double divisao = (double) n1 / n2;
                    Console.WriteLine(divisao.ToString("F1",CultureInfo.InvariantCulture));
                }

            }
        }
    }
}
