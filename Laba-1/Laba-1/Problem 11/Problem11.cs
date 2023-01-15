using System;

class Problem11
{
    static void Main()
    {
        Console.Write("number: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("n: ");
        int n = int.Parse(Console.ReadLine());
        
        int nDigit = (int)(number / (long)Math.Pow(10, n - 1) % 10);

        if (Math.Pow(10, n - 1) > number)
            Console.WriteLine(" - ");
        else Console.WriteLine($"nDigit: {nDigit}");
    }
}