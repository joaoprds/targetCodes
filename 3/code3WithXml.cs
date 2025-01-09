using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

class Program
{
    [XmlRoot("rows")]
    public class Rows
    {
        [XmlElement("row")]
        public List<Row> Items { get; set; }
    }

    public class Row
    {
        public int dia { get; set; }
        public double valor { get; set; }
    }

    static void Main()
    {
        string xmlPath = "data/revenue.xml";
        XmlSerializer serializer = new XmlSerializer(typeof(Rows));

        using (StreamReader reader = new StreamReader(xmlPath))
        {
            Rows rows = (Rows)serializer.Deserialize(reader);
            var validDays = rows.Items.Where(r => r.valor > 0).ToList();

            double min = validDays.Min(r => r.valor);
            double max = validDays.Max(r => r.valor);
            double average = validDays.Average(r => r.valor);
            int daysAboveAverage = validDays.Count(r => r.valor > average);

            Console.WriteLine($"Smallest revenue: {min}");
            Console.WriteLine($"Largest revenue: {max}");
            Console.WriteLine($"Days above average: {daysAboveAverage}");
        }
    }
}
