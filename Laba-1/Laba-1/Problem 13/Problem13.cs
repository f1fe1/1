using System;

class Problem13
{
    static void Main()
    {
        Console.Write("n: ");

        int n = int.Parse(Console.ReadLine());

        bool result = false;

        if (n % 9 == 0 || n % 11 == 0 || n % 13 == 0)
            result = true;
        else result = false;

        Console.WriteLine(result);
    }
}