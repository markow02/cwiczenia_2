using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double w, h, bmi;

        Console.WriteLine("Podaj swoją wagę w kilogramach");
        w = inputValue();
        Console.WriteLine("Podaj swój wzrost w metrach");
        h = inputValue();
        bmi = w / Math.Pow(h, 2);
        Console.WriteLine("Twój współczynnik BMI wynosi " + bmi);
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
