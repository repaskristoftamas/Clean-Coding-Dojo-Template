using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburger
{
    abstract class Hamburger
    {
        public void Create()
        {
            SetPasta();
            SetSauce();
            Meat();
            Vegetable();
            Baking();
            Delivery();
        }

        protected abstract void SetPasta();
        protected abstract void SetSauce();
        protected abstract void Meat();
        protected virtual void Vegetable()
        {

        }

        private void Baking()
        {
            Console.WriteLine("We baked the hamburger.");
        }
        private void Delivery()
        {
            Console.WriteLine("We delivered the hamburger.");
        }
    }
}
