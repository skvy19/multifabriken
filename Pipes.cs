using System;

namespace Multifabriken 
{
class Pipes
    {
        public int diameter;
        public int length;

        public void Confirmation()
        {
            Console.WriteLine("Rör i {0}mm diameter och {1}mm längd har beställts!", diameter, length);
        }
    }
}