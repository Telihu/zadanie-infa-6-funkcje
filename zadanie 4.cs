using System;

class Program
{
    static void Main()
    {
        int[,] array = {
            { 1, 2, 3, 4 },
            { 4, 2, 3, 1 },
            { 2, 3, 1, 4 },
            { 3, 4, 2, 1 }
        };

        int[] closestRows = FindClosestRows(array);
        Console.WriteLine("Najbardziej zbliżone wiersze: {0} i {1}", closestRows[0], closestRows[1]);
    }

    static int[] FindClosestRows(int[,] array)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);
        int[] closestRows = new int[2];
        int minDifference = int.MaxValue;

        for (int i = 0; i < rows; i++)
        {
            for (int j = i + 1; j < rows; j++)
            {
                int difference = CalculateRowDifference(array, i, j, cols);
                if (difference < minDifference)
                {
                    minDifference = difference;
                    closestRows[0] = i;
                    closestRows[1] = j;
                }
            }
        }

        return closestRows;
    }

    static int CalculateRowDifference(int[,] array, int i, int j, int cols)
    {
        int difference = 0;

        for (int k = 0; k < cols; k++)
        {
            int aik = array[i, k];
            int ajk = array[j, k];
            difference += (aik - ajk) * (aik - ajk);
        }

        return difference;
    }
}

