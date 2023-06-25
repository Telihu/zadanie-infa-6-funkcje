public class Program
{
    public static double ObliczSrednia(double[] tablica, int rozmiar)
    {
        if (rozmiar == 0)
        {
            return 0; 
        }
        else if (rozmiar == 1)
        {
            return tablica[0]; 
        }
        else
        {
            double ostatniaLiczba = tablica[rozmiar - 1];
            double sredniaPoprzednich = ObliczSrednia(tablica, rozmiar - 1);
            double srednia = (sredniaPoprzednich * (rozmiar - 1) + ostatniaLiczba) / rozmiar;
            return srednia;
        }
    }

    public static void Main(string[] args)
    {
        double[] tablica = { 1.5, 2.5, 3.5, 4.5, 5.5 };
        int rozmiar = tablica.Length;
        double srednia = ObliczSrednia(tablica, rozmiar);

        Console.WriteLine("Średnia arytmetyczna: " + srednia);
    }
}

