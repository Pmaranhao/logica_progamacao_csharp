using System;
using System.Globalization;

/* Fazer um programa para ler os dados de um funcionário (nome, salário bruto e imposto). Em
seguida, mostrar os dados do funcionário (nome e salário líquido). Em seguida, aumentar o
salário do funcionário com base em uma porcentagem dada (somente o salário bruto é
afetado pela porcentagem) e mostrar novamente os dados do funcionário. 

    EXEMPLO
Nome: Joao Silva
Salário bruto: 6000.00
Imposto: 1000.00
Funcionário: Joao Silva, $ 5000.00
Digite a porcentagem para aumentar o salário: 10.0
Dados atualizados: Joao Silva, $ 5600.00 */

namespace oo6
{
    class Program
    {
        static void Main(string[] args)
        {

            Funcionario f = new Funcionario();

            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Funcionário: " + f);
            Console.WriteLine();

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f.AumentarSalario(porc);
            Console.WriteLine();
            Console.Write("Funcionário: " + f);
            

        }
    }
}
