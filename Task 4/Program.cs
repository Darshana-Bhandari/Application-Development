using System;

class Program
{
    static void Main()
    {
        int[] favoriteNumbers = { 7, 25, 10, 3, 18 };

        Console.WriteLine("Original array:");

        for (int i = 0; i < favoriteNumbers.Length; i++)
        {
            Console.WriteLine(favoriteNumbers[i]);
        }

        // Sort in ascending order
        Array.Sort(favoriteNumbers);

        Console.WriteLine("\nAfter sorting:");

        for (int i = 0; i < favoriteNumbers.Length; i++)
        {
            Console.WriteLine(favoriteNumbers[i]);
        }

        // Reverse the sorted array
        Array.Reverse(favoriteNumbers);

        Console.WriteLine("\nAfter reversing:");

        for (int i = 0; i < favoriteNumbers.Length; i++)
        {
            Console.WriteLine(favoriteNumbers[i]);
        }

        // Find position of a specific number
        int numberToFind = 10;
        int position = Array.IndexOf(favoriteNumbers, numberToFind);

        Console.WriteLine($"\nPosition of {numberToFind}: {position}");
    }
}