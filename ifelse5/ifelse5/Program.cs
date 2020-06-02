using System;
using System.Globalization;

/* Com base na tabela abaixo, escreva um programa que leia o 
 código de um item e a quantidade deste item. A seguir, 
 calcule e mostre o valor da conta a pagar. 
 CÓDIGO     ESPECIFICAÇÃO         PREÇO
    1        Cachorro quente        R$4.00
    2        X-Salada               R$4.50
    3        X-Bacon                R$5.00
    4        Torrada simples        R$2.00
    5        Refrigerante           R$1.50

    EXEMPLO 

    ENTRADA         SAÍDA
    3 2             Total: R$ 10.00


     */

namespace ifelse5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o item e a quantidade: ");
            string[] vet = Console.ReadLine().Split(' ');
            int cod = int.Parse(vet[0]);
            int quant = int.Parse(vet[1]);

            double calculo = 0;

            if(cod == 1)
            {
                calculo = quant * 4.00;
                Console.Write("Total: R$ " + calculo.ToString("F2", CultureInfo.InvariantCulture));
            } else if (cod == 2)
            {
                calculo = quant * 4.50;
                Console.Write("Total: R$ " + calculo.ToString("F2", CultureInfo.InvariantCulture));
            } else if (cod == 3)
            {
                calculo = quant * 5.00;
                Console.Write("Total: R$ " + calculo.ToString("F2", CultureInfo.InvariantCulture));
            } else if (cod == 4)
            {
                calculo = quant * 2.00;
                Console.Write("Total: R$ " + calculo.ToString("F2", CultureInfo.InvariantCulture));
            } else
            {
                calculo = quant * 1.50;
                Console.Write("Total: R$ " + calculo.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
