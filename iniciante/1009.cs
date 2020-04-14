using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 
        string nome = Convert.ToString(Console.ReadLine());
        double salario = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
        double vendas = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("TOTAL = R$ {0}", (salario + (vendas * 0.15)).ToString("F2", CultureInfo.InvariantCulture));
    }

}