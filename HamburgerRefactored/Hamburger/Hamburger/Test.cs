using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburger
{
    class Test : BologneseBurger
    {
        protected override void Meat()
        {
            Console.WriteLine("test");
        }

        protected override void SetPasta()
        {
            Console.WriteLine("test");
        }

        protected override void SetSauce()
        {
            Console.WriteLine("test");
        }

        protected override void Vegetable()
        {
            Console.WriteLine("test");
        }
    }
}
