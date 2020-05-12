using System;

class URI
{
    static void Main(string[] args)
    {
        var testes = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < testes; i++)
        {
            var frase = Console.ReadLine();
            int j = 0;
            var leds = 0;
            while (j < frase.Length)
            {
                switch (frase[j])
                {
                    case '1':
                        leds += 2;
                        break;
                    case '2':
                    case '3':
                    case '5':
                        leds += 5;
                        break;
                    case '4':
                        leds += 4;
                        break;
                    case '6':
                    case '9':
                    case '0':
                        leds += 6;
                        break;
                    case '7':
                        leds += 3;
                        break;
                    case '8':
                        leds += 7;
                        break;

                };
                j++;
            }
            Console.WriteLine("{0} leds", leds);
        }
    }
}