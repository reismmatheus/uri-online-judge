using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 
        var motorista = Convert.ToInt32(Console.ReadLine(), CultureInfo.InvariantCulture);
        var bomba = Convert.ToInt32(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine(motorista - bomba);
    }
}