using System;

namespace Multifabriken 
{
class Sweets
    {
        public string taste;
        public int quantity;

        public void Form(string input) {

            Console.WriteLine("Beställning av godis\n");

            do {
                Console.Write("Ange smak: ");
                input = Console.ReadLine();
                if (isValidInputForTaste(input)) {
                    taste = input;
                } else {
                    Console.WriteLine("Ogiltigt värde!");
                }
            } while (!isValidInputForTaste(input));

            do {
                Console.Write("Ange antal: ");
                input = Console.ReadLine();
                if (isValidInputForQty(input, quantity)) {
                    quantity = Convert.ToInt32(input);
                } else {
                    Console.WriteLine("Ogiltigt värde!");
                }
            } while (!isValidInputForQty(input, quantity));

        }

        public void Confirmation()
        {
            Console.WriteLine("\n{0}st godis i {1} smak har beställts!", quantity, taste);
        }

        public string Item() {
            return string.Format("{0}st godis i {1} smak.", quantity, taste);
        }

        public bool isValidInputForTaste(string input) {
            return (!string.IsNullOrWhiteSpace(input) && !Char.IsDigit(input[0])) ? true : false;
        }
        public bool isValidInputForQty(string input, int value) {
            return (!string.IsNullOrWhiteSpace(input) && int.TryParse(input, out value)) ? true : false;
        }
    }
}