// See https://aka.ms/new-console-template for more information

using System.Globalization;

Console.WriteLine("Hello, World!");
Console.WriteLine("Modyfikcja1");
Console.WriteLine("Modyfikcja2");
Console.WriteLine("Modyfikcja3");

static double GetAverage(int[] numbers)
{
    int sumencja = 0;
    foreach (var number in numbers)
    {
        sumencja += number;
    }

    return (double) sumencja / numbers.Length;
    
}

int[] numbers = {1, 2, 3, 4};

Console.WriteLine(GetAverage(numbers));