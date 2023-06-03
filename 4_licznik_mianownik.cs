using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int a, b, c, d, x, y;

        Console.WriteLine("x/y = a/b + c/d");
        Console.WriteLine("Podaj a:");
        a = (int)inputValue();
        Console.WriteLine("Podaj b:");
        b = (int)inputValue();
        Console.WriteLine("Podaj c:");
        c = (int)inputValue();
        Console.WriteLine("Podaj d:");
        d = (int)inputValue();
        if (b != 0 || d != 0)
        {
            x = a * d + b * c;
            y = b * d;
            Console.WriteLine("Licznik wynosi " + x);
            Console.WriteLine("Mianownik wynosi " + y);
        }
        else
        {
            Console.WriteLine("Brak rozwiązania");
        }
    }

    // .NET can only read single characters or entire lines from the
    // console. The following function safely reads a double value.
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}
