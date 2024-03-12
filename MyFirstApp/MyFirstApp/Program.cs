// See https://aka.ms/new-console-template for more information

using System.Globalization;

Console.WriteLine("Hello, World!");
Console.WriteLine("Modyfikcja1");
Console.WriteLine("Modyfikcja2");
Console.WriteLine("Modyfikcja3");

static double GetAverage(int[] numbers)
{
    int sum = 0;
    foreach (var number in numbers)
    {
        sum += number;
    }

    return (dobule) sum / numbers.Length;
    
}