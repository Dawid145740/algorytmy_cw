using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double l1, l2;

        Console.WriteLine("Podaj pierwsz¹ liczbe");
        l1 = inputValue();
        Console.WriteLine("Podaj drug¹ liczbe");
        l2 = inputValue();
        if (l1 > l2)
        {
            Console.WriteLine("Liczba " + l1 + " jest wiêksza od " + l2);
        }
        else
        {
            Console.WriteLine("Liczba " + l2 + " jest wiêksza od " + l1);
        }
    }


    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}
