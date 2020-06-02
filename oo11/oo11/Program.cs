using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

/*Struct
 Nullable*/

namespace oo11
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p;

            p.X = 10;
            p.Y = 20;
            Console.WriteLine(p);

            p = new Point();
            Console.WriteLine(p);


            Nullable<double> t = null;
            //ou 
            double? f = 10;

            Console.WriteLine(t.GetValueOrDefault());
            Console.WriteLine(f.GetValueOrDefault());
            
            Console.WriteLine(t.HasValue);
            Console.WriteLine(f.HasValue);

            if (t.HasValue)
                Console.WriteLine(t.Value);
            else
                Console.WriteLine("T é nulo");
            if (f.HasValue)
                Console.WriteLine(f.Value);
            else
                Console.WriteLine("Y é nulo");

            
            //operador de coalescência nula
            double? m = null;
            double? n = 15;

            double a = m ?? 5;
            double b = n ?? 5;

            Console.WriteLine(a);
            Console.WriteLine(b);

        }
    }
}
