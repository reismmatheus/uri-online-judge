using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 
        var distancia = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        var combustivel = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("{0} km/l", (distancia / combustivel).ToString("F3"));
    }
}