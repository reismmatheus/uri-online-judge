using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 
        var valor = Convert.ToInt32(Console.ReadLine(), CultureInfo.InvariantCulture);

        var resto = valor;

        var nota100 = resto / 100;
        resto %= 100;
        var nota50 = resto / 50;
        resto %= 50;
        var nota20 = resto / 20;
        resto %= 20;
        var nota10 = resto / 10;
        resto %= 10;
        var nota5 = resto / 5;
        resto %= 5;
        var nota2 = resto / 2;
        resto %= 2;
        var nota1 = resto;

        Console.WriteLine(valor);
        Console.WriteLine("{0} nota(s) de R$ 100,00", nota100);
        Console.WriteLine("{0} nota(s) de R$ 50,00", nota50);
        Console.WriteLine("{0} nota(s) de R$ 20,00", nota20);
        Console.WriteLine("{0} nota(s) de R$ 10,00", nota10);
        Console.WriteLine("{0} nota(s) de R$ 5,00", nota5);
        Console.WriteLine("{0} nota(s) de R$ 2,00", nota2);
        Console.WriteLine("{0} nota(s) de R$ 1,00", nota1);
    }
}