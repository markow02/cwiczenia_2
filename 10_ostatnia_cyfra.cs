using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_ostatnia_cyfra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę naturalną");
            int number = inputValue();

            int ostatniaCyfra = number % 10;

            Console.WriteLine("Ostatnią cyfrą " + number + " jest: " + ostatniaCyfra);
        }
        private static int inputValue()
        {
            int result;
            while (!int.TryParse(Console.ReadLine(), out result)) ;
            return result;
        }
    }
}
