using System;
using System.Globalization;

/* Fazer um programa para ler um conjunto de N nomes de alunos,
   bem como as notas que eles tiraram no 1 e 2 semestres.
   Cada uma dessas informações deve ser armazenadas em um
   vetor. Depois, imprimir os nomes dos alunos aprovados,
   considerando aprovados aqueles cuja média das notas seja maior ou igual a seis.
   EXEMPLO:
   ENTRADA                          SAÍDA
   4                                Alunos aprovados:
   Joao 7.0 8.5                     Joao
   Maria 9.2 6.5                    Maria
   Carlos 5.0 6.0                   Teresa
   Teresa 5.5 6.5  
   */

namespace exercicioVetor7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o tamanho do vetor: ");
            int n = int.Parse(Console.ReadLine());

            string[] nomes = new string[n];
            double[] sm1 = new double[n];
            double[] sm2 = new double[n];

            Console.WriteLine("Digite o nome e as notas: ");
            for (int i = 0; i < n; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                nomes[i] = valores[0];
                sm1[i] = double.Parse(valores[1], CultureInfo.InvariantCulture);
                sm2[i] = double.Parse(valores[2], CultureInfo.InvariantCulture);
            }

            double soma = 0;
            double media = 0;

            Console.WriteLine("Aunos Aprovados: ");

            for (int i = 0; i < n; i++)
            {
                soma = sm1[i] + sm2[i];
                media = soma / 2.0;

                if (media >= 6)
                {
                    Console.WriteLine(nomes[i]);
                }

            }
        }
    }
}
