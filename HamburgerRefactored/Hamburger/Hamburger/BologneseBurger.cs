using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburger
{
    abstract class BologneseBurger : Hamburger
    {
        protected override void Meat()
        {
            Console.WriteLine("Meat: minced pork meat");
        }

        protected override void SetPasta()
        {
            Console.WriteLine("Pasta: tomato");
        }

        protected override void SetSauce()
        {
            Console.WriteLine("Sauce: bolognese");
        }
    }
}
