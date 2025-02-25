using System;

namespace Hamburger
{
    class BologneseBurger
    {
        public BologneseBurger(string pasta, string sauce, string meat, string vegetable)
        {
            Pasta = pasta;
            Sauce = sauce;
            Meat = meat;
            Vegetable = vegetable;
        }
        public string Pasta { get; set; }
        public string Sauce { get; set; }
        public string Meat { get; set; }
        public string Vegetable { get; set; }

        public void Baking() => Console.WriteLine("We baked the hamburger.");

        public void Delivery() => Console.WriteLine("We delivered the hamburger.");

        public void WriteOut()
        {
            Console.WriteLine("Pasta: " + Pasta);
            Console.WriteLine("Sauce: " + Sauce);
            Console.WriteLine("Meat: " + Meat);
            Console.WriteLine("Vegetable: " + Vegetable);
        }
    }
}
