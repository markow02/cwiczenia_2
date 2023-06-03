using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double p, r, o;

        Console.WriteLine("Podaj pole koła");
        p = inputValue();
        r = Math.Sqrt(p / Math.PI);
        o = 2 * Math.PI * r;
        Console.WriteLine("Obwód koła wynosi " + o);
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
