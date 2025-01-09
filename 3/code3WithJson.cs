using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

class Program
{
    class Revenue
    {
        public int dia { get; set; }
        public double valor { get; set; }
    }

    static void Main()
    {
        string jsonPath = "data/revenue.json";
        string jsonData = File.ReadAllText(jsonPath);

        List<Revenue> revenues = JsonConvert.DeserializeObject<List<Revenue>>(jsonData);
        var validDays = revenues.Where(r => r.valor > 0).ToList();

        double min = validDays.Min(r => r.valor);
        double max = validDays.Max(r => r.valor);
        double average = validDays.Average(r => r.valor);
        int daysAboveAverage = validDays.Count(r => r.valor > average);

        Console.WriteLine($"Smallest revenue: {min}");
        Console.WriteLine($"Largest revenue: {max}");
        Console.WriteLine($"Days above average: {daysAboveAverage}");
    }
}
