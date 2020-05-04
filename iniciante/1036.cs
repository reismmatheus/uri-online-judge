using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 
        var entrada = Convert.ToString(Console.ReadLine());

        var a = Convert.ToDouble(entrada.Split(' ')[0], CultureInfo.InvariantCulture);
        var b = Convert.ToDouble(entrada.Split(' ')[1], CultureInfo.InvariantCulture);
        var c = Convert.ToDouble(entrada.Split(' ')[2], CultureInfo.InvariantCulture);

        var delta = (Math.Pow(b, 2)) - (4 * a * c);

        if(delta < 0 || a == 0){
            Console.WriteLine("Impossivel calcular");
            return;
        }

        var r1 = (-b + Math.Sqrt(delta)) / (2 * a);
        var r2 = (-b - Math.Sqrt(delta)) / (2 * a);

        Console.WriteLine("R1 = {0}", r1.ToString("F5", CultureInfo.InvariantCulture));
        Console.WriteLine("R2 = {0}", r2.ToString("F5", CultureInfo.InvariantCulture));
    }
}