using System;
using System.Linq;

class Program
{
    static void Main()
    {
        double[] revenues = { 1000, 0, 2000, 3000, 0, 0, 1500, 4000, 500, 0, 2500 };
        var validDays = revenues.Where(x => x > 0).ToArray();
        double average = validDays.Average();

        Console.WriteLine("Lowest revenue: " + validDays.Min());
        Console.WriteLine("Highest revenue: " + validDays.Max());
        Console.WriteLine("Days above the average: " + validDays.Count(x => x > average));
    }
}
