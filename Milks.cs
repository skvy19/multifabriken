using System;

namespace Multifabriken 
{
class Milks
    {
        public decimal fat;
        public decimal liter;

        public void Form(string input) {

            Console.WriteLine("Beställning av havremjölk\n");

            do {
                Console.Write("Ange litermängd: ");
                input = Console.ReadLine();
                if (isValidInput(input, liter)) {
                    liter = Convert.ToDecimal(input);
                } else {
                    Console.WriteLine("Ogiltigt värde!");
                }
            } while (!isValidInput(input, liter));

            do {
                Console.Write("Ange fetthalt: ");
                input = Console.ReadLine();
                if (isValidInput(input, fat)) {
                    fat = Convert.ToDecimal(input);
                } else {
                    Console.WriteLine("Ogiltigt värde!");
                }
            } while (!isValidInput(input, fat));

        }
        
        public void Confirmation() {
            Console.WriteLine("\n{0} liter havremjölk med {1} fetthalt har beställts!", liter, fat);
        }

        public string Item() {
            return String.Format("{0} liter havremjölk med {1} fetthalt.", liter, fat);
        }

        public bool isValidInput(string input, decimal value) {
            return (!string.IsNullOrWhiteSpace(input) && decimal.TryParse(input, out value)) ? true : false;
        }

    }
}