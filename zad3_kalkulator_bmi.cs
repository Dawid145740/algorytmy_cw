using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double waga;
        double wzrost;
        double bmi;

        Console.WriteLine("Podaj swoj¹ wagê w [kg]");
        waga = inputValue();
        Console.WriteLine("Podaj swój wzrost w [m]");
        wzrost = inputValue();
        bmi = waga / Math.Pow(wzrost, 2);
        Console.WriteLine("Twoje BMI to " + bmi);
    }


    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}
