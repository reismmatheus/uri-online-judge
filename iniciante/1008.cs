using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 
        int numero = Convert.ToInt32(Console.ReadLine());
        int horas = Convert.ToInt32(Console.ReadLine());
        double salario = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("NUMBER = {0}", numero);
        Console.WriteLine("SALARY = U$ {0}", (salario * horas).ToString("F2", CultureInfo.InvariantCulture));
    }

}