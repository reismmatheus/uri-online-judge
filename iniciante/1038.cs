using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 
        var entrada = Convert.ToString(Console.ReadLine());

        var codigo = Convert.ToInt32(entrada.Split(' ')[0], CultureInfo.InvariantCulture);
        var quantidade = Convert.ToInt32(entrada.Split(' ')[1], CultureInfo.InvariantCulture);

        double total = 0;

        switch (codigo)
        {
            case 1:
                total = quantidade * 4;
                break;
            case 2:
                total = quantidade * 4.5;
                break;
            case 3:
                total = quantidade * 5;
                break;
            case 4:
                total = quantidade * 2;
                break;
            case 5:
                total = quantidade * 1.5;
                break;
        }
        Console.WriteLine("Total: R$ {0}", total.ToString("F2", CultureInfo.InvariantCulture));
    }
}