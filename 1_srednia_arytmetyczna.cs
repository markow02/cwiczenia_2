using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double a, b, c, sredniaArytmetyczna;

        Console.WriteLine("Podaj liczbę a");
        a = inputValue();
        Console.WriteLine("Podaj liczbę b");
        b = inputValue();
        Console.WriteLine("Podaj liczbę c");
        c = inputValue();
        sredniaArytmetyczna = (a + b + c) / 3;
        Console.WriteLine("Średnia arytmetyczna wynosi " + sredniaArytmetyczna);
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
