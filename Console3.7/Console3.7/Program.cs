using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int counter = 10;
        Console.WriteLine("Value: {0} Increment: {1}", counter, counter++);

        int counterOne = 10;
        Console.WriteLine("Value: {0} Increment: {1}", counterOne, ++counterOne);

        double result = 5.0 / 2.0 * 3.0;
        Console.WriteLine("Value: {0}", result);

        int MyCase = 4 & 5;
        Console.WriteLine("Value: {0}", MyCase);

        int b = 10;
        int k = -5;
        b = b - k;
        Console.WriteLine(b);

        double results = 10 % 3;
        Console.WriteLine(results);

        Console.ReadKey();
    }
}