using System;
using System.Collections.Generic;

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

            string input;
            var cars = new Cars();

            while(true) {
                switch(Console.ReadKey(true).Key) {
                    case ConsoleKey.D1:
                        Header();

                        Console.WriteLine("Bestälning av en bil\n");
                        Console.Write("Ange registreringsnummer: ");
                        input = Console.ReadLine();
                        cars.nummer = input.ToUpper();

                        Console.Write("Ange färg: ");
                        input = Console.ReadLine();
                        var firstChar = input.Substring(0, 1);
                        var capitalizedFirstChar = input.Substring(0, 1).ToUpper();
                        cars.color = input.Replace(firstChar, capitalizedFirstChar);

                        Console.Write("Ange bilmärke: ");
                        input = Console.ReadLine();
                        cars.brand = input.ToUpper();
                        
                        Header();
                        cars.Confirmation();
                        
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
                        break;
                }
            }

        }
    }
}
