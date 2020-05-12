using System;

class URI
{
    static void Main(string[] args)
    {
        var testes = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < testes; i++)
        {
            var senha = new int[12];
            var frase = Console.ReadLine();
            int j = 0;
            int casas = 0;
            while (casas < 12)
            {
                switch (frase[j])
                {
                    case 'G':
                    case 'Q':
                    case 'a':
                    case 'k':
                    case 'u':
                        Console.Write(0);
                        casas++;
                        break;

                    case 'I':
                    case 'S':
                    case 'b':
                    case 'l':
                    case 'v':
                        Console.Write(1);
                        casas++;
                        break;

                    case 'E':
                    case 'O':
                    case 'Y':
                    case 'c':
                    case 'm':
                    case 'w':
                        Console.Write(2);
                        casas++;
                        break;

                    case 'F':
                    case 'P':
                    case 'Z':
                    case 'd':
                    case 'n':
                    case 'x':
                        Console.Write(3);
                        casas++;
                        break;

                    case 'J':
                    case 'T':
                    case 'e':
                    case 'o':
                    case 'y':
                        Console.Write(4);
                        casas++;
                        break;

                    case 'D':
                    case 'N':
                    case 'X':
                    case 'f':
                    case 'p':
                    case 'z':
                        Console.Write(5);
                        casas++;
                        break;

                    case 'A':
                    case 'K':
                    case 'U':
                    case 'g':
                    case 'q':
                        Console.Write(6);
                        casas++;
                        break;

                    case 'C':
                    case 'M':
                    case 'W':
                    case 'h':
                    case 'r':
                        Console.Write(7);
                        casas++;
                        break;

                    case 'B':
                    case 'L':
                    case 'V':
                    case 'i':
                    case 's':
                        Console.Write(8);
                        casas++;
                        break;

                    case 'H':
                    case 'R':
                    case 'j':
                    case 't':
                        Console.Write(9);
                        casas++;
                        break;
                };
                j++;
            }
            Console.WriteLine();
        }
    }
}