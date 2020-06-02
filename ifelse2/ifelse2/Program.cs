using System;

/* Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar. 
    EXEMPLO
    ENTRADA             SAÍDA
    12                    PAR  
     */

namespace ifelse2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um valor: ");
            int n = int.Parse(Console.ReadLine());

            if(n%2 == 0)
            {
                Console.WriteLine("PAR");
            }else
            {
                Console.WriteLine("ÍMPAR");
            }
        }
    }
}
