using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 
        var entrada = Convert.ToString(Console.ReadLine());

        var a = Convert.ToInt32(entrada.Split(' ')[0]);
        var b = Convert.ToInt32(entrada.Split(' ')[1]);
        var c = Convert.ToInt32(entrada.Split(' ')[2]);
        var d = Convert.ToInt32(entrada.Split(' ')[3]);

        var logica = (b > c && d > a && (c + d) > (a + b) && (c > 0 && d > 0) &&(a % 2 == 0));

        if(logica)
            Console.WriteLine("Valores aceitos");
        else
            Console.WriteLine("Valores nao aceitos");
    }
}