using System;

namespace Multifabriken
{
    class Program
    {
        static void Header() {
            Console.Clear();
            Console.WriteLine("**********************************************\n");
            Console.WriteLine("\t\tMultifabriken AB");          
            Console.WriteLine("\n**********************************************");  
            Console.WriteLine("[1] Bilar\t\t[5] Lista produkter\n[2] Godis\t\t[6] Avsluta\n[3] Rör\n[4] Havremjölk");
            Console.WriteLine("______________________________________________\n");
        }

        static void Main(string[] args)
        {
            Header();

            while(true) {
                switch(Console.ReadKey(true).Key) {
                    case  ConsoleKey.D1:
                        Header();
                        Console.WriteLine("Bilar");
                        break;
                    case  ConsoleKey.D2:
                        Header();
                        Console.WriteLine("Godis");
                        break;
                    case  ConsoleKey.D3:
                        Header();
                        Console.WriteLine("Rör");
                        break;
                    case  ConsoleKey.D4:
                        Header();
                        Console.WriteLine("Havremjölk");
                        break;
                    case  ConsoleKey.D5:
                        Header();
                        Console.WriteLine("Lista av produkter");
                        break;
                    case  ConsoleKey.D6:
                        return;
                    default:
                        Header();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ogilltigt val!");
                        Console.ResetColor();
                        break;
                }
            }

        }
    }
}
