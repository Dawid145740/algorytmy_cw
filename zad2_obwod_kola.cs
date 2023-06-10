using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Podaj Pole ko³a");
        double p;
        double r;
        double obwod;

        p = inputValue();
        r = Math.Sqrt(p / Math.PI);
        obwod = 2 * Math.PI * r;
        Console.WriteLine("Obwód ko³a to " + obwod);
    }

 
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}
