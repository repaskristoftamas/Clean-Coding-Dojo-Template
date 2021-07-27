using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerUnitTesting
{
    public class Hamburger
    {

        //Legalább 1 hamburgert vásárolni kell.
        //2000 forinttól 20% kedvezmény
        //3000 forinttól 30% kedvezmény
        //chickenBurgerPrice = 1000;
        //bologneseBurgerPrice = 1100;
        //pulledporkBurgerPrice = 1300;

        public int[] Purchase(int chickenBurger, int bologneseBurger, int pulledporkBurger)
        {
            if (chickenBurger == 0 && bologneseBurger == 0 && pulledporkBurger == 0)
            {
                throw new Exception("Legalább 1 hamburgert vásárolni kell!");
            }
            else
            {
                int[] result = new int[3];
                result[0] = chickenBurger;
                result[1] = bologneseBurger;
                result[2] = pulledporkBurger;
                return result;
            }
        }

        public double Pay(int chickenBurgerPrice, int bologneseBurgerPrice, int pulledporkBurgerPrice, int[] quantity)
        {
            double pay = chickenBurgerPrice * quantity[0] + bologneseBurgerPrice * quantity[1] + pulledporkBurgerPrice * quantity[2];
            if (pay >= 3000)
            {
                return pay * 0.7;
            }
            else if (pay >= 2000)
            {
                return pay * 0.8;
            }
            else
            {
                return pay;
            }
        }
    }
}
