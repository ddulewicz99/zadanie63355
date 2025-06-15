
using System;
using System.Text;

class Program
{
    static void Kalkulator()
    {
        Console.WriteLine("\n--- Prosty kalkulator dwóch liczb ---");
        Console.Write("Podaj pierwszą liczbę: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Podaj drugą liczbę: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Wybierz operację (+, -, *, /): ");
        string operacja = Console.ReadLine();

        double wynik = 0;
        bool poprawna = true;

        switch (operacja)
        {
            case "+":
                wynik = a + b;
                break;
            case "-":
                wynik = a - b;
                break;
            case "*":
                wynik = a * b;
                break;
            case "/":
                if (b != 0)
                    wynik = a / b;
                else
                {
                    Console.WriteLine("Błąd: dzielenie przez zero!");
                    poprawna = false;
                }
                break;
            default:
                Console.WriteLine("Nieznana operacja.");
                poprawna = false;
                break;
        }

        if (poprawna)
            Console.WriteLine("Wynik: " + wynik);
    }

    static void KonwerterTemperatur()
    {
        Console.WriteLine("\n--- Konwerter temperatur Celsjusz ↔ Fahrenheit ---");
        Console.Write("Wybierz kierunek konwersji (C/F): ");
        string kierunek = Console.ReadLine().ToUpper();

        Console.Write("Podaj temperaturę: ");
        double temp = Convert.ToDouble(Console.ReadLine());

        if (kierunek == "C")
        {
            double wynik = temp * 1.8 + 32;
            Console.WriteLine($"{temp}°C = {wynik:F2}°F");
        }
        else if (kierunek == "F")
        {
            double wynik = (temp - 32) / 1.8;
            Console.WriteLine($"{temp}°F = {wynik:F2}°C");
        }
        else
        {
            Console.WriteLine("Niepoprawny wybór.");
        }
    }

    static void SredniaOcen()
    {
        Console.WriteLine("\n--- Średnia ocen ucznia ---");
        Console.Write("Podaj liczbę ocen: ");
        int n = Convert.ToInt32(Console.ReadLine());
        double suma = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Ocena #{i + 1}: ");
            double ocena = Convert.ToDouble(Console.ReadLine());
            suma += ocena;
        }

        double srednia = suma / n;
        Console.WriteLine($"Średnia: {srednia:F2}");
        Console.WriteLine(srednia >= 3.0 ? "Uczeń zdał." : "Uczeń nie zdał.");
    }

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        while (true)
        {
            Console.WriteLine("\n--- MENU ---");
            Console.WriteLine("1. Kalkulator");
            Console.WriteLine("2. Konwerter temperatur");
            Console.WriteLine("3. Średnia ocen");
            Console.WriteLine("0. Wyjście");
            Console.Write("Wybierz opcję: ");
            string wybor = Console.ReadLine();

            switch (wybor)
            {
                case "1":
                    Kalkulator();
                    break;
                case "2":
                    KonwerterTemperatur();
                    break;
                case "3":
                    SredniaOcen();
                    break;
                case "0":
                    Console.WriteLine("Zakończono program.");
                    return;
                default:
                    Console.WriteLine("Nieprawidłowy wybór.");
                    break;
            }
        }
    }
}
