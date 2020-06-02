using System;
using System.Globalization;

/* Fazer um programa para ler o nome de um aluno e as três notas que ele obteve nos três trimestres do ano
(primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada). Ao final, mostrar qual a nota final do aluno no
ano. Dizer também se o aluno está APROVADO ou REPROVADO e, em caso negativo, quantos pontos faltam para o
aluno obter o mínimo para ser aprovado (que é 60 pontos). Você deve criar uma classe Aluno para resolver este
problema.

Exemplo 1:
Nome do aluno: Alex Green
Digite as três notas do aluno:
27.00
31.00
32.00
NOTA FINAL = 90.00
APROVADO

Exemplo 2:
Nome do aluno: Alex Green
Digite as três notas do aluno:
17.00
20.00
15.00
NOTA FINAL = 52.00
REPROVADO
FALTARAM 8.00 PONTOS
  */

namespace oo7
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();

            Console.Write("Nome do aluno: ");
            a.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            a.Nota1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            a.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Nota final: " + a.NotaFinal().ToString("F2",CultureInfo.InvariantCulture));

            if (a.Aprovado())
            {
                Console.WriteLine("Aprovado");
            } else
            {
                Console.WriteLine("Reprovado");
                Console.WriteLine("Faltaram " + a.NotaRestante().ToString("F2", CultureInfo.InvariantCulture) + " pontos");
            }
        }
    }
}
