using System;

class Problem8
{
    static void Main()
    {
        Console.Write("a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("b: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("c: ");
        int c = int.Parse(Console.ReadLine());

        float average = (float)(a + b + c) / 3;

        Console.WriteLine($"Average: {average}");
    }
}