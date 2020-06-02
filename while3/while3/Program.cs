using System;

/* Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva
um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel
4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até
que seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser escrito a
mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme
exemplo.
Exemplo:
Entrada:        Saída:
8               MUITO OBRIGADO
1               Alcool: 1
7               Gasolina: 2
2               Diesel: 0 
2
4
*/

namespace while3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma opção de combustível: ");
            int opcao = int.Parse(Console.ReadLine());

            int countA = 0;
            int countG = 0;
            int countD = 0;
                
                     
            while (opcao != 4)
            {
                if ((opcao != 1 && opcao != 2) && opcao != 3)
                {
                    Console.Write("Digite uma opção válida: ");
                    opcao = int.Parse(Console.ReadLine());
                }
                else if (opcao == 1)
                {
                    countA++;
                }
                else if (opcao == 2)
                {
                    countG++;
                }
                else if (opcao == 3)
                {
                    countD++;
                }

                Console.Write("Digite uma opção de combustível: ");
                opcao = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Muito obrigado");
            Console.WriteLine("Álcool: " + countA);
            Console.WriteLine("Gasolina: " + countG);
            Console.WriteLine("Diesel: " + countD);

        }
    }
}