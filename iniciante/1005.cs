using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 
        var a = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        var b = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        var result = ((a * 3.5) + (b * 7.5)) / 11;
        Console.WriteLine("MEDIA = " + result.ToString("F5", CultureInfo.InvariantCulture));
    }

}