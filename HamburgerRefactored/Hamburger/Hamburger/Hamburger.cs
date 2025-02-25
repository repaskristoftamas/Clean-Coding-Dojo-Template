using System;

namespace Hamburger
{
    abstract class Hamburger
    {
        public void Create()
        {
            Meat();
            SetPasta();
            SetSauce();
            Vegetable();
            Baking();
            Delivery();
        }

        protected abstract void Meat();
        protected abstract void SetPasta();
        protected abstract void SetSauce();

        protected virtual void Vegetable() { }

        private void Baking() => Console.WriteLine("We baked the hamburger.");
        private void Delivery() => Console.WriteLine("We delivered the hamburger.\n");
    }
}
