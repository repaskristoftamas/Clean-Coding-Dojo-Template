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
            Hamburger chickenBurger = new ChickenBurger();
            chickenBurger.Create();
            Hamburger test = new Test();
            test.Create();
            Console.ReadLine();
        }
    }
}
