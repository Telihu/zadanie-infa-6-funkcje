using System;

public class Program
{
    public static void Main(string[] args)
    {
       
        double x1 = 2.5;
        double y1 = 3.8;
        double x2 = 7.1;
        double y2 = 9.3;

      
        double dlugosc = ObliczDlugoscOdcinka(x1, y1, x2, y2);

        Console.WriteLine($"Długość odcinka wynosi: {dlugosc}");
    }

    public static double ObliczDlugoscOdcinka(double x1, double y1, double x2, double y2)
    {
    
        double roznicaX = x2 - x1;
        double roznicaY = y2 - y1;

        
        double kwadratRoznicyX = roznicaX * roznicaX;
        double kwadratRoznicyY = roznicaY * roznicaY;

       
        double sumaKwadratowRoznic = kwadratRoznicyX + kwadratRoznicyY;

        
        double dlugosc = Math.Sqrt(sumaKwadratowRoznic);

        return dlugosc;
    }
}
