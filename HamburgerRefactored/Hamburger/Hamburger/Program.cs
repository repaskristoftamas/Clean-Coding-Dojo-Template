using System;

namespace Hamburger
{
    static class Program
    {
        static void Main(string[] args)
        {
            Hamburger chickenBurger = new ChickenBurger();
            chickenBurger.Create();
            Hamburger pulledPorkBurger = new PulledPorkBurger();
            pulledPorkBurger.Create();
            Hamburger bologneseBuger = new BologneseBurger();
            bologneseBuger.Create();
            Console.ReadLine();
        }
    }
}
