using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double a, b, c;

        Console.WriteLine("Podaj pierwszy bok tr�jk�ta");
        a = inputValue();
        Console.WriteLine("Podaj drugi bok tr�jk�ta");
        b = inputValue();
        Console.WriteLine("Podaj trzeci bok tr�jk�ta");
        c = inputValue();
        if (a == b)
        {
            if (a == c)
            {
                if (c == b)
                {
                    Console.WriteLine("Owe boki mog� utworzy� tr�jk�t r�wnoboczny");
                }
            }
            else
            {
                Console.WriteLine("Z tych bok�w nie uzyskamy tr�jk�ta r�wnobocznego");
            }
        }
        else
        {
            Console.WriteLine("Z tych bok�w nie uzyskamy tr�jk�ta r�wnobocznego");
        }
    }


    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}
