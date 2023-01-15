using System;

class Problem12
{
    static void Main()
    {
        Console.Write("n: ");
        int n = int.Parse(Console.ReadLine());

        bool result = false;

        if (n % 2 != 0 && n > 20)
            result = true;
        else result = false;

        Console.WriteLine(result);
    }
}