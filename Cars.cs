using System;

namespace Multifabriken 
{
class Cars
    {
        public string nummer;
        public string color;
        public string brand;

        public void Confirmation()
        {
            Console.WriteLine("{0} {1} med registreringsnummer {2} har beställts!", color, brand, nummer);
        }
    }
}