﻿using System;

class Problem9
{
    static void Main()
    {
        Console.Write("a: ");
        float a = float.Parse(Console.ReadLine());
        
        Console.Write("b: ");
        float b = float.Parse(Console.ReadLine());

        Console.Write("h: ");
        float h = float.Parse(Console.ReadLine());

        float area = (a + b) / 2 * h;
        Console.WriteLine($"Area: {area}");
    }
}