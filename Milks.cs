using System;

namespace Multifabriken 
{
class Milks
    {
        public decimal fat;
        public decimal liter;

        public void Confirmation()
        {
            Console.WriteLine("{0} liter havremjölk med {1} fetthalt har beställts!", liter, fat);
        }
    }
}