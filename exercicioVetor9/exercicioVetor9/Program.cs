using System;
using System.Globalization;

/* Um comerciante deseja fazer o levantamento do lucro das mercadorias que ele
 * comercializa. Para isto, mandou digitar um conjunto de N mercadorias, cada uma 
 contendo nome, preço de compra e preço de venda das mesmas. Fazer um programa
 que leia tais dados e determine e escreva quantas mercadorias proporcionaram:
 - lucro <10%;
 - 10% < lucro < 20%;
 - lucro > 20%.
  EXEMPLO:
  ENTRADA                                 SAÍDA
  4                                       Lucro abaixo de 10%: 1
  Feijao 10.00 11.00                      Lucro entre 10% e 20%: 2
  Arroz 12.00 12.80                       Lucro acima de 20%: 1
  Oleo 5.00 5.70                          Valor total de compra: 30.00
  Sal 3.00 4.00                           Valor total de compra: 33.50 
                                          Lucro tota: 3.50  
 */


namespace exercicioVetor9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o tamanho do vetor: ");
            int n = int.Parse(Console.ReadLine());

            string[] nome = new string[n];
            double[] pc = new double[n];
            double[] pv = new double[n];

            Console.WriteLine("Digite o produto, valor de compra e de venda: ");
            for (int i = 0; i < n; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                nome[i] = valores[0];
                pc[i] = double.Parse(valores[1], CultureInfo.InvariantCulture);
                pv[i] = double.Parse(valores[2], CultureInfo.InvariantCulture);
            }


            int contl10 = 0;
            int contl20 = 0;
            int contl30 = 0;
            int somacont = 0;
            double porcento = 0.0;
            double lucropor = 0.0;

            for (int i = 0; i < n; i++)
            {
                lucropor = pv[i] - pc[i];
                porcento = (lucropor / pc[i]) * 100.0;

                if (porcento < 10)
                {
                    contl10++;
                }
                else if (porcento <= 20)
                {
                    contl20++;
                }
                else
                {
                    contl30++;
                }

            }

            somacont = contl10 + contl20;

            Console.WriteLine("Lucro abaixo de 10% : " + contl10);
            Console.WriteLine("Lucro entre 10% e 20%: " + contl20);
            Console.WriteLine("Lucro acima de 20%: " + contl30);

            double somac = 0;

            for (int i = 0; i < n; i++)
            {
                somac = pc[i] + somac;

            }
            Console.WriteLine("Valor total de compra : " + somac.ToString("F2", CultureInfo.InvariantCulture));

            double somav = 0;

            for (int i = 0; i < n; i++)
            {
                somav = pv[i] + somav;

            }
            Console.WriteLine("Valor total de venda : " + somav.ToString("F2", CultureInfo.InvariantCulture));

            double lucro = 0;

            lucro = somav - somac;
            Console.WriteLine("Lucro: " + lucro.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
