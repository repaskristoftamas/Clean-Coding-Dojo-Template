using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburger
{
    class Program
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
