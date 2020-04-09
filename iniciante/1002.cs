using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 
        var pi = 3.14159;
        var raio = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        var area = Math.Pow(raio, 2) * pi;

        Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));
    }

}