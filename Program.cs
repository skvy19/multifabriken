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
            var car = new Cars();
            var candy = new Sweets();
            var pipe = new Pipes();
            var milk = new Milks();

            var carsList = new List<object>();
            var sweetsList = new List<object>();
            var pipesList = new List<object>();
            var milksList = new List<object>();

            while(true) {
                switch(Console.ReadKey(true).Key) {
                    case ConsoleKey.D1:
                        Header();

                        Console.WriteLine("Bestälning av en bil\n");
                        Console.Write("Ange registreringsnummer: ");
                        input = Console.ReadLine();
                        car.nummer = input.ToUpper();

                        Console.Write("Ange färg: ");
                        input = Console.ReadLine();
                        var firstChar = input.Substring(0, 1);
                        var capitalizedFirstChar = input.Substring(0, 1).ToUpper();
                        car.color = input.Replace(firstChar, capitalizedFirstChar);

                        Console.Write("Ange bilmärke: ");
                        input = Console.ReadLine();
                        car.brand = input.ToUpper();
                        
                        Header();
                        car.Confirmation();
                        carsList.Add(string.Format("{0} {1} med registreringsnummer {2}.", car.color, car.brand, car.nummer));
                        
                        break;
                    case  ConsoleKey.D2:
                        Header();

                        Console.WriteLine("Beställning av godis\n");
                        Console.Write("Ange smak: ");
                        input = Console.ReadLine();
                        candy.taste = input;

                        Console.Write("Ange antal: ");
                        input = Console.ReadLine();
                        candy.quantity = Convert.ToInt32(input);

                        Header();
                        candy.Confirmation();
                        sweetsList.Add(string.Format("{0}st godis i {1} smak.", candy.quantity, candy.taste));

                        break;
                    case  ConsoleKey.D3:
                        Header();

                        Console.WriteLine("Beställning av rör\n");
                        Console.Write("Ange diameter i mm: ");
                        input = Console.ReadLine();
                        pipe.diameter = Convert.ToInt32(input);
                        
                        Console.Write("Ange längd i mm: ");
                        input = Console.ReadLine();
                        pipe.length = Convert.ToInt32(input);

                        Header();
                        pipe.Confirmation();
                        pipesList.Add(string.Format("Rör i {0}mm diameter och {1}mm längd.", pipe.diameter, pipe.length));

                        break;
                    case  ConsoleKey.D4:
                        Header();
                        Console.WriteLine("Beställning av havremjölk\n");
                        Console.Write("Ange litermängd: ");
                        input = Console.ReadLine();
                        milk.liter = Convert.ToDecimal(input);
                        
                        Console.Write("Ange fetthalt: ");
                        input = Console.ReadLine();
                        milk.fat = Convert.ToDecimal(input);

                        Header();
                        milk.Confirmation();
                        milksList.Add(string.Format("{0} liter havremjölk med {1} fetthalt.", milk.liter, milk.fat));

                        break;
                    case  ConsoleKey.D5:
                        Header();

                        if (carsList.Count > 0) {
                            Console.WriteLine("Beställda bilar: ");
                            foreach(var n in carsList) Console.WriteLine("* " + n);
                        } 
                        
                        if (sweetsList.Count > 0) {
                            Console.WriteLine("\nBeställda godis: ");
                            foreach(var n in sweetsList) Console.WriteLine("* " + n);
                        } 
                        
                        if (pipesList.Count > 0) {
                            Console.WriteLine("\nBeställda rör: ");
                            foreach(var n in pipesList) Console.WriteLine("* " + n);
                        } 

                        if (milksList.Count > 0) {
                            Console.WriteLine("\nBeställda havremjölk: ");
                            foreach(var n in milksList) Console.WriteLine("* " + n);
                        } 
                        
                        if  (carsList.Count == 0 && sweetsList.Count == 0 && pipesList.Count == 0 && milksList.Count == 0){
                            Console.WriteLine("Inga produkter har beställts!");
                        }
                            
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
