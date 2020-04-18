using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 
        var raio = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        var result = (4/3.0) * 3.14159 * Math.Pow(raio, 3);
        Console.WriteLine("VOLUME = " + result.ToString("F3", CultureInfo.InvariantCulture));
    }

}