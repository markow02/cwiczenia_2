using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double a, b;

        Console.WriteLine("Podaj pierwszą liczbę");
        a = inputValue();
        Console.WriteLine("Podaj drugą liczbę");
        b = inputValue();
        if (a > b)
        {
            Console.WriteLine("Większa liczba to " + a);
        }
        else
        {
            Console.WriteLine("Większa liczba to: " + b);
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
