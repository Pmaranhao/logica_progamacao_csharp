using System;

/* Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.
    EXEMPLO:
    ENTRADA             SAÍDA
      -10               NEGATIVO
  */

namespace ifelse1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escolha um núemro inteiro:  ");
            int n = int.Parse(Console.ReadLine());

            if(n < 0)
            {
                Console.WriteLine("NEGATIVO");
            } else if (n > 0)
            {
                Console.WriteLine("POSITIVO");
            } else
            {
                Console.WriteLine("NEUTRO");
            }
        }
    }
}
