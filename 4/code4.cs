using System;

class Program
{
    static void Main()
    {
        double sp = 67836.43, rj = 36678.66, mg = 29229.88, es = 27165.48, others = 19849.53;
        double total = sp + rj + mg + es + others;

        Console.WriteLine("Percentage of SP: " + (sp / total * 100).ToString("F2") + "%");
        Console.WriteLine("Percentage of RJ: " + (rj / total * 100).ToString("F2") + "%");
        Console.WriteLine("Percentage of MG: " + (mg / total * 100).ToString("F2") + "%");
        Console.WriteLine("Percentage of ES: " + (es / total * 100).ToString("F2") + "%");
        Console.WriteLine("Percentage of Others: " + (others / total * 100).ToString("F2") + "%");
    }
}
