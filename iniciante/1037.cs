using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 
        var valor = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

        if(valor < 0){
            Console.WriteLine("Fora de intervalo");
        }
        else if(valor <= 25.0000000d){
            Console.WriteLine("Intervalo [0,25]");
        }
        else if(valor <= 50.0000000d){
            Console.WriteLine("Intervalo (25,50]");
        }
        else if(valor <= 75.0000000d){
            Console.WriteLine("Intervalo (50,75]");
        }
        else if(valor <= 100.0000000d){
            Console.WriteLine("Intervalo (75,100]");
        }
        else{
            Console.WriteLine("Fora de intervalo");
        }
    }
}