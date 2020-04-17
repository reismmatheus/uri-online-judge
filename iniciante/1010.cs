using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 
        var somaTotal = 0.0;

        for (int i = 0; i < 2; i++)
        {
            var entrada = Console.ReadLine();
            var codigo = int.Parse(entrada.Split(' ')[0]);
            var quantidade = int.Parse(entrada.Split(' ')[1]);
            var valor = Double.Parse(entrada.Split(' ')[2], CultureInfo.InvariantCulture);
            somaTotal += valor * quantidade;
        }

        Console.WriteLine("VALOR A PAGAR: R$ " + somaTotal.ToString("F2", CultureInfo.InvariantCulture));
    }

}