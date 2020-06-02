using System;

/* Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, 
 * sabendo que o mesmo pode começar em um dia e terminar em outro, tendo uma duração 
 * mínima de 1 hora e máxima de 24 horas.
    EXEMPLO             SAÍDA
    16  2               O JOGO DUROU 10 HORA(S)
     
     */

namespace ifelse4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o horário que o jogo começou e terminou: ");
            string[] vet = Console.ReadLine().Split(' ');
            int inicio = int.Parse(vet[0]);
            int fim = int.Parse(vet[1]);

            int calculo = 0;
                        
            if (inicio > fim)
            {
                calculo = 24 - inicio + fim;
                Console.WriteLine("O JOGO DUROU " + calculo + " HORA(S)");

            } else if(fim>inicio)
            {
                calculo = inicio - fim;
                Console.WriteLine("O JOGO DUROU " + calculo + " HORA(S)");
            
            } else
            {
                Console.WriteLine("O JOGO DUROU 24 HORA(S)");
            }
       
        }
    }
}
