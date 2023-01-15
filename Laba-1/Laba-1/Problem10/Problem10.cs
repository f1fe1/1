using System;

class Problem10
{
    static void Main()
    {
        Console.Write("n: ");
        int n = int.Parse(Console.ReadLine());

        int lastDigit = n % 10;

        Console.WriteLine($"LastDigit: {lastDigit}");
    }
}