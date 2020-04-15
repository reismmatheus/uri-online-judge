using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 
        var entrada = Console.ReadLine();
        var a = Double.Parse(entrada.Split(' ')[0], CultureInfo.InvariantCulture);
        var b = Double.Parse(entrada.Split(' ')[1], CultureInfo.InvariantCulture);
        var c = Double.Parse(entrada.Split(' ')[2], CultureInfo.InvariantCulture);

        Console.WriteLine("TRIANGULO: " + ((a * c) / 2).ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("CIRCULO: " + (3.14159 * Math.Pow(c, 2)).ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("TRAPEZIO: " + ((a + b) * c / 2).ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("QUADRADO: " + (Math.Pow(b, 2)).ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("RETANGULO: " + (a * b).ToString("F3", CultureInfo.InvariantCulture));
    }

}