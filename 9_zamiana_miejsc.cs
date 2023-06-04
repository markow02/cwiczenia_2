using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_zamiana_miejsc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a -> b, b -> c, c -> a\r\n");

          
            double a, b, c;
            Console.WriteLine("Podaj liczbe a");
            a = inputValue();
            Console.WriteLine("Podaj liczbe b");
            b = inputValue();
            Console.WriteLine("Podaj liczbe c");
            c = inputValue();

            a = a + b + c;
            b = a - (b + c);
            c = a - (b + c);
            a = a - (b + c);

            Console.WriteLine("\r\na: " + a);
            Console.WriteLine("b: " + b);
            Console.WriteLine("c: " + c);
        }
        private static double inputValue()
        {
            double result;
            while (!double.TryParse(Console.ReadLine(), out result)) ;
            return result;
        }
    }

}
