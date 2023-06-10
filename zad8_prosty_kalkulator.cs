using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj pierwszą liczbę: ");
        double liczba1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Podaj drugą liczbę: ");
        double liczba2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Wybierz numer działania:");
        Console.WriteLine("1 - Dodawanie");
        Console.WriteLine("2 - Odejmowanie");
        Console.WriteLine("3 - Mnożenie");
        Console.WriteLine("4 - Dzielenie");
        int numerDzialania = int.Parse(Console.ReadLine());

        double wynik = 0;

        switch (numerDzialania)
        {
            case 1:
                wynik = liczba1 + liczba2;
                break;
            case 2:
                wynik = liczba1 - liczba2;
                break;
            case 3:
                wynik = liczba1 * liczba2;
                break;
            case 4:
                if (liczba2 != 0)
                {
                    wynik = liczba1 / liczba2;
                }
                else
                {
                    Console.WriteLine("Błąd: Dzielenie przez zero!");
                    wynik = liczba1 / 0;
                }
                break;
            default:
                Console.WriteLine("Błąd: Nieprawidłowy numer działania!");
                break;
        }

        if (double.IsInfinity(wynik))
        {
            Console.WriteLine("Wynik: " + liczba1 + "/0");
        }
        else
        {
            Console.WriteLine("Wynik: " + wynik);
        }
    }
}