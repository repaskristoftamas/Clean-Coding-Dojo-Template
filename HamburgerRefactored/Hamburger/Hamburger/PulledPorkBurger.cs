using System;

namespace Hamburger
{
    class PulledPorkBurger : Hamburger
    {
        protected override void Meat()
        {
            Console.WriteLine("Meat: Pork");
        }

        protected override void SetPasta()
        {
            Console.WriteLine("Pasta: basic");
        }

        protected override void SetSauce()
        {
            Console.WriteLine("Sauce: ketchup");
        }
    }
}
