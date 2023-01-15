using System;

class Problem15
{
    static void Main()
    {
        Console.Write("a: ");
        float a = float.Parse(Console.ReadLine());

        Console.Write("b: ");
        float b = float.Parse(Console.ReadLine());

        Console.Write("c: ");
        float c = float.Parse(Console.ReadLine());

        int index = 0;
        if (a >= 0) index++;
        if (b >= 0) index++;
        if (c >= 0) index++;

        string? product = null;

        if (index == 0 || index == 2) product = "Negative";
        else if (index == 1 || index == 3) product = "Positive";

        Console.WriteLine(product);
    }
}