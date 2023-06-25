using System;

public class Program
{
    public static int LiczbaDzielnikowPierwszych(int n)
    {
        if (n <= 5)
        {
            return 0;
        }

        int dzielniki = 0;

        for (int i = 2; i <= n / 2; i++)
        {
            if (n % i == 0 && CzyLiczbaPierwsza(i))
            {
                dzielniki++;
            }
        }

        return dzielniki;
    }

    public static bool CzyLiczbaPierwsza(int liczba)
    {
        if (liczba < 2)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(liczba); i++)
        {
            if (liczba % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    public static void Main()
    {
        
        int n = 12;
        int liczbaDzielnikow = LiczbaDzielnikowPierwszych(n);
        Console.WriteLine($"Liczba dzielników pierwszych liczby {n}: {liczbaDzielnikow}");
    }
}

