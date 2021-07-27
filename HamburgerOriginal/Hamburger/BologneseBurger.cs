using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburger
{
    class BologneseBurger
    {
        public BologneseBurger(string pasta, string sauce, string meat, string vegetable)
        {
            this.Pasta = pasta;
            this.Sauce = sauce;
            this.Meat = meat;
            this.Vegetable = vegetable;
        }
        public string Pasta { get; set; }
        public string Sauce { get; set; }
        public string Meat { get; set; }
        public string Vegetable { get; set; }
        public void Baking()
        {
            Console.WriteLine("We baked the hamburger.");
        }
        public void Delivery()
        {
            Console.WriteLine("We delivered the hamburger.");
        }
        public void WriteOut()
        {
            Console.WriteLine("Pasta: " + Pasta);
            Console.WriteLine("Sauce: " + Sauce);
            Console.WriteLine("Meat: " + Meat);
            Console.WriteLine("Vegetable: " + Vegetable);
        }
    }
}
