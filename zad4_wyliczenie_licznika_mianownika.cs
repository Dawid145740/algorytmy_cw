using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int a, b, c, d;

        Console.WriteLine("Podaj liczbê a");
        a = (int)inputValue();
        Console.WriteLine("Podaj liczbê b");
        b = (int)inputValue();
        if (b == 0)
        {
            Console.WriteLine("Brak rozwi¹zania");
        }
        Console.WriteLine("Podaj liczbê c");
        c = (int)inputValue();
        Console.WriteLine("Podaj liczbê d");
        d = (int)inputValue();
        if (d == 0)
        {
            Console.WriteLine("Brak rozwi¹zania");
        }
        double x, y;

        x = a * d + b * c;
        y = b * d;
        Console.WriteLine("Licznik równa siê " + x + ", mianownik równa siê " + y);
    }


    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}
