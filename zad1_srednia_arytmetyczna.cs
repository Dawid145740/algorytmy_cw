using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double a, b, c;
        
        a = inputValue();
        b = inputValue();
        c = inputValue();
        double srednia;
        
        srednia = (a + b + c) / 3;
        Console.WriteLine(srednia);
    }
    

    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result));
        return result;
    }
}
