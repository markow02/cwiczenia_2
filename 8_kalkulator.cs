using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double a, b, c;

        Console.WriteLine("Podaj pierwszą liczb");
        a = inputValue();
        Console.WriteLine("Podaj drugą liczbę");
        b = inputValue();
        Console.WriteLine("Wybierz działanie: 1 - dodawanie, 2 - odejmowanie, 3 - mnożenie, 4 - dzielenie");
        c = inputValue();
        
        switch (c)
        {
            case 1:
                Console.WriteLine("Wynik: " + (a + b));
                break;
            case 2:
                Console.WriteLine("Wynik: " + (a - b));
                break;
            case 3:
                Console.WriteLine("Wynik: " + (a * b));
                break;
            case 4:
                if(b == 0)
                {
                    Console.WriteLine("Wynik: " + (a + "/0"));
                }
                else
                {
                    Console.WriteLine("Wynik: " + (a / b));
                }
                break;
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
