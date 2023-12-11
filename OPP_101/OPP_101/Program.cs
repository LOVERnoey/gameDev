using System;

namespace OPP_101
{
    internal class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Car car1 = new Car("Honda", "Civic", "black", 3200);
            Car car2 = new Car("Honda", "Civic", "black", 3200);
            Plane plane1 = new Plane("da", "ic", "ck", 32);
            car1.Start();
            Verhicle.PrintVC();
            
        }
    }
}