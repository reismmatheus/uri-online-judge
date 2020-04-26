using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 
        var tempo = Convert.ToInt32(Console.ReadLine(), CultureInfo.InvariantCulture);

        var horas = tempo / 3600;
        tempo %= 3600;
        var minutos = tempo / 60;
        tempo %= 60;
        var segundos = tempo;

        Console.WriteLine("{0}:{1}:{2}", horas, minutos, segundos);
    }
}