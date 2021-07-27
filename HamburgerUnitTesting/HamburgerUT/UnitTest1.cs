using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HamburgerUnitTesting;

namespace HamburgerUT
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ZeroHamburger()
        {
            Hamburger hamburger = new Hamburger();
            int chickenBurgerQuantity = 0;
            int bologneseBurgerQuantity = 0;
            int pulledporkBurgerQuantity = 0;
            Exception expected = null;
            int[] actual;
            try
            {
                actual = hamburger.Purchase(chickenBurgerQuantity, bologneseBurgerQuantity, pulledporkBurgerQuantity);
            }
            catch (Exception exception)
            {
                expected = exception;
            }
            Assert.IsNotNull(expected);
            //Ha egyiket átírod 10-re, nem teljesül, hogy hiba nélkül lefut, vagyis 0 van mindenhol, ezért fail.
            //Vagyis akkor működik, ha success a teszt, vagyis itt az expectedben van valami, mert akkor tudjuk, hogy mindehol 0 volt.
        }

        [TestMethod]
        public void PulledPork()
        {
            Hamburger hamburger = new Hamburger();
            int chickenBurgerPrice = 1000;
            int bologneseBurgerPrice = 1100;
            int pulledporkBurgerPrice = 1300;
            int chickenBurgerQuantity = 0;
            int bologneseBurgerQuantity = 0;
            int pulledporkBurgerQuantity = 1;
            int[] quantity = new int[] { chickenBurgerQuantity, bologneseBurgerQuantity, pulledporkBurgerQuantity };
            int expected = 1300;
            double actual;

            actual = hamburger.Pay(chickenBurgerPrice, bologneseBurgerPrice, pulledporkBurgerPrice, quantity);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MoreThan2000()
        {
            Hamburger hamburger = new Hamburger();
            int chickenBurgerPrice = 1000;
            int bologneseBurgerPrice = 1100;
            int pulledporkBurgerPrice = 1300;
            int chickenBurgerQuantity = 0;
            int bologneseBurgerQuantity = 1;
            int pulledporkBurgerQuantity = 1;
            int[] quantity = new int[] { chickenBurgerQuantity, bologneseBurgerQuantity, pulledporkBurgerQuantity };
            int expected = 1920;
            double actual;

            actual = hamburger.Pay(chickenBurgerPrice, bologneseBurgerPrice, pulledporkBurgerPrice, quantity);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MoreThan3000()
        {
            Hamburger hamburger = new Hamburger();
            int chickenBurgerPrice = 1000;
            int bologneseBurgerPrice = 1100;
            int pulledporkBurgerPrice = 1300;
            int chickenBurgerQuantity = 0;
            int bologneseBurgerQuantity = 3;
            int pulledporkBurgerQuantity = 0;
            int[] quantity = new int[] { chickenBurgerQuantity, bologneseBurgerQuantity, pulledporkBurgerQuantity };
            int expected = 2310;
            double actual;

            actual = hamburger.Pay(chickenBurgerPrice, bologneseBurgerPrice, pulledporkBurgerPrice, quantity);
            Assert.AreEqual(expected, actual);
        }
    }
}
