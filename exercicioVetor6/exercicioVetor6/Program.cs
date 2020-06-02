using System;

/* Fazer um programa para ler um conjunto de nomes de pessoas e suas respectivas idades.
 * Depois, mostrar na tela o nome da pessoa mais velha.
    EXEMPLO:
    
    ENTRADA                     SAÍDA
      5                         Pessoa mais velha: Carlos
      Joao 16
      Maria 21
      Teresa 15
      Carlos 23
      Paulo 17
     */

namespace exercicioVetor6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite o tamanho do vetor: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os valores do vetor (ex. Pedro 34): ");
            string[] nome = new string[n];
            int[] idade = new int[n];



            for (int i = 0; i < n; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                nome[i] = valores[0];
                idade[i] = int.Parse(valores[1]);
            }

            int maiorIdade = idade[0];
            int posicaoMaiorIdade = 0;

            for (int i = 1; i < n; i++)
            {
                if (idade[i] > maiorIdade)
                {
                    maiorIdade = idade[i];
                    posicaoMaiorIdade = i;
                }
            }


            Console.WriteLine("Pessoa mais velha: " + nome[posicaoMaiorIdade]);
        }
    }
}
