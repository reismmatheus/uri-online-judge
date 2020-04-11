using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 
        var a = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        var b = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        var c = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        var result = ((a * 2) + (b * 3) + (c * 5)) / 10;
        Console.WriteLine("MEDIA = " + result.ToString("F1", CultureInfo.InvariantCulture));
    }

}