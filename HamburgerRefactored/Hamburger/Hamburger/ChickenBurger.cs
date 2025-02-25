using System;

namespace Hamburger
{
    class ChickenBurger : Hamburger
    {
        protected override void Meat()
        {
            Console.WriteLine("Meat: chicken");
        }

        protected override void SetPasta()
        {
            Console.WriteLine("Pasta: sour cream");
        }

        protected override void SetSauce()
        {
            Console.WriteLine("Sauce: mustard");
        }

        protected override void Vegetable()
        {
            Console.WriteLine("Vegetable: mixed salad");
        }
    }
}
