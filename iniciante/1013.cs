using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 
        var entrada = Console.ReadLine();
        var a = int.Parse(entrada.Split(' ')[0], CultureInfo.InvariantCulture);
        var b = int.Parse(entrada.Split(' ')[1], CultureInfo.InvariantCulture);
        var c = int.Parse(entrada.Split(' ')[2], CultureInfo.InvariantCulture);

        int maior = 0;

        maior = Maior(a, b);
        maior = Maior(maior, c);

        Console.WriteLine("{0} eh o maior", maior);
    }

    static int Maior(int a, int b){
        return a > b ? a : b;
    }

}