using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 
        var x = Console.ReadLine();
        var y = Console.ReadLine();
        var x1 = Convert.ToDouble(x.Split(' ')[0], CultureInfo.InvariantCulture);
        var y1 = Convert.ToDouble(x.Split(' ')[1], CultureInfo.InvariantCulture);
        var x2 = Convert.ToDouble(y.Split(' ')[0], CultureInfo.InvariantCulture);
        var y2 = Convert.ToDouble(y.Split(' ')[1], CultureInfo.InvariantCulture);

        var total = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

        Console.WriteLine(total.ToString("F4"), CultureInfo.InvariantCulture);
    }
}