using System;
using System.Linq;

class URI
{
    static void Main(string[] args)
    {
        string entrada = "";
        while ((entrada = Console.ReadLine()) != "*")
        {
            var palavras = entrada.Split(' ').ToList();
            if (palavras.Any(x => x[0].ToString().ToUpper() != entrada[0].ToString().ToUpper()))
            {
                Console.WriteLine("N");
            }
            else
            {
                Console.WriteLine("Y");
            }
        }
    }
}