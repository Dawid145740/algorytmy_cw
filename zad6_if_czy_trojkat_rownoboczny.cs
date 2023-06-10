using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double a, b, c;

        Console.WriteLine("Podaj pierwszy bok trójk¹ta");
        a = inputValue();
        Console.WriteLine("Podaj drugi bok trójk¹ta");
        b = inputValue();
        Console.WriteLine("Podaj trzeci bok trójk¹ta");
        c = inputValue();
        if (a == b)
        {
            if (a == c)
            {
                if (c == b)
                {
                    Console.WriteLine("Owe boki mog¹ utworzyæ trójk¹t równoboczny");
                }
            }
            else
            {
                Console.WriteLine("Z tych boków nie uzyskamy trójk¹ta równobocznego");
            }
        }
        else
        {
            Console.WriteLine("Z tych boków nie uzyskamy trójk¹ta równobocznego");
        }
    }


    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}
