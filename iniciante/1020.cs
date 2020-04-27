using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 
        var idade = Convert.ToInt32(Console.ReadLine(), CultureInfo.InvariantCulture);

        var ano = idade / 365;
        idade %= 365;
        var mes = idade / 30;
        idade %= 30;
        var dia = idade;

        Console.WriteLine("{0} ano(s)", ano);
        Console.WriteLine("{0} mes(es)", mes);
        Console.WriteLine("{0} dia(s)", dia);
    }
}