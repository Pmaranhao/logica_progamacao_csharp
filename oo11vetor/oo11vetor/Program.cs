using System;
using System.Globalization;

/*Fazer um programa para ler um número inteiro N e os dados (nome e
preço) de N Produtos. Armazene os N produtos em um vetor. Em
seguida, mostrar o preço médio dos produtos.
 EXEMPLO

    Input:          Output:
    3                AVERAGE PRICE = 700.00
    TV
    900.00
    Fryer
    400.00
    Stove
    800.00

 */

namespace oo11vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantidade de produtos: ");
            int n = int.Parse(Console.ReadLine());

            Produto[] vet = new Produto[n];

            for (int i = 0; i < n; i++)
            {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vet[i] = new Produto { Nome = nome, Preco = preco };
            }

            double soma = 0.0;

            for (int i = 0; i < n; i++)
            {
                soma += vet[i].Preco;
            }

            double media = soma / n;

            Console.WriteLine("Preço médio = " + media.ToString("F2",CultureInfo.InvariantCulture));





        }
    }
}
