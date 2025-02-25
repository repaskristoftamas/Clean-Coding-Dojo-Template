using System;

namespace Hamburger
{
    static class Program
    {
        static void Main(string[] args)
        {
            ChickenBurger chickenBurger = new ChickenBurger("basic", "ketchup", "chicken", "tomato");
            chickenBurger.WriteOut();
            chickenBurger.Baking();
            chickenBurger.Delivery();
            Console.ReadLine();
        }
    }
}
