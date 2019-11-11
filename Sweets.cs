using System;

namespace Multifabriken 
{
class Sweets
    {
        public string taste;
        public int quantity;

        public void Confirmation()
        {
            Console.WriteLine("{0}st godis i {1} smak har beställts!", quantity, taste);
        }
    }
}