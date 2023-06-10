using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double x, y, r;

        Console.WriteLine("Podaj pierwsz¹ wspó³rzêdn¹ punktu P");
        x = inputValue();
        Console.WriteLine("Podaj drug¹ wspó³rzêdn¹ punktu");
        y = inputValue();
        Console.WriteLine("Podaj promieñ ko³a");
        r = inputValue();
        double wspPunktu, kwadratPromienia, a, b;

        a = 0;
        b = 0;
        wspPunktu = Math.Pow(x - a, 2) + Math.Pow(y - b, 2);
        kwadratPromienia = Math.Pow(r, 2);
        if (wspPunktu <= kwadratPromienia)
        {
            Console.WriteLine("Punkt P le¿y w obrêbie ko³a");
        }
        else
        {
            Console.WriteLine("Punkt P nie le¿y w obrêbie ko³a");
        }
    }


    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}
