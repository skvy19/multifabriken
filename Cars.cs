using System;

namespace Multifabriken 
{
class Cars
    {
        public string nummer;
        public string color;
        public string brand;

        public void Form(string input) {

            Console.WriteLine("Bestälning av en bil\n");

            do {
                Console.Write("Ange registreringsnummer: ");
                input = Console.ReadLine();
                if (isValidInput(input)) {
                    nummer = input.ToUpper();
                } else {
                    Console.WriteLine("Ogiltigt värde!");
                }
            } while (!isValidInput(input));

            do {
                Console.Write("Ange färg: ");
                input = Console.ReadLine();
                if (isValidInput(input)) {
                    var firstChar = input.Substring(0, 1);
                    var capitalizedFirstChar = input.Substring(0, 1).ToUpper();
                    color = input.Replace(firstChar, capitalizedFirstChar);
                } else {
                    Console.WriteLine("Ogiltigt värde!");
                }
            } while (!isValidInput(input));

            do {
                Console.Write("Ange bilmärke: ");
                input = Console.ReadLine();
                if (isValidInput(input)) {
                    brand = input.ToUpper();
                } else {
                    Console.WriteLine("Ogiltigt värde!");
                }
            } while (!isValidInput(input));

        }

        public void Confirmation() {
            Console.WriteLine("\n{0} {1} med registreringsnummer {2} har beställts!", color, brand, nummer);
        }

        public string Item() {
            return string.Format("{0} {1} med registreringsnummer {2}.", color, brand, nummer);
        }

        public bool isValidInput(string input) {
            return (!string.IsNullOrWhiteSpace(input) && !Char.IsDigit(input[0])) ? true : false;
        }

    }
}