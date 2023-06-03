using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double x, y, r, odlegloscOdSrodka;

        Console.WriteLine("Podaj x");
        x = inputValue();
        Console.WriteLine("Podaj y");
        y = inputValue();
        Console.WriteLine("Podaj r");
        r = inputValue();
        if (x * x + y * y <= r * r)
        {
            Console.WriteLine("Wpisane współrzędne znajdują się w obrębie koła");
        }
        else
        {
            Console.WriteLine("Wpisane współrzędne NIE znajdują się w obrębie koła");
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
