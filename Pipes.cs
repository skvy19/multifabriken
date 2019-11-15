using System;

namespace Multifabriken 
{
class Pipes
    {
        public int diameter;
        public int length;

        public void Form(string input) {

            Console.WriteLine("Beställning av rör\n");

            do {
                Console.Write("Ange diameter i mm (endast heltal!): ");
                input = Console.ReadLine();
                if (isValidInput(input, diameter)) {
                    diameter = Convert.ToInt32(input);
                } else {
                    Console.WriteLine("Ogiltigt värde!");
                }
            } while (!isValidInput(input, diameter));

            do {
                Console.Write("Ange längd i mm (endast heltal!): ");
                input = Console.ReadLine();
                if (isValidInput(input, length)) {
                    length = Convert.ToInt32(input);
                } else {
                    Console.WriteLine("Ogiltigt värde!");
                }
            } while (!isValidInput(input, length));

        }

        public void Confirmation()
        {
            Console.WriteLine("\nRör i {0}mm diameter och {1}mm längd har beställts!", diameter, length);
        }

        public string Item() {
            return string.Format("Rör i {0}mm diameter och {1}mm längd.", diameter, length);
        }

        public bool isValidInput(string input, int value) {
            return (!string.IsNullOrWhiteSpace(input) && int.TryParse(input, out value)) ? true : false;
        }
    }
}