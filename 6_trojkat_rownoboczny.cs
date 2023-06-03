using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double a, b, c;

        Console.WriteLine("Podaj bok a");
        a = inputValue();
        Console.WriteLine("Podaj bok b");
        b = inputValue();
        Console.WriteLine("Podaj bok c");
        c = inputValue();
        if (a == b && a == c && b == c)
        {
            Console.WriteLine("Z tych boków może powstać trójkąt równoboczny");
        }
        else
        {
            Console.WriteLine("Z tych boków NIE może powstać trójkąt równoboczny");
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
