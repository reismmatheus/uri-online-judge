using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 
        var entrada = Convert.ToString(Console.ReadLine());

        var y = Convert.ToDouble(entrada.Split(' ')[0], CultureInfo.InvariantCulture);
        var x = Convert.ToDouble(entrada.Split(' ')[1], CultureInfo.InvariantCulture);

        if(x == 0 & y == 0){
            Console.WriteLine("Origem");
        }
        else if(x == 0){
            Console.WriteLine("Eixo X");
        }
        else if(y == 0){
            Console.WriteLine("Eixo Y");
        }
        else if(x > 0){
            if(y > 0){
                Console.WriteLine("Q1");
            }
            else {
                Console.WriteLine("Q2");
            }
        }
        else{
            if(y > 0){
                Console.WriteLine("Q4");
            }
            else {
                Console.WriteLine("Q3");
            }
        }
    }
}