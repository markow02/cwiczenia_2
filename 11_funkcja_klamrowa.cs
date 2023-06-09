using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_funkcja_klamrowa
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        public static double FunkcjaKlamrowa(double x)
        {
            if (x <= 1.0)
            {
                if (x >= -2.0)
                {
                    return 0.0;
                }
                else
                {
                    return -1.0;
                }
            }
            else
            {
                if (x <= 2.0)
                {
                    return 1.0;
                }
                else
                {
                    return 0.0;
                }
            }
        }

    }
}
