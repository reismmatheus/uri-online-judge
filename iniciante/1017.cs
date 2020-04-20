using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 
        var tempo = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
        var velocidade = Convert.ToInt32(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine((tempo * velocidade / 12).ToString("F3", CultureInfo.InvariantCulture));
    }

}