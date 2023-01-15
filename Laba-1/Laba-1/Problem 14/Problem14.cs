using System;

class Problem14
{
    static void Main()
    {
        Console.Write("a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("b: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("c: ");
        int c = int.Parse(Console.ReadLine());

        int max = 0;

        if (a > b && a > c)
            max = a;
        else if (c > b && c > a)
            max = c;
        else if (b > a && b > c)
            max = b;
        else if (a == b && b == c)
            max = a;

        Console.WriteLine($"Max: {max}");
    }
}