using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int a, b, c, d;

        Console.WriteLine("Podaj liczb� a");
        a = (int)inputValue();
        Console.WriteLine("Podaj liczb� b");
        b = (int)inputValue();
        if (b == 0)
        {
            Console.WriteLine("Brak rozwi�zania");
        }
        Console.WriteLine("Podaj liczb� c");
        c = (int)inputValue();
        Console.WriteLine("Podaj liczb� d");
        d = (int)inputValue();
        if (d == 0)
        {
            Console.WriteLine("Brak rozwi�zania");
        }
        double x, y;

        x = a * d + b * c;
        y = b * d;
        Console.WriteLine("Licznik r�wna si� " + x + ", mianownik r�wna si� " + y);
    }


    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}
